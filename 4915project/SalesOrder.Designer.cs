namespace _4915project 
{
    partial class SalesOrder
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
            panel1 = new Panel();
            dgvOrderItems = new DataGridView();
            buttonRefresh = new Button();
            buttonEditOrder = new Button();
            buttonCreateOrder = new Button();
            buttonClear = new Button();
            buttonSearch = new Button();
            labelDateTo = new Label();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            labelDateForm = new Label();
            comboBoxStatus = new ComboBox();
            label2 = new Label();
            textCust = new TextBox();
            labelCustomer = new Label();
            textOrderID = new TextBox();
            labelOrderID = new Label();
            label2Order = new Label();
            Logoutbt = new LinkLabel();
            lblWelcome = new Label();
            gbMenu = new GroupBox();
            btRawMaterial = new Button();
            btSetting = new Button();
            AfterSales = new Button();
            Production = new Button();
            Inventory = new Button();
            btDashBoard = new Button();
            Logistics = new Button();
            LTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            gbMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dgvOrderItems);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(buttonEditOrder);
            panel1.Controls.Add(buttonCreateOrder);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(labelDateTo);
            panel1.Controls.Add(dateTimePickerEnd);
            panel1.Controls.Add(dateTimePickerStart);
            panel1.Controls.Add(labelDateForm);
            panel1.Controls.Add(comboBoxStatus);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textCust);
            panel1.Controls.Add(labelCustomer);
            panel1.Controls.Add(textOrderID);
            panel1.Controls.Add(labelOrderID);
            panel1.Location = new Point(256, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 609);
            panel1.TabIndex = 1;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(24, 189);
            dgvOrderItems.Margin = new Padding(5);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 62;
            dgvOrderItems.Size = new Size(996, 345);
            dgvOrderItems.TabIndex = 16;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(24, 552);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(112, 34);
            buttonRefresh.TabIndex = 15;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonEditOrder
            // 
            buttonEditOrder.Location = new Point(888, 552);
            buttonEditOrder.Name = "buttonEditOrder";
            buttonEditOrder.Size = new Size(132, 34);
            buttonEditOrder.TabIndex = 14;
            buttonEditOrder.Text = "Edit Order";
            buttonEditOrder.UseVisualStyleBackColor = true;
            buttonEditOrder.Click += buttonEditOrder_Click;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(724, 552);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(130, 34);
            buttonCreateOrder.TabIndex = 13;
            buttonCreateOrder.Text = "Create Order";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(922, 126);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(97, 35);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(808, 126);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(97, 35);
            buttonSearch.TabIndex = 10;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += btnSearch_click;
            // 
            // labelDateTo
            // 
            labelDateTo.AutoSize = true;
            labelDateTo.Location = new Point(420, 130);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(81, 23);
            labelDateTo.TabIndex = 9;
            labelDateTo.Text = "Date To:";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(508, 129);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(215, 30);
            dateTimePickerEnd.TabIndex = 8;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(137, 130);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(262, 30);
            dateTimePickerStart.TabIndex = 7;
            // 
            // labelDateForm
            // 
            labelDateForm.AutoSize = true;
            labelDateForm.Location = new Point(27, 136);
            labelDateForm.Name = "labelDateForm";
            labelDateForm.Size = new Size(104, 23);
            labelDateForm.TabIndex = 6;
            labelDateForm.Text = "Date Form:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Quoted", "Paid", "InProduction", "Ready for shipment", "Delivered" });
            comboBoxStatus.Location = new Point(812, 72);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(208, 31);
            comboBoxStatus.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(740, 77);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 4;
            label2.Text = "Status:";
            // 
            // textCust
            // 
            textCust.Location = new Point(508, 74);
            textCust.Name = "textCust";
            textCust.Size = new Size(215, 30);
            textCust.TabIndex = 3;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(404, 77);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(97, 23);
            labelCustomer.TabIndex = 2;
            labelCustomer.Text = "Customer:";
            // 
            // textOrderID
            // 
            textOrderID.Location = new Point(137, 74);
            textOrderID.Name = "textOrderID";
            textOrderID.Size = new Size(262, 30);
            textOrderID.TabIndex = 1;
            // 
            // labelOrderID
            // 
            labelOrderID.AutoSize = true;
            labelOrderID.Location = new Point(47, 80);
            labelOrderID.Name = "labelOrderID";
            labelOrderID.Size = new Size(83, 23);
            labelOrderID.TabIndex = 0;
            labelOrderID.Text = "OrderID:";
            // 
            // label2Order
            // 
            label2Order.AutoSize = true;
            label2Order.FlatStyle = FlatStyle.Flat;
            label2Order.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2Order.Location = new Point(270, 94);
            label2Order.Name = "label2Order";
            label2Order.Size = new Size(239, 30);
            label2Order.TabIndex = 18;
            label2Order.Text = "Order Management";
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(1175, 21);
            Logoutbt.Margin = new Padding(5, 0, 5, 0);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(74, 23);
            Logoutbt.TabIndex = 11;
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
            lblWelcome.TabIndex = 10;
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(btRawMaterial);
            gbMenu.Controls.Add(btSetting);
            gbMenu.Controls.Add(AfterSales);
            gbMenu.Controls.Add(Production);
            gbMenu.Controls.Add(Inventory);
            gbMenu.Controls.Add(btDashBoard);
            gbMenu.Controls.Add(Logistics);
            gbMenu.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gbMenu.Location = new Point(20, 94);
            gbMenu.Margin = new Padding(5);
            gbMenu.Name = "gbMenu";
            gbMenu.Padding = new Padding(5);
            gbMenu.Size = new Size(228, 595);
            gbMenu.TabIndex = 12;
            gbMenu.TabStop = false;
            gbMenu.Text = "Order";
            // 
            // btRawMaterial
            // 
            btRawMaterial.Font = new Font("Microsoft JhengHei UI", 10F);
            btRawMaterial.Location = new Point(25, 340);
            btRawMaterial.Margin = new Padding(5);
            btRawMaterial.Name = "btRawMaterial";
            btRawMaterial.Size = new Size(184, 52);
            btRawMaterial.TabIndex = 13;
            btRawMaterial.Text = "Raw Material";
            btRawMaterial.UseVisualStyleBackColor = true;
            btRawMaterial.Click += btRawMaterial_Click;
            // 
            // btSetting
            // 
            btSetting.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btSetting.Location = new Point(24, 492);
            btSetting.Margin = new Padding(5);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(182, 48);
            btSetting.TabIndex = 7;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // AfterSales
            // 
            AfterSales.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            AfterSales.Location = new Point(24, 417);
            AfterSales.Margin = new Padding(5);
            AfterSales.Name = "AfterSales";
            AfterSales.Size = new Size(182, 48);
            AfterSales.TabIndex = 5;
            AfterSales.Text = "AfterSales";
            AfterSales.UseVisualStyleBackColor = true;
            AfterSales.Click += AfterSales_Click;
            // 
            // Production
            // 
            Production.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Production.Location = new Point(24, 267);
            Production.Margin = new Padding(5);
            Production.Name = "Production";
            Production.Size = new Size(182, 48);
            Production.TabIndex = 4;
            Production.Text = "Production";
            Production.UseVisualStyleBackColor = true;
            Production.Click += Production_Click;
            // 
            // Inventory
            // 
            Inventory.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Inventory.Location = new Point(24, 189);
            Inventory.Margin = new Padding(5);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(182, 48);
            Inventory.TabIndex = 2;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // btDashBoard
            // 
            btDashBoard.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btDashBoard.Location = new Point(24, 46);
            btDashBoard.Margin = new Padding(5);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(182, 48);
            btDashBoard.TabIndex = 1;
            btDashBoard.Text = "DashBoard";
            btDashBoard.UseVisualStyleBackColor = true;
            btDashBoard.Click += btDashBoard_Click;
            // 
            // Logistics
            // 
            Logistics.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Logistics.Location = new Point(24, 113);
            Logistics.Margin = new Padding(5);
            Logistics.Name = "Logistics";
            Logistics.Size = new Size(182, 48);
            Logistics.TabIndex = 0;
            Logistics.Text = "Logistics/Delivery";
            Logistics.UseVisualStyleBackColor = true;
            Logistics.Click += Logistics_Click;
            // 
            // LTitle
            // 
            LTitle.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            LTitle.Location = new Point(41, 21);
            LTitle.Margin = new Padding(5, 0, 5, 0);
            LTitle.Name = "LTitle";
            LTitle.Size = new Size(592, 35);
            LTitle.TabIndex = 13;
            LTitle.Text = "Premium Living Centralized Manage System";
            LTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SalesOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(label2Order);
            Controls.Add(LTitle);
            Controls.Add(gbMenu);
            Controls.Add(Logoutbt);
            Controls.Add(lblWelcome);
            Controls.Add(panel1);
            Name = "SalesOrder";
            Text = "SalesOrder";
            Load += FormOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            gbMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label labelOrderID;
        private TextBox textCust;
        private Label labelCustomer;
        private TextBox textOrderID;
        private Label labelDateForm;
        private ComboBox comboBoxStatus;
        private Label label2;
        private Label labelDateTo;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Button buttonClear;
        private Button buttonSearch;
        private Button buttonEditOrder;
        private Button buttonCreateOrder;
        private Button buttonRefresh;
        private LinkLabel Logoutbt;
        private Label lblWelcome;
        private DataGridView dgvOrderItems;
        private GroupBox gbMenu;
        private Button AfterSales;
        private Button Production;
        private Button Inventory;
        private Button btDashBoard;
        private Button Logistics;
        private Button btSetting;
        private Label LTitle;
        private Label label2Order;
        private Button btRawMaterial;
    }
}