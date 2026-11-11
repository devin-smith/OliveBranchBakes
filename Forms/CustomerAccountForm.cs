using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OliveBranchBakes.Models;
using OliveBranchBakes.Services;

namespace OliveBranchBakes.Forms
{
    public partial class CustomerAccountForm : BaseForm
    {
        private readonly AccountService accountService = new AccountService();

        public CustomerAccountForm()
        {
            InitializeComponent();
        }


        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text.Trim();
            string password = textPassword.Text;

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your email and password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Customer? customer =
                accountService.SignIn(email, password);

            if (customer == null)
            {
                MessageBox.Show(
                    "Invalid email or password.",
                    "Sign In Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Remember the signed-in customer.
            CustomerSession.SignIn(customer);

            int previousOrders =
                accountService.GetPreviousOrderCount(
                    customer.CustomerId);

            MessageBox.Show(
                $"Welcome back, {customer.FullName}!\n\n" +
                $"Previous Orders: {previousOrders}",
                "Sign In Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void labelFullName_Click(object sender, EventArgs e)
        {

        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name = textFullName.Text.Trim();
            string phone = textPhone.Text.Trim();
            string email = textEmail.Text.Trim();
            string password = textPassword.Text;

            try
            {
                Customer customer = accountService.Register(
                    name, email, phone, password);

                MessageBox.Show(
                    $"Account created for {customer.FullName}!\n\n" +
                    "You can now sign in.",
                    "Registration Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                textPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Registration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

    }
}
