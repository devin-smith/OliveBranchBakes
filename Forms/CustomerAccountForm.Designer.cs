namespace OliveBranchBakes.Forms
{
    partial class CustomerAccountForm
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
            labelEmail = new Label();
            textEmail = new TextBox();
            labelPassword = new Label();
            textPassword = new TextBox();
            buttonSignIn = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(342, 45);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(315, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Customer Account";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(254, 115);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(500, 25);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Sign in to manage your account and view previous orders.";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(225, 209);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(134, 25);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email Address:";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(229, 238);
            textEmail.Margin = new Padding(4, 4, 4, 4);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(374, 32);
            textEmail.TabIndex = 0;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(225, 302);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(95, 25);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password:";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(229, 336);
            textPassword.Margin = new Padding(4, 4, 4, 4);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(376, 32);
            textPassword.TabIndex = 1;
            textPassword.UseSystemPasswordChar = true;
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.FromArgb(81, 100, 63);
            buttonSignIn.Enabled = false;
            buttonSignIn.FlatStyle = FlatStyle.Flat;
            buttonSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignIn.ForeColor = Color.White;
            buttonSignIn.Location = new Point(382, 574);
            buttonSignIn.Margin = new Padding(4, 4, 4, 4);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(300, 50);
            buttonSignIn.TabIndex = 2;
            buttonSignIn.Text = "Sign In";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // CustomerAccountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 701);
            Controls.Add(buttonSignIn);
            Controls.Add(textPassword);
            Controls.Add(labelPassword);
            Controls.Add(textEmail);
            Controls.Add(labelEmail);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(996, 738);
            Name = "CustomerAccountForm";
            Text = "Olive Branch Bakes - Customer Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelDescription;
        private Label labelEmail;
        private TextBox textEmail;
        private Label labelPassword;
        private TextBox textPassword;
        private Button buttonSignIn;
    }
}