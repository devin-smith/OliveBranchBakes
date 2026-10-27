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
            labelProduct = new Label();
            comboBoxProduct = new ComboBox();
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
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(36, 83);
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
            comboBoxProduct.Location = new Point(36, 106);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(300, 28);
            comboBoxProduct.TabIndex = 0;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(344, 83);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(68, 20);
            labelQuantity.TabIndex = 2;
            labelQuantity.Text = "Quantity:";
            labelQuantity.Click += labelQuantity_Click;
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(344, 106);
            numericQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(120, 27);
            numericQuantity.TabIndex = 1;
            numericQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantity.ValueChanged += numericQuantity_ValueChanged;
            // 
            // labelPickupDate
            // 
            labelPickupDate.AutoSize = true;
            labelPickupDate.Location = new Point(36, 151);
            labelPickupDate.Name = "labelPickupDate";
            labelPickupDate.Size = new Size(165, 20);
            labelPickupDate.TabIndex = 3;
            labelPickupDate.Text = "Requested Pickup Date:";
            // 
            // dateTimePickup
            // 
            dateTimePickup.Location = new Point(207, 146);
            dateTimePickup.Name = "dateTimePickup";
            dateTimePickup.Size = new Size(259, 27);
            dateTimePickup.TabIndex = 2;
            // 
            // labelCustomName
            // 
            labelCustomName.AutoSize = true;
            labelCustomName.Location = new Point(36, 209);
            labelCustomName.Name = "labelCustomName";
            labelCustomName.Size = new Size(119, 20);
            labelCustomName.TabIndex = 4;
            labelCustomName.Text = "Customer Name:";
            // 
            // textCustomerName
            // 
            textCustomerName.Location = new Point(194, 209);
            textCustomerName.MaxLength = 100;
            textCustomerName.Name = "textCustomerName";
            textCustomerName.Size = new Size(270, 27);
            textCustomerName.TabIndex = 3;
            // 
            // textCustomerEmail
            // 
            textCustomerEmail.Location = new Point(194, 248);
            textCustomerEmail.MaxLength = 150;
            textCustomerEmail.Name = "textCustomerEmail";
            textCustomerEmail.Size = new Size(270, 27);
            textCustomerEmail.TabIndex = 4;
            // 
            // labelCustomerEmail
            // 
            labelCustomerEmail.AutoSize = true;
            labelCustomerEmail.Location = new Point(35, 251);
            labelCustomerEmail.Name = "labelCustomerEmail";
            labelCustomerEmail.Size = new Size(106, 20);
            labelCustomerEmail.TabIndex = 6;
            labelCustomerEmail.Text = "Email Address:";
            // 
            // textCustomerPhone
            // 
            textCustomerPhone.Location = new Point(194, 291);
            textCustomerPhone.MaxLength = 20;
            textCustomerPhone.Name = "textCustomerPhone";
            textCustomerPhone.Size = new Size(270, 27);
            textCustomerPhone.TabIndex = 5;
            // 
            // labelCustomerPhone
            // 
            labelCustomerPhone.AutoSize = true;
            labelCustomerPhone.Location = new Point(35, 291);
            labelCustomerPhone.Name = "labelCustomerPhone";
            labelCustomerPhone.Size = new Size(111, 20);
            labelCustomerPhone.TabIndex = 8;
            labelCustomerPhone.Text = "Phone Number:";
            // 
            // textAllergies
            // 
            textAllergies.Location = new Point(194, 334);
            textAllergies.MaxLength = 500;
            textAllergies.Multiline = true;
            textAllergies.Name = "textAllergies";
            textAllergies.ScrollBars = ScrollBars.Vertical;
            textAllergies.Size = new Size(270, 74);
            textAllergies.TabIndex = 6;
            // 
            // labelAllergies
            // 
            labelAllergies.AutoSize = true;
            labelAllergies.Location = new Point(35, 334);
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
            buttonOrderSummary.Location = new Point(294, 484);
            buttonOrderSummary.Name = "buttonOrderSummary";
            buttonOrderSummary.Size = new Size(231, 42);
            buttonOrderSummary.TabIndex = 7;
            buttonOrderSummary.Text = "Order Summary";
            buttonOrderSummary.UseVisualStyleBackColor = false;
            buttonOrderSummary.Click += buttonOrderSummary_Click;
            // 
            // CustomerOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(800, 561);
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
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelProduct;
        private ComboBox comboBoxProduct;
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
    }
}