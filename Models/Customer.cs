using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FullName { get; set; } = "";

        public string Email { get; set; } = "";

        public string Phone { get; set; } = "";

        // Store a salted password hash, never plaintext.
        public string PasswordHash { get; set; } = "";

        public string PasswordSalt { get; set; } = "";

        // Used to determine eligibility for the P2
        // loyalty discount.
        public int PreviousOrderCount { get; set; }

        // Required for loading customer data from JSON.
        public Customer()
        {
        }

        // Creates a customer with basic account details.
        public Customer(int customerId, string fullName,
            string email, string phone)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentException(
                    "Customer name is required.");
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException(
                    "Customer email is required.");
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                throw new ArgumentException(
                    "Customer phone number is required.");
            }

            CustomerId = customerId;
            FullName = fullName;
            Email = email.Trim();
            Phone = phone;
        }
    }
}
