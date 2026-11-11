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
            textFullName = new TextBox();
            labelFullName = new Label();
            textPhone = new TextBox();
            labelPhone = new Label();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(274, 36);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(253, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Customer Account";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(203, 92);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(391, 20);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Sign in to manage your account and view previous orders.";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(417, 146);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(106, 20);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email Address:";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(417, 169);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(326, 27);
            textEmail.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(417, 210);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(73, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password:";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(417, 233);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(326, 27);
            textPassword.TabIndex = 3;
            textPassword.UseSystemPasswordChar = true;
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.FromArgb(81, 100, 63);
            buttonSignIn.FlatStyle = FlatStyle.Flat;
            buttonSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignIn.ForeColor = Color.White;
            buttonSignIn.Location = new Point(417, 454);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(240, 40);
            buttonSignIn.TabIndex = 5;
            buttonSignIn.Text = "Sign In";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // textFullName
            // 
            textFullName.Location = new Point(72, 169);
            textFullName.Name = "textFullName";
            textFullName.Size = new Size(326, 27);
            textFullName.TabIndex = 0;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(72, 146);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(79, 20);
            labelFullName.TabIndex = 6;
            labelFullName.Text = "Full Name:";
            labelFullName.Click += labelFullName_Click;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(72, 233);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(326, 27);
            textPhone.TabIndex = 2;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(72, 210);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(111, 20);
            labelPhone.TabIndex = 8;
            labelPhone.Text = "Phone Number:";
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(81, 100, 63);
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(158, 454);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(240, 40);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "Create Account";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // CustomerAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(buttonRegister);
            Controls.Add(textPhone);
            Controls.Add(labelPhone);
            Controls.Add(textFullName);
            Controls.Add(labelFullName);
            Controls.Add(buttonSignIn);
            Controls.Add(textPassword);
            Controls.Add(labelPassword);
            Controls.Add(textEmail);
            Controls.Add(labelEmail);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            MinimumSize = new Size(800, 598);
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
        private TextBox textFullName;
        private Label labelFullName;
        private TextBox textPhone;
        private Label labelPhone;
        private Button buttonRegister;
    }
}