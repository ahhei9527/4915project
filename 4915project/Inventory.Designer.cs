namespace _4915project
{
    partial class Inventory
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            btRefresh = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            btSearch = new Button();
            tbItemID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cmWearhouse = new ComboBox();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            cmbCStatus = new ComboBox();
            lblCurrentStus = new Label();
            tbSN = new TextBox();
            lblSN = new Label();
            cmbPID = new ComboBox();
            lblProductID = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            cmbBatch = new ComboBox();
            dataGridView2 = new DataGridView();
            date = new DateTimePicker();
            numQuantity = new NumericUpDown();
            btSubmit = new Button();
            cbWearhouse = new ComboBox();
            cmItem = new ComboBox();
            cbSupplier = new ComboBox();
            tbInventoryID = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lbInventoryID = new Label();
            gbMenu = new GroupBox();
            btRawMaterial = new Button();
            btSetting = new Button();
            AfterSales = new Button();
            Production = new Button();
            btDashBoard = new Button();
            SalesOrder = new Button();
            Logistics = new Button();
            Logoutbt = new LinkLabel();
            lblWelcome = new Label();
            LTitle = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            gbMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(266, 97);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1036, 708);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkGray;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1028, 672);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Stock Overview";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(btRefresh);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btSearch);
            groupBox1.Controls.Add(tbItemID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmWearhouse);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1017, 659);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search / Filter";
            // 
            // btRefresh
            // 
            btRefresh.Location = new Point(715, 202);
            btRefresh.Margin = new Padding(5);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(118, 35);
            btRefresh.TabIndex = 7;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(420, 610);
            button1.Name = "button1";
            button1.Size = new Size(149, 34);
            button1.TabIndex = 6;
            button1.Text = "Export to Excel";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(995, 308);
            dataGridView1.TabIndex = 1;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(866, 204);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(112, 34);
            btSearch.TabIndex = 5;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // tbItemID
            // 
            tbItemID.Location = new Point(235, 124);
            tbItemID.Name = "tbItemID";
            tbItemID.Size = new Size(194, 30);
            tbItemID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 127);
            label3.Name = "label3";
            label3.Size = new Size(137, 23);
            label3.TabIndex = 2;
            label3.Text = "Item Name/ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 126);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 1;
            label2.Text = "Warehouse:";
            // 
            // cmWearhouse
            // 
            cmWearhouse.FormattingEnabled = true;
            cmWearhouse.Location = new Point(639, 123);
            cmWearhouse.Name = "cmWearhouse";
            cmWearhouse.Size = new Size(194, 31);
            cmWearhouse.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkGray;
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1028, 672);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Inward Goods";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gainsboro;
            groupBox2.Controls.Add(cmbCStatus);
            groupBox2.Controls.Add(lblCurrentStus);
            groupBox2.Controls.Add(tbSN);
            groupBox2.Controls.Add(lblSN);
            groupBox2.Controls.Add(cmbPID);
            groupBox2.Controls.Add(lblProductID);
            groupBox2.Controls.Add(cmbStatus);
            groupBox2.Controls.Add(lblStatus);
            groupBox2.Controls.Add(cmbBatch);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(date);
            groupBox2.Controls.Add(numQuantity);
            groupBox2.Controls.Add(btSubmit);
            groupBox2.Controls.Add(cbWearhouse);
            groupBox2.Controls.Add(cmItem);
            groupBox2.Controls.Add(cbSupplier);
            groupBox2.Controls.Add(tbInventoryID);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lbInventoryID);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1017, 659);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Record New Inward Goods";
            // 
            // cmbCStatus
            // 
            cmbCStatus.FormattingEnabled = true;
            cmbCStatus.Location = new Point(185, 222);
            cmbCStatus.Margin = new Padding(5);
            cmbCStatus.Name = "cmbCStatus";
            cmbCStatus.Size = new Size(182, 31);
            cmbCStatus.TabIndex = 25;
            // 
            // lblCurrentStus
            // 
            lblCurrentStus.AutoSize = true;
            lblCurrentStus.Location = new Point(39, 225);
            lblCurrentStus.Name = "lblCurrentStus";
            lblCurrentStus.Size = new Size(143, 23);
            lblCurrentStus.TabIndex = 24;
            lblCurrentStus.Text = "Instance Status:";
            // 
            // tbSN
            // 
            tbSN.Location = new Point(536, 179);
            tbSN.Margin = new Padding(5);
            tbSN.Name = "tbSN";
            tbSN.Size = new Size(193, 30);
            tbSN.TabIndex = 23;
            // 
            // lblSN
            // 
            lblSN.AutoSize = true;
            lblSN.Location = new Point(489, 182);
            lblSN.Name = "lblSN";
            lblSN.Size = new Size(39, 23);
            lblSN.TabIndex = 21;
            lblSN.Text = "SN:";
            // 
            // cmbPID
            // 
            cmbPID.FormattingEnabled = true;
            cmbPID.Location = new Point(185, 184);
            cmbPID.Margin = new Padding(5);
            cmbPID.Name = "cmbPID";
            cmbPID.Size = new Size(182, 31);
            cmbPID.TabIndex = 20;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(80, 187);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(100, 23);
            lblProductID.TabIndex = 19;
            lblProductID.Text = "ProductID:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(536, 138);
            cmbStatus.Margin = new Padding(5);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(193, 31);
            cmbStatus.TabIndex = 18;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(467, 141);
            lblStatus.Margin = new Padding(5, 0, 5, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(72, 23);
            lblStatus.TabIndex = 17;
            lblStatus.Text = "Status: ";
            // 
            // cmbBatch
            // 
            cmbBatch.FormattingEnabled = true;
            cmbBatch.Location = new Point(185, 143);
            cmbBatch.Margin = new Padding(5);
            cmbBatch.Name = "cmbBatch";
            cmbBatch.Size = new Size(182, 31);
            cmbBatch.TabIndex = 16;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 274);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(995, 308);
            dataGridView2.TabIndex = 15;
            // 
            // date
            // 
            date.Location = new Point(536, 29);
            date.Name = "date";
            date.Size = new Size(193, 30);
            date.TabIndex = 14;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(537, 103);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(192, 30);
            numQuantity.TabIndex = 13;
            // 
            // btSubmit
            // 
            btSubmit.Location = new Point(801, 225);
            btSubmit.Name = "btSubmit";
            btSubmit.Size = new Size(176, 34);
            btSubmit.TabIndex = 12;
            btSubmit.Text = "Submit Receipt";
            btSubmit.UseVisualStyleBackColor = true;
            btSubmit.Click += btSubmit_Click;
            // 
            // cbWearhouse
            // 
            cbWearhouse.FormattingEnabled = true;
            cbWearhouse.Location = new Point(536, 64);
            cbWearhouse.Name = "cbWearhouse";
            cbWearhouse.Size = new Size(193, 31);
            cbWearhouse.TabIndex = 11;
            // 
            // cmItem
            // 
            cmItem.FormattingEnabled = true;
            cmItem.Location = new Point(185, 104);
            cmItem.Name = "cmItem";
            cmItem.Size = new Size(182, 31);
            cmItem.TabIndex = 10;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(185, 67);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(182, 31);
            cbSupplier.TabIndex = 9;
            // 
            // tbInventoryID
            // 
            tbInventoryID.Location = new Point(185, 32);
            tbInventoryID.Name = "tbInventoryID";
            tbInventoryID.Size = new Size(182, 30);
            tbInventoryID.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(449, 104);
            label10.Name = "label10";
            label10.Size = new Size(89, 23);
            label10.TabIndex = 6;
            label10.Text = "Quantity:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(429, 67);
            label9.Name = "label9";
            label9.Size = new Size(110, 23);
            label9.TabIndex = 5;
            label9.Text = "Warehouse:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(484, 32);
            label8.Name = "label8";
            label8.Size = new Size(55, 23);
            label8.TabIndex = 4;
            label8.Text = "Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 146);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 3;
            label7.Text = "Batch/Lot:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 107);
            label6.Name = "label6";
            label6.Size = new Size(53, 23);
            label6.TabIndex = 2;
            label6.Text = "Item:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 71);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 1;
            label5.Text = "Supplier:";
            // 
            // lbInventoryID
            // 
            lbInventoryID.AutoSize = true;
            lbInventoryID.Location = new Point(68, 35);
            lbInventoryID.Name = "lbInventoryID";
            lbInventoryID.Size = new Size(113, 23);
            lbInventoryID.TabIndex = 0;
            lbInventoryID.Text = "InventoryID:";
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(btRawMaterial);
            gbMenu.Controls.Add(btSetting);
            gbMenu.Controls.Add(AfterSales);
            gbMenu.Controls.Add(Production);
            gbMenu.Controls.Add(btDashBoard);
            gbMenu.Controls.Add(SalesOrder);
            gbMenu.Controls.Add(Logistics);
            gbMenu.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gbMenu.Location = new Point(20, 94);
            gbMenu.Margin = new Padding(5);
            gbMenu.Name = "gbMenu";
            gbMenu.Padding = new Padding(5);
            gbMenu.Size = new Size(228, 607);
            gbMenu.TabIndex = 7;
            gbMenu.TabStop = false;
            gbMenu.Text = "Inventory";
            // 
            // btRawMaterial
            // 
            btRawMaterial.Font = new Font("Microsoft JhengHei UI", 10F);
            btRawMaterial.Location = new Point(22, 347);
            btRawMaterial.Margin = new Padding(5);
            btRawMaterial.Name = "btRawMaterial";
            btRawMaterial.Size = new Size(184, 48);
            btRawMaterial.TabIndex = 13;
            btRawMaterial.Text = "Raw Material";
            btRawMaterial.UseVisualStyleBackColor = true;
            btRawMaterial.Click += btRawMaterial_Click;
            // 
            // btSetting
            // 
            btSetting.Font = new Font("Microsoft JhengHei UI", 10F);
            btSetting.Location = new Point(24, 521);
            btSetting.Margin = new Padding(5);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(184, 48);
            btSetting.TabIndex = 7;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // AfterSales
            // 
            AfterSales.Font = new Font("Microsoft JhengHei UI", 10F);
            AfterSales.Location = new Point(24, 435);
            AfterSales.Margin = new Padding(5);
            AfterSales.Name = "AfterSales";
            AfterSales.Size = new Size(184, 48);
            AfterSales.TabIndex = 5;
            AfterSales.Text = "AfterSales";
            AfterSales.UseVisualStyleBackColor = true;
            AfterSales.Click += AfterSales_Click;
            // 
            // Production
            // 
            Production.Font = new Font("Microsoft JhengHei UI", 10F);
            Production.Location = new Point(24, 267);
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
            btDashBoard.Font = new Font("Microsoft JhengHei UI", 10F);
            btDashBoard.Location = new Point(24, 46);
            btDashBoard.Margin = new Padding(5);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(184, 48);
            btDashBoard.TabIndex = 2;
            btDashBoard.Text = "DashBoard";
            btDashBoard.UseVisualStyleBackColor = true;
            btDashBoard.Click += btDashBoard_Click;
            // 
            // SalesOrder
            // 
            SalesOrder.Font = new Font("Microsoft JhengHei UI", 10F);
            SalesOrder.Location = new Point(24, 113);
            SalesOrder.Margin = new Padding(5);
            SalesOrder.Name = "SalesOrder";
            SalesOrder.Size = new Size(184, 48);
            SalesOrder.TabIndex = 1;
            SalesOrder.Text = "Sales/Order";
            SalesOrder.UseVisualStyleBackColor = true;
            SalesOrder.Click += SalesOrder_Click;
            // 
            // Logistics
            // 
            Logistics.Font = new Font("Microsoft JhengHei UI", 10F);
            Logistics.Location = new Point(24, 193);
            Logistics.Margin = new Padding(5);
            Logistics.Name = "Logistics";
            Logistics.Size = new Size(184, 48);
            Logistics.TabIndex = 0;
            Logistics.Text = "Logistics/Delivery";
            Logistics.UseVisualStyleBackColor = true;
            Logistics.Click += Logistics_Click;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(1175, 21);
            Logoutbt.Margin = new Padding(5, 0, 5, 0);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(74, 23);
            Logoutbt.TabIndex = 13;
            Logoutbt.TabStop = true;
            Logoutbt.Text = "LogOut";
            Logoutbt.LinkClicked += Logoutbt_LinkClicked;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(808, 9);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(358, 60);
            lblWelcome.TabIndex = 12;
            // 
            // LTitle
            // 
            LTitle.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            LTitle.Location = new Point(41, 21);
            LTitle.Margin = new Padding(5, 0, 5, 0);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(602, 72);
            LTitle.TabIndex = 14;
            LTitle.Text = "Premium Living Centralized Manage System";
            LTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(LTitle);
            Controls.Add(Logoutbt);
            Controls.Add(lblWelcome);
            Controls.Add(gbMenu);
            Controls.Add(tabControl1);
            Location = new Point(28, 19);
            Name = "Inventory";
            Text = "Inventory";
            Load += Inventory_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            gbMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private TextBox tbItemID;
        private Label label3;
        private Label label2;
        private ComboBox cmWearhouse;
        private CheckBox cbLowStock;
        private Button btSearch;
        private DataGridView dataGridView1;
        private Button button1;
        private GroupBox groupBox2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lbInventoryID;
        private ComboBox cmItem;
        private ComboBox cbSupplier;
        private TextBox tbInventoryID;
        private DataGridView dataGridView2;
        private DateTimePicker date;
        private NumericUpDown numQuantity;
        private Button btSubmit;
        private ComboBox cbWearhouse;
        private GroupBox gbMenu;
        private Button AfterSales;
        private Button Production;
        private Button btDashBoard;
        private Button SalesOrder;
        private Button Logistics;
        private LinkLabel Logoutbt;
        private Label lblWelcome;
        private Button btRefresh;
        private Button btSetting;
        private ComboBox cmbBatch;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private ComboBox cmbPID;
        private Label lblProductID;
        private TextBox tbSN;
        private Label lblSN;
        private ComboBox cmbCStatus;
        private Label lblCurrentStus;
        private Label LTitle;
        private Button btRawMaterial;
    }
}
