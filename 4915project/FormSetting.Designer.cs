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
            General = new TabPage();
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
            Security = new TabPage();
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
            settingTab.SuspendLayout();
            General.SuspendLayout();
            panel2.SuspendLayout();
            Security.SuspendLayout();
            panel4.SuspendLayout();
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
            settingTab.Controls.Add(General);
            settingTab.Controls.Add(Security);
            settingTab.Location = new Point(12, 45);
            settingTab.Name = "settingTab";
            settingTab.SelectedIndex = 0;
            settingTab.Size = new Size(536, 258);
            settingTab.TabIndex = 25;
            // 
            // General
            // 
            General.Controls.Add(panel2);
            General.Location = new Point(4, 24);
            General.Name = "General";
            General.Padding = new Padding(3);
            General.Size = new Size(528, 230);
            General.TabIndex = 0;
            General.Text = "General";
            General.UseVisualStyleBackColor = true;
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
            // Security
            // 
            Security.Controls.Add(panel4);
            Security.Location = new Point(4, 24);
            Security.Name = "Security";
            Security.Padding = new Padding(3);
            Security.Size = new Size(528, 230);
            Security.TabIndex = 1;
            Security.Text = "Security";
            Security.UseVisualStyleBackColor = true;
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
            General.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Security.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1SystemName;
        private TabControl settingTab;
        private TabPage General;
        private TabPage Security;
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
    }
}