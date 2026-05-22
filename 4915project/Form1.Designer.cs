namespace _4915project
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
            button1 = new Button();
            textBoxEmail = new TextBox();
            textBoxPwd = new TextBox();
            Email = new Label();
            Pwd = new Label();
            LTitle = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(127, 264);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(71, 22);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(127, 125);
            textBoxEmail.Margin = new Padding(2, 2, 2, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(97, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPwd
            // 
            textBoxPwd.Location = new Point(127, 213);
            textBoxPwd.Margin = new Padding(2, 2, 2, 2);
            textBoxPwd.Name = "textBoxPwd";
            textBoxPwd.Size = new Size(97, 23);
            textBoxPwd.TabIndex = 2;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(68, 127);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(38, 15);
            Email.TabIndex = 3;
            Email.Text = "Email";
            // 
            // Pwd
            // 
            Pwd.AutoSize = true;
            Pwd.Location = new Point(68, 213);
            Pwd.Margin = new Padding(2, 0, 2, 0);
            Pwd.Name = "Pwd";
            Pwd.Size = new Size(60, 15);
            Pwd.TabIndex = 4;
            Pwd.Text = "Password";
            // 
            // LTitle
            // 
            LTitle.AutoSize = true;
            LTitle.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            LTitle.Location = new Point(107, 47);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(118, 47);
            LTitle.TabIndex = 5;
            LTitle.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 358);
            Controls.Add(LTitle);
            Controls.Add(Pwd);
            Controls.Add(Email);
            Controls.Add(textBoxPwd);
            Controls.Add(textBoxEmail);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxEmail;
        private TextBox textBoxPwd;
        private Label Email;
        private Label Pwd;
        private Label LTitle;
    }
}
