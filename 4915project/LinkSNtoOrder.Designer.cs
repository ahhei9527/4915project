namespace _4915project
{
    partial class LinkSNtoOrder
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
            lblOrder = new Label();
            cmbOrderID = new ComboBox();
            cmbSN = new ComboBox();
            lblSN = new Label();
            lblBatch = new Label();
            lblProduct = new Label();
            tbBatch = new TextBox();
            tbProduct = new TextBox();
            btSave = new Button();
            btClose = new Button();
            lblProductionDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            lblEndDate = new Label();
            SuspendLayout();
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Location = new Point(49, 43);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(52, 15);
            lblOrder.TabIndex = 0;
            lblOrder.Text = "OrderID";
            // 
            // cmbOrderID
            // 
            cmbOrderID.FormattingEnabled = true;
            cmbOrderID.Location = new Point(107, 40);
            cmbOrderID.Name = "cmbOrderID";
            cmbOrderID.Size = new Size(121, 23);
            cmbOrderID.TabIndex = 1;
            // 
            // cmbSN
            // 
            cmbSN.FormattingEnabled = true;
            cmbSN.Location = new Point(336, 40);
            cmbSN.Name = "cmbSN";
            cmbSN.Size = new Size(121, 23);
            cmbSN.TabIndex = 3;
            cmbSN.SelectedIndexChanged += cmbSN_SelectedIndexChanged;
            // 
            // lblSN
            // 
            lblSN.AutoSize = true;
            lblSN.Location = new Point(306, 43);
            lblSN.Name = "lblSN";
            lblSN.Size = new Size(24, 15);
            lblSN.TabIndex = 2;
            lblSN.Text = "SN";
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Location = new Point(63, 86);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new Size(38, 15);
            lblBatch.TabIndex = 4;
            lblBatch.Text = "Batch";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(278, 89);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(51, 15);
            lblProduct.TabIndex = 6;
            lblProduct.Text = "Product";
            // 
            // tbBatch
            // 
            tbBatch.Location = new Point(107, 81);
            tbBatch.Name = "tbBatch";
            tbBatch.Size = new Size(121, 23);
            tbBatch.TabIndex = 7;
            // 
            // tbProduct
            // 
            tbProduct.Location = new Point(336, 83);
            tbProduct.Name = "tbProduct";
            tbProduct.Size = new Size(121, 23);
            tbProduct.TabIndex = 8;
            // 
            // btSave
            // 
            btSave.Location = new Point(360, 165);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 9;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(49, 165);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 23);
            btClose.TabIndex = 10;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // lblProductionDate
            // 
            lblProductionDate.AutoSize = true;
            lblProductionDate.Location = new Point(5, 129);
            lblProductionDate.Name = "lblProductionDate";
            lblProductionDate.Size = new Size(96, 15);
            lblProductionDate.TabIndex = 11;
            lblProductionDate.Text = "ProductionDate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(107, 123);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(336, 123);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(121, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(273, 129);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(56, 15);
            lblEndDate.TabIndex = 13;
            lblEndDate.Text = "EndDate";
            // 
            // LinkSNtoOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 214);
            Controls.Add(dateTimePicker2);
            Controls.Add(lblEndDate);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblProductionDate);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(tbProduct);
            Controls.Add(tbBatch);
            Controls.Add(lblProduct);
            Controls.Add(lblBatch);
            Controls.Add(cmbSN);
            Controls.Add(lblSN);
            Controls.Add(cmbOrderID);
            Controls.Add(lblOrder);
            Name = "LinkSNtoOrder";
            Text = "Link SN to Order";
            Load += LinkSNtoOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrder;
        private ComboBox cmbOrderID;
        private ComboBox cmbSN;
        private Label lblSN;
        private Label lblBatch;
        private Label lblProduct;
        private TextBox tbBatch;
        private TextBox tbProduct;
        private Button btSave;
        private Button btClose;
        private Label lblProductionDate;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label lblEndDate;
    }
}