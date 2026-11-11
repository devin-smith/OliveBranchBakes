using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OliveBranchBakes.Models;
using OliveBranchBakes.Services;

namespace OliveBranchBakes.Forms
{
    public partial class OrderSummaryForm : BaseForm
    {
        private CartService cartService;
        private DateTime pickupDate;
        private SchedulingService schedulingService = new SchedulingService();
        private PricingService pricingService = new PricingService();

        private readonly OrderService orderService = new OrderService();

        private bool orderConfirmed = false;

        public OrderSummaryForm(
            CartService cart,
            DateTime selectedPickupDate)
        {
            InitializeComponent();

            cartService = cart;
            pickupDate = selectedPickupDate;

            this.Load += OrderSummaryForm_Load;

        }



        private void OrderSummaryForm_Load(
            object sender, EventArgs e)
        {
            // Configure the cart recap.
            listOrderItems.View = View.Details;
            listOrderItems.FullRowSelect = true;
            listOrderItems.GridLines = true;

            listOrderItems.Columns.Clear();
            listOrderItems.Items.Clear();

            listOrderItems.Columns.Add("Product", 220);
            listOrderItems.Columns.Add("Qty", 60);
            listOrderItems.Columns.Add("Price", 90);
            listOrderItems.Columns.Add("Total", 90);

            // Display each cart item.
            foreach (var item in cartService.Items)
            {
                ListViewItem row = new ListViewItem(
                    item.Product.Name);

                row.SubItems.Add(item.Quantity.ToString());
                row.SubItems.Add(
                    $"${item.Product.Price:F2}");
                row.SubItems.Add($"${item.Total:F2}");

                listOrderItems.Items.Add(row);
            }

            // Determine loyalty eligibility.
            bool isSignedIn = CustomerSession.IsSignedIn;
            int previousOrders = 0;

            if (isSignedIn &&
                CustomerSession.CurrentCustomer != null)
            {
                AccountService accountService =
                    new AccountService();

                previousOrders =
                    accountService.GetPreviousOrderCount(
                        CustomerSession.CurrentCustomer.CustomerId);
            }

            // Calculate pricing.
            decimal subtotal =
                pricingService.GetSubtotal(cartService.Items);

            decimal discount =
                pricingService.GetDiscount(
                    subtotal, isSignedIn, previousOrders);

            decimal taxableAmount = subtotal - discount;

            decimal tax =
                pricingService.GetTax(taxableAmount);

            decimal total =
                pricingService.GetTotal(
                    cartService.Items, isSignedIn, previousOrders);

            // Display pricing on the form.
            labelSubtotal.Text =
                $"Subtotal: ${subtotal:F2}";

            labelOrderDiscount.Text =
                $"Discount: -${discount:F2}";

            labelOrderTax.Text =
                $"Sales Tax (8.5%): ${tax:F2}";

            labelOrderTotal.Text =
                $"Total: ${total:F2}";

            labelOrderPickup.Text =
                $"Pickup: {pickupDate:MM/dd/yyyy hh:mm tt}";
        }



        private void buttonConfirmOrder_Click(
            object sender, EventArgs e)
        {
            // Prevent duplicate orders.
            if (orderConfirmed)
                return;

            try
            {
                Order order = orderService.SaveOrder(
                    cartService, pickupDate);

                orderConfirmed = true;
                buttonConfirmOrder.Enabled = false;

                MessageBox.Show(
                    $"Order Confirmed!\n\n" +
                    $"Confirmation: {order.ConfirmationNumber}\n" +
                    $"Pickup: {order.PickupDate:g}\n" +
                    $"Total: ${order.Total:F2}\n" +
                    $"Status: {order.Status}",
                    "Order Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear the cart after successful saving.
                cartService.Items.Clear();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Order Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

    }
}
