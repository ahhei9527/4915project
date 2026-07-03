namespace _4915project
{
    partial class FormOrderDetail
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
            labelTitle = new Label();
            labelOrderDetail = new Label();
            plOrderDetail = new Panel();
            gbItem = new GroupBox();
            buttonCancel = new Button();
            buttonSaveOrder = new Button();
            tbTotal = new TextBox();
            labelTotalAmount = new Label();
            dgvOrderItems = new DataGridView();
            buttonAddItem = new Button();
            numericUpDownQuantity = new NumericUpDown();
            labelQuantity = new Label();
            textBoxUnitPrice = new TextBox();
            label3UnitPrice = new Label();
            comboBoxProductIDName = new ComboBox();
            labelProductIDName = new Label();
            gbInformation = new GroupBox();
            cmbCustName = new ComboBox();
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
            tbOrderID = new TextBox();
            plOrderDetail.SuspendLayout();
            gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            gbInformation.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelTitle.Location = new Point(28, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(760, 46);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Premium Living Centralized Manage System";
            // 
            // labelOrderDetail
            // 
            labelOrderDetail.AutoSize = true;
            labelOrderDetail.FlatStyle = FlatStyle.Flat;
            labelOrderDetail.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelOrderDetail.Location = new Point(44, 74);
            labelOrderDetail.Name = "labelOrderDetail";
            labelOrderDetail.Size = new Size(152, 30);
            labelOrderDetail.TabIndex = 12;
            labelOrderDetail.Text = "Order Detail";
            // 
            // plOrderDetail
            // 
            plOrderDetail.BorderStyle = BorderStyle.FixedSingle;
            plOrderDetail.Controls.Add(gbItem);
            plOrderDetail.Controls.Add(gbInformation);
            plOrderDetail.Location = new Point(28, 94);
            plOrderDetail.Name = "plOrderDetail";
            plOrderDetail.Size = new Size(1309, 720);
            plOrderDetail.TabIndex = 13;
            // 
            // gbItem
            // 
            gbItem.Controls.Add(buttonCancel);
            gbItem.Controls.Add(buttonSaveOrder);
            gbItem.Controls.Add(tbTotal);
            gbItem.Controls.Add(labelTotalAmount);
            gbItem.Controls.Add(dgvOrderItems);
            gbItem.Controls.Add(buttonAddItem);
            gbItem.Controls.Add(numericUpDownQuantity);
            gbItem.Controls.Add(labelQuantity);
            gbItem.Controls.Add(textBoxUnitPrice);
            gbItem.Controls.Add(label3UnitPrice);
            gbItem.Controls.Add(comboBoxProductIDName);
            gbItem.Controls.Add(labelProductIDName);
            gbItem.Location = new Point(17, 207);
            gbItem.Name = "gbItem";
            gbItem.Size = new Size(1273, 475);
            gbItem.TabIndex = 1;
            gbItem.TabStop = false;
            gbItem.Text = "Order Items - Order Item Details";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(1144, 419);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSaveOrder
            // 
            buttonSaveOrder.Location = new Point(1002, 419);
            buttonSaveOrder.Name = "buttonSaveOrder";
            buttonSaveOrder.Size = new Size(112, 34);
            buttonSaveOrder.TabIndex = 10;
            buttonSaveOrder.Text = "Save Order";
            buttonSaveOrder.UseVisualStyleBackColor = true;
            buttonSaveOrder.Click += buttonSaveOrder_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(1115, 375);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(141, 30);
            tbTotal.TabIndex = 9;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Location = new Point(928, 379);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(175, 23);
            labelTotalAmount.TabIndex = 8;
            labelTotalAmount.Text = "Total Amount: HKD";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(16, 110);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 62;
            dgvOrderItems.Size = new Size(1240, 241);
            dgvOrderItems.TabIndex = 7;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Location = new Point(1144, 70);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(112, 34);
            buttonAddItem.TabIndex = 6;
            buttonAddItem.Text = "Add Item";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(1075, 26);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(181, 30);
            numericUpDownQuantity.TabIndex = 5;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(980, 29);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(89, 23);
            labelQuantity.TabIndex = 4;
            labelQuantity.Text = "Quantity:";
            // 
            // textBoxUnitPrice
            // 
            textBoxUnitPrice.Location = new Point(654, 26);
            textBoxUnitPrice.Name = "textBoxUnitPrice";
            textBoxUnitPrice.ReadOnly = true;
            textBoxUnitPrice.Size = new Size(150, 30);
            textBoxUnitPrice.TabIndex = 3;
            // 
            // label3UnitPrice
            // 
            label3UnitPrice.AutoSize = true;
            label3UnitPrice.Location = new Point(505, 31);
            label3UnitPrice.Name = "label3UnitPrice";
            label3UnitPrice.Size = new Size(141, 23);
            label3UnitPrice.TabIndex = 2;
            label3UnitPrice.Text = "Unit Price: HKD";
            // 
            // comboBoxProductIDName
            // 
            comboBoxProductIDName.FormattingEnabled = true;
            comboBoxProductIDName.Location = new Point(245, 26);
            comboBoxProductIDName.Name = "comboBoxProductIDName";
            comboBoxProductIDName.Size = new Size(182, 31);
            comboBoxProductIDName.TabIndex = 1;
            comboBoxProductIDName.SelectedIndexChanged += comboBoxProductIDName_SelectedIndexChanged;
            // 
            // labelProductIDName
            // 
            labelProductIDName.AutoSize = true;
            labelProductIDName.Location = new Point(64, 29);
            labelProductIDName.Name = "labelProductIDName";
            labelProductIDName.Size = new Size(175, 23);
            labelProductIDName.TabIndex = 0;
            labelProductIDName.Text = "Product ID / Name:";
            // 
            // gbInformation
            // 
            gbInformation.Controls.Add(cmbCustName);
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
            gbInformation.Controls.Add(tbOrderID);
            gbInformation.Location = new Point(17, 12);
            gbInformation.Name = "gbInformation";
            gbInformation.Size = new Size(1273, 189);
            gbInformation.TabIndex = 0;
            gbInformation.TabStop = false;
            gbInformation.Text = "Order Header - Basic Order Information";
            // 
            // cmbCustName
            // 
            cmbCustName.FormattingEnabled = true;
            cmbCustName.Location = new Point(255, 71);
            cmbCustName.Margin = new Padding(5);
            cmbCustName.Name = "cmbCustName";
            cmbCustName.Size = new Size(329, 31);
            cmbCustName.TabIndex = 12;
            cmbCustName.SelectedIndexChanged += cmbCustName_SelectedIndexChanged;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Quoted", "Paid" });
            cbStatus.Location = new Point(917, 120);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(197, 31);
            cbStatus.TabIndex = 11;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Location = new Point(846, 123);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(67, 23);
            lblstatus.TabIndex = 10;
            lblstatus.Text = "Status:";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(255, 120);
            tbAddress.Multiline = true;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(329, 45);
            tbAddress.TabIndex = 9;
            // 
            // labelDeliveryAddress
            // 
            labelDeliveryAddress.AutoSize = true;
            labelDeliveryAddress.Location = new Point(92, 123);
            labelDeliveryAddress.Name = "labelDeliveryAddress";
            labelDeliveryAddress.Size = new Size(155, 23);
            labelDeliveryAddress.TabIndex = 8;
            labelDeliveryAddress.Text = "Delivery Address:";
            // 
            // deliveryDate
            // 
            deliveryDate.Location = new Point(919, 72);
            deliveryDate.Name = "deliveryDate";
            deliveryDate.Size = new Size(196, 30);
            deliveryDate.TabIndex = 7;
            // 
            // lblRequestDeliveryDate
            // 
            lblRequestDeliveryDate.AutoSize = true;
            lblRequestDeliveryDate.Location = new Point(708, 75);
            lblRequestDeliveryDate.Name = "lblRequestDeliveryDate";
            lblRequestDeliveryDate.Size = new Size(203, 23);
            lblRequestDeliveryDate.TabIndex = 6;
            lblRequestDeliveryDate.Text = "Request Delivery Date:";
            // 
            // labelCustomerID
            // 
            labelCustomerID.AutoSize = true;
            labelCustomerID.Location = new Point(93, 75);
            labelCustomerID.Name = "labelCustomerID";
            labelCustomerID.Size = new Size(154, 23);
            labelCustomerID.TabIndex = 4;
            labelCustomerID.Text = "Customer Name:";
            // 
            // OrderDate
            // 
            OrderDate.Location = new Point(917, 29);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(197, 30);
            OrderDate.TabIndex = 3;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(801, 32);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(110, 23);
            labelDate.TabIndex = 2;
            labelDate.Text = "Order Date:";
            // 
            // labelOrderID
            // 
            labelOrderID.AutoSize = true;
            labelOrderID.Location = new Point(166, 32);
            labelOrderID.Name = "labelOrderID";
            labelOrderID.Size = new Size(83, 23);
            labelOrderID.TabIndex = 1;
            labelOrderID.Text = "OrderID:";
            // 
            // tbOrderID
            // 
            tbOrderID.Location = new Point(255, 29);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.Size = new Size(329, 30);
            tbOrderID.TabIndex = 0;
            // 
            // FormOrderDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(labelOrderDetail);
            Controls.Add(plOrderDetail);
            Controls.Add(labelTitle);
            Name = "FormOrderDetail";
            Text = "Order";
            Load += FormOrderDetail_Load;
            plOrderDetail.ResumeLayout(false);
            gbItem.ResumeLayout(false);
            gbItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            gbInformation.ResumeLayout(false);
            gbInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelOrderDetail;
        private Panel plOrderDetail;
        private GroupBox gbInformation;
        private Label labelOrderID;
        private TextBox tbOrderID;
        private DateTimePicker deliveryDate;
        private Label lblRequestDeliveryDate;
        private Label labelCustomerID;
        private DateTimePicker OrderDate;
        private Label labelDate;
        private ComboBox cbStatus;
        private Label lblstatus;
        private TextBox tbAddress;
        private Label labelDeliveryAddress;
        private GroupBox gbItem;
        private ComboBox comboBoxProductIDName;
        private Label labelProductIDName;
        private Label labelQuantity;
        private TextBox textBoxUnitPrice;
        private Label label3UnitPrice;
        private DataGridView dgvOrderItems;
        private Button buttonAddItem;
        private NumericUpDown numericUpDownQuantity;
        private Button buttonSaveOrder;
        private TextBox tbTotal;
        private Label labelTotalAmount;
        private Button buttonCancel;
        private ComboBox cmbCustName;
    }
}
