using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Models
{
    // Defines the allowed stages of an order.
    public enum OrderStatus
    {
        Received,
        Baking,
        Ready,
        PickedUp,
        Cancelled
    }

    public class Order
    {
        public int OrderId { get; set; }

        // Guest orders will not have a customer ID.
        public int? CustomerId { get; set; }

        // Assigned when an order is placed.
        // Format: OBB-YYMMDD-###
        public string ConfirmationNumber { get; set; } = "";

        public DateTime OrderDate { get; set; }

        public DateTime PickupDate { get; set; }

        public OrderStatus Status { get; set; }
            = OrderStatus.Received;

        // Preserves the allergy information from Phase 2.
        public string AllergyNotes { get; set; } = "";

        public string CustomerNotes { get; set; } = "";

        // Each order contains one or more order lines.
        public List<OrderItem> Items { get; set; } = new();

        // Financial values use decimal rather than double.
        public decimal Subtotal { get; set; }

        public decimal Discount { get; set; }

        public decimal Fees { get; set; }

        public decimal Tax { get; set; }

        public decimal Total { get; set; }

        // Empty constructor supports JSON loading.
        public Order()
        {
        }

        // Creates an order with initial information.
        public Order(int orderId, int? customerId,
            DateTime pickupDate)
        {
            if (pickupDate == DateTime.MinValue)
            {
                throw new ArgumentException(
                    "A valid pickup date is required.");
            }

            OrderId = orderId;
            CustomerId = customerId;
            OrderDate = DateTime.Now;
            PickupDate = pickupDate;
            Status = OrderStatus.Received;
        }
    }
}
