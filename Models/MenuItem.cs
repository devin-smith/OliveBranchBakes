using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OliveBranchBakes.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public string Category { get; set; } = "";

        public string Allergens { get; set; } = "";

        public bool IsActive { get; set; } = true;

        public DateTime? SeasonStart { get; set; }

        public DateTime? SeasonEnd { get; set; }

        public MenuItem()
        {
        }

        public MenuItem(int id, string name,
            string description, decimal price,
            string category)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(
                    "Product name is required.");

            if (price < 0)
                throw new ArgumentException(
                    "Price cannot be negative.");

            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }
    }
}
