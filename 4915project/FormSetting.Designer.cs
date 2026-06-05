namespace ITP4915M
{
    partial class FormSetting
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
            label1SystemName = new Label();
            settingTab = new TabControl();
            Company = new TabPage();
            panel2 = new Panel();
            btAddCom = new Button();
            cmbCompanyName = new ComboBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            buttonResetDefault = new Button();
            labelCompanyName = new Label();
            cmbComCurr = new ComboBox();
            labelDefaultLanguage = new Label();
            labelDefaultWarehouse = new Label();
            labelDefaultCurrency = new Label();
            cmbComWH = new ComboBox();
            cmbComLan = new ComboBox();
            Employee = new TabPage();
            panel4 = new Panel();
            tbPosit = new TextBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            tbPassword = new TextBox();
            label4 = new Label();
            btAddUser = new Button();
            label3 = new Label();
            cmbDepartment = new ComboBox();
            label9 = new Label();
            label1 = new Label();
            cmbUserName = new ComboBox();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            cmbRole = new ComboBox();
            label2 = new Label();
            label8 = new Label();
            Customer = new TabPage();
            tbCustPhone = new TextBox();
            tbCustAddress = new TextBox();
            tbCustEmail = new TextBox();
            cmbCustCompany = new ComboBox();
            cmbCustName = new ComboBox();
            btAddCust = new Button();
            btCustCancel = new Button();
            btCustSave = new Button();
            btCustReset = new Button();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            settingTab.SuspendLayout();
            Company.SuspendLayout();
            panel2.SuspendLayout();
            Employee.SuspendLayout();
            panel4.SuspendLayout();
            Customer.SuspendLayout();
            SuspendLayout();
            // 
            // label1SystemName
            // 
            label1SystemName.AutoSize = true;
            label1SystemName.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1SystemName.Location = new Point(18, 12);
            label1SystemName.Margin = new Padding(2, 0, 2, 0);
            label1SystemName.Name = "label1SystemName";
            label1SystemName.Size = new Size(509, 30);
            label1SystemName.TabIndex = 18;
            label1SystemName.Text = "Premium Living Centralized Manage System";
            // 
            // settingTab
            // 
            settingTab.Controls.Add(Company);
            settingTab.Controls.Add(Employee);
            settingTab.Controls.Add(Customer);
            settingTab.Location = new Point(12, 45);
            settingTab.Name = "settingTab";
            settingTab.SelectedIndex = 0;
            settingTab.Size = new Size(536, 258);
            settingTab.TabIndex = 25;
            // 
            // Company
            // 
            Company.Controls.Add(panel2);
            Company.Location = new Point(4, 24);
            Company.Name = "Company";
            Company.Padding = new Padding(3);
            Company.Size = new Size(528, 230);
            Company.TabIndex = 0;
            Company.Text = "Company Setting";
            Company.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btAddCom);
            panel2.Controls.Add(cmbCompanyName);
            panel2.Controls.Add(buttonCancel);
            panel2.Controls.Add(buttonSave);
            panel2.Controls.Add(buttonResetDefault);
            panel2.Controls.Add(labelCompanyName);
            panel2.Controls.Add(cmbComCurr);
            panel2.Controls.Add(labelDefaultLanguage);
            panel2.Controls.Add(labelDefaultWarehouse);
            panel2.Controls.Add(labelDefaultCurrency);
            panel2.Controls.Add(cmbComWH);
            panel2.Controls.Add(cmbComLan);
            panel2.Location = new Point(5, 5);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 220);
            panel2.TabIndex = 12;
            // 
            // btAddCom
            // 
            btAddCom.Location = new Point(35, 146);
            btAddCom.Name = "btAddCom";
            btAddCom.Size = new Size(122, 23);
            btAddCom.TabIndex = 17;
            btAddCom.Text = "Add Company";
            btAddCom.UseVisualStyleBackColor = true;
            btAddCom.Click += btAddCom_Click;
            // 
            // cmbCompanyName
            // 
            cmbCompanyName.FormattingEnabled = true;
            cmbCompanyName.Location = new Point(129, 13);
            cmbCompanyName.Name = "cmbCompanyName";
            cmbCompanyName.Size = new Size(224, 23);
            cmbCompanyName.TabIndex = 16;
            cmbCompanyName.SelectedIndexChanged += cmbCompanyName_SelectedIndexChanged;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(434, 146);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(71, 22);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(327, 146);
            buttonSave.Margin = new Padding(2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(71, 22);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonResetDefault
            // 
            buttonResetDefault.Location = new Point(195, 146);
            buttonResetDefault.Margin = new Padding(2);
            buttonResetDefault.Name = "buttonResetDefault";
            buttonResetDefault.Size = new Size(93, 22);
            buttonResetDefault.TabIndex = 13;
            buttonResetDefault.TabStop = false;
            buttonResetDefault.Text = "Reset Default";
            buttonResetDefault.UseVisualStyleBackColor = true;
            buttonResetDefault.Click += buttonResetDefault_Click;
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelCompanyName.Location = new Point(21, 16);
            labelCompanyName.Margin = new Padding(2, 0, 2, 0);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(103, 15);
            labelCompanyName.TabIndex = 0;
            labelCompanyName.Text = "Company Name:";
            // 
            // cmbComCurr
            // 
            cmbComCurr.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmbComCurr.FormattingEnabled = true;
            cmbComCurr.Location = new Point(129, 101);
            cmbComCurr.Margin = new Padding(2);
            cmbComCurr.Name = "cmbComCurr";
            cmbComCurr.Size = new Size(102, 23);
            cmbComCurr.TabIndex = 9;
            // 
            // labelDefaultLanguage
            // 
            labelDefaultLanguage.AutoSize = true;
            labelDefaultLanguage.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelDefaultLanguage.Location = new Point(13, 44);
            labelDefaultLanguage.Margin = new Padding(2, 0, 2, 0);
            labelDefaultLanguage.Name = "labelDefaultLanguage";
            labelDefaultLanguage.Size = new Size(111, 15);
            labelDefaultLanguage.TabIndex = 1;
            labelDefaultLanguage.Text = "Default Language:";
            // 
            // labelDefaultWarehouse
            // 
            labelDefaultWarehouse.AutoSize = true;
            labelDefaultWarehouse.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelDefaultWarehouse.Location = new Point(4, 70);
            labelDefaultWarehouse.Margin = new Padding(2, 0, 2, 0);
            labelDefaultWarehouse.Name = "labelDefaultWarehouse";
            labelDefaultWarehouse.Size = new Size(118, 15);
            labelDefaultWarehouse.TabIndex = 4;
            labelDefaultWarehouse.Text = "Default Warehouse:";
            // 
            // labelDefaultCurrency
            // 
            labelDefaultCurrency.AutoSize = true;
            labelDefaultCurrency.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelDefaultCurrency.Location = new Point(4, 101);
            labelDefaultCurrency.Margin = new Padding(2, 0, 2, 0);
            labelDefaultCurrency.Name = "labelDefaultCurrency";
            labelDefaultCurrency.Size = new Size(103, 15);
            labelDefaultCurrency.TabIndex = 3;
            labelDefaultCurrency.Text = "Default Currency:";
            // 
            // cmbComWH
            // 
            cmbComWH.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmbComWH.FormattingEnabled = true;
            cmbComWH.Location = new Point(129, 74);
            cmbComWH.Margin = new Padding(2);
            cmbComWH.Name = "cmbComWH";
            cmbComWH.Size = new Size(102, 23);
            cmbComWH.TabIndex = 7;
            // 
            // cmbComLan
            // 
            cmbComLan.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmbComLan.FormattingEnabled = true;
            cmbComLan.Location = new Point(129, 42);
            cmbComLan.Margin = new Padding(2);
            cmbComLan.Name = "cmbComLan";
            cmbComLan.Size = new Size(102, 23);
            cmbComLan.TabIndex = 6;
            // 
            // Employee
            // 
            Employee.Controls.Add(panel4);
            Employee.Location = new Point(4, 24);
            Employee.Name = "Employee";
            Employee.Padding = new Padding(3);
            Employee.Size = new Size(528, 230);
            Employee.TabIndex = 1;
            Employee.Text = "Employee Setting";
            Employee.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(tbPosit);
            panel4.Controls.Add(checkBox2);
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(tbPassword);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btAddUser);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(cmbDepartment);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cmbUserName);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(cmbRole);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(2, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(521, 225);
            panel4.TabIndex = 16;
            // 
            // tbPosit
            // 
            tbPosit.Location = new Point(416, 94);
            tbPosit.Name = "tbPosit";
            tbPosit.Size = new Size(100, 23);
            tbPosit.TabIndex = 31;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(135, 63);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 19);
            checkBox2.TabIndex = 30;
            checkBox2.Text = "Change Role";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(382, 51);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 19);
            checkBox1.TabIndex = 29;
            checkBox1.Text = "Change Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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
            // btAddUser
            // 
            btAddUser.Location = new Point(42, 154);
            btAddUser.Name = "btAddUser";
            btAddUser.Size = new Size(110, 23);
            btAddUser.TabIndex = 26;
            btAddUser.Text = "Add Employee";
            btAddUser.UseVisualStyleBackColor = true;
            btAddUser.Click += btAddUser_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 24;
            label3.Text = "Position:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(245, 94);
            cmbDepartment.Margin = new Padding(2);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(87, 23);
            cmbDepartment.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(163, 97);
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
            // cmbUserName
            // 
            cmbUserName.FormattingEnabled = true;
            cmbUserName.Location = new Point(123, 23);
            cmbUserName.Name = "cmbUserName";
            cmbUserName.Size = new Size(121, 23);
            cmbUserName.TabIndex = 20;
            cmbUserName.SelectedIndexChanged += cmbUserName_SelectedIndexChanged;
            // 
            // button8
            // 
            button8.Location = new Point(437, 154);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(71, 22);
            button8.TabIndex = 19;
            button8.Text = "Cancel";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(319, 154);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(71, 22);
            button9.TabIndex = 18;
            button9.Text = "Save";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(187, 154);
            button10.Margin = new Padding(2);
            button10.Name = "button10";
            button10.Size = new Size(93, 22);
            button10.TabIndex = 17;
            button10.TabStop = false;
            button10.Text = "Reset Default";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(52, 94);
            cmbRole.Margin = new Padding(2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(87, 23);
            cmbRole.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
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
            label8.Location = new Point(2, 63);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 4;
            label8.Text = "Role Permission";
            // 
            // Customer
            // 
            Customer.Controls.Add(tbCustPhone);
            Customer.Controls.Add(tbCustAddress);
            Customer.Controls.Add(tbCustEmail);
            Customer.Controls.Add(cmbCustCompany);
            Customer.Controls.Add(cmbCustName);
            Customer.Controls.Add(btAddCust);
            Customer.Controls.Add(btCustCancel);
            Customer.Controls.Add(btCustSave);
            Customer.Controls.Add(btCustReset);
            Customer.Controls.Add(label11);
            Customer.Controls.Add(label10);
            Customer.Controls.Add(label7);
            Customer.Controls.Add(label6);
            Customer.Controls.Add(label5);
            Customer.Location = new Point(4, 24);
            Customer.Name = "Customer";
            Customer.Size = new Size(528, 230);
            Customer.TabIndex = 2;
            Customer.Text = "Customer Setting";
            Customer.UseVisualStyleBackColor = true;
            // 
            // tbCustPhone
            // 
            tbCustPhone.Location = new Point(296, 80);
            tbCustPhone.Name = "tbCustPhone";
            tbCustPhone.Size = new Size(121, 23);
            tbCustPhone.TabIndex = 35;
            // 
            // tbCustAddress
            // 
            tbCustAddress.Location = new Point(19, 142);
            tbCustAddress.Name = "tbCustAddress";
            tbCustAddress.Size = new Size(398, 23);
            tbCustAddress.TabIndex = 34;
            // 
            // tbCustEmail
            // 
            tbCustEmail.Location = new Point(76, 77);
            tbCustEmail.Name = "tbCustEmail";
            tbCustEmail.Size = new Size(121, 23);
            tbCustEmail.TabIndex = 33;
            // 
            // cmbCustCompany
            // 
            cmbCustCompany.FormattingEnabled = true;
            cmbCustCompany.Location = new Point(296, 12);
            cmbCustCompany.Name = "cmbCustCompany";
            cmbCustCompany.Size = new Size(121, 23);
            cmbCustCompany.TabIndex = 32;
            // 
            // cmbCustName
            // 
            cmbCustName.FormattingEnabled = true;
            cmbCustName.Location = new Point(76, 9);
            cmbCustName.Name = "cmbCustName";
            cmbCustName.Size = new Size(121, 23);
            cmbCustName.TabIndex = 31;
            cmbCustName.SelectedIndexChanged += cmbCustName_SelectedIndexChanged;
            // 
            // btAddCust
            // 
            btAddCust.Location = new Point(19, 181);
            btAddCust.Name = "btAddCust";
            btAddCust.Size = new Size(110, 23);
            btAddCust.TabIndex = 30;
            btAddCust.Text = "Add Customer";
            btAddCust.UseVisualStyleBackColor = true;
            btAddCust.Click += btAddCust_Click;
            // 
            // btCustCancel
            // 
            btCustCancel.Location = new Point(414, 181);
            btCustCancel.Margin = new Padding(2);
            btCustCancel.Name = "btCustCancel";
            btCustCancel.Size = new Size(71, 22);
            btCustCancel.TabIndex = 29;
            btCustCancel.Text = "Cancel";
            btCustCancel.UseVisualStyleBackColor = true;
            btCustCancel.Click += btCustCancel_Click;
            // 
            // btCustSave
            // 
            btCustSave.Location = new Point(296, 181);
            btCustSave.Margin = new Padding(2);
            btCustSave.Name = "btCustSave";
            btCustSave.Size = new Size(71, 22);
            btCustSave.TabIndex = 28;
            btCustSave.Text = "Save";
            btCustSave.UseVisualStyleBackColor = true;
            btCustSave.Click += btCustSave_Click;
            // 
            // btCustReset
            // 
            btCustReset.Location = new Point(164, 181);
            btCustReset.Margin = new Padding(2);
            btCustReset.Name = "btCustReset";
            btCustReset.Size = new Size(93, 22);
            btCustReset.TabIndex = 27;
            btCustReset.TabStop = false;
            btCustReset.Text = "Reset Default";
            btCustReset.UseVisualStyleBackColor = true;
            btCustReset.Click += btCustReset_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(224, 12);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 4;
            label11.Text = "Company: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 77);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 3;
            label10.Text = "Email: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(235, 85);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 2;
            label7.Text = "Phone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 124);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 1;
            label6.Text = "Address: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 12);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 0;
            label5.Text = "Name: ";
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 304);
            Controls.Add(settingTab);
            Controls.Add(label1SystemName);
            Margin = new Padding(2);
            Name = "FormSetting";
            Text = "Settings";
            Load += FormSetting_Load;
            settingTab.ResumeLayout(false);
            Company.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Employee.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            Customer.ResumeLayout(false);
            Customer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1SystemName;
        private TabControl settingTab;
        private TabPage Company;
        private TabPage Employee;
        private Panel panel2;
        private Button buttonCancel;
        private Button buttonSave;
        private Button buttonResetDefault;
        private Label labelCompanyName;
        private ComboBox cmbComCurr;
        private Label labelDefaultLanguage;
        private Label labelDefaultWarehouse;
        private Label labelDefaultCurrency;
        private ComboBox cmbComWH;
        private ComboBox cmbComLan;
        private Panel panel4;
        private Button button8;
        private Button button9;
        private Button button10;
        private ComboBox cmbRole;
        private Label label2;
        private Label label8;
        private ComboBox cmbCompanyName;
        private Label label1;
        private ComboBox cmbUserName;
        private Button btAddCom;
        private ComboBox cmbDepartment;
        private Label label9;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox tbPassword;
        private Label label4;
        private Button btAddUser;
        private Label label3;
        private TextBox tbPosit;
        private TabPage Customer;
        private Button btAddCust;
        private Button btCustCancel;
        private Button btCustSave;
        private Button btCustReset;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbCustPhone;
        private TextBox tbCustAddress;
        private TextBox tbCustEmail;
        private ComboBox cmbCustCompany;
        private ComboBox cmbCustName;
    }
}