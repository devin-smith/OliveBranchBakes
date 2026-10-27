namespace OliveBranchBakes.Forms
{
    partial class WelcomeForm
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
            labelWelcome = new Label();
            button1 = new Button();
            buttonAccount = new Button();
            buttonAdmin = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(243, 28);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(305, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Olive Branch Bakes";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Location = new Point(268, 73);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(248, 20);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Freshly baked with love, just for you!";
            labelWelcome.Click += labelWelcome_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(81, 100, 63);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(304, 246);
            button1.Name = "button1";
            button1.Size = new Size(199, 42);
            button1.TabIndex = 0;
            button1.Text = "Start Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonAccount
            // 
            buttonAccount.BackColor = Color.FromArgb(81, 100, 63);
            buttonAccount.Cursor = Cursors.Hand;
            buttonAccount.FlatStyle = FlatStyle.Flat;
            buttonAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAccount.ForeColor = Color.White;
            buttonAccount.Location = new Point(304, 294);
            buttonAccount.Name = "buttonAccount";
            buttonAccount.Size = new Size(199, 42);
            buttonAccount.TabIndex = 1;
            buttonAccount.Text = "Customer Account";
            buttonAccount.UseVisualStyleBackColor = false;
            buttonAccount.Click += buttonAccount_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.FromArgb(81, 100, 63);
            buttonAdmin.Cursor = Cursors.Hand;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdmin.ForeColor = Color.White;
            buttonAdmin.Location = new Point(304, 342);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(199, 42);
            buttonAdmin.TabIndex = 3;
            buttonAdmin.Text = "Administrator Login";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(buttonAdmin);
            Controls.Add(buttonAccount);
            Controls.Add(button1);
            Controls.Add(labelWelcome);
            Controls.Add(labelTitle);
            MinimumSize = new Size(800, 600);
            Name = "WelcomeForm";
            Text = "Olive Branch Bakes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelWelcome;
        private Button button1;
        private Button buttonAccount;
        private Button buttonAdmin;
    }
}