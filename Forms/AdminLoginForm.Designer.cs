namespace OliveBranchBakes.Forms
{
    partial class AdminLoginForm
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
            labelUsername = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            labelPassword = new Label();
            buttonLogin = new Button();
            buttonPreviousConsole = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(266, 54);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(277, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Administrator Login";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(248, 106);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(307, 20);
            labelDescription.TabIndex = 1;
            labelDescription.Text = "Administrator access to bakery management.";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(363, 166);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(75, 20);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(248, 189);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(300, 27);
            textUsername.TabIndex = 0;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(250, 278);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(300, 27);
            textPassword.TabIndex = 1;
            textPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(365, 255);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(73, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(81, 100, 63);
            buttonLogin.Enabled = false;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(293, 396);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(237, 42);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonPreviousConsole
            // 
            buttonPreviousConsole.BackColor = Color.FromArgb(213, 166, 73);
            buttonPreviousConsole.Enabled = false;
            buttonPreviousConsole.FlatStyle = FlatStyle.Flat;
            buttonPreviousConsole.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPreviousConsole.ForeColor = Color.FromArgb(89, 62, 44);
            buttonPreviousConsole.Location = new Point(293, 444);
            buttonPreviousConsole.Name = "buttonPreviousConsole";
            buttonPreviousConsole.Size = new Size(237, 42);
            buttonPreviousConsole.TabIndex = 5;
            buttonPreviousConsole.Text = "Preview Admin Console";
            buttonPreviousConsole.UseVisualStyleBackColor = false;
            buttonPreviousConsole.Click += buttonPreviousConsole_Click;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(buttonPreviousConsole);
            Controls.Add(buttonLogin);
            Controls.Add(textPassword);
            Controls.Add(labelPassword);
            Controls.Add(textUsername);
            Controls.Add(labelUsername);
            Controls.Add(labelDescription);
            Controls.Add(labelTitle);
            MinimumSize = new Size(800, 600);
            Name = "AdminLoginForm";
            Text = "Olive Branch Bakes - Administrator Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelDescription;
        private Label labelUsername;
        private TextBox textUsername;
        private TextBox textPassword;
        private Label labelPassword;
        private Button buttonLogin;
        private Button buttonPreviousConsole;
    }
}