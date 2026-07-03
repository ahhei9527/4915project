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
            Logoutbt.Location = new Point(1172, 38);
            Logoutbt.Margin = new Padding(5, 0, 5, 0);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(74, 23);
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
            gbMenu.Location = new Point(17, 110);
            gbMenu.Margin = new Padding(5);
            gbMenu.Name = "gbMenu";
            gbMenu.Padding = new Padding(5);
            gbMenu.Size = new Size(228, 604);
            gbMenu.TabIndex = 19;
            gbMenu.TabStop = false;
            gbMenu.Text = "Raw Material";
            // 
            // btAfterSales
            // 
            btAfterSales.Font = new Font("Microsoft JhengHei UI", 10F);
            btAfterSales.Location = new Point(24, 428);
            btAfterSales.Margin = new Padding(5);
            btAfterSales.Name = "btAfterSales";
            btAfterSales.Size = new Size(184, 52);
            btAfterSales.TabIndex = 13;
            btAfterSales.Text = "After Sales";
            btAfterSales.UseVisualStyleBackColor = true;
            btAfterSales.Click += btAfterSales_Click;
            // 
            // btSetting
            // 
            btSetting.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btSetting.Location = new Point(24, 514);
            btSetting.Margin = new Padding(5);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(184, 48);
            btSetting.TabIndex = 7;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // btLog
            // 
            btLog.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btLog.Location = new Point(24, 189);
            btLog.Margin = new Padding(5);
            btLog.Name = "btLog";
            btLog.Size = new Size(184, 48);
            btLog.TabIndex = 5;
            btLog.Text = "Logistics/Delivery";
            btLog.UseVisualStyleBackColor = true;
            btLog.Click += btLog_Click;
            // 
            // Production
            // 
            Production.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Production.Location = new Point(24, 340);
            Production.Margin = new Padding(5);
            Production.Name = "Production";
            Production.Size = new Size(184, 48);
            Production.TabIndex = 4;
            Production.Text = "Production";
            Production.UseVisualStyleBackColor = true;
            Production.Click += Production_Click;
            // 
            // btDashBoard
            // 
            btDashBoard.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btDashBoard.Location = new Point(24, 46);
            btDashBoard.Margin = new Padding(5);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(184, 48);
            btDashBoard.TabIndex = 1;
            btDashBoard.Text = "DashBoard";
            btDashBoard.UseVisualStyleBackColor = true;
            btDashBoard.Click += btDashBoard_Click;
            // 
            // btSales
            // 
            btSales.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btSales.Location = new Point(24, 118);
            btSales.Margin = new Padding(5);
            btSales.Name = "btSales";
            btSales.Size = new Size(184, 48);
            btSales.TabIndex = 0;
            btSales.Text = "Sales/Order";
            btSales.UseVisualStyleBackColor = true;
            btSales.Click += btSales_Click;
            // 
            // Inventory
            // 
            Inventory.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Inventory.Location = new Point(24, 264);
            Inventory.Margin = new Padding(5);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(184, 48);
            Inventory.TabIndex = 2;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(805, 26);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(358, 60);
            lblWelcome.TabIndex = 17;
            // 
            // label1SystemName
            // 
            label1SystemName.AutoSize = true;
            label1SystemName.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1SystemName.Location = new Point(17, 38);
            label1SystemName.Name = "label1SystemName";
            label1SystemName.Size = new Size(592, 36);
            label1SystemName.TabIndex = 15;
            label1SystemName.Text = "Premium Living Centralized Manage System";
            label1SystemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 156);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 20;
            label1.Text = "Type:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(378, 153);
            cmbType.Margin = new Padding(5);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(188, 31);
            cmbType.TabIndex = 21;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(668, 152);
            cmbUnit.Margin = new Padding(5);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(188, 31);
            cmbUnit.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(619, 156);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 22;
            label2.Text = "Unit:";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(999, 152);
            cmbSupplier.Margin = new Padding(5);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(221, 31);
            cmbSupplier.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(916, 155);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 24;
            label3.Text = "Supplier:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(263, 255);
            dataGridView1.Margin = new Padding(5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1093, 414);
            dataGridView1.TabIndex = 26;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(771, 679);
            btCreate.Margin = new Padding(5);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(229, 35);
            btCreate.TabIndex = 27;
            btCreate.Text = "Create Raw Material";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(1051, 679);
            btEdit.Margin = new Padding(5);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(195, 35);
            btEdit.TabIndex = 28;
            btEdit.Text = "Edit Raw Material";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(1111, 210);
            btClear.Margin = new Padding(5);
            btClear.Name = "btClear";
            btClear.Size = new Size(118, 35);
            btClear.TabIndex = 29;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(974, 210);
            btSearch.Margin = new Padding(5);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(118, 35);
            btSearch.TabIndex = 30;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // RawMaterial
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
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
            Margin = new Padding(5);
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