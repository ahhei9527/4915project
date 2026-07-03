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
            lblOrder.Location = new Point(520, 262);
            lblOrder.Margin = new Padding(5, 0, 5, 0);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(83, 23);
            lblOrder.TabIndex = 0;
            lblOrder.Text = "OrderID:";
            // 
            // cmbOrderID
            // 
            cmbOrderID.FormattingEnabled = true;
            cmbOrderID.Location = new Point(610, 254);
            cmbOrderID.Margin = new Padding(5, 5, 5, 5);
            cmbOrderID.Name = "cmbOrderID";
            cmbOrderID.Size = new Size(188, 31);
            cmbOrderID.TabIndex = 1;
            // 
            // cmbSN
            // 
            cmbSN.FormattingEnabled = true;
            cmbSN.Location = new Point(610, 305);
            cmbSN.Margin = new Padding(5, 5, 5, 5);
            cmbSN.Name = "cmbSN";
            cmbSN.Size = new Size(188, 31);
            cmbSN.TabIndex = 3;
            cmbSN.SelectedIndexChanged += cmbSN_SelectedIndexChanged;
            // 
            // lblSN
            // 
            lblSN.AutoSize = true;
            lblSN.Location = new Point(565, 313);
            lblSN.Margin = new Padding(5, 0, 5, 0);
            lblSN.Name = "lblSN";
            lblSN.Size = new Size(39, 23);
            lblSN.TabIndex = 2;
            lblSN.Text = "SN:";
            // 
            // lblBatch
            // 
            lblBatch.AutoSize = true;
            lblBatch.Location = new Point(542, 360);
            lblBatch.Margin = new Padding(5, 0, 5, 0);
            lblBatch.Name = "lblBatch";
            lblBatch.Size = new Size(62, 23);
            lblBatch.TabIndex = 4;
            lblBatch.Text = "Batch:";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(522, 413);
            lblProduct.Margin = new Padding(5, 0, 5, 0);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(81, 23);
            lblProduct.TabIndex = 6;
            lblProduct.Text = "Product:";
            // 
            // tbBatch
            // 
            tbBatch.Location = new Point(610, 357);
            tbBatch.Margin = new Padding(5, 5, 5, 5);
            tbBatch.Name = "tbBatch";
            tbBatch.Size = new Size(188, 30);
            tbBatch.TabIndex = 7;
            // 
            // tbProduct
            // 
            tbProduct.Location = new Point(610, 406);
            tbProduct.Margin = new Padding(5, 5, 5, 5);
            tbProduct.Name = "tbProduct";
            tbProduct.Size = new Size(188, 30);
            tbProduct.TabIndex = 8;
            // 
            // btSave
            // 
            btSave.Location = new Point(528, 565);
            btSave.Margin = new Padding(5, 5, 5, 5);
            btSave.Name = "btSave";
            btSave.Size = new Size(118, 35);
            btSave.TabIndex = 9;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(680, 565);
            btClose.Margin = new Padding(5, 5, 5, 5);
            btClose.Name = "btClose";
            btClose.Size = new Size(118, 35);
            btClose.TabIndex = 10;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // lblProductionDate
            // 
            lblProductionDate.AutoSize = true;
            lblProductionDate.Location = new Point(455, 457);
            lblProductionDate.Margin = new Padding(5, 0, 5, 0);
            lblProductionDate.Name = "lblProductionDate";
            lblProductionDate.Size = new Size(149, 23);
            lblProductionDate.TabIndex = 11;
            lblProductionDate.Text = "ProductionDate:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(610, 451);
            dateTimePicker1.Margin = new Padding(5, 5, 5, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 30);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(610, 500);
            dateTimePicker2.Margin = new Padding(5, 5, 5, 5);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(188, 30);
            dateTimePicker2.TabIndex = 14;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(517, 506);
            lblEndDate.Margin = new Padding(5, 0, 5, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(87, 23);
            lblEndDate.TabIndex = 13;
            lblEndDate.Text = "EndDate:";
            // 
            // LinkSNtoOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
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
            Margin = new Padding(5, 5, 5, 5);
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