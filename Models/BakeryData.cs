using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Models
{
    // Represents the data saved to our JSON file.
    public class BakeryData
    {
        // Products available in the bakery.
        public List<MenuItem> MenuItems { get; set; } = new();

        // Categories used to organize products.
        public List<Category> Categories { get; set; } = new();

        // Registered bakery customers.
        public List<Customer> Customers { get; set; } = new();

        // Customer orders and their line items.
        public List<Order> Orders { get; set; } = new();

        // Settings used by the bakery application.
        public BakerySettings Settings { get; set; } = new();
    }
}
