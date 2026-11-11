using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class AccountService
    {
        private readonly DataStore dataStore = new DataStore();

        // Register a new customer.
        public Customer Register(
            string name,
            string email,
            string phone,
            string password)
        {
            var data = dataStore.Load();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException(
                    "All account fields are required.");
            }

            email = email.Trim();

            if (data.Customers.Any(c =>
                string.Equals(c.Email, email,
                    StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException(
                    "An account with this email already exists.");
            }

            int customerId = data.Customers.Count == 0
                ? 1
                : data.Customers.Max(c => c.CustomerId) + 1;

            Customer customer = new Customer(
                customerId, name, email, phone);

            byte[] salt = RandomNumberGenerator.GetBytes(16);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                600000,
                HashAlgorithmName.SHA256,
                32);

            customer.PasswordSalt =
                Convert.ToBase64String(salt);

            customer.PasswordHash =
                Convert.ToBase64String(hash);

            data.Customers.Add(customer);
            dataStore.Save(data);

            return customer;
        }

        // Authenticate an existing customer.
        public Customer? SignIn(
            string email, string password)
        {
            var data = dataStore.Load();

            Customer? customer = data.Customers
                .FirstOrDefault(c =>
                    string.Equals(c.Email,
                        email.Trim(),
                        StringComparison.OrdinalIgnoreCase));

            if (customer == null ||
                string.IsNullOrEmpty(customer.PasswordHash) ||
                string.IsNullOrEmpty(customer.PasswordSalt))
            {
                return null;
            }

            try
            {
                byte[] salt = Convert.FromBase64String(
                    customer.PasswordSalt);

                byte[] expectedHash = Convert.FromBase64String(
                    customer.PasswordHash);

                byte[] actualHash = Rfc2898DeriveBytes.Pbkdf2(
                    password,
                    salt,
                    600000,
                    HashAlgorithmName.SHA256,
                    expectedHash.Length);

                if (!CryptographicOperations.FixedTimeEquals(
                    expectedHash, actualHash))
                {
                    return null;
                }
            }
            catch (FormatException)
            {
                return null;
            }

            return customer;
        }

        // Count saved orders for the loyalty rule.
        public int GetPreviousOrderCount(int customerId)
        {
            var data = dataStore.Load();

            return data.Orders.Count(o =>
                o.CustomerId == customerId &&
                o.Status != OrderStatus.Cancelled);
        }
    }
}
