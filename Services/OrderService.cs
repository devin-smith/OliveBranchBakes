using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class OrderService
    {
        private readonly DataStore dataStore =
            new DataStore();

        private readonly PricingService pricingService =
            new PricingService();

        private readonly SchedulingService schedulingService =
            new SchedulingService();

        private readonly MenuService menuService =
            new MenuService();

        public Order SaveOrder(
            CartService cart,
            DateTime pickupDate)
        {
            if (cart == null || cart.Items.Count == 0)
            {
                throw new InvalidOperationException(
                    "Cannot save an empty order.");
            }

            // Validate pickup date again at checkout.
            if (!schedulingService.IsValidPickupDate(
                pickupDate))
            {
                throw new InvalidOperationException(
                    "Invalid pickup date.");
            }

            bool isSignedIn =
                CustomerSession.IsSignedIn;

            int? customerId =
                CustomerSession.CurrentCustomer?.CustomerId;

            // Check quantities and seasonal availability.
            var availableProducts = menuService
                .GetAvailableProducts(pickupDate);

            foreach (var item in cart.Items)
            {
                if (!schedulingService.IsValidQuantity(
                    item.Quantity, isSignedIn))
                {
                    throw new InvalidOperationException(
                        "Quantity limit exceeded.");
                }

                if (!availableProducts.Any(p =>
                    p.ProductId == item.Product.ProductId))
                {
                    throw new InvalidOperationException(
                        item.Product.Name +
                        " is unavailable on the pickup date.");
                }
            }

            BakeryData data = dataStore.Load();

            int previousOrders = customerId.HasValue
                ? data.Orders.Count(o =>
                    o.CustomerId == customerId.Value &&
                    o.Status != OrderStatus.Cancelled)
                : 0;

            int orderId = data.Orders.Count == 0
                ? 1
                : data.Orders.Max(o => o.OrderId) + 1;

            Order order = new Order(
                orderId, customerId, pickupDate);

            order.ConfirmationNumber =
                $"OBB-{DateTime.Now:yyMMdd}-{orderId:000}";

            order.Subtotal =
                pricingService.GetSubtotal(cart.Items);

            order.Discount =
                pricingService.GetDiscount(
                    order.Subtotal,
                    isSignedIn,
                    previousOrders);

            decimal taxableAmount =
                order.Subtotal - order.Discount;

            order.Tax =
                pricingService.GetTax(taxableAmount);

            order.Total =
                pricingService.GetTotal(
                    cart.Items,
                    isSignedIn,
                    previousOrders);

            order.Status = OrderStatus.Received;

            // Copy cart items into the saved order.
            int nextItemId = data.Orders
                .SelectMany(o => o.Items)
                .Select(i => i.OrderItemId)
                .DefaultIfEmpty(0)
                .Max() + 1;

            foreach (var item in cart.Items)
            {
                order.Items.Add(new OrderItem(
                    nextItemId++,
                    orderId,
                    item.Product.ProductId,
                    item.Product.Name,
                    item.Product.Price,
                    item.Quantity));
            }

            data.Orders.Add(order);

            // Save the entire bakery data file.
            dataStore.Save(data);

            return order;
        }
    }
}
