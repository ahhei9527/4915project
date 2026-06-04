namespace ITP4915M
{
    partial class AfterSales
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
            tabAfterSales = new TabControl();
            tabPageShipConfirmation = new TabPage();
            btSave = new Button();
            btClear = new Button();
            btRefresh = new Button();
            dataGridView2 = new DataGridView();
            lblNote = new Label();
            lblCustConfir = new Label();
            lblCondit = new Label();
            cmbCustConfirm = new ComboBox();
            lblName = new Label();
            date = new DateTimePicker();
            lblDate = new Label();
            lblShipID = new Label();
            cmbCondit = new ComboBox();
            tbReceiverName = new TextBox();
            tbNote = new TextBox();
            tbShipID = new TextBox();
            cmbConID = new ComboBox();
            lblComID = new Label();
            tabPageComplaint = new TabPage();
            panel3 = new Panel();
            cmbOrderID = new ComboBox();
            cmbCust = new ComboBox();
            EDate = new DateTimePicker();
            SDate = new DateTimePicker();
            btRefreshComplaint = new Button();
            btViewComplaint = new Button();
            btNewComplaint = new Button();
            dataGridView1 = new DataGridView();
            btCLears = new Button();
            btSearch = new Button();
            label21 = new Label();
            label20 = new Label();
            cmbUser = new ComboBox();
            label19 = new Label();
            cmbType = new ComboBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            lblSearch = new Label();
            gbMenu = new GroupBox();
            btSetting = new Button();
            btLog = new Button();
            Production = new Button();
            btDashBoard = new Button();
            btSales = new Button();
            SubmitDesign = new Button();
            Inventory = new Button();
            Logoutbt = new LinkLabel();
            lblWelcome = new Label();
            tabAfterSales.SuspendLayout();
            tabPageShipConfirmation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPageComplaint.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label1SystemName.TabIndex = 3;
            label1SystemName.Text = "Premium Living Centralized Manage System";
            // 
            // tabAfterSales
            // 
            tabAfterSales.Controls.Add(tabPageShipConfirmation);
            tabAfterSales.Controls.Add(tabPageComplaint);
            tabAfterSales.Location = new Point(186, 63);
            tabAfterSales.Name = "tabAfterSales";
            tabAfterSales.SelectedIndex = 0;
            tabAfterSales.Size = new Size(644, 475);
            tabAfterSales.TabIndex = 7;
            // 
            // tabPageShipConfirmation
            // 
            tabPageShipConfirmation.Controls.Add(btSave);
            tabPageShipConfirmation.Controls.Add(btClear);
            tabPageShipConfirmation.Controls.Add(btRefresh);
            tabPageShipConfirmation.Controls.Add(dataGridView2);
            tabPageShipConfirmation.Controls.Add(lblNote);
            tabPageShipConfirmation.Controls.Add(lblCustConfir);
            tabPageShipConfirmation.Controls.Add(lblCondit);
            tabPageShipConfirmation.Controls.Add(cmbCustConfirm);
            tabPageShipConfirmation.Controls.Add(lblName);
            tabPageShipConfirmation.Controls.Add(date);
            tabPageShipConfirmation.Controls.Add(lblDate);
            tabPageShipConfirmation.Controls.Add(lblShipID);
            tabPageShipConfirmation.Controls.Add(cmbCondit);
            tabPageShipConfirmation.Controls.Add(tbReceiverName);
            tabPageShipConfirmation.Controls.Add(tbNote);
            tabPageShipConfirmation.Controls.Add(tbShipID);
            tabPageShipConfirmation.Controls.Add(cmbConID);
            tabPageShipConfirmation.Controls.Add(lblComID);
            tabPageShipConfirmation.Location = new Point(4, 24);
            tabPageShipConfirmation.Name = "tabPageShipConfirmation";
            tabPageShipConfirmation.Padding = new Padding(3);
            tabPageShipConfirmation.Size = new Size(636, 447);
            tabPageShipConfirmation.TabIndex = 1;
            tabPageShipConfirmation.Text = "Shipment Confirmation";
            tabPageShipConfirmation.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            btSave.Location = new Point(373, 404);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 19;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClear
            // 
            btClear.Location = new Point(464, 404);
            btClear.Name = "btClear";
            btClear.Size = new Size(75, 23);
            btClear.TabIndex = 18;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btRefresh
            // 
            btRefresh.Location = new Point(40, 411);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(75, 23);
            btRefresh.TabIndex = 17;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(22, 248);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(517, 150);
            dataGridView2.TabIndex = 16;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(22, 192);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(42, 15);
            lblNote.TabIndex = 15;
            lblNote.Text = "Note: ";
            // 
            // lblCustConfir
            // 
            lblCustConfir.AutoSize = true;
            lblCustConfir.Location = new Point(268, 152);
            lblCustConfir.Name = "lblCustConfir";
            lblCustConfir.Size = new Size(144, 15);
            lblCustConfir.TabIndex = 14;
            lblCustConfir.Text = "Customer Confirmation: ";
            // 
            // lblCondit
            // 
            lblCondit.AutoSize = true;
            lblCondit.Location = new Point(17, 150);
            lblCondit.Name = "lblCondit";
            lblCondit.Size = new Size(104, 15);
            lblCondit.TabIndex = 13;
            lblCondit.Text = "Item Conditione: ";
            // 
            // cmbCustConfirm
            // 
            cmbCustConfirm.FormattingEnabled = true;
            cmbCustConfirm.Location = new Point(418, 147);
            cmbCustConfirm.Name = "cmbCustConfirm";
            cmbCustConfirm.Size = new Size(121, 23);
            cmbCustConfirm.TabIndex = 12;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 95);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 15);
            lblName.TabIndex = 11;
            lblName.Text = "Receiver Name: ";
            // 
            // date
            // 
            date.Location = new Point(424, 87);
            date.Name = "date";
            date.Size = new Size(115, 23);
            date.TabIndex = 10;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(307, 93);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(95, 15);
            lblDate.TabIndex = 9;
            lblDate.Text = "Received Date: ";
            // 
            // lblShipID
            // 
            lblShipID.AutoSize = true;
            lblShipID.Location = new Point(323, 28);
            lblShipID.Name = "lblShipID";
            lblShipID.Size = new Size(79, 15);
            lblShipID.TabIndex = 8;
            lblShipID.Text = "ShipmentID: ";
            // 
            // cmbCondit
            // 
            cmbCondit.FormattingEnabled = true;
            cmbCondit.Location = new Point(127, 144);
            cmbCondit.Name = "cmbCondit";
            cmbCondit.Size = new Size(121, 23);
            cmbCondit.TabIndex = 7;
            // 
            // tbReceiverName
            // 
            tbReceiverName.Location = new Point(127, 92);
            tbReceiverName.Name = "tbReceiverName";
            tbReceiverName.Size = new Size(121, 23);
            tbReceiverName.TabIndex = 6;
            // 
            // tbNote
            // 
            tbNote.Location = new Point(22, 219);
            tbNote.Name = "tbNote";
            tbNote.Size = new Size(517, 23);
            tbNote.TabIndex = 4;
            // 
            // tbShipID
            // 
            tbShipID.Location = new Point(424, 25);
            tbShipID.Name = "tbShipID";
            tbShipID.Size = new Size(115, 23);
            tbShipID.TabIndex = 2;
            // 
            // cmbConID
            // 
            cmbConID.FormattingEnabled = true;
            cmbConID.Location = new Point(127, 25);
            cmbConID.Name = "cmbConID";
            cmbConID.Size = new Size(121, 23);
            cmbConID.TabIndex = 1;
            cmbConID.SelectedIndexChanged += cmbConID_SelectedIndexChanged;
            // 
            // lblComID
            // 
            lblComID.AutoSize = true;
            lblComID.Location = new Point(22, 28);
            lblComID.Name = "lblComID";
            lblComID.Size = new Size(99, 15);
            lblComID.TabIndex = 0;
            lblComID.Text = "ConfirmationID: ";
            // 
            // tabPageComplaint
            // 
            tabPageComplaint.Controls.Add(panel3);
            tabPageComplaint.Location = new Point(4, 24);
            tabPageComplaint.Name = "tabPageComplaint";
            tabPageComplaint.Padding = new Padding(3);
            tabPageComplaint.Size = new Size(636, 447);
            tabPageComplaint.TabIndex = 0;
            tabPageComplaint.Text = "Complaint";
            tabPageComplaint.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cmbOrderID);
            panel3.Controls.Add(cmbCust);
            panel3.Controls.Add(EDate);
            panel3.Controls.Add(SDate);
            panel3.Controls.Add(btRefreshComplaint);
            panel3.Controls.Add(btViewComplaint);
            panel3.Controls.Add(btNewComplaint);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(btCLears);
            panel3.Controls.Add(btSearch);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(cmbUser);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(cmbType);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(lblSearch);
            panel3.Location = new Point(5, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(626, 440);
            panel3.TabIndex = 1;
            // 
            // cmbOrderID
            // 
            cmbOrderID.FormattingEnabled = true;
            cmbOrderID.Location = new Point(92, 43);
            cmbOrderID.Name = "cmbOrderID";
            cmbOrderID.Size = new Size(121, 23);
            cmbOrderID.TabIndex = 25;
            // 
            // cmbCust
            // 
            cmbCust.FormattingEnabled = true;
            cmbCust.Location = new Point(288, 45);
            cmbCust.Name = "cmbCust";
            cmbCust.Size = new Size(121, 23);
            cmbCust.TabIndex = 24;
            // 
            // EDate
            // 
            EDate.Location = new Point(288, 116);
            EDate.Name = "EDate";
            EDate.Size = new Size(123, 23);
            EDate.TabIndex = 22;
            // 
            // SDate
            // 
            SDate.Location = new Point(94, 116);
            SDate.Name = "SDate";
            SDate.Size = new Size(126, 23);
            SDate.TabIndex = 21;
            // 
            // btRefreshComplaint
            // 
            btRefreshComplaint.Location = new Point(535, 359);
            btRefreshComplaint.Margin = new Padding(2);
            btRefreshComplaint.Name = "btRefreshComplaint";
            btRefreshComplaint.Size = new Size(71, 22);
            btRefreshComplaint.TabIndex = 20;
            btRefreshComplaint.Text = "Refresh";
            btRefreshComplaint.UseVisualStyleBackColor = true;
            btRefreshComplaint.Click += btRefreshComplaint_Click;
            // 
            // btViewComplaint
            // 
            btViewComplaint.Location = new Point(450, 359);
            btViewComplaint.Margin = new Padding(2);
            btViewComplaint.Name = "btViewComplaint";
            btViewComplaint.Size = new Size(86, 22);
            btViewComplaint.TabIndex = 19;
            btViewComplaint.Text = "View / Edit";
            btViewComplaint.UseVisualStyleBackColor = true;
            btViewComplaint.Click += btViewComplaint_Click;
            // 
            // btNewComplaint
            // 
            btNewComplaint.Location = new Point(335, 359);
            btNewComplaint.Margin = new Padding(2);
            btNewComplaint.Name = "btNewComplaint";
            btNewComplaint.Size = new Size(111, 22);
            btNewComplaint.TabIndex = 18;
            btNewComplaint.Text = "New Complaint";
            btNewComplaint.UseVisualStyleBackColor = true;
            btNewComplaint.Click += btNewComplaint_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 186);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(607, 147);
            dataGridView1.TabIndex = 17;
            // 
            // btCLears
            // 
            btCLears.Location = new Point(535, 146);
            btCLears.Margin = new Padding(2);
            btCLears.Name = "btCLears";
            btCLears.Size = new Size(71, 22);
            btCLears.TabIndex = 7;
            btCLears.Text = "Clear";
            btCLears.UseVisualStyleBackColor = true;
            btCLears.Click += btCLears_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(450, 146);
            btSearch.Margin = new Padding(2);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(71, 22);
            btSearch.TabIndex = 8;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(242, 122);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(28, 15);
            label21.TabIndex = 15;
            label21.Text = "To: ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(18, 121);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(72, 15);
            label20.TabIndex = 13;
            label20.Text = "Date From: ";
            // 
            // cmbUser
            // 
            cmbUser.FormattingEnabled = true;
            cmbUser.Location = new Point(92, 79);
            cmbUser.Margin = new Padding(2);
            cmbUser.Name = "cmbUser";
            cmbUser.Size = new Size(128, 23);
            cmbUser.TabIndex = 12;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(11, 81);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(82, 15);
            label19.TabIndex = 11;
            label19.Text = "Assigned To: ";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(288, 79);
            cmbType.Margin = new Padding(2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(128, 23);
            cmbType.TabIndex = 10;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(242, 81);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(41, 15);
            label18.TabIndex = 9;
            label18.Text = "Type: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(218, 46);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(67, 15);
            label17.TabIndex = 7;
            label17.Text = "Customer: ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 46);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(58, 15);
            label16.TabIndex = 5;
            label16.Text = "Order ID:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(7, 45);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblSearch.Location = new Point(6, 12);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(133, 24);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search / Filter";
            // 
            // gbMenu
            // 
            gbMenu.Controls.Add(btSetting);
            gbMenu.Controls.Add(btLog);
            gbMenu.Controls.Add(Production);
            gbMenu.Controls.Add(btDashBoard);
            gbMenu.Controls.Add(btSales);
            gbMenu.Controls.Add(SubmitDesign);
            gbMenu.Controls.Add(Inventory);
            gbMenu.Location = new Point(18, 50);
            gbMenu.Name = "gbMenu";
            gbMenu.Size = new Size(145, 499);
            gbMenu.TabIndex = 14;
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
            // btLog
            // 
            btLog.Location = new Point(20, 182);
            btLog.Name = "btLog";
            btLog.Size = new Size(119, 52);
            btLog.TabIndex = 5;
            btLog.Text = "Logistics/Delivery";
            btLog.UseVisualStyleBackColor = true;
            btLog.Click += btLog_Click;
            // 
            // Production
            // 
            Production.Location = new Point(22, 309);
            Production.Name = "Production";
            Production.Size = new Size(103, 52);
            Production.TabIndex = 4;
            Production.Text = "Production";
            Production.UseVisualStyleBackColor = true;
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
            // SubmitDesign
            // 
            SubmitDesign.Location = new Point(22, 379);
            SubmitDesign.Name = "SubmitDesign";
            SubmitDesign.Size = new Size(103, 52);
            SubmitDesign.TabIndex = 3;
            SubmitDesign.Text = "SubmitDesign";
            SubmitDesign.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            Inventory.Location = new Point(20, 240);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(103, 52);
            Inventory.TabIndex = 2;
            Inventory.Text = "Inventory";
            Inventory.UseVisualStyleBackColor = true;
            Inventory.Click += Inventory_Click;
            // 
            // Logoutbt
            // 
            Logoutbt.AutoSize = true;
            Logoutbt.Location = new Point(773, 22);
            Logoutbt.Name = "Logoutbt";
            Logoutbt.Size = new Size(50, 15);
            Logoutbt.TabIndex = 9;
            Logoutbt.TabStop = true;
            Logoutbt.Text = "LogOut";
            Logoutbt.LinkClicked += Logoutbt_LinkClicked;
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblWelcome.Location = new Point(595, 45);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(228, 39);
            lblWelcome.TabIndex = 8;
            // 
            // AfterSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 561);
            Controls.Add(Logoutbt);
            Controls.Add(gbMenu);
            Controls.Add(lblWelcome);
            Controls.Add(tabAfterSales);
            Controls.Add(label1SystemName);
            Margin = new Padding(2);
            Name = "AfterSales";
            Text = "AfterSales";
            Load += AfterSales_Load;
            tabAfterSales.ResumeLayout(false);
            tabPageShipConfirmation.ResumeLayout(false);
            tabPageShipConfirmation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPageComplaint.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1SystemName;
        private TabControl tabAfterSales;
        private TabPage tabPageComplaint;
        private Panel panel3;
        private Button btRefreshComplaint;
        private Button btViewComplaint;
        private Button btNewComplaint;
        private DataGridView dataGridView1;
        private Button btCLears;
        private Button btSearch;
        private Label label21;
        private Label label20;
        private ComboBox cmbUser;
        private Label label19;
        private ComboBox cmbType;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label lblSearch;
        private TabPage tabPageShipConfirmation;
        private TextBox tbShipID;
        private ComboBox cmbConID;
        private Label lblComID;
        private Label lblNote;
        private Label lblCustConfir;
        private Label lblCondit;
        private ComboBox cmbCustConfirm;
        private Label lblName;
        private DateTimePicker date;
        private Label lblDate;
        private Label lblShipID;
        private ComboBox cmbCondit;
        private TextBox tbReceiverName;
        private TextBox tbNote;
        private Button btSave;
        private Button btClear;
        private Button btRefresh;
        private DataGridView dataGridView2;
        private GroupBox gbMenu;
        private Button btSetting;
        private Button btLog;
        private Button Production;
        private Button SubmitDesign;
        private Button Inventory;
        private Button btDashBoard;
        private Button btSales;
        private DateTimePicker EDate;
        private DateTimePicker SDate;
        private LinkLabel Logoutbt;
        private Label lblWelcome;
        private ComboBox cmbOrderID;
        private ComboBox cmbCust;
    }
}