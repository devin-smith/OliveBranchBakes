using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OliveBranchBakes.Models
{
    public class CartItem
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal Total
        {
            get
            {
                return Product.Price * Quantity;
            }
        }

        public CartItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public string DisplayText
        {
            get
            {
                return $"{Product.Name} x {Quantity} - ${Total:F2}";
            }
        }
    }
}
