namespace OliveBranchBakes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelProjectName = new Label();
            labelStudentName = new Label();
            labelClass = new Label();
            labelPhase = new Label();
            labelDate = new Label();
            labelDescription = new Label();
            textBoxProjectName = new TextBox();
            textBoxStudentName = new TextBox();
            textBoxPhase = new TextBox();
            textBoxClass = new TextBox();
            textBoxDate = new TextBox();
            richTextBoxDescription = new RichTextBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.BackColor = Color.SteelBlue;
            labelTitle.BorderStyle = BorderStyle.Fixed3D;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.WhiteSmoke;
            labelTitle.Location = new Point(14, 12);
            labelTitle.MinimumSize = new Size(114, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(8);
            labelTitle.Size = new Size(887, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Olive Branch Bakes - Project Information";
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.Font = new Font("Segoe UI", 11.25F);
            labelProjectName.Location = new Point(43, 84);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(99, 20);
            labelProjectName.TabIndex = 1;
            labelProjectName.Text = "Project Name";
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new Font("Segoe UI", 11.25F);
            labelStudentName.Location = new Point(43, 128);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(104, 20);
            labelStudentName.TabIndex = 2;
            labelStudentName.Text = "Student Name";
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Segoe UI", 11.25F);
            labelClass.Location = new Point(43, 216);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(42, 20);
            labelClass.TabIndex = 3;
            labelClass.Text = "Class";
            // 
            // labelPhase
            // 
            labelPhase.AutoSize = true;
            labelPhase.Font = new Font("Segoe UI", 11.25F);
            labelPhase.Location = new Point(43, 172);
            labelPhase.Name = "labelPhase";
            labelPhase.Size = new Size(47, 20);
            labelPhase.TabIndex = 4;
            labelPhase.Text = "Phase";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 11.25F);
            labelDate.Location = new Point(43, 260);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(41, 20);
            labelDate.TabIndex = 5;
            labelDate.Text = "Date";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 11.25F);
            labelDescription.Location = new Point(43, 304);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.TabIndex = 6;
            labelDescription.Text = "Description";
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.Font = new Font("Segoe UI", 11.25F);
            textBoxProjectName.Location = new Point(219, 80);
            textBoxProjectName.Margin = new Padding(3, 4, 3, 4);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.ReadOnly = true;
            textBoxProjectName.Size = new Size(652, 27);
            textBoxProjectName.TabIndex = 7;
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.Font = new Font("Segoe UI", 11.25F);
            textBoxStudentName.Location = new Point(219, 124);
            textBoxStudentName.Margin = new Padding(3, 4, 3, 4);
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.ReadOnly = true;
            textBoxStudentName.Size = new Size(652, 27);
            textBoxStudentName.TabIndex = 8;
            // 
            // textBoxPhase
            // 
            textBoxPhase.Font = new Font("Segoe UI", 11.25F);
            textBoxPhase.Location = new Point(219, 168);
            textBoxPhase.Margin = new Padding(3, 4, 3, 4);
            textBoxPhase.Name = "textBoxPhase";
            textBoxPhase.ReadOnly = true;
            textBoxPhase.Size = new Size(652, 27);
            textBoxPhase.TabIndex = 9;
            // 
            // textBoxClass
            // 
            textBoxClass.Font = new Font("Segoe UI", 11.25F);
            textBoxClass.Location = new Point(219, 212);
            textBoxClass.Margin = new Padding(3, 4, 3, 4);
            textBoxClass.Name = "textBoxClass";
            textBoxClass.ReadOnly = true;
            textBoxClass.Size = new Size(652, 27);
            textBoxClass.TabIndex = 10;
            // 
            // textBoxDate
            // 
            textBoxDate.Font = new Font("Segoe UI", 11.25F);
            textBoxDate.Location = new Point(219, 256);
            textBoxDate.Margin = new Padding(3, 4, 3, 4);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.ReadOnly = true;
            textBoxDate.Size = new Size(652, 27);
            textBoxDate.TabIndex = 11;
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxDescription.Location = new Point(219, 300);
            richTextBoxDescription.Margin = new Padding(3, 4, 3, 4);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.ReadOnly = true;
            richTextBoxDescription.Size = new Size(652, 127);
            richTextBoxDescription.TabIndex = 12;
            richTextBoxDescription.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(914, 470);
            Controls.Add(richTextBoxDescription);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxClass);
            Controls.Add(textBoxPhase);
            Controls.Add(textBoxStudentName);
            Controls.Add(textBoxProjectName);
            Controls.Add(labelDescription);
            Controls.Add(labelDate);
            Controls.Add(labelPhase);
            Controls.Add(labelClass);
            Controls.Add(labelStudentName);
            Controls.Add(labelProjectName);
            Controls.Add(labelTitle);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(112, 39);
            Name = "Form1";
            Text = "Olive Branch Bakes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelProjectName;
        private Label labelStudentName;
        private Label labelClass;
        private Label labelPhase;
        private Label labelDate;
        private Label labelDescription;
        private TextBox textBoxProjectName;
        private TextBox textBoxStudentName;
        private TextBox textBoxPhase;
        private TextBox textBoxClass;
        private TextBox textBoxDate;
        private RichTextBox richTextBoxDescription;
    }
}
