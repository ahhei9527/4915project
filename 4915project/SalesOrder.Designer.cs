namespace ITP4915M
{
    partial class FormOrder
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
            buttonRefresh = new Button();
            buttonEditOrder = new Button();
            buttonCreateOrder = new Button();
            dgvOrderItems = new DataGridView();
            ColumnOrderID = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnCustomerName = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            ColumnTotalAmt = new DataGridViewTextBoxColumn();
            buttonClear = new Button();
            buttonSearch = new Button();
            labelDateTo = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            labelDateForm = new Label();
            comboBoxStatus = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            labelCustomer = new Label();
            textOrderID = new TextBox();
            labelOrderID = new Label();
            label2Order = new Label();
            lblOrder = new Label();
            palOrder = new Panel();
            buttonSetting = new Button();
            buttonComplaints = new Button();
            buttonLogistics = new Button();
            button2 = new Button();
            buttonHome = new Button();
            Logoutbt = new LinkLabel();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            palOrder.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(760, 46);
            label1.TabIndex = 0;
            label1.Text = "Premium Living Centralized Manage System";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(buttonEditOrder);
            panel1.Controls.Add(buttonCreateOrder);
            panel1.Controls.Add(dgvOrderItems);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(labelDateTo);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(labelDateForm);
            panel1.Controls.Add(comboBoxStatus);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelCustomer);
            panel1.Controls.Add(textOrderID);
            panel1.Controls.Add(labelOrderID);
            panel1.Location = new Point(266, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 523);
            panel1.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(38, 456);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(112, 34);
            buttonRefresh.TabIndex = 15;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonEditOrder
            // 
            buttonEditOrder.Location = new Point(909, 456);
            buttonEditOrder.Name = "buttonEditOrder";
            buttonEditOrder.Size = new Size(112, 34);
            buttonEditOrder.TabIndex = 14;
            buttonEditOrder.Text = "Edit Order";
            buttonEditOrder.UseVisualStyleBackColor = true;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(748, 456);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(131, 34);
            buttonCreateOrder.TabIndex = 13;
            buttonCreateOrder.Text = "Create Order";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvOrderItems.BackgroundColor = SystemColors.ActiveBorder;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Columns.AddRange(new DataGridViewColumn[] { ColumnOrderID, ColumnDate, ColumnCustomerName, ColumnStatus, ColumnTotalAmt });
            dgvOrderItems.Location = new Point(38, 111);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersWidth = 62;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.Size = new Size(983, 316);
            dgvOrderItems.TabIndex = 12;
            // 
            // ColumnOrderID
            // 
            ColumnOrderID.HeaderText = "Order ID";
            ColumnOrderID.MinimumWidth = 8;
            ColumnOrderID.Name = "ColumnOrderID";
            ColumnOrderID.ReadOnly = true;
            ColumnOrderID.Width = 150;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Date";
            ColumnDate.MinimumWidth = 8;
            ColumnDate.Name = "ColumnDate";
            ColumnDate.ReadOnly = true;
            ColumnDate.Width = 150;
            // 
            // ColumnCustomerName
            // 
            ColumnCustomerName.HeaderText = "Customer Name";
            ColumnCustomerName.MinimumWidth = 8;
            ColumnCustomerName.Name = "ColumnCustomerName";
            ColumnCustomerName.ReadOnly = true;
            ColumnCustomerName.Width = 150;
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.MinimumWidth = 8;
            ColumnStatus.Name = "ColumnStatus";
            ColumnStatus.ReadOnly = true;
            ColumnStatus.Width = 150;
            // 
            // ColumnTotalAmt
            // 
            ColumnTotalAmt.HeaderText = "Total Amt ";
            ColumnTotalAmt.MinimumWidth = 8;
            ColumnTotalAmt.Name = "ColumnTotalAmt";
            ColumnTotalAmt.ReadOnly = true;
            ColumnTotalAmt.Width = 150;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(924, 68);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(97, 36);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(810, 68);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(97, 36);
            buttonSearch.TabIndex = 10;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += btnSearch_click;
            // 
            // labelDateTo
            // 
            labelDateTo.AutoSize = true;
            labelDateTo.Location = new Point(356, 74);
            labelDateTo.Name = "labelDateTo";
            labelDateTo.Size = new Size(81, 23);
            labelDateTo.TabIndex = 9;
            labelDateTo.Text = "Date To:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(443, 69);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(196, 30);
            dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(134, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(193, 30);
            dateTimePicker1.TabIndex = 7;
            // 
            // labelDateForm
            // 
            labelDateForm.AutoSize = true;
            labelDateForm.Location = new Point(24, 75);
            labelDateForm.Name = "labelDateForm";
            labelDateForm.Size = new Size(104, 23);
            labelDateForm.TabIndex = 6;
            labelDateForm.Text = "Date Form:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Quoted", "Paid", "InProduction", "Ready for shipment", "Delivered" });
            comboBoxStatus.Location = new Point(813, 26);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(208, 31);
            comboBoxStatus.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(740, 30);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 4;
            label2.Text = "Status:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(507, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 30);
            textBox1.TabIndex = 3;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(404, 30);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(97, 23);
            labelCustomer.TabIndex = 2;
            labelCustomer.Text = "Customer:";
            // 
            // textOrderID
            // 
            textOrderID.Location = new Point(113, 27);
            textOrderID.Name = "textOrderID";
            textOrderID.Size = new Size(285, 30);
            textOrderID.TabIndex = 1;
            // 
            // labelOrderID
            // 
            labelOrderID.AutoSize = true;
            labelOrderID.Location = new Point(24, 30);
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
            label2Order.Location = new Point(281, 120);
            label2Order.Name = "label2Order";
            label2Order.Size = new Size(239, 30);
            label2Order.TabIndex = 7;
            label2Order.Text = "Order Management";
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblOrder.Location = new Point(36, 125);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(80, 30);
            lblOrder.TabIndex = 8;
            lblOrder.Text = "Order";
            // 
            // palOrder
            // 
            palOrder.AutoSize = true;
            palOrder.BorderStyle = BorderStyle.FixedSingle;
            palOrder.Controls.Add(buttonSetting);
            palOrder.Controls.Add(buttonComplaints);
            palOrder.Controls.Add(buttonLogistics);
            palOrder.Controls.Add(button2);
            palOrder.Controls.Add(buttonHome);
            palOrder.Location = new Point(28, 145);
            palOrder.Name = "palOrder";
            palOrder.Size = new Size(214, 422);
            palOrder.TabIndex = 9;
            // 
            // buttonSetting
            // 
            buttonSetting.Location = new Point(7, 255);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Size = new Size(112, 34);
            buttonSetting.TabIndex = 10;
            buttonSetting.Text = "Setting";
            buttonSetting.UseVisualStyleBackColor = true;
            // 
            // buttonComplaints
            // 
            buttonComplaints.Location = new Point(7, 195);
            buttonComplaints.Name = "buttonComplaints";
            buttonComplaints.Size = new Size(112, 34);
            buttonComplaints.TabIndex = 10;
            buttonComplaints.Text = "Complaints";
            buttonComplaints.UseVisualStyleBackColor = true;
            // 
            // buttonLogistics
            // 
            buttonLogistics.Location = new Point(7, 134);
            buttonLogistics.Name = "buttonLogistics";
            buttonLogistics.Size = new Size(112, 34);
            buttonLogistics.TabIndex = 10;
            buttonLogistics.Text = "Logistics";
            buttonLogistics.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(7, 78);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Inventory";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            buttonHome.Location = new Point(7, 23);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(112, 34);
            buttonHome.TabIndex = 10;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += button1_Click;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(1231, 11);
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
            lblWelcome.Location = new Point(952, 46);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(358, 60);
            lblWelcome.TabIndex = 10;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(Logoutbt);
            Controls.Add(lblWelcome);
            Controls.Add(lblOrder);
            Controls.Add(palOrder);
            Controls.Add(label2Order);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormOrder";
            Text = "Order";
            Load += FormOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            palOrder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2Order;
        private Label labelOrderID;
        private TextBox textBox1;
        private Label labelCustomer;
        private TextBox textOrderID;
        private Label labelDateForm;
        private ComboBox comboBoxStatus;
        private Label label2;
        private Label labelDateTo;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button buttonClear;
        private Button buttonSearch;
        private DataGridView dgvOrderItems;
        private Label lblOrder;
        private Panel palOrder;
        private Button button2;
        private Button buttonHome;
        private Button buttonEditOrder;
        private Button buttonCreateOrder;
        private Button buttonLogistics;
        private Button buttonComplaints;
        private Button buttonRefresh;
        private Button buttonSetting;
        private DataGridViewTextBoxColumn ColumnOrderID;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnCustomerName;
        private DataGridViewTextBoxColumn ColumnStatus;
        private DataGridViewTextBoxColumn ColumnTotalAmt;
        private LinkLabel Logoutbt;
        private Label lblWelcome;
    }
}