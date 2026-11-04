
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
            comboCategory.Items.Add("Cookies");
            comboCategory.Items.Add("Cupcakes");
            comboCategory.Items.Add("Muffins");
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
                cartService.AddItem(product, (int)numericQuantity.Value);
                RefreshCart();
            }
        }

        private void buttonUpdateCart_Click(object sender, EventArgs e)
        {
            if (listCart.SelectedItem is CartItem item)
            {
                cartService.UpdateQuantity(
                    item.Product.ProductId,
                    (int)numericQuantity.Value);

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

        private void buttonOrderSummary_Click(object sender, EventArgs e)
        {
            OrderSummaryForm summaryForm = new OrderSummaryForm();
            summaryForm.ShowDialog();
        }
    }
}
