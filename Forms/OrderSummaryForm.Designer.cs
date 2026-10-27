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
            // OrderSummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
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
    }
}