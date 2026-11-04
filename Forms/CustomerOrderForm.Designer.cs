namespace OliveBranchBakes.Forms
{
    partial class CustomerOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelQuantity = new Label();
            numericQuantity = new NumericUpDown();
            labelPickupDate = new Label();
            dateTimePickup = new DateTimePicker();
            labelCustomName = new Label();
            textCustomerName = new TextBox();
            textCustomerEmail = new TextBox();
            labelCustomerEmail = new Label();
            textCustomerPhone = new TextBox();
            labelCustomerPhone = new Label();
            textAllergies = new TextBox();
            labelAllergies = new Label();
            buttonOrderSummary = new Button();
            comboCategory = new ComboBox();
            listProducts = new ListBox();
            dateMenu = new DateTimePicker();
            labelCategory = new Label();
            label1 = new Label();
            label2 = new Label();
            listCart = new ListBox();
            buttonAddCart = new Button();
            buttonUpdateCart = new Button();
            buttonRemoveCart = new Button();
            labelSubtotal = new Label();
            labelProduct = new Label();
            comboBoxProduct = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(294, 32);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(231, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Place Your Order";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(702, 224);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(68, 20);
            labelQuantity.TabIndex = 2;
            labelQuantity.Text = "Quantity:";
            labelQuantity.Click += labelQuantity_Click;
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(702, 247);
            numericQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(68, 27);
            numericQuantity.TabIndex = 1;
            numericQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantity.ValueChanged += numericQuantity_ValueChanged;
            // 
            // labelPickupDate
            // 
            labelPickupDate.AutoSize = true;
            labelPickupDate.Location = new Point(416, 147);
            labelPickupDate.Name = "labelPickupDate";
            labelPickupDate.Size = new Size(165, 20);
            labelPickupDate.TabIndex = 3;
            labelPickupDate.Text = "Requested Pickup Date:";
            labelPickupDate.Click += labelPickupDate_Click;
            // 
            // dateTimePickup
            // 
            dateTimePickup.Format = DateTimePickerFormat.Short;
            dateTimePickup.Location = new Point(416, 171);
            dateTimePickup.Name = "dateTimePickup";
            dateTimePickup.Size = new Size(165, 27);
            dateTimePickup.TabIndex = 2;
            // 
            // labelCustomName
            // 
            labelCustomName.AutoSize = true;
            labelCustomName.Location = new Point(31, 87);
            labelCustomName.Name = "labelCustomName";
            labelCustomName.Size = new Size(119, 20);
            labelCustomName.TabIndex = 4;
            labelCustomName.Text = "Customer Name:";
            // 
            // textCustomerName
            // 
            textCustomerName.Location = new Point(31, 110);
            textCustomerName.MaxLength = 100;
            textCustomerName.Name = "textCustomerName";
            textCustomerName.Size = new Size(242, 27);
            textCustomerName.TabIndex = 3;
            // 
            // textCustomerEmail
            // 
            textCustomerEmail.Location = new Point(279, 110);
            textCustomerEmail.MaxLength = 150;
            textCustomerEmail.Name = "textCustomerEmail";
            textCustomerEmail.Size = new Size(246, 27);
            textCustomerEmail.TabIndex = 4;
            // 
            // labelCustomerEmail
            // 
            labelCustomerEmail.AutoSize = true;
            labelCustomerEmail.Location = new Point(282, 87);
            labelCustomerEmail.Name = "labelCustomerEmail";
            labelCustomerEmail.Size = new Size(106, 20);
            labelCustomerEmail.TabIndex = 6;
            labelCustomerEmail.Text = "Email Address:";
            // 
            // textCustomerPhone
            // 
            textCustomerPhone.Location = new Point(531, 110);
            textCustomerPhone.MaxLength = 20;
            textCustomerPhone.Name = "textCustomerPhone";
            textCustomerPhone.Size = new Size(239, 27);
            textCustomerPhone.TabIndex = 5;
            // 
            // labelCustomerPhone
            // 
            labelCustomerPhone.AutoSize = true;
            labelCustomerPhone.Location = new Point(531, 87);
            labelCustomerPhone.Name = "labelCustomerPhone";
            labelCustomerPhone.Size = new Size(111, 20);
            labelCustomerPhone.TabIndex = 8;
            labelCustomerPhone.Text = "Phone Number:";
            // 
            // textAllergies
            // 
            textAllergies.Location = new Point(32, 378);
            textAllergies.MaxLength = 500;
            textAllergies.Multiline = true;
            textAllergies.Name = "textAllergies";
            textAllergies.ScrollBars = ScrollBars.Vertical;
            textAllergies.Size = new Size(354, 74);
            textAllergies.TabIndex = 6;
            // 
            // labelAllergies
            // 
            labelAllergies.AutoSize = true;
            labelAllergies.Location = new Point(32, 355);
            labelAllergies.Name = "labelAllergies";
            labelAllergies.Size = new Size(141, 20);
            labelAllergies.TabIndex = 10;
            labelAllergies.Text = "Allergy Information:";
            // 
            // buttonOrderSummary
            // 
            buttonOrderSummary.BackColor = Color.FromArgb(81, 100, 63);
            buttonOrderSummary.Cursor = Cursors.Hand;
            buttonOrderSummary.FlatStyle = FlatStyle.Flat;
            buttonOrderSummary.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOrderSummary.ForeColor = Color.White;
            buttonOrderSummary.Location = new Point(32, 481);
            buttonOrderSummary.Name = "buttonOrderSummary";
            buttonOrderSummary.Size = new Size(231, 42);
            buttonOrderSummary.TabIndex = 7;
            buttonOrderSummary.Text = "Order Summary";
            buttonOrderSummary.UseVisualStyleBackColor = false;
            buttonOrderSummary.Click += buttonOrderSummary_Click;
            // 
            // comboCategory
            // 
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new Point(31, 170);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new Size(367, 28);
            comboCategory.TabIndex = 11;
            comboCategory.SelectedIndexChanged += comboCategory_SelectedIndexChanged;
            // 
            // listProducts
            // 
            listProducts.FormattingEnabled = true;
            listProducts.Location = new Point(32, 251);
            listProducts.Name = "listProducts";
            listProducts.Size = new Size(354, 84);
            listProducts.TabIndex = 12;
            // 
            // dateMenu
            // 
            dateMenu.Format = DateTimePickerFormat.Short;
            dateMenu.Location = new Point(641, 171);
            dateMenu.Name = "dateMenu";
            dateMenu.Size = new Size(129, 27);
            dateMenu.TabIndex = 13;
            dateMenu.ValueChanged += dateMenu_ValueChanged;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(31, 147);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(72, 20);
            labelCategory.TabIndex = 14;
            labelCategory.Text = "Category:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(641, 148);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 15;
            label1.Text = "Menu Date:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 224);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 16;
            label2.Text = "Available Products:";
            // 
            // listCart
            // 
            listCart.FormattingEnabled = true;
            listCart.Location = new Point(416, 348);
            listCart.Name = "listCart";
            listCart.Size = new Size(357, 104);
            listCart.TabIndex = 17;
            // 
            // buttonAddCart
            // 
            buttonAddCart.BackColor = Color.FromArgb(81, 100, 63);
            buttonAddCart.Cursor = Cursors.Hand;
            buttonAddCart.FlatStyle = FlatStyle.Flat;
            buttonAddCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddCart.ForeColor = Color.White;
            buttonAddCart.Location = new Point(413, 289);
            buttonAddCart.Name = "buttonAddCart";
            buttonAddCart.Size = new Size(357, 42);
            buttonAddCart.TabIndex = 18;
            buttonAddCart.Text = "Add to Cart";
            buttonAddCart.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateCart
            // 
            buttonUpdateCart.BackColor = Color.FromArgb(81, 100, 63);
            buttonUpdateCart.Cursor = Cursors.Hand;
            buttonUpdateCart.FlatStyle = FlatStyle.Flat;
            buttonUpdateCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdateCart.ForeColor = Color.White;
            buttonUpdateCart.Location = new Point(416, 467);
            buttonUpdateCart.Name = "buttonUpdateCart";
            buttonUpdateCart.Size = new Size(178, 42);
            buttonUpdateCart.TabIndex = 19;
            buttonUpdateCart.Text = "Update Quantity";
            buttonUpdateCart.UseVisualStyleBackColor = false;
            // 
            // buttonRemoveCart
            // 
            buttonRemoveCart.BackColor = Color.FromArgb(81, 100, 63);
            buttonRemoveCart.Cursor = Cursors.Hand;
            buttonRemoveCart.FlatStyle = FlatStyle.Flat;
            buttonRemoveCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemoveCart.ForeColor = Color.White;
            buttonRemoveCart.Location = new Point(600, 467);
            buttonRemoveCart.Name = "buttonRemoveCart";
            buttonRemoveCart.Size = new Size(170, 42);
            buttonRemoveCart.TabIndex = 20;
            buttonRemoveCart.Text = "Remove Item";
            buttonRemoveCart.UseVisualStyleBackColor = false;
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Location = new Point(663, 512);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(107, 20);
            labelSubtotal.TabIndex = 21;
            labelSubtotal.Text = "Subtotal: $0.00";
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(413, 223);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(106, 20);
            labelProduct.TabIndex = 1;
            labelProduct.Text = "Select an Item:";
            labelProduct.Click += labelProduct_Click;
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Items.AddRange(new object[] { "Chocolate Chip Cookies", "Christmas Cookies", "Cinnamon Rolls", "Blueberry Muffins", "Cannolis" });
            comboBoxProduct.Location = new Point(413, 246);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(283, 28);
            comboBoxProduct.TabIndex = 0;
            // 
            // CustomerOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(800, 561);
            Controls.Add(labelSubtotal);
            Controls.Add(buttonRemoveCart);
            Controls.Add(buttonUpdateCart);
            Controls.Add(buttonAddCart);
            Controls.Add(listCart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelCategory);
            Controls.Add(dateMenu);
            Controls.Add(listProducts);
            Controls.Add(comboCategory);
            Controls.Add(buttonOrderSummary);
            Controls.Add(textAllergies);
            Controls.Add(labelAllergies);
            Controls.Add(textCustomerPhone);
            Controls.Add(labelCustomerPhone);
            Controls.Add(textCustomerEmail);
            Controls.Add(labelCustomerEmail);
            Controls.Add(textCustomerName);
            Controls.Add(labelCustomName);
            Controls.Add(dateTimePickup);
            Controls.Add(labelPickupDate);
            Controls.Add(numericQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(comboBoxProduct);
            Controls.Add(labelProduct);
            Controls.Add(labelTitle);
            MinimumSize = new Size(800, 600);
            Name = "CustomerOrderForm";
            Text = "Olive Branch Bakes - Customer Order";
            Load += CustomerOrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelQuantity;
        private NumericUpDown numericQuantity;
        private Label labelPickupDate;
        private DateTimePicker dateTimePickup;
        private Label labelCustomName;
        private TextBox textCustomerName;
        private TextBox textCustomerEmail;
        private Label labelCustomerEmail;
        private TextBox textCustomerPhone;
        private Label labelCustomerPhone;
        private TextBox textAllergies;
        private Label labelAllergies;
        private Button buttonOrderSummary;
        private ComboBox comboCategory;
        private ListBox listProducts;
        private DateTimePicker dateMenu;
        private Label labelCategory;
        private Label label1;
        private Label label2;
        private ListBox listCart;
        private Button buttonAddCart;
        private Button buttonUpdateCart;
        private Button buttonRemoveCart;
        private Label labelSubtotal;
        private Label labelProduct;
        private ComboBox comboBoxProduct;
    }
}