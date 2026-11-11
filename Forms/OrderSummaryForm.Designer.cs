namespace OliveBranchBakes.Forms
{
    partial class OrderSummaryForm
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
            labelDescription = new Label();
            buttonConfirmOrder = new Button();
            listOrderItems = new ListView();
            labelSubtotal = new Label();
            labelOrderDiscount = new Label();
            labelOrderTax = new Label();
            labelOrderTotal = new Label();
            labelOrderPickup = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(299, 35);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(221, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Order Summary";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(329, 91);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(154, 20);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Your order details are:";
            // 
            // buttonConfirmOrder
            // 
            buttonConfirmOrder.BackColor = Color.FromArgb(81, 100, 63);
            buttonConfirmOrder.Cursor = Cursors.Hand;
            buttonConfirmOrder.FlatStyle = FlatStyle.Flat;
            buttonConfirmOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConfirmOrder.ForeColor = Color.White;
            buttonConfirmOrder.Location = new Point(539, 384);
            buttonConfirmOrder.Name = "buttonConfirmOrder";
            buttonConfirmOrder.Size = new Size(231, 42);
            buttonConfirmOrder.TabIndex = 8;
            buttonConfirmOrder.Text = "Confirm Order";
            buttonConfirmOrder.UseVisualStyleBackColor = false;
            buttonConfirmOrder.Click += buttonConfirmOrder_Click;
            // 
            // listOrderItems
            // 
            listOrderItems.FullRowSelect = true;
            listOrderItems.GridLines = true;
            listOrderItems.Location = new Point(60, 133);
            listOrderItems.MultiSelect = false;
            listOrderItems.Name = "listOrderItems";
            listOrderItems.Size = new Size(460, 293);
            listOrderItems.TabIndex = 9;
            listOrderItems.UseCompatibleStateImageBehavior = false;
            listOrderItems.View = View.Details;
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Location = new Point(539, 133);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(107, 20);
            labelSubtotal.TabIndex = 22;
            labelSubtotal.Text = "Subtotal: $0.00";
            // 
            // labelOrderDiscount
            // 
            labelOrderDiscount.AutoSize = true;
            labelOrderDiscount.Location = new Point(539, 153);
            labelOrderDiscount.Name = "labelOrderDiscount";
            labelOrderDiscount.Size = new Size(109, 20);
            labelOrderDiscount.TabIndex = 23;
            labelOrderDiscount.Text = "Discount: $0.00";
            // 
            // labelOrderTax
            // 
            labelOrderTax.AutoSize = true;
            labelOrderTax.Location = new Point(539, 173);
            labelOrderTax.Name = "labelOrderTax";
            labelOrderTax.Size = new Size(72, 20);
            labelOrderTax.TabIndex = 24;
            labelOrderTax.Text = "Tax: $0.00";
            // 
            // labelOrderTotal
            // 
            labelOrderTotal.AutoSize = true;
            labelOrderTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOrderTotal.Location = new Point(539, 217);
            labelOrderTotal.Name = "labelOrderTotal";
            labelOrderTotal.Size = new Size(92, 20);
            labelOrderTotal.TabIndex = 25;
            labelOrderTotal.Text = "Total: $0.00";
            // 
            // labelOrderPickup
            // 
            labelOrderPickup.AutoSize = true;
            labelOrderPickup.Location = new Point(539, 261);
            labelOrderPickup.Name = "labelOrderPickup";
            labelOrderPickup.Size = new Size(55, 20);
            labelOrderPickup.TabIndex = 26;
            labelOrderPickup.Text = "Pickup:";
            //
            // OrderSummaryForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(labelOrderPickup);
            Controls.Add(labelOrderTotal);
            Controls.Add(labelOrderTax);
            Controls.Add(labelOrderDiscount);
            Controls.Add(labelSubtotal);
            Controls.Add(listOrderItems);
            Controls.Add(buttonConfirmOrder);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            MinimumSize = new Size(800, 600);
            Name = "OrderSummaryForm";
            Text = "Olive Branch Bakes - Order Summary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelDescription;
        private Button buttonConfirmOrder;
        private ListView listOrderItems;
        private Label labelSubtotal;
        private Label labelOrderDiscount;
        private Label labelOrderTax;
        private Label labelOrderTotal;
        private Label labelOrderPickup;
    }
}