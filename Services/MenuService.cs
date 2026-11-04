using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class MenuService
    {
        private List<Product> products = new List<Product>();

        public MenuService()
        {
            products.Add(new RegularProduct
            {
                ProductId = 1,
                Name = "Chocolate Chip Cookie",
                Category = "Cookies",
                Price = 2.50m
            });

            products.Add(new RegularProduct
            {
                ProductId = 2,
                Name = "Vanilla Cupcake",
                Category = "Cupcakes",
                Price = 3.00m
            });

            products.Add(new SeasonalProduct
            {
                ProductId = 3,
                Name = "Pumpkin Spice Muffin",
                Category = "Muffins",
                Price = 3.50m,
                StartDate = new DateTime(2026, 9, 1),
                EndDate = new DateTime(2026, 11, 30)
            });
        }

        public List<Product> GetAvailableProducts(DateTime date)
        {
            return products
                .Where(p => p.IsAvailable(date))
                .ToList();
        }

        public List<Product> GetProductsByCategory(
            string category, DateTime date)
        {
            return GetAvailableProducts(date)
                .Where(p => p.Category == category)
                .ToList();
        }
    }
}
