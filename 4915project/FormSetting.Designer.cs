namespace _4915project
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
            Customer = new TabPage();
            panel1 = new Panel();
            tbCustAddress = new TextBox();
            tbCustPhone = new TextBox();
            tbCustEmail = new TextBox();
            cmbCustName = new ComboBox();
            label2 = new Label();
            btAddCust = new Button();
            button2 = new Button();
            button3 = new Button();
            btCustReset = new Button();
            label4 = new Label();
            cmbCustCompany = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            Employee = new TabPage();
            panel4 = new Panel();
            cbRole = new CheckBox();
            cmbPosit = new ComboBox();
            label1 = new Label();
            cmbDepartment = new ComboBox();
            label18 = new Label();
            cbPwd = new CheckBox();
            cmbUserName = new ComboBox();
            label17 = new Label();
            tbPassword = new TextBox();
            label16 = new Label();
            cmbRole = new ComboBox();
            label3 = new Label();
            btAddUser = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label8 = new Label();
            Company = new TabPage();
            panel2 = new Panel();
            cmbCompanyName = new ComboBox();
            btAddCom = new Button();
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
            settingTab = new TabControl();
            Customer.SuspendLayout();
            panel1.SuspendLayout();
            Employee.SuspendLayout();
            panel4.SuspendLayout();
            Company.SuspendLayout();
            panel2.SuspendLayout();
            settingTab.SuspendLayout();
            SuspendLayout();
            // 
            // label1SystemName
            // 
            label1SystemName.AutoSize = true;
            label1SystemName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1SystemName.Location = new Point(41, 21);
            label1SystemName.Name = "label1SystemName";
            label1SystemName.Size = new Size(592, 36);
            label1SystemName.TabIndex = 18;
            label1SystemName.Text = "Premium Living Centralized Manage System";
            // 
            // Customer
            // 
            Customer.BorderStyle = BorderStyle.FixedSingle;
            Customer.Controls.Add(panel1);
            Customer.Location = new Point(4, 32);
            Customer.Margin = new Padding(5, 5, 5, 5);
            Customer.Name = "Customer";
            Customer.Size = new Size(1270, 711);
            Customer.TabIndex = 2;
            Customer.Text = "Customer";
            Customer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tbCustAddress);
            panel1.Controls.Add(tbCustPhone);
            panel1.Controls.Add(tbCustEmail);
            panel1.Controls.Add(cmbCustName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btAddCust);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btCustReset);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbCustCompany);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(20, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 677);
            panel1.TabIndex = 36;
            // 
            // tbCustAddress
            // 
            tbCustAddress.Location = new Point(462, 281);
            tbCustAddress.Margin = new Padding(5, 5, 5, 5);
            tbCustAddress.Name = "tbCustAddress";
            tbCustAddress.Size = new Size(348, 30);
            tbCustAddress.TabIndex = 41;
            // 
            // tbCustPhone
            // 
            tbCustPhone.Location = new Point(462, 235);
            tbCustPhone.Margin = new Padding(5, 5, 5, 5);
            tbCustPhone.Name = "tbCustPhone";
            tbCustPhone.Size = new Size(348, 30);
            tbCustPhone.TabIndex = 40;
            // 
            // tbCustEmail
            // 
            tbCustEmail.Location = new Point(462, 186);
            tbCustEmail.Margin = new Padding(5, 5, 5, 5);
            tbCustEmail.Name = "tbCustEmail";
            tbCustEmail.Size = new Size(348, 30);
            tbCustEmail.TabIndex = 39;
            // 
            // cmbCustName
            // 
            cmbCustName.FormattingEnabled = true;
            cmbCustName.Location = new Point(462, 141);
            cmbCustName.Margin = new Padding(5, 5, 5, 5);
            cmbCustName.Name = "cmbCustName";
            cmbCustName.Size = new Size(348, 31);
            cmbCustName.TabIndex = 38;
            cmbCustName.SelectedIndexChanged += cmbCustName_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 239);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(156, 23);
            label2.TabIndex = 35;
            label2.Text = "Customer Phone:";
            // 
            // btAddCust
            // 
            btAddCust.Location = new Point(245, 498);
            btAddCust.Margin = new Padding(5, 5, 5, 5);
            btAddCust.Name = "btAddCust";
            btAddCust.Size = new Size(192, 35);
            btAddCust.TabIndex = 33;
            btAddCust.Text = "Add Customer";
            btAddCust.UseVisualStyleBackColor = true;
            btAddCust.Click += btAddCust_Click;
            // 
            // button2
            // 
            button2.Location = new Point(869, 498);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 32;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(739, 500);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 31;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            // 
            // btCustReset
            // 
            btCustReset.Location = new Point(445, 500);
            btCustReset.Name = "btCustReset";
            btCustReset.Size = new Size(146, 34);
            btCustReset.TabIndex = 30;
            btCustReset.TabStop = false;
            btCustReset.Text = "Reset Default";
            btCustReset.UseVisualStyleBackColor = true;
            btCustReset.Click += btCustReset_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(303, 146);
            label4.Name = "label4";
            label4.Size = new Size(154, 23);
            label4.TabIndex = 23;
            label4.Text = "Customer Name:";
            // 
            // cmbCustCompany
            // 
            cmbCustCompany.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmbCustCompany.FormattingEnabled = true;
            cmbCustCompany.Location = new Point(460, 324);
            cmbCustCompany.Name = "cmbCustCompany";
            cmbCustCompany.Size = new Size(350, 31);
            cmbCustCompany.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.Location = new Point(300, 190);
            label6.Name = "label6";
            label6.Size = new Size(149, 23);
            label6.TabIndex = 24;
            label6.Text = "Customer Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(278, 285);
            label7.Name = "label7";
            label7.Size = new Size(169, 23);
            label7.TabIndex = 26;
            label7.Text = "Customer Address:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label9.Location = new Point(262, 328);
            label9.Name = "label9";
            label9.Size = new Size(183, 23);
            label9.TabIndex = 25;
            label9.Text = "Customer Company:";
            // 
            // Employee
            // 
            Employee.BorderStyle = BorderStyle.FixedSingle;
            Employee.Controls.Add(panel4);
            Employee.Location = new Point(4, 32);
            Employee.Margin = new Padding(5, 5, 5, 5);
            Employee.Name = "Employee";
            Employee.Padding = new Padding(5, 5, 5, 5);
            Employee.Size = new Size(1270, 711);
            Employee.TabIndex = 1;
            Employee.Text = "Security Settings";
            Employee.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cbRole);
            panel4.Controls.Add(cmbPosit);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(cmbDepartment);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(cbPwd);
            panel4.Controls.Add(cmbUserName);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(tbPassword);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(cmbRole);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(btAddUser);
            panel4.Controls.Add(button8);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button10);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(16, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(1232, 675);
            panel4.TabIndex = 16;
            // 
            // cbRole
            // 
            cbRole.AutoSize = true;
            cbRole.Location = new Point(718, 282);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(140, 27);
            cbRole.TabIndex = 53;
            cbRole.Text = "Charge Role";
            cbRole.UseVisualStyleBackColor = true;
            cbRole.CheckedChanged += cbRole_CheckedChanged;
            // 
            // cmbPosit
            // 
            cmbPosit.FormattingEnabled = true;
            cmbPosit.Location = new Point(530, 325);
            cmbPosit.Name = "cmbPosit";
            cmbPosit.Size = new Size(182, 31);
            cmbPosit.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 328);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 51;
            label1.Text = "Position:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(530, 376);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(182, 31);
            cmbDepartment.TabIndex = 50;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(409, 379);
            label18.Name = "label18";
            label18.Size = new Size(118, 23);
            label18.TabIndex = 49;
            label18.Text = "Deoartment:";
            // 
            // cbPwd
            // 
            cbPwd.AutoSize = true;
            cbPwd.Location = new Point(714, 169);
            cbPwd.Name = "cbPwd";
            cbPwd.Size = new Size(182, 27);
            cbPwd.TabIndex = 48;
            cbPwd.Text = "Charge Password";
            cbPwd.UseVisualStyleBackColor = true;
            cbPwd.CheckedChanged += cbPwd_CheckedChanged;
            // 
            // cmbUserName
            // 
            cmbUserName.FormattingEnabled = true;
            cmbUserName.Location = new Point(530, 114);
            cmbUserName.Name = "cmbUserName";
            cmbUserName.Size = new Size(178, 31);
            cmbUserName.TabIndex = 47;
            cmbUserName.SelectedIndexChanged += cmbUserName_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(415, 117);
            label17.Name = "label17";
            label17.Size = new Size(109, 23);
            label17.TabIndex = 46;
            label17.Text = "User Name:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(530, 167);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(178, 30);
            tbPassword.TabIndex = 45;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(366, 170);
            label16.Name = "label16";
            label16.Size = new Size(158, 23);
            label16.TabIndex = 44;
            label16.Text = "Modify Password:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(530, 278);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(182, 31);
            cmbRole.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 281);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 32;
            label3.Text = "Role:";
            // 
            // btAddUser
            // 
            btAddUser.Location = new Point(223, 558);
            btAddUser.Margin = new Padding(5, 5, 5, 5);
            btAddUser.Name = "btAddUser";
            btAddUser.Size = new Size(173, 35);
            btAddUser.TabIndex = 26;
            btAddUser.Text = "Add Employee";
            btAddUser.UseVisualStyleBackColor = true;
            btAddUser.Click += btAddUser_Click;
            // 
            // button8
            // 
            button8.Location = new Point(798, 560);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 19;
            button8.Text = "Cancel";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(658, 558);
            button9.Name = "button9";
            button9.Size = new Size(112, 34);
            button9.TabIndex = 18;
            button9.Text = "Save";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(409, 558);
            button10.Name = "button10";
            button10.Size = new Size(146, 34);
            button10.TabIndex = 17;
            button10.TabStop = false;
            button10.Text = "Reset Default";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label8.Location = new Point(520, 230);
            label8.Name = "label8";
            label8.Size = new Size(192, 30);
            label8.TabIndex = 4;
            label8.Text = "Role Permission";
            // 
            // Company
            // 
            Company.BorderStyle = BorderStyle.FixedSingle;
            Company.Controls.Add(panel2);
            Company.Location = new Point(4, 32);
            Company.Margin = new Padding(5, 5, 5, 5);
            Company.Name = "Company";
            Company.Padding = new Padding(5, 5, 5, 5);
            Company.Size = new Size(1270, 711);
            Company.TabIndex = 0;
            Company.Text = "General Settings";
            Company.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cmbCompanyName);
            panel2.Controls.Add(btAddCom);
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
            panel2.Location = new Point(16, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(1232, 675);
            panel2.TabIndex = 12;
            // 
            // cmbCompanyName
            // 
            cmbCompanyName.FormattingEnabled = true;
            cmbCompanyName.Location = new Point(464, 120);
            cmbCompanyName.Margin = new Padding(5, 5, 5, 5);
            cmbCompanyName.Name = "cmbCompanyName";
            cmbCompanyName.Size = new Size(348, 31);
            cmbCompanyName.TabIndex = 22;
            cmbCompanyName.SelectedIndexChanged += cmbCompanyName_SelectedIndexChanged;
            // 
            // btAddCom
            // 
            btAddCom.Location = new Point(247, 477);
            btAddCom.Margin = new Padding(5, 5, 5, 5);
            btAddCom.Name = "btAddCom";
            btAddCom.Size = new Size(192, 35);
            btAddCom.TabIndex = 17;
            btAddCom.Text = "Add Company";
            btAddCom.UseVisualStyleBackColor = true;
            btAddCom.Click += btAddCom_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(871, 477);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 15;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(740, 478);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonResetDefault
            // 
            buttonResetDefault.Location = new Point(446, 478);
            buttonResetDefault.Name = "buttonResetDefault";
            buttonResetDefault.Size = new Size(146, 34);
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
            labelCompanyName.Location = new Point(305, 124);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(152, 23);
            labelCompanyName.TabIndex = 0;
            labelCompanyName.Text = "Company Name:";
            // 
            // cmbComCurr
            // 
            cmbComCurr.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmbComCurr.FormattingEnabled = true;
            cmbComCurr.Location = new Point(464, 256);
            cmbComCurr.Name = "cmbComCurr";
            cmbComCurr.Size = new Size(350, 31);
            cmbComCurr.TabIndex = 9;
            // 
            // labelDefaultLanguage
            // 
            labelDefaultLanguage.AutoSize = true;
            labelDefaultLanguage.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelDefaultLanguage.Location = new Point(292, 169);
            labelDefaultLanguage.Name = "labelDefaultLanguage";
            labelDefaultLanguage.Size = new Size(165, 23);
            labelDefaultLanguage.TabIndex = 1;
            labelDefaultLanguage.Text = "Default Language:";
            // 
            // labelDefaultWarehouse
            // 
            labelDefaultWarehouse.AutoSize = true;
            labelDefaultWarehouse.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelDefaultWarehouse.Location = new Point(281, 218);
            labelDefaultWarehouse.Name = "labelDefaultWarehouse";
            labelDefaultWarehouse.Size = new Size(178, 23);
            labelDefaultWarehouse.TabIndex = 4;
            labelDefaultWarehouse.Text = "Default Warehouse:";
            // 
            // labelDefaultCurrency
            // 
            labelDefaultCurrency.AutoSize = true;
            labelDefaultCurrency.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelDefaultCurrency.Location = new Point(300, 259);
            labelDefaultCurrency.Name = "labelDefaultCurrency";
            labelDefaultCurrency.Size = new Size(158, 23);
            labelDefaultCurrency.TabIndex = 3;
            labelDefaultCurrency.Text = "Default Currency:";
            // 
            // cmbComWH
            // 
            cmbComWH.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmbComWH.FormattingEnabled = true;
            cmbComWH.Location = new Point(464, 215);
            cmbComWH.Name = "cmbComWH";
            cmbComWH.Size = new Size(350, 31);
            cmbComWH.TabIndex = 7;
            // 
            // cmbComLan
            // 
            cmbComLan.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmbComLan.FormattingEnabled = true;
            cmbComLan.Location = new Point(462, 166);
            cmbComLan.Name = "cmbComLan";
            cmbComLan.Size = new Size(350, 31);
            cmbComLan.TabIndex = 6;
            // 
            // settingTab
            // 
            settingTab.Controls.Add(Company);
            settingTab.Controls.Add(Employee);
            settingTab.Controls.Add(Customer);
            settingTab.Location = new Point(41, 74);
            settingTab.Margin = new Padding(5, 5, 5, 5);
            settingTab.Name = "settingTab";
            settingTab.SelectedIndex = 0;
            settingTab.Size = new Size(1278, 747);
            settingTab.TabIndex = 25;
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(settingTab);
            Controls.Add(label1SystemName);
            Name = "FormSetting";
            Text = "Settings";
            Load += FormSetting_Load;
            Customer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Employee.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            Company.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            settingTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1SystemName;
        private TabPage Customer;
        private Panel panel1;
        private ComboBox cmbCustName;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label2;
        private Button btAddCust;
        private Button button2;
        private Button button3;
        private Button btCustReset;
        private Label label4;
        private ComboBox cmbCustCompany;
        private Label label6;
        private Label label7;
        private Label label9;
        private TabPage Employee;
        private Panel panel4;
        private CheckBox cbRole;
        private ComboBox cmbPosit;
        private Label label1;
        private ComboBox cmbDepartment;
        private Label label18;
        private CheckBox cbPwd;
        private ComboBox cmbUserName;
        private Label label17;
        private TextBox tbPassword;
        private Label label16;
        private ComboBox cmbRole;
        private Label label3;
        private Button btAddUser;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label8;
        private TabPage Company;
        private Panel panel2;
        private ComboBox cmbCompanyName;
        private Button btAddCom;
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
        private TabControl settingTab;
        private TextBox tbCustAddress;
        private TextBox tbCustPhone;
        private TextBox tbCustEmail;
    }
}
