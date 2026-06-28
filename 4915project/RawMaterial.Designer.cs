namespace _4915project
{
    partial class RawMaterial
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
            Logoutbt = new LinkLabel();
            gbMenu = new GroupBox();
            btAfterSales = new Button();
            btSetting = new Button();
            btLog = new Button();
            Production = new Button();
            btDashBoard = new Button();
            btSales = new Button();
            Inventory = new Button();
            lblWelcome = new Label();
            label1SystemName = new Label();
            label1 = new Label();
            cmbType = new ComboBox();
            cmbUnit = new ComboBox();
            label2 = new Label();
            cmbSupplier = new ComboBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btCreate = new Button();
            btEdit = new Button();
            btClear = new Button();
            btSearch = new Button();
            gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(746, 25);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(50, 15);
            Logoutbt.TabIndex = 18;
            Logoutbt.TabStop = true;
            Logoutbt.Text = "LogOut";
            Logoutbt.LinkClicked += Logoutbt_LinkClicked;
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(btAfterSales);
            gbMenu.Controls.Add(btSetting);
            gbMenu.Controls.Add(btLog);
            gbMenu.Controls.Add(Production);
            gbMenu.Controls.Add(btDashBoard);
            gbMenu.Controls.Add(btSales);
            gbMenu.Controls.Add(Inventory);
            gbMenu.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gbMenu.Location = new Point(11, 72);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(145, 394);
            gbMenu.TabIndex = 19;
            gbMenu.TabStop = false;
            gbMenu.Text = "Raw Material";
            // 
            // btAfterSales
            // 
            btAfterSales.Location = new Point(15, 279);
            btAfterSales.Name = "btAfterSales";
            btAfterSales.Size = new Size(117, 34);
            btAfterSales.TabIndex = 13;
            btAfterSales.Text = "After Sales";
            btAfterSales.UseVisualStyleBackColor = true;
            btAfterSales.Click += btAfterSales_Click;
            // 
            // btSetting
            // 
            btSetting.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btSetting.Location = new Point(15, 335);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(117, 31);
            btSetting.TabIndex = 7;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // btLog
            // 
            btLog.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btLog.Location = new Point(15, 123);
            btLog.Name = "btLog";
            btLog.Size = new Size(117, 31);
            btLog.TabIndex = 5;
            btLog.Text = "Logistics/Delivery";
            btLog.UseVisualStyleBackColor = true;
            btLog.Click += btLog_Click;
            // 
            // Production
            // 
            Production.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Production.Location = new Point(15, 222);
            Production.Name = "Production";
            Production.Size = new Size(117, 31);
            Production.TabIndex = 4;
            Production.Text = "Production";
            Production.UseVisualStyleBackColor = true;
            Production.Click += Production_Click;
            // 
            // btDashBoard
            // 
            btDashBoard.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btDashBoard.Location = new Point(15, 30);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(117, 31);
            btDashBoard.TabIndex = 1;
            btDashBoard.Text = "DashBoard";
            btDashBoard.UseVisualStyleBackColor = true;
            btDashBoard.Click += btDashBoard_Click;
            // 
            // btSales
            // 
            btSales.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btSales.Location = new Point(15, 77);
            btSales.Name = "btSales";
            btSales.Size = new Size(117, 31);
            btSales.TabIndex = 0;
            btSales.Text = "Sales/Order";
            btSales.UseVisualStyleBackColor = true;
            btSales.Click += btSales_Click;
            // 
            // Inventory
            // 
            Inventory.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Inventory.Location = new Point(15, 172);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(117, 31);
            Inventory.TabIndex = 2;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(512, 17);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(228, 39);
            lblWelcome.TabIndex = 17;
            // 
            // label1SystemName
            // 
            label1SystemName.AutoSize = true;
            label1SystemName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1SystemName.Location = new Point(11, 25);
            label1SystemName.Margin = new Padding(2, 0, 2, 0);
            label1SystemName.Name = "label1SystemName";
            label1SystemName.Size = new Size(407, 24);
            label1SystemName.TabIndex = 15;
            label1SystemName.Text = "Premium Living Centralized Manage System";
            label1SystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 102);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 20;
            label1.Text = "Type:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(256, 99);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 21;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(442, 99);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(121, 23);
            cmbUnit.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 102);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 22;
            label2.Text = "Unit:";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(655, 99);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(121, 23);
            cmbSupplier.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(592, 102);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 24;
            label3.Text = "Supplier:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(208, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(568, 221);
            dataGridView1.TabIndex = 26;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(485, 411);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(146, 23);
            btCreate.TabIndex = 27;
            btCreate.Text = "Create Raw Material";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(637, 411);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(124, 23);
            btEdit.TabIndex = 28;
            btEdit.Text = "Edit Raw Material";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(686, 137);
            btClear.Name = "btClear";
            btClear.Size = new Size(75, 23);
            btClear.TabIndex = 29;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(583, 137);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(75, 23);
            btSearch.TabIndex = 30;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // RawMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 561);
            Controls.Add(btSearch);
            Controls.Add(btClear);
            Controls.Add(btEdit);
            Controls.Add(btCreate);
            Controls.Add(dataGridView1);
            Controls.Add(cmbSupplier);
            Controls.Add(label3);
            Controls.Add(cmbUnit);
            Controls.Add(label2);
            Controls.Add(cmbType);
            Controls.Add(label1);
            Controls.Add(Logoutbt);
            Controls.Add(gbMenu);
            Controls.Add(lblWelcome);
            Controls.Add(label1SystemName);
            Name = "RawMaterial";
            Text = "RawMaterial";
            Load += RawMaterial_Load;
            gbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel Logoutbt;
        private GroupBox gbMenu;
        private Button btAfterSales;
        private Button btSetting;
        private Button btLog;
        private Button Production;
        private Button btDashBoard;
        private Button btSales;
        private Button Inventory;
        private Label lblWelcome;
        private Label label1SystemName;
        private Label label1;
        private ComboBox cmbType;
        private ComboBox cmbUnit;
        private Label label2;
        private ComboBox cmbSupplier;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btCreate;
        private Button btEdit;
        private Button btClear;
        private Button btSearch;
    }
}