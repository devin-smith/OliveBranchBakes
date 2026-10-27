namespace OliveBranchBakes.Forms
{
    partial class AdminConsoleForm
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
            labelFeatures = new Label();
            labelOrders = new Label();
            labelOrderStatus = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(262, 43);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(307, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Administrator Console";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(306, 89);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(220, 20);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Bakery management dashboard";
            // 
            // labelFeatures
            // 
            labelFeatures.AutoSize = true;
            labelFeatures.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFeatures.Location = new Point(326, 177);
            labelFeatures.Name = "labelFeatures";
            labelFeatures.Size = new Size(182, 21);
            labelFeatures.TabIndex = 2;
            labelFeatures.Text = "Manage Bakery Products";
            // 
            // labelOrders
            // 
            labelOrders.AutoSize = true;
            labelOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOrders.Location = new Point(340, 226);
            labelOrders.Name = "labelOrders";
            labelOrders.Size = new Size(168, 21);
            labelOrders.TabIndex = 3;
            labelOrders.Text = "View Customer Orders";
            // 
            // labelOrderStatus
            // 
            labelOrderStatus.AutoSize = true;
            labelOrderStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOrderStatus.Location = new Point(348, 276);
            labelOrderStatus.Name = "labelOrderStatus";
            labelOrderStatus.Size = new Size(151, 21);
            labelOrderStatus.TabIndex = 4;
            labelOrderStatus.Text = "Update Order Status";
            // 
            // AdminConsoleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(labelOrderStatus);
            Controls.Add(labelOrders);
            Controls.Add(labelFeatures);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            MinimumSize = new Size(800, 600);
            Name = "AdminConsoleForm";
            Text = "Olive Branch Bakes - Administrator Console";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelDescription;
        private Label labelFeatures;
        private Label labelOrders;
        private Label labelOrderStatus;
    }
}