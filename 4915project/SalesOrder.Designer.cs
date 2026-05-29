namespace ITP4915M
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
            label1 = new Label();
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
            Menu = new GroupBox();
            AfterSales = new Button();
            Production = new Button();
            SubmitDesign = new Button();
            Inventory = new Button();
            btDashBoard = new Button();
            Logistics = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(18, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(509, 30);
            label1.TabIndex = 0;
            label1.Text = "Premium Living Centralized Manage System";
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
            panel1.Location = new Point(169, 91);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 342);
            panel1.TabIndex = 1;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(15, 67);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.Size = new Size(634, 225);
            dgvOrderItems.TabIndex = 16;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(24, 297);
            buttonRefresh.Margin = new Padding(2);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(71, 22);
            buttonRefresh.TabIndex = 15;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonEditOrder
            // 
            buttonEditOrder.Location = new Point(565, 297);
            buttonEditOrder.Margin = new Padding(2);
            buttonEditOrder.Name = "buttonEditOrder";
            buttonEditOrder.Size = new Size(84, 22);
            buttonEditOrder.TabIndex = 14;
            buttonEditOrder.Text = "Edit Order";
            buttonEditOrder.UseVisualStyleBackColor = true;
            buttonEditOrder.Click += buttonEditOrder_Click;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(471, 297);
            buttonCreateOrder.Margin = new Padding(2);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(83, 22);
            buttonCreateOrder.TabIndex = 13;
            buttonCreateOrder.Text = "Create Order";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(588, 44);
            buttonClear.Margin = new Padding(2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(62, 23);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(515, 44);
            buttonSearch.Margin = new Padding(2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(62, 23);
            buttonSearch.TabIndex = 10;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += btnSearch_click;
            // 
            // labelDateTo
            // 
            labelDateTo.AutoSize = true;
            labelDateTo.Location = new Point(227, 48);
            labelDateTo.Margin = new Padding(2, 0, 2, 0);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(55, 15);
            labelDateTo.TabIndex = 9;
            labelDateTo.Text = "Date To:";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(282, 45);
            dateTimePickerEnd.Margin = new Padding(2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(126, 23);
            dateTimePickerEnd.TabIndex = 8;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(85, 45);
            dateTimePickerStart.Margin = new Padding(2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(124, 23);
            dateTimePickerStart.TabIndex = 7;
            // 
            // labelDateForm
            // 
            labelDateForm.AutoSize = true;
            labelDateForm.Location = new Point(15, 49);
            labelDateForm.Margin = new Padding(2, 0, 2, 0);
            labelDateForm.Name = "labelDateForm";
            labelDateForm.Size = new Size(69, 15);
            labelDateForm.TabIndex = 6;
            labelDateForm.Text = "Date Form:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Quoted", "Paid", "InProduction", "Ready for shipment", "Delivered" });
            comboBoxStatus.Location = new Point(517, 17);
            comboBoxStatus.Margin = new Padding(2);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(134, 23);
            comboBoxStatus.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 20);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Status:";
            // 
            // textCust
            // 
            textCust.Location = new Point(323, 18);
            textCust.Margin = new Padding(2);
            textCust.Name = "textCust";
            textCust.Size = new Size(138, 23);
            textCust.TabIndex = 3;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(257, 20);
            labelCustomer.Margin = new Padding(2, 0, 2, 0);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(64, 15);
            labelCustomer.TabIndex = 2;
            labelCustomer.Text = "Customer:";
            // 
            // textOrderID
            // 
            textOrderID.Location = new Point(72, 18);
            textOrderID.Margin = new Padding(2);
            textOrderID.Name = "textOrderID";
            textOrderID.Size = new Size(183, 23);
            textOrderID.TabIndex = 1;
            // 
            // labelOrderID
            // 
            labelOrderID.AutoSize = true;
            labelOrderID.Location = new Point(15, 20);
            labelOrderID.Margin = new Padding(2, 0, 2, 0);
            labelOrderID.Name = "labelOrderID";
            labelOrderID.Size = new Size(55, 15);
            labelOrderID.TabIndex = 0;
            labelOrderID.Text = "OrderID:";
            // 
            // label2Order
            // 
            label2Order.AutoSize = true;
            label2Order.FlatStyle = FlatStyle.Flat;
            label2Order.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2Order.Location = new Point(179, 78);
            label2Order.Margin = new Padding(2, 0, 2, 0);
            label2Order.Name = "label2Order";
            label2Order.Size = new Size(159, 20);
            label2Order.TabIndex = 7;
            label2Order.Text = "Order Management";
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(783, 7);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(50, 15);
            Logoutbt.TabIndex = 11;
            Logoutbt.TabStop = true;
            Logoutbt.Text = "LogOut";
            Logoutbt.LinkClicked += Logoutbt_LinkClicked;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(606, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(228, 39);
            lblWelcome.TabIndex = 10;
            // 
            // Menu
            // 
            Menu.Controls.Add(AfterSales);
            Menu.Controls.Add(Production);
            Menu.Controls.Add(SubmitDesign);
            Menu.Controls.Add(Inventory);
            Menu.Controls.Add(btDashBoard);
            Menu.Controls.Add(Logistics);
            Menu.Location = new Point(12, 50);
            Menu.Name = "Menu";
            Menu.Size = new Size(145, 499);
            Menu.TabIndex = 12;
            Menu.TabStop = false;
            Menu.Text = "Menu";
            // 
            // AfterSales
            // 
            AfterSales.Location = new Point(22, 385);
            AfterSales.Name = "AfterSales";
            AfterSales.Size = new Size(103, 52);
            AfterSales.TabIndex = 5;
            AfterSales.Text = "AfterSales";
            AfterSales.UseVisualStyleBackColor = true;
            // 
            // Production
            // 
            Production.Location = new Point(22, 239);
            Production.Name = "Production";
            Production.Size = new Size(103, 52);
            Production.TabIndex = 4;
            Production.Text = "Production";
            Production.UseVisualStyleBackColor = true;
            // 
            // SubmitDesign
            // 
            SubmitDesign.Location = new Point(22, 309);
            SubmitDesign.Name = "SubmitDesign";
            SubmitDesign.Size = new Size(103, 52);
            SubmitDesign.TabIndex = 3;
            SubmitDesign.Text = "SubmitDesign";
            SubmitDesign.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            Inventory.Location = new Point(20, 170);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(103, 52);
            Inventory.TabIndex = 2;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            // 
            // btDashBoard
            // 
            btDashBoard.Location = new Point(22, 31);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(103, 52);
            btDashBoard.TabIndex = 1;
            btDashBoard.Text = "DashBoard";
            btDashBoard.UseVisualStyleBackColor = true;
            btDashBoard.Click += SalesOrder_Click;
            // 
            // Logistics
            // 
            Logistics.Location = new Point(8, 96);
            Logistics.Name = "Logistics";
            Logistics.Size = new Size(117, 68);
            Logistics.TabIndex = 0;
            Logistics.Text = "Logistics/Delivery";
            Logistics.UseVisualStyleBackColor = true;
            // 
            // SalesOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 561);
            Controls.Add(Menu);
            Controls.Add(Logoutbt);
            Controls.Add(lblWelcome);
            Controls.Add(label2Order);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "SalesOrder";
            Text = "SalesOrder";
            Load += FormOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            Menu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2Order;
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
        private GroupBox Menu;
        private Button AfterSales;
        private Button Production;
        private Button SubmitDesign;
        private Button Inventory;
        private Button btDashBoard;
        private Button Logistics;
    }
}