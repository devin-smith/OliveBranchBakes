using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class CartService
    {
        public List<CartItem> Items { get; } = new List<CartItem>();

        public void AddItem(Product product, int quantity)
        {
            if (quantity <= 0)
                return;

            var existingItem = Items.FirstOrDefault(
                i => i.Product.ProductId == product.ProductId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new CartItem(product, quantity));
            }
        }

        public void UpdateQuantity(int productId, int quantity)
        {
            var item = Items.FirstOrDefault(
                i => i.Product.ProductId == productId);

            if (item == null)
                return;

            if (quantity <= 0)
            {
                Items.Remove(item);
            }
            else
            {
                item.Quantity = quantity;
            }
        }

        public void RemoveItem(int productId)
        {
            var item = Items.FirstOrDefault(
                i => i.Product.ProductId == productId);

            if (item != null)
            {
                Items.Remove(item);
            }
        }

        public decimal GetSubtotal()
        {
            return Items.Sum(i => i.Total);
        }
    }
}
