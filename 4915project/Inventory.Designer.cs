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
            cbLowStock = new CheckBox();
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
            btSetting = new Button();
            AfterSales = new Button();
            Production = new Button();
            btDashBoard = new Button();
            SalesOrder = new Button();
            Logistics = new Button();
            Logoutbt = new LinkLabel();
            lblWelcome = new Label();
            LTitle = new Label();
            btRawMaterial = new Button();
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
            tabControl1.Location = new Point(169, 63);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(659, 462);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkGray;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(651, 434);
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
            groupBox1.Controls.Add(cbLowStock);
            groupBox1.Controls.Add(tbItemID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmWearhouse);
            groupBox1.Location = new Point(4, 4);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(647, 430);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search / Filter";
            // 
            // btRefresh
            // 
            btRefresh.Location = new Point(455, 132);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(75, 23);
            btRefresh.TabIndex = 7;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // button1
            // 
            button1.Location = new Point(267, 398);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(95, 22);
            button1.TabIndex = 6;
            button1.Text = "Export to Excel";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 179);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(633, 201);
            dataGridView1.TabIndex = 1;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(551, 133);
            btSearch.Margin = new Padding(2);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(71, 22);
            btSearch.TabIndex = 5;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // cbLowStock
            // 
            cbLowStock.AutoSize = true;
            cbLowStock.Location = new Point(88, 96);
            cbLowStock.Margin = new Padding(2);
            cbLowStock.Name = "cbLowStock";
            cbLowStock.Size = new Size(146, 19);
            cbLowStock.TabIndex = 4;
            cbLowStock.Text = "Show Low Stock Only";
            cbLowStock.UseVisualStyleBackColor = true;
            // 
            // tbItemID
            // 
            tbItemID.Location = new Point(104, 24);
            tbItemID.Margin = new Padding(2);
            tbItemID.Name = "tbItemID";
            tbItemID.Size = new Size(125, 23);
            tbItemID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 26);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Item Name/ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Warehouse:";
            // 
            // cmWearhouse
            // 
            cmWearhouse.FormattingEnabled = true;
            cmWearhouse.Location = new Point(104, 53);
            cmWearhouse.Margin = new Padding(2);
            cmWearhouse.Name = "cmWearhouse";
            cmWearhouse.Size = new Size(125, 23);
            cmWearhouse.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkGray;
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(651, 434);
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
            groupBox2.Location = new Point(4, 4);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(647, 430);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Record New Inward Goods";
            // 
            // cmbCStatus
            // 
            cmbCStatus.FormattingEnabled = true;
            cmbCStatus.Location = new Point(118, 145);
            cmbCStatus.Name = "cmbCStatus";
            cmbCStatus.Size = new Size(117, 23);
            cmbCStatus.TabIndex = 25;
            // 
            // lblCurrentStus
            // 
            lblCurrentStus.AutoSize = true;
            lblCurrentStus.Location = new Point(25, 147);
            lblCurrentStus.Margin = new Padding(2, 0, 2, 0);
            lblCurrentStus.Name = "lblCurrentStus";
            lblCurrentStus.Size = new Size(93, 15);
            lblCurrentStus.TabIndex = 24;
            lblCurrentStus.Text = "Instance Status:";
            // 
            // tbSN
            // 
            tbSN.Location = new Point(341, 117);
            tbSN.Name = "tbSN";
            tbSN.Size = new Size(124, 23);
            tbSN.TabIndex = 23;
            // 
            // lblSN
            // 
            lblSN.AutoSize = true;
            lblSN.Location = new Point(311, 119);
            lblSN.Margin = new Padding(2, 0, 2, 0);
            lblSN.Name = "lblSN";
            lblSN.Size = new Size(27, 15);
            lblSN.TabIndex = 21;
            lblSN.Text = "SN:";
            // 
            // cmbPID
            // 
            cmbPID.FormattingEnabled = true;
            cmbPID.Location = new Point(118, 120);
            cmbPID.Name = "cmbPID";
            cmbPID.Size = new Size(117, 23);
            cmbPID.TabIndex = 20;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(51, 122);
            lblProductID.Margin = new Padding(2, 0, 2, 0);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(66, 15);
            lblProductID.TabIndex = 19;
            lblProductID.Text = "ProductID:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(341, 90);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(124, 23);
            cmbStatus.TabIndex = 18;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(297, 92);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 15);
            lblStatus.TabIndex = 17;
            lblStatus.Text = "Status: ";
            // 
            // cmbBatch
            // 
            cmbBatch.FormattingEnabled = true;
            cmbBatch.Location = new Point(118, 93);
            cmbBatch.Name = "cmbBatch";
            cmbBatch.Size = new Size(117, 23);
            cmbBatch.TabIndex = 16;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(4, 179);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(633, 201);
            dataGridView2.TabIndex = 15;
            // 
            // date
            // 
            date.Location = new Point(341, 19);
            date.Margin = new Padding(2);
            date.Name = "date";
            date.Size = new Size(124, 23);
            date.TabIndex = 14;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(342, 67);
            numQuantity.Margin = new Padding(2);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(122, 23);
            numQuantity.TabIndex = 13;
            // 
            // btSubmit
            // 
            btSubmit.Location = new Point(510, 147);
            btSubmit.Margin = new Padding(2);
            btSubmit.Name = "btSubmit";
            btSubmit.Size = new Size(112, 22);
            btSubmit.TabIndex = 12;
            btSubmit.Text = "Submit Receipt";
            btSubmit.UseVisualStyleBackColor = true;
            btSubmit.Click += btSubmit_Click;
            // 
            // cbWearhouse
            // 
            cbWearhouse.FormattingEnabled = true;
            cbWearhouse.Location = new Point(341, 42);
            cbWearhouse.Margin = new Padding(2);
            cbWearhouse.Name = "cbWearhouse";
            cbWearhouse.Size = new Size(124, 23);
            cbWearhouse.TabIndex = 11;
            // 
            // cmItem
            // 
            cmItem.FormattingEnabled = true;
            cmItem.Location = new Point(118, 68);
            cmItem.Margin = new Padding(2);
            cmItem.Name = "cmItem";
            cmItem.Size = new Size(117, 23);
            cmItem.TabIndex = 10;
            // 
            // cbSupplier
            // 
            cbSupplier.FormattingEnabled = true;
            cbSupplier.Location = new Point(118, 44);
            cbSupplier.Margin = new Padding(2);
            cbSupplier.Name = "cbSupplier";
            cbSupplier.Size = new Size(117, 23);
            cbSupplier.TabIndex = 9;
            // 
            // tbInventoryID
            // 
            tbInventoryID.Location = new Point(118, 21);
            tbInventoryID.Margin = new Padding(2);
            tbInventoryID.Name = "tbInventoryID";
            tbInventoryID.Size = new Size(117, 23);
            tbInventoryID.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(286, 68);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 6;
            label10.Text = "Quantity:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(273, 44);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 5;
            label9.Text = "Warehouse:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(308, 21);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 4;
            label8.Text = "Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 95);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 3;
            label7.Text = "Batch/Lot:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(81, 70);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 2;
            label6.Text = "Item:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 46);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 1;
            label5.Text = "Supplier:";
            // 
            // lbInventoryID
            // 
            lbInventoryID.AutoSize = true;
            lbInventoryID.Location = new Point(43, 23);
            lbInventoryID.Margin = new Padding(2, 0, 2, 0);
            lbInventoryID.Name = "lbInventoryID";
            lbInventoryID.Size = new Size(74, 15);
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
            gbMenu.Location = new Point(13, 61);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(145, 396);
            gbMenu.TabIndex = 7;
            gbMenu.TabStop = false;
            gbMenu.Text = "Inventory";
            // 
            // btSetting
            // 
            btSetting.Font = new Font("Microsoft JhengHei UI", 10F);
            btSetting.Location = new Point(15, 340);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(116, 31);
            btSetting.TabIndex = 7;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // AfterSales
            // 
            AfterSales.Font = new Font("Microsoft JhengHei UI", 10F);
            AfterSales.Location = new Point(15, 284);
            AfterSales.Name = "AfterSales";
            AfterSales.Size = new Size(116, 31);
            AfterSales.TabIndex = 5;
            AfterSales.Text = "AfterSales";
            AfterSales.UseVisualStyleBackColor = true;
            AfterSales.Click += AfterSales_Click;
            // 
            // Production
            // 
            Production.Font = new Font("Microsoft JhengHei UI", 10F);
            Production.Location = new Point(15, 174);
            Production.Name = "Production";
            Production.Size = new Size(116, 31);
            Production.TabIndex = 4;
            Production.Text = "Production";
            Production.UseVisualStyleBackColor = true;
            Production.Click += Production_Click;
            // 
            // btDashBoard
            // 
            btDashBoard.Font = new Font("Microsoft JhengHei UI", 10F);
            btDashBoard.Location = new Point(15, 30);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(116, 31);
            btDashBoard.TabIndex = 2;
            btDashBoard.Text = "DashBoard";
            btDashBoard.UseVisualStyleBackColor = true;
            btDashBoard.Click += btDashBoard_Click;
            // 
            // SalesOrder
            // 
            SalesOrder.Font = new Font("Microsoft JhengHei UI", 10F);
            SalesOrder.Location = new Point(15, 74);
            SalesOrder.Name = "SalesOrder";
            SalesOrder.Size = new Size(116, 31);
            SalesOrder.TabIndex = 1;
            SalesOrder.Text = "Sales/Order";
            SalesOrder.UseVisualStyleBackColor = true;
            SalesOrder.Click += SalesOrder_Click;
            // 
            // Logistics
            // 
            Logistics.Font = new Font("Microsoft JhengHei UI", 10F);
            Logistics.Location = new Point(15, 126);
            Logistics.Name = "Logistics";
            Logistics.Size = new Size(116, 31);
            Logistics.TabIndex = 0;
            Logistics.Text = "Logistics/Delivery";
            Logistics.UseVisualStyleBackColor = true;
            Logistics.Click += Logistics_Click;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(748, 14);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(50, 15);
            Logoutbt.TabIndex = 13;
            Logoutbt.TabStop = true;
            Logoutbt.Text = "LogOut";
            Logoutbt.LinkClicked += Logoutbt_LinkClicked;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(514, 6);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(228, 39);
            lblWelcome.TabIndex = 12;
            // 
            // LTitle
            // 
            LTitle.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            LTitle.Location = new Point(26, 14);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(383, 47);
            LTitle.TabIndex = 14;
            LTitle.Text = "Premium Living Centralized Manage System";
            LTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btRawMaterial
            // 
            btRawMaterial.Location = new Point(14, 226);
            btRawMaterial.Name = "btRawMaterial";
            btRawMaterial.Size = new Size(117, 34);
            btRawMaterial.TabIndex = 13;
            btRawMaterial.Text = "Raw Material";
            btRawMaterial.UseVisualStyleBackColor = true;
            btRawMaterial.Click += btRawMaterial_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 561);
            Controls.Add(LTitle);
            Controls.Add(Logoutbt);
            Controls.Add(lblWelcome);
            Controls.Add(gbMenu);
            Controls.Add(tabControl1);
            Location = new Point(28, 19);
            Margin = new Padding(2);
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
