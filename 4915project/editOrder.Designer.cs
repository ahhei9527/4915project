namespace _4915project
{
    partial class editOrder
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
            labelOrderDetail.Location = new Point(21, 10);
            labelOrderDetail.Margin = new Padding(2, 0, 2, 0);
            labelOrderDetail.Name = "labelOrderDetail";
            labelOrderDetail.Size = new Size(101, 20);
            labelOrderDetail.TabIndex = 14;
            labelOrderDetail.Text = "Order Detail";
            // 
            // plOrderDetail
            // 
            plOrderDetail.BorderStyle = BorderStyle.FixedSingle;
            plOrderDetail.Controls.Add(gbItem);
            plOrderDetail.Controls.Add(gbInformation);
            plOrderDetail.Location = new Point(11, 23);
            plOrderDetail.Margin = new Padding(2);
            plOrderDetail.Name = "plOrderDetail";
            plOrderDetail.Size = new Size(689, 470);
            plOrderDetail.TabIndex = 15;
            // 
            // gbItem
            // 
            gbItem.Controls.Add(buttonCancel);
            gbItem.Controls.Add(buttonSaveOrder);
            gbItem.Controls.Add(tbTotal);
            gbItem.Controls.Add(labelTotalAmount);
            gbItem.Controls.Add(dgvOrderItems);
            gbItem.Location = new Point(11, 135);
            gbItem.Margin = new Padding(2);
            gbItem.Name = "gbItem";
            gbItem.Padding = new Padding(2);
            gbItem.Size = new Size(664, 310);
            gbItem.TabIndex = 1;
            gbItem.TabStop = false;
            gbItem.Text = "Order Items - Order Item Details";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(585, 272);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(71, 22);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSaveOrder
            // 
            buttonSaveOrder.Location = new Point(480, 272);
            buttonSaveOrder.Margin = new Padding(2);
            buttonSaveOrder.Name = "buttonSaveOrder";
            buttonSaveOrder.Size = new Size(71, 22);
            buttonSaveOrder.TabIndex = 10;
            buttonSaveOrder.Text = "Save Order";
            buttonSaveOrder.UseVisualStyleBackColor = true;
            buttonSaveOrder.Click += buttonSaveOrder_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(567, 243);
            tbTotal.Margin = new Padding(2);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(91, 23);
            tbTotal.TabIndex = 9;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Location = new Point(447, 245);
            labelTotalAmount.Margin = new Padding(2, 0, 2, 0);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(115, 15);
            labelTotalAmount.TabIndex = 8;
            labelTotalAmount.Text = "Total Amount: HKD";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(10, 34);
            dgvOrderItems.Margin = new Padding(2);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 62;
            dgvOrderItems.Size = new Size(646, 195);
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
            gbInformation.Location = new Point(11, 8);
            gbInformation.Margin = new Padding(2);
            gbInformation.Name = "gbInformation";
            gbInformation.Padding = new Padding(2);
            gbInformation.Size = new Size(664, 123);
            gbInformation.TabIndex = 0;
            gbInformation.TabStop = false;
            gbInformation.Text = "Order Header - Basic Order Information";
            // 
            // tbCustName
            // 
            tbCustName.Location = new Point(117, 47);
            tbCustName.Name = "tbCustName";
            tbCustName.Size = new Size(161, 23);
            tbCustName.TabIndex = 14;
            // 
            // cmOrderID
            // 
            cmOrderID.FormattingEnabled = true;
            cmOrderID.Location = new Point(70, 18);
            cmOrderID.Name = "cmOrderID";
            cmOrderID.Size = new Size(208, 23);
            cmOrderID.TabIndex = 13;
            cmOrderID.SelectedIndexChanged += cmOrderID_SelectedIndexChanged;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Quoted", "Paid" });
            cbStatus.Location = new Point(455, 76);
            cbStatus.Margin = new Padding(2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(96, 23);
            cbStatus.TabIndex = 11;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Location = new Point(409, 77);
            lblstatus.Margin = new Padding(2, 0, 2, 0);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(44, 15);
            lblstatus.TabIndex = 10;
            lblstatus.Text = "Status:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(113, 82);
            tbAddress.Margin = new Padding(2);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(166, 31);
            tbAddress.TabIndex = 9;
            // 
            // labelDeliveryAddress
            // 
            labelDeliveryAddress.AutoSize = true;
            labelDeliveryAddress.Location = new Point(10, 82);
            labelDeliveryAddress.Margin = new Padding(2, 0, 2, 0);
            labelDeliveryAddress.Name = "labelDeliveryAddress";
            labelDeliveryAddress.Size = new Size(103, 15);
            labelDeliveryAddress.TabIndex = 8;
            labelDeliveryAddress.Text = "Delivery Address:";
            // 
            // deliveryDate
            // 
            deliveryDate.Location = new Point(456, 45);
            deliveryDate.Margin = new Padding(2);
            deliveryDate.Name = "deliveryDate";
            deliveryDate.Size = new Size(126, 23);
            deliveryDate.TabIndex = 7;
            deliveryDate.ValueChanged += deliveryDate_ValueChanged;
            // 
            // lblRequestDeliveryDate
            // 
            lblRequestDeliveryDate.AutoSize = true;
            lblRequestDeliveryDate.Location = new Point(317, 46);
            lblRequestDeliveryDate.Margin = new Padding(2, 0, 2, 0);
            lblRequestDeliveryDate.Name = "lblRequestDeliveryDate";
            lblRequestDeliveryDate.Size = new Size(134, 15);
            lblRequestDeliveryDate.TabIndex = 6;
            lblRequestDeliveryDate.Text = "Request Delivery Date:";
            // 
            // labelCustomerID
            // 
            labelCustomerID.AutoSize = true;
            labelCustomerID.Location = new Point(10, 48);
            labelCustomerID.Margin = new Padding(2, 0, 2, 0);
            labelCustomerID.Name = "labelCustomerID";
            labelCustomerID.Size = new Size(102, 15);
            labelCustomerID.TabIndex = 4;
            labelCustomerID.Text = "Customer Name:";
            // 
            // OrderDate
            // 
            OrderDate.Location = new Point(455, 17);
            OrderDate.Margin = new Padding(2);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(127, 23);
            OrderDate.TabIndex = 3;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(380, 18);
            labelDate.Margin = new Padding(2, 0, 2, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(73, 15);
            labelDate.TabIndex = 2;
            labelDate.Text = "Order Date:";
            // 
            // labelOrderID
            // 
            labelOrderID.AutoSize = true;
            labelOrderID.Location = new Point(10, 20);
            labelOrderID.Margin = new Padding(2, 0, 2, 0);
            labelOrderID.Name = "labelOrderID";
            labelOrderID.Size = new Size(55, 15);
            labelOrderID.TabIndex = 1;
            labelOrderID.Text = "OrderID:";
            // 
            // editOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 515);
            Controls.Add(labelOrderDetail);
            Controls.Add(plOrderDetail);
            Name = "editOrder";
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