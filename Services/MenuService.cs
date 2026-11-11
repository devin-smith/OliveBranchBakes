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
            var data = SeedData.Create();

            foreach (var item in data.MenuItems)
            {
                Product product;

                if (item.SeasonStart.HasValue &&
                    item.SeasonEnd.HasValue)
                {
                    product = new SeasonalProduct
                    {
                        StartDate = item.SeasonStart.Value,
                        EndDate = item.SeasonEnd.Value
                    };
                }
                else
                {
                    product = new RegularProduct();
                }

                product.ProductId = item.Id;
                product.Name = item.Name;
                product.Category = item.Category;
                product.Price = item.Price;

                products.Add(product);
            }
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

        public List<string> GetCategories()
        {
            return products
                .Select(p => p.Category)
                .Distinct()
                .ToList();
        }
    }
}
