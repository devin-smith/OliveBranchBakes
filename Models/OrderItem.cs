using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        // Preserve the product name at purchase.
        public string ProductName { get; set; } = "";

        // Preserve the unit price at purchase.
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        // Calculates the total for this order line.
        public decimal LineTotal
        {
            get { return UnitPrice * Quantity; }
        }

        // Empty constructor supports JSON loading.
        public OrderItem()
        {
        }

        // Creates an order item with product information.
        public OrderItem(int orderItemId, int orderId,
            int productId, string productName,
            decimal unitPrice, int quantity)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                throw new ArgumentException(
                    "Product name is required.");
            }

            if (unitPrice < 0)
            {
                throw new ArgumentException(
                    "Unit price cannot be negative.");
            }

            if (quantity < 1)
            {
                throw new ArgumentException(
                    "Quantity must be at least one.");
            }

            OrderItemId = orderItemId;
            OrderId = orderId;
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}
