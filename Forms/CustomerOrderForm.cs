
using System;
using System.Linq;
using System.Windows.Forms;
using OliveBranchBakes.Models;
using OliveBranchBakes.Services;

namespace OliveBranchBakes.Forms
{
    public partial class CustomerOrderForm : BaseForm
    {
        private MenuService menuService = new MenuService();
        private CartService cartService = new CartService();
        private SchedulingService schedulingService = new SchedulingService();

        public CustomerOrderForm()
        {
            InitializeComponent();

            dateMenu.ValueChanged -= dateMenu_ValueChanged;
            dateMenu.ValueChanged += dateMenu_ValueChanged;

            comboCategory.SelectedIndexChanged -= comboCategory_SelectedIndexChanged;
            comboCategory.SelectedIndexChanged += comboCategory_SelectedIndexChanged;

            buttonAddCart.Click += buttonAddCart_Click;
            buttonUpdateCart.Click += buttonUpdateCart_Click;
            buttonRemoveCart.Click += buttonRemoveCart_Click;
        }

        private void CustomerOrderForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
            RefreshCart();
        }

        private void LoadCategories()
        {
            comboCategory.Items.Clear();
            comboCategory.Items.Add("All Products");

            foreach (string category in menuService.GetCategories())
            {
                comboCategory.Items.Add(category);
            }

            comboCategory.SelectedIndex = 0;
        }

        private void LoadProducts()
        {
            listProducts.Items.Clear();

            var products = menuService.GetAvailableProducts(dateMenu.Value);

            if (comboCategory.SelectedItem != null &&
                comboCategory.SelectedItem.ToString() != "All Products")
            {
                products = menuService.GetProductsByCategory(
                    comboCategory.SelectedItem.ToString(),
                    dateMenu.Value);
            }

            foreach (var product in products)
            {
                listProducts.Items.Add(product);
            }

            listProducts.DisplayMember = "Name";
        }

        private void RefreshCart()
        {
            listCart.Items.Clear();

            foreach (var item in cartService.Items)
            {
                listCart.Items.Add(item);
            }

            listCart.DisplayMember = "DisplayText";

            labelSubtotal.Text =
                $"Subtotal: ${cartService.GetSubtotal():F2}";
        }


        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            if (listProducts.SelectedItem is Product product)
            {
                int quantity = (int)numericQuantity.Value;

                // Check existing quantity already in cart.
                int existingQuantity = cartService.Items
                    .Where(i => i.Product.ProductId == product.ProductId)
                    .Sum(i => i.Quantity);

                int newQuantity = existingQuantity + quantity;

                // Determine whether the customer is signed in.
                bool isSignedIn = CustomerSession.IsSignedIn;

                if (!schedulingService.IsValidQuantity(
                    newQuantity, isSignedIn))
                {
                    MessageBox.Show(
                        schedulingService.GetQuantityMessage(
                            isSignedIn),
                        "Quantity Limit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                cartService.AddItem(product, quantity);
                RefreshCart();
            }
        }



        private void buttonUpdateCart_Click(object sender, EventArgs e)
        {
            if (listCart.SelectedItem is CartItem item)
            {
                int quantity = (int)numericQuantity.Value;

                bool isSignedIn = CustomerSession.IsSignedIn;

                if (!schedulingService.IsValidQuantity(
                    quantity, isSignedIn))
                {
                    MessageBox.Show(
                        schedulingService.GetQuantityMessage(
                            isSignedIn),
                        "Quantity Limit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                cartService.UpdateQuantity(
                    item.Product.ProductId,
                    quantity);

                RefreshCart();
            }
        }


        private void buttonRemoveCart_Click(object sender, EventArgs e)
        {
            if (listCart.SelectedItem is CartItem item)
            {
                cartService.RemoveItem(item.Product.ProductId);
                RefreshCart();
            }
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dateMenu_ValueChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void labelQuantity_Click(object sender, EventArgs e) { }
        private void labelProduct_Click(object sender, EventArgs e) { }
        private void numericQuantity_ValueChanged(object sender, EventArgs e) { }
        private void labelPickupDate_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e) { }


        private void buttonOrderSummary_Click(
            object sender, EventArgs e)
        {
            if (cartService.Items.Count == 0)
            {
                MessageBox.Show(
                    "Please add items to your cart first.");
                return;
            }

            if (!schedulingService.IsValidPickupDate(
                dateMenu.Value))
            {
                MessageBox.Show(
                    "Pickup must be between 24 hours " +
                    "and 30 days from now. Thanksgiving " +
                    "and Christmas are unavailable.",
                    "Invalid Pickup Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            OrderSummaryForm summaryForm = new OrderSummaryForm(cartService, dateMenu.Value);

            if (summaryForm.ShowDialog() == DialogResult.OK)
            {
                RefreshCart();
            }
        }

    }
}
