using Mysqlx.Session;

namespace _4915project
{
    partial class AddEmployee
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
            panel4 = new Panel();
            label7 = new Label();
            tbPhone = new TextBox();
            label6 = new Label();
            tbEmail = new TextBox();
            label5 = new Label();
            tbUserName = new TextBox();
            tbPosit = new TextBox();
            tbPassword = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cmbDepartment = new ComboBox();
            label9 = new Label();
            label1 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            cmbRole = new ComboBox();
            label2 = new Label();
            label8 = new Label();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(tbPhone);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(tbEmail);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(tbUserName);
            panel4.Controls.Add(tbPosit);
            panel4.Controls.Add(tbPassword);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(cmbDepartment);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(cmbRole);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(11, 11);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(529, 250);
            panel4.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 75);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 37;
            label7.Text = "@company.com";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(382, 69);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(115, 23);
            tbPhone.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 72);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 35;
            label6.Text = "Phone No.:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(59, 72);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(80, 23);
            tbEmail.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 77);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 33;
            label5.Text = "Email:";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(123, 23);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(100, 23);
            tbUserName.TabIndex = 32;
            // 
            // tbPosit
            // 
            tbPosit.Location = new Point(416, 138);
            tbPosit.Name = "tbPosit";
            tbPosit.Size = new Size(100, 23);
            tbPosit.TabIndex = 31;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(382, 22);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(115, 23);
            tbPassword.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 25);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 27;
            label4.Text = "Password: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 141);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 24;
            label3.Text = "Position:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(245, 138);
            cmbDepartment.Margin = new Padding(2);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(87, 23);
            cmbDepartment.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(163, 141);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 22;
            label9.Text = "Department:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 21;
            label1.Text = "Employee Name:";
            // 
            // button8
            // 
            button8.Location = new Point(445, 211);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(71, 22);
            button8.TabIndex = 19;
            button8.Text = "Cancel";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Cancel_Click;
            // 
            // button9
            // 
            button9.Location = new Point(334, 211);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(71, 22);
            button9.TabIndex = 18;
            button9.Text = "Save";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Save_Click;
            // 
            // button10
            // 
            button10.Location = new Point(194, 211);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(93, 22);
            button10.TabIndex = 17;
            button10.TabStop = false;
            button10.Text = "Reset Default";
            button10.UseVisualStyleBackColor = true;
            button10.Click += ResetDefault_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(52, 138);
            cmbRole.Margin = new Padding(2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(87, 23);
            cmbRole.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 141);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Role:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(2, 107);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 4;
            label8.Text = "Role Permission";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 277);
            Controls.Add(panel4);
            Name = "AddEmployee";
            Text = "Add Employee";
            Load += AddEmployee_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private TextBox tbPosit;
        private TextBox tbPassword;
        private Label label4;
        private Label label3;
        private ComboBox cmbDepartment;
        private Label label9;
        private Label label1;
        private Button button8;
        private Button button9;
        private Button button10;
        private ComboBox cmbRole;
        private Label label2;
        private Label label8;
        private TextBox tbPhone;
        private Label label6;
        private TextBox tbEmail;
        private Label label5;
        private TextBox tbUserName;
        private Label label7;
    }
}