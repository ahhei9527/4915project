namespace ITP4915M
{
    partial class FormLogistics
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            cbOrderID = new ComboBox();
            tbShipID = new TextBox();
            cbMethod = new ComboBox();
            lblMethod = new Label();
            cbremark = new ComboBox();
            cbshipStat = new ComboBox();
            lblShipStatus = new Label();
            receviedDate = new DateTimePicker();
            DelivDate = new DateTimePicker();
            lblActualDDate = new Label();
            cbOrderstat = new ComboBox();
            btUpdateCreate = new Button();
            label12 = new Label();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            lblOrderStatus = new Label();
            label10 = new Label();
            lblShipID = new Label();
            gbMenu = new GroupBox();
            btSetting = new Button();
            AfterSales = new Button();
            Production = new Button();
            SubmitDesign = new Button();
            Inventory = new Button();
            btDashBoard = new Button();
            btSales = new Button();
            Logoutbt = new LinkLabel();
            lblWelcome = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            gbMenu.SuspendLayout();
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
            label1SystemName.TabIndex = 2;
            label1SystemName.Text = "Premium Living Centralized Manage System";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(169, 63);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(659, 458);
            tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkGray;
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(651, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Status & Goods Received";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(cbOrderID);
            groupBox1.Controls.Add(tbShipID);
            groupBox1.Controls.Add(cbMethod);
            groupBox1.Controls.Add(lblMethod);
            groupBox1.Controls.Add(cbremark);
            groupBox1.Controls.Add(cbshipStat);
            groupBox1.Controls.Add(lblShipStatus);
            groupBox1.Controls.Add(receviedDate);
            groupBox1.Controls.Add(DelivDate);
            groupBox1.Controls.Add(lblActualDDate);
            groupBox1.Controls.Add(cbOrderstat);
            groupBox1.Controls.Add(btUpdateCreate);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblOrderStatus);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lblShipID);
            groupBox1.Location = new Point(6, 8);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(641, 418);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ongoing Deliveries";
            // 
            // cbOrderID
            // 
            cbOrderID.FormattingEnabled = true;
            cbOrderID.Location = new Point(467, 12);
            cbOrderID.Name = "cbOrderID";
            cbOrderID.Size = new Size(121, 23);
            cbOrderID.TabIndex = 28;
            cbOrderID.SelectedIndexChanged += cbOrderID_SelectedIndexChanged;
            // 
            // tbShipID
            // 
            tbShipID.Location = new Point(109, 20);
            tbShipID.Name = "tbShipID";
            tbShipID.Size = new Size(121, 23);
            tbShipID.TabIndex = 27;
            // 
            // cbMethod
            // 
            cbMethod.FormattingEnabled = true;
            cbMethod.Location = new Point(109, 114);
            cbMethod.Name = "cbMethod";
            cbMethod.Size = new Size(121, 23);
            cbMethod.TabIndex = 26;
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Location = new Point(5, 117);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(107, 15);
            lblMethod.TabIndex = 25;
            lblMethod.Text = "Delivery Method: ";
            // 
            // cbremark
            // 
            cbremark.FormattingEnabled = true;
            cbremark.Location = new Point(459, 114);
            cbremark.Name = "cbremark";
            cbremark.Size = new Size(129, 23);
            cbremark.TabIndex = 24;
            // 
            // cbshipStat
            // 
            cbshipStat.FormattingEnabled = true;
            cbshipStat.Location = new Point(109, 75);
            cbshipStat.Name = "cbshipStat";
            cbshipStat.Size = new Size(121, 23);
            cbshipStat.TabIndex = 23;
            // 
            // lblShipStatus
            // 
            lblShipStatus.AutoSize = true;
            lblShipStatus.Location = new Point(5, 81);
            lblShipStatus.Name = "lblShipStatus";
            lblShipStatus.Size = new Size(98, 15);
            lblShipStatus.TabIndex = 22;
            lblShipStatus.Text = "Shipment Status";
            // 
            // receviedDate
            // 
            receviedDate.Location = new Point(471, 46);
            receviedDate.Name = "receviedDate";
            receviedDate.Size = new Size(117, 23);
            receviedDate.TabIndex = 21;
            // 
            // DelivDate
            // 
            DelivDate.Location = new Point(461, 81);
            DelivDate.Name = "DelivDate";
            DelivDate.Size = new Size(127, 23);
            DelivDate.TabIndex = 20;
            // 
            // lblActualDDate
            // 
            lblActualDDate.AutoSize = true;
            lblActualDDate.Location = new Point(329, 81);
            lblActualDDate.Name = "lblActualDDate";
            lblActualDDate.Size = new Size(126, 15);
            lblActualDDate.TabIndex = 19;
            lblActualDDate.Text = "Actual Delivery Date: ";
            // 
            // cbOrderstat
            // 
            cbOrderstat.FormattingEnabled = true;
            cbOrderstat.Location = new Point(109, 45);
            cbOrderstat.Name = "cbOrderstat";
            cbOrderstat.Size = new Size(121, 23);
            cbOrderstat.TabIndex = 17;
            // 
            // btUpdateCreate
            // 
            btUpdateCreate.Location = new Point(204, 392);
            btUpdateCreate.Margin = new Padding(2);
            btUpdateCreate.Name = "btUpdateCreate";
            btUpdateCreate.Size = new Size(225, 22);
            btUpdateCreate.TabIndex = 16;
            btUpdateCreate.Text = "Update Status & Complete Order";
            btUpdateCreate.UseVisualStyleBackColor = true;
            btUpdateCreate.Click += btUpdateCreate_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(398, 15);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 10;
            label12.Text = "Order ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 162);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(218, 15);
            label7.TabIndex = 9;
            label7.Text = "Pending Orders (Ready for Shipment)";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(4, 194);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(620, 186);
            dataGridView2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(274, 117);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(181, 15);
            label8.TabIndex = 3;
            label8.Text = "Remarks / Shortage / Damage:";
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Location = new Point(4, 48);
            lblOrderStatus.Margin = new Padding(2, 0, 2, 0);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(80, 15);
            lblOrderStatus.TabIndex = 2;
            lblOrderStatus.Text = "Order Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(364, 48);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 1;
            label10.Text = "Received Date:";
            // 
            // lblShipID
            // 
            lblShipID.AutoSize = true;
            lblShipID.Location = new Point(20, 23);
            lblShipID.Margin = new Padding(2, 0, 2, 0);
            lblShipID.Name = "lblShipID";
            lblShipID.Size = new Size(70, 15);
            lblShipID.TabIndex = 0;
            lblShipID.Text = "Delivery ID:";
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(btSetting);
            gbMenu.Controls.Add(AfterSales);
            gbMenu.Controls.Add(Production);
            gbMenu.Controls.Add(SubmitDesign);
            gbMenu.Controls.Add(Inventory);
            gbMenu.Controls.Add(btDashBoard);
            gbMenu.Controls.Add(btSales);
            gbMenu.Location = new Point(12, 50);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(145, 499);
            gbMenu.TabIndex = 13;
            gbMenu.TabStop = false;
            gbMenu.Text = "Menu";
            // 
            // btSetting
            // 
            btSetting.Location = new Point(20, 448);
            btSetting.Name = "btSetting";
            btSetting.Size = new Size(103, 45);
            btSetting.TabIndex = 7;
            btSetting.Text = "Setting";
            btSetting.UseVisualStyleBackColor = true;
            btSetting.Click += btSetting_Click;
            // 
            // AfterSales
            // 
            AfterSales.Location = new Point(22, 385);
            AfterSales.Name = "AfterSales";
            AfterSales.Size = new Size(103, 52);
            AfterSales.TabIndex = 5;
            AfterSales.Text = "AfterSales";
            AfterSales.UseVisualStyleBackColor = true;
            AfterSales.Click += AfterSales_Click;
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
            Inventory.Click += Inventory_Click;
            // 
            // btDashBoard
            // 
            btDashBoard.Location = new Point(22, 31);
            btDashBoard.Name = "btDashBoard";
            btDashBoard.Size = new Size(103, 52);
            btDashBoard.TabIndex = 1;
            btDashBoard.Text = "DashBoard";
            btDashBoard.UseVisualStyleBackColor = true;
            btDashBoard.Click += btDashBoard_Click;
            // 
            // btSales
            // 
            btSales.Location = new Point(20, 100);
            btSales.Name = "btSales";
            btSales.Size = new Size(103, 60);
            btSales.TabIndex = 0;
            btSales.Text = "Sales/Order";
            btSales.UseVisualStyleBackColor = true;
            btSales.Click += btSales_Click;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(769, 9);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(50, 15);
            Logoutbt.TabIndex = 13;
            Logoutbt.TabStop = true;
            Logoutbt.Text = "LogOut";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(592, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(228, 39);
            lblWelcome.TabIndex = 12;
            // 
            // FormLogistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 561);
            Controls.Add(Logoutbt);
            Controls.Add(gbMenu);
            Controls.Add(lblWelcome);
            Controls.Add(tabControl1);
            Controls.Add(label1SystemName);
            Margin = new Padding(2);
            Name = "FormLogistics";
            Text = "Logistics";
            Load += FormLogistics_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            gbMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1SystemName;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label12;
        private Label label7;
        private DataGridView dataGridView2;
        private Label label8;
        private Label lblOrderStatus;
        private Label label10;
        private Label lblShipID;
        private Button btUpdateCreate;
        private GroupBox gbMenu;
        private Button btSetting;
        private Button AfterSales;
        private Button Production;
        private Button SubmitDesign;
        private Button Inventory;
        private Button btDashBoard;
        private Button btSales;
        private LinkLabel Logoutbt;
        private Label lblWelcome;
        private ComboBox cbOrderstat;
        private DateTimePicker receviedDate;
        private DateTimePicker DelivDate;
        private Label lblActualDDate;
        private Label lblShipStatus;
        private ComboBox cbshipStat;
        private ComboBox cbremark;
        private ComboBox cbMethod;
        private Label lblMethod;
        private TextBox tbShipID;
        private ComboBox cbOrderID;
    }
}