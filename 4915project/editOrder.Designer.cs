namespace _4915project
{
    partial class EditOrder
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
            labelOrderDetail = new Label();
            plOrderDetail = new Panel();
            gbItem = new GroupBox();
            buttonCancel = new Button();
            buttonSaveOrder = new Button();
            tbTotal = new TextBox();
            labelTotalAmount = new Label();
            dgvOrderItems = new DataGridView();
            gbInformation = new GroupBox();
            tbCustName = new TextBox();
            cmOrderID = new ComboBox();
            cbStatus = new ComboBox();
            lblstatus = new Label();
            tbAddress = new TextBox();
            labelDeliveryAddress = new Label();
            deliveryDate = new DateTimePicker();
            lblRequestDeliveryDate = new Label();
            labelCustomerID = new Label();
            OrderDate = new DateTimePicker();
            labelDate = new Label();
            labelOrderID = new Label();
            plOrderDetail.SuspendLayout();
            gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            gbInformation.SuspendLayout();
            SuspendLayout();
            // 
            // labelOrderDetail
            // 
            labelOrderDetail.AutoSize = true;
            labelOrderDetail.FlatStyle = FlatStyle.Flat;
            labelOrderDetail.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelOrderDetail.Location = new Point(33, 15);
            labelOrderDetail.Name = "labelOrderDetail";
            labelOrderDetail.Size = new Size(152, 30);
            labelOrderDetail.TabIndex = 14;
            labelOrderDetail.Text = "Order Detail";
            // 
            // plOrderDetail
            // 
            plOrderDetail.BorderStyle = BorderStyle.FixedSingle;
            plOrderDetail.Controls.Add(gbItem);
            plOrderDetail.Controls.Add(gbInformation);
            plOrderDetail.Location = new Point(17, 35);
            plOrderDetail.Name = "plOrderDetail";
            plOrderDetail.Size = new Size(1319, 795);
            plOrderDetail.TabIndex = 15;
            // 
            // gbItem
            // 
            gbItem.Controls.Add(buttonCancel);
            gbItem.Controls.Add(buttonSaveOrder);
            gbItem.Controls.Add(tbTotal);
            gbItem.Controls.Add(labelTotalAmount);
            gbItem.Controls.Add(dgvOrderItems);
            gbItem.Location = new Point(17, 207);
            gbItem.Name = "gbItem";
            gbItem.Size = new Size(1281, 562);
            gbItem.TabIndex = 1;
            gbItem.TabStop = false;
            gbItem.Text = "Order Items - Order Item Details";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(1092, 457);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSaveOrder
            // 
            buttonSaveOrder.Location = new Point(913, 457);
            buttonSaveOrder.Name = "buttonSaveOrder";
            buttonSaveOrder.Size = new Size(112, 34);
            buttonSaveOrder.TabIndex = 10;
            buttonSaveOrder.Text = "Save Order";
            buttonSaveOrder.UseVisualStyleBackColor = true;
            buttonSaveOrder.Click += buttonSaveOrder_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(1063, 376);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(141, 30);
            tbTotal.TabIndex = 9;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Location = new Point(888, 379);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(175, 23);
            labelTotalAmount.TabIndex = 8;
            labelTotalAmount.Text = "Total Amount: HKD";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(16, 52);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 62;
            dgvOrderItems.Size = new Size(1245, 299);
            dgvOrderItems.TabIndex = 7;
            // 
            // gbInformation
            // 
            gbInformation.Controls.Add(tbCustName);
            gbInformation.Controls.Add(cmOrderID);
            gbInformation.Controls.Add(cbStatus);
            gbInformation.Controls.Add(lblstatus);
            gbInformation.Controls.Add(tbAddress);
            gbInformation.Controls.Add(labelDeliveryAddress);
            gbInformation.Controls.Add(deliveryDate);
            gbInformation.Controls.Add(lblRequestDeliveryDate);
            gbInformation.Controls.Add(labelCustomerID);
            gbInformation.Controls.Add(OrderDate);
            gbInformation.Controls.Add(labelDate);
            gbInformation.Controls.Add(labelOrderID);
            gbInformation.Location = new Point(17, 12);
            gbInformation.Name = "gbInformation";
            gbInformation.Size = new Size(1281, 189);
            gbInformation.TabIndex = 0;
            gbInformation.TabStop = false;
            gbInformation.Text = "Order Header - Basic Order Information";
            // 
            // tbCustName
            // 
            tbCustName.Location = new Point(261, 75);
            tbCustName.Margin = new Padding(5, 5, 5, 5);
            tbCustName.Name = "tbCustName";
            tbCustName.Size = new Size(325, 30);
            tbCustName.TabIndex = 14;
            // 
            // cmOrderID
            // 
            cmOrderID.FormattingEnabled = true;
            cmOrderID.Location = new Point(261, 30);
            cmOrderID.Margin = new Padding(5, 5, 5, 5);
            cmOrderID.Name = "cmOrderID";
            cmOrderID.Size = new Size(325, 31);
            cmOrderID.TabIndex = 13;
            cmOrderID.SelectedIndexChanged += cmOrderID_SelectedIndexChanged;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Quoted", "Paid" });
            cbStatus.Location = new Point(1008, 121);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(196, 31);
            cbStatus.TabIndex = 11;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Location = new Point(934, 123);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(67, 23);
            lblstatus.TabIndex = 10;
            lblstatus.Text = "Status:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(261, 129);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(325, 45);
            tbAddress.TabIndex = 9;
            // 
            // labelDeliveryAddress
            // 
            labelDeliveryAddress.AutoSize = true;
            labelDeliveryAddress.Location = new Point(100, 129);
            labelDeliveryAddress.Name = "labelDeliveryAddress";
            labelDeliveryAddress.Size = new Size(155, 23);
            labelDeliveryAddress.TabIndex = 8;
            labelDeliveryAddress.Text = "Delivery Address:";
            // 
            // deliveryDate
            // 
            deliveryDate.Location = new Point(1008, 74);
            deliveryDate.Name = "deliveryDate";
            deliveryDate.Size = new Size(196, 30);
            deliveryDate.TabIndex = 7;
            deliveryDate.ValueChanged += deliveryDate_ValueChanged;
            // 
            // lblRequestDeliveryDate
            // 
            lblRequestDeliveryDate.AutoSize = true;
            lblRequestDeliveryDate.Location = new Point(795, 75);
            lblRequestDeliveryDate.Name = "lblRequestDeliveryDate";
            lblRequestDeliveryDate.Size = new Size(203, 23);
            lblRequestDeliveryDate.TabIndex = 6;
            lblRequestDeliveryDate.Text = "Request Delivery Date:";
            // 
            // labelCustomerID
            // 
            labelCustomerID.AutoSize = true;
            labelCustomerID.Location = new Point(99, 78);
            labelCustomerID.Name = "labelCustomerID";
            labelCustomerID.Size = new Size(154, 23);
            labelCustomerID.TabIndex = 4;
            labelCustomerID.Text = "Customer Name:";
            // 
            // OrderDate
            // 
            OrderDate.Location = new Point(1006, 31);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(197, 30);
            OrderDate.TabIndex = 3;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(888, 33);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(110, 23);
            labelDate.TabIndex = 2;
            labelDate.Text = "Order Date:";
            // 
            // labelOrderID
            // 
            labelOrderID.AutoSize = true;
            labelOrderID.Location = new Point(172, 33);
            labelOrderID.Name = "labelOrderID";
            labelOrderID.Size = new Size(83, 23);
            labelOrderID.TabIndex = 1;
            labelOrderID.Text = "OrderID:";
            // 
            // editOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(labelOrderDetail);
            Controls.Add(plOrderDetail);
            Margin = new Padding(5, 5, 5, 5);
            Name = "EditOrder";
            Text = "Edit Order";
            Load += editOrder_Load;
            plOrderDetail.ResumeLayout(false);
            gbItem.ResumeLayout(false);
            gbItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            gbInformation.ResumeLayout(false);
            gbInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOrderDetail;
        private Panel plOrderDetail;
        private GroupBox gbItem;
        private Button buttonCancel;
        private Button buttonSaveOrder;
        private TextBox tbTotal;
        private Label labelTotalAmount;
        private DataGridView dgvOrderItems;
        private GroupBox gbInformation;
        private ComboBox cbStatus;
        private Label lblstatus;
        private TextBox tbAddress;
        private Label labelDeliveryAddress;
        private DateTimePicker deliveryDate;
        private Label lblRequestDeliveryDate;
        private Label labelCustomerID;
        private DateTimePicker OrderDate;
        private Label labelDate;
        private Label labelOrderID;
        private ComboBox cmOrderID;
        private TextBox tbCustName;
    }
}
