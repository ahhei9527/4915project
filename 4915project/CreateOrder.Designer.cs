namespace ITP4915M
{
    partial class FormOrdelDetail
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
            labelTitle.Location = new Point(18, 12);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(509, 30);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Premium Living Centralized Manage System";
            // 
            // labelOrderDetail
            // 
            labelOrderDetail.AutoSize = true;
            labelOrderDetail.FlatStyle = FlatStyle.Flat;
            labelOrderDetail.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labelOrderDetail.Location = new Point(28, 48);
            labelOrderDetail.Margin = new Padding(2, 0, 2, 0);
            labelOrderDetail.Name = "labelOrderDetail";
            labelOrderDetail.Size = new Size(101, 20);
            labelOrderDetail.TabIndex = 12;
            labelOrderDetail.Text = "Order Detail";
            // 
            // plOrderDetail
            // 
            plOrderDetail.BorderStyle = BorderStyle.FixedSingle;
            plOrderDetail.Controls.Add(gbItem);
            plOrderDetail.Controls.Add(gbInformation);
            plOrderDetail.Location = new Point(18, 61);
            plOrderDetail.Margin = new Padding(2);
            plOrderDetail.Name = "plOrderDetail";
            plOrderDetail.Size = new Size(689, 470);
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
            labelTotalAmount.Location = new Point(448, 246);
            labelTotalAmount.Margin = new Padding(2, 0, 2, 0);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(115, 15);
            labelTotalAmount.TabIndex = 8;
            labelTotalAmount.Text = "Total Amount: HKD";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(10, 72);
            dgvOrderItems.Margin = new Padding(2);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 62;
            dgvOrderItems.Size = new Size(646, 157);
            dgvOrderItems.TabIndex = 7;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Location = new Point(585, 46);
            buttonAddItem.Margin = new Padding(2);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(71, 22);
            buttonAddItem.TabIndex = 6;
            buttonAddItem.Text = "Add Item";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(542, 15);
            numericUpDownQuantity.Margin = new Padding(2);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(115, 23);
            numericUpDownQuantity.TabIndex = 5;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(482, 17);
            labelQuantity.Margin = new Padding(2, 0, 2, 0);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(58, 15);
            labelQuantity.TabIndex = 4;
            labelQuantity.Text = "Quantity:";
            // 
            // textBoxUnitPrice
            // 
            textBoxUnitPrice.Location = new Point(373, 12);
            textBoxUnitPrice.Margin = new Padding(2);
            textBoxUnitPrice.Name = "textBoxUnitPrice";
            textBoxUnitPrice.ReadOnly = true;
            textBoxUnitPrice.Size = new Size(97, 23);
            textBoxUnitPrice.TabIndex = 3;
            // 
            // label3UnitPrice
            // 
            label3UnitPrice.AutoSize = true;
            label3UnitPrice.Location = new Point(278, 15);
            label3UnitPrice.Margin = new Padding(2, 0, 2, 0);
            label3UnitPrice.Name = "label3UnitPrice";
            label3UnitPrice.Size = new Size(91, 15);
            label3UnitPrice.TabIndex = 2;
            label3UnitPrice.Text = "Unit Price: HKD";
            // 
            // comboBoxProductIDName
            // 
            comboBoxProductIDName.FormattingEnabled = true;
            comboBoxProductIDName.Location = new Point(126, 15);
            comboBoxProductIDName.Margin = new Padding(2);
            comboBoxProductIDName.Name = "comboBoxProductIDName";
            comboBoxProductIDName.Size = new Size(117, 23);
            comboBoxProductIDName.TabIndex = 1;
            comboBoxProductIDName.SelectedIndexChanged += comboBoxProductIDName_SelectedIndexChanged;
            // 
            // labelProductIDName
            // 
            labelProductIDName.AutoSize = true;
            labelProductIDName.Location = new Point(11, 17);
            labelProductIDName.Margin = new Padding(2, 0, 2, 0);
            labelProductIDName.Name = "labelProductIDName";
            labelProductIDName.Size = new Size(115, 15);
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
            gbInformation.Location = new Point(11, 8);
            gbInformation.Margin = new Padding(2);
            gbInformation.Name = "gbInformation";
            gbInformation.Padding = new Padding(2);
            gbInformation.Size = new Size(664, 123);
            gbInformation.TabIndex = 0;
            gbInformation.TabStop = false;
            gbInformation.Text = "Order Header - Basic Order Information";
            // 
            // cmbCustName
            // 
            cmbCustName.FormattingEnabled = true;
            cmbCustName.Location = new Point(118, 49);
            cmbCustName.Name = "cmbCustName";
            cmbCustName.Size = new Size(160, 23);
            cmbCustName.TabIndex = 12;
            cmbCustName.SelectedIndexChanged += cmbCustName_SelectedIndexChanged;
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
            lblstatus.Location = new Point(410, 78);
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
            labelDeliveryAddress.Location = new Point(11, 83);
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
            // 
            // lblRequestDeliveryDate
            // 
            lblRequestDeliveryDate.AutoSize = true;
            lblRequestDeliveryDate.Location = new Point(318, 47);
            lblRequestDeliveryDate.Margin = new Padding(2, 0, 2, 0);
            lblRequestDeliveryDate.Name = "lblRequestDeliveryDate";
            lblRequestDeliveryDate.Size = new Size(134, 15);
            lblRequestDeliveryDate.TabIndex = 6;
            lblRequestDeliveryDate.Text = "Request Delivery Date:";
            // 
            // labelCustomerID
            // 
            labelCustomerID.AutoSize = true;
            labelCustomerID.Location = new Point(11, 49);
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
            labelDate.Location = new Point(381, 19);
            labelDate.Margin = new Padding(2, 0, 2, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(73, 15);
            labelDate.TabIndex = 2;
            labelDate.Text = "Order Date:";
            // 
            // labelOrderID
            // 
            labelOrderID.AutoSize = true;
            labelOrderID.Location = new Point(11, 21);
            labelOrderID.Margin = new Padding(2, 0, 2, 0);
            labelOrderID.Name = "labelOrderID";
            labelOrderID.Size = new Size(55, 15);
            labelOrderID.TabIndex = 1;
            labelOrderID.Text = "OrderID:";
            // 
            // tbOrderID
            // 
            tbOrderID.Location = new Point(67, 19);
            tbOrderID.Margin = new Padding(2);
            tbOrderID.Name = "tbOrderID";
            tbOrderID.Size = new Size(211, 23);
            tbOrderID.TabIndex = 0;
            // 
            // FormOrdelDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 554);
            Controls.Add(labelOrderDetail);
            Controls.Add(plOrderDetail);
            Controls.Add(labelTitle);
            Margin = new Padding(2);
            Name = "FormOrdelDetail";
            Text = "Order";
            Load += FormOrdelDetail_Load;
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