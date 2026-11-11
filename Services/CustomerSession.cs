using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public static class CustomerSession
    {
        public static Customer? CurrentCustomer
        {
            get;
            private set;
        }

        public static bool IsSignedIn =>
            CurrentCustomer != null;

        public static void SignIn(Customer customer)
        {
            CurrentCustomer = customer;
        }

        public static void SignOut()
        {
            CurrentCustomer = null;
        }
    }
}
