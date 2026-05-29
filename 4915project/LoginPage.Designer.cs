namespace _4915project
{
    partial class LoginPage
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
            button1.Location = new Point(200, 405);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(200, 192);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(150, 30);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPwd
            // 
            textBoxPwd.AcceptsReturn = true;
            textBoxPwd.Location = new Point(200, 327);
            textBoxPwd.Name = "textBoxPwd";
            textBoxPwd.PasswordChar = '*';
            textBoxPwd.Size = new Size(150, 30);
            textBoxPwd.TabIndex = 2;
            textBoxPwd.UseSystemPasswordChar = true;
            textBoxPwd.KeyDown += textBoxPwd_KeyDown;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(107, 195);
            Email.Name = "Email";
            Email.Size = new Size(57, 23);
            Email.TabIndex = 3;
            Email.Text = "Email";
            // 
            // Pwd
            // 
            Pwd.AutoSize = true;
            Pwd.Location = new Point(107, 327);
            Pwd.Name = "Pwd";
            Pwd.Size = new Size(90, 23);
            Pwd.TabIndex = 4;
            Pwd.Text = "Password";
            // 
            // LTitle
            // 
            LTitle.AutoSize = true;
            LTitle.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            LTitle.Location = new Point(55, 35);
            LTitle.Margin = new Padding(5, 0, 5, 0);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(381, 72);
            LTitle.TabIndex = 5;
            LTitle.Text = "Premium Living Centralized \r\nManage System";
            LTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 549);
            Controls.Add(LTitle);
            Controls.Add(Pwd);
            Controls.Add(Email);
            Controls.Add(textBoxPwd);
            Controls.Add(textBoxEmail);
            Controls.Add(button1);
            Name = "LoginPage";
            Text = "LoginPage";
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
