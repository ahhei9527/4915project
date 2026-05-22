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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(338, 321);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(338, 108);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(150, 30);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPwd
            // 
            textBoxPwd.Location = new Point(338, 242);
            textBoxPwd.Name = "textBoxPwd";
            textBoxPwd.Size = new Size(150, 30);
            textBoxPwd.TabIndex = 2;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(245, 111);
            Email.Name = "Email";
            Email.Size = new Size(57, 23);
            Email.TabIndex = 3;
            Email.Text = "Email";
            // 
            // Pwd
            // 
            Pwd.AutoSize = true;
            Pwd.Location = new Point(245, 242);
            Pwd.Name = "Pwd";
            Pwd.Size = new Size(90, 23);
            Pwd.TabIndex = 4;
            Pwd.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pwd);
            Controls.Add(Email);
            Controls.Add(textBoxPwd);
            Controls.Add(textBoxEmail);
            Controls.Add(button1);
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
    }
}
