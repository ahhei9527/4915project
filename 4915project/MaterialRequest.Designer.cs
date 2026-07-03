namespace _4915project
{
    partial class MaterialRequest
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
            cmbMaterialName = new ComboBox();
            label3 = new Label();
            QuantityIssued = new NumericUpDown();
            label2 = new Label();
            QuantityApproved = new NumericUpDown();
            label1 = new Label();
            cmbRequestID = new ComboBox();
            cmbBatchID = new ComboBox();
            cmbRequestBy = new ComboBox();
            tbRequestItemID = new TextBox();
            cmbRequestStatus = new ComboBox();
            RequestByDate = new DateTimePicker();
            RequestDate = new DateTimePicker();
            QuantityRequested = new NumericUpDown();
            cmbUrgency = new ComboBox();
            btAdd = new Button();
            button10 = new Button();
            button8 = new Button();
            dataGridView2 = new DataGridView();
            label35 = new Label();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            ((System.ComponentModel.ISupportInitialize)QuantityIssued).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantityApproved).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantityRequested).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // cmbMaterialName
            // 
            cmbMaterialName.FormattingEnabled = true;
            cmbMaterialName.Location = new Point(546, 329);
            cmbMaterialName.Margin = new Padding(5);
            cmbMaterialName.Name = "cmbMaterialName";
            cmbMaterialName.Size = new Size(164, 31);
            cmbMaterialName.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 333);
            label3.Name = "label3";
            label3.Size = new Size(142, 23);
            label3.TabIndex = 71;
            label3.Text = "Material Name:";
            // 
            // QuantityIssued
            // 
            QuantityIssued.Location = new Point(767, 436);
            QuantityIssued.Name = "QuantityIssued";
            QuantityIssued.Size = new Size(115, 30);
            QuantityIssued.TabIndex = 70;
            QuantityIssued.ValueChanged += QuantityIssued_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(654, 439);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 69;
            label2.Text = "Qty Issued:";
            // 
            // QuantityApproved
            // 
            QuantityApproved.Location = new Point(515, 433);
            QuantityApproved.Name = "QuantityApproved";
            QuantityApproved.Size = new Size(115, 30);
            QuantityApproved.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 436);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 61;
            label1.Text = "Qty Approved:";
            // 
            // cmbRequestID
            // 
            cmbRequestID.FormattingEnabled = true;
            cmbRequestID.Location = new Point(355, 105);
            cmbRequestID.Margin = new Padding(5);
            cmbRequestID.Name = "cmbRequestID";
            cmbRequestID.Size = new Size(182, 31);
            cmbRequestID.TabIndex = 68;
            // 
            // cmbBatchID
            // 
            cmbBatchID.FormattingEnabled = true;
            cmbBatchID.Location = new Point(355, 149);
            cmbBatchID.Margin = new Padding(5);
            cmbBatchID.Name = "cmbBatchID";
            cmbBatchID.Size = new Size(181, 31);
            cmbBatchID.TabIndex = 67;
            // 
            // cmbRequestBy
            // 
            cmbRequestBy.FormattingEnabled = true;
            cmbRequestBy.Location = new Point(720, 144);
            cmbRequestBy.Margin = new Padding(5);
            cmbRequestBy.Name = "cmbRequestBy";
            cmbRequestBy.Size = new Size(188, 31);
            cmbRequestBy.TabIndex = 66;
            // 
            // tbRequestItemID
            // 
            tbRequestItemID.Location = new Point(546, 286);
            tbRequestItemID.Name = "tbRequestItemID";
            tbRequestItemID.Size = new Size(164, 30);
            tbRequestItemID.TabIndex = 65;
            // 
            // cmbRequestStatus
            // 
            cmbRequestStatus.FormattingEnabled = true;
            cmbRequestStatus.Location = new Point(355, 190);
            cmbRequestStatus.Name = "cmbRequestStatus";
            cmbRequestStatus.Size = new Size(182, 31);
            cmbRequestStatus.TabIndex = 64;
            // 
            // RequestByDate
            // 
            RequestByDate.Location = new Point(720, 191);
            RequestByDate.Name = "RequestByDate";
            RequestByDate.Size = new Size(193, 30);
            RequestByDate.TabIndex = 62;
            // 
            // RequestDate
            // 
            RequestDate.Location = new Point(720, 102);
            RequestDate.Name = "RequestDate";
            RequestDate.Size = new Size(193, 30);
            RequestDate.TabIndex = 60;
            // 
            // QuantityRequested
            // 
            QuantityRequested.Location = new Point(872, 288);
            QuantityRequested.Name = "QuantityRequested";
            QuantityRequested.Size = new Size(115, 30);
            QuantityRequested.TabIndex = 59;
            QuantityRequested.ValueChanged += QuantityRequested_ValueChanged;
            // 
            // cmbUrgency
            // 
            cmbUrgency.FormattingEnabled = true;
            cmbUrgency.Location = new Point(1011, 100);
            cmbUrgency.Name = "cmbUrgency";
            cmbUrgency.Size = new Size(182, 31);
            cmbUrgency.TabIndex = 58;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(919, 436);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(97, 35);
            btAdd.TabIndex = 57;
            btAdd.Text = "Add Item";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // button10
            // 
            button10.Location = new Point(683, 759);
            button10.Name = "button10";
            button10.Size = new Size(112, 34);
            button10.TabIndex = 56;
            button10.Text = "Clear";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button8
            // 
            button8.Location = new Point(514, 759);
            button8.Name = "button8";
            button8.Size = new Size(152, 34);
            button8.TabIndex = 55;
            button8.Text = "Save Request";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(91, 496);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1186, 225);
            dataGridView2.TabIndex = 54;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label35.Location = new Point(527, 383);
            label35.Name = "label35";
            label35.Size = new Size(349, 30);
            label35.TabIndex = 53;
            label35.Text = "Approval/Inventory Response";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(736, 291);
            label33.Name = "label33";
            label33.Size = new Size(140, 23);
            label33.TabIndex = 52;
            label33.Text = "Qty Requested:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(385, 290);
            label32.Name = "label32";
            label32.Size = new Size(151, 23);
            label32.TabIndex = 51;
            label32.Text = "Request Item ID:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label31.Location = new Point(546, 231);
            label31.Name = "label31";
            label31.Size = new Size(263, 30);
            label31.TabIndex = 50;
            label31.Text = "Matetial Request Item";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(560, 193);
            label30.Name = "label30";
            label30.Size = new Size(154, 23);
            label30.TabIndex = 49;
            label30.Text = "Request By Date:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(280, 197);
            label29.Name = "label29";
            label29.Size = new Size(67, 23);
            label29.TabIndex = 48;
            label29.Text = "Status:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(584, 149);
            label28.Name = "label28";
            label28.Size = new Size(129, 23);
            label28.TabIndex = 47;
            label28.Text = "Requested By:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(261, 152);
            label27.Name = "label27";
            label27.Size = new Size(86, 23);
            label27.TabIndex = 46;
            label27.Text = "Batch ID:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(921, 102);
            label26.Name = "label26";
            label26.Size = new Size(84, 23);
            label26.TabIndex = 45;
            label26.Text = "Urgency:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(584, 105);
            label25.Name = "label25";
            label25.Size = new Size(129, 23);
            label25.TabIndex = 44;
            label25.Text = "Request Date:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(242, 108);
            label24.Name = "label24";
            label24.Size = new Size(107, 23);
            label24.TabIndex = 43;
            label24.Text = "Request ID:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label23.Location = new Point(584, 60);
            label23.Name = "label23";
            label23.Size = new Size(195, 30);
            label23.TabIndex = 42;
            label23.Text = "Request Header";
            // 
            // MaterialRequest
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 860);
            Controls.Add(cmbMaterialName);
            Controls.Add(label3);
            Controls.Add(QuantityIssued);
            Controls.Add(label2);
            Controls.Add(QuantityApproved);
            Controls.Add(label1);
            Controls.Add(cmbRequestID);
            Controls.Add(cmbBatchID);
            Controls.Add(cmbRequestBy);
            Controls.Add(tbRequestItemID);
            Controls.Add(cmbRequestStatus);
            Controls.Add(RequestByDate);
            Controls.Add(RequestDate);
            Controls.Add(QuantityRequested);
            Controls.Add(cmbUrgency);
            Controls.Add(btAdd);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(dataGridView2);
            Controls.Add(label35);
            Controls.Add(label33);
            Controls.Add(label32);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Margin = new Padding(5);
            Name = "MaterialRequest";
            Text = "Material Request";
            Load += MaterialRequest_Load;
            ((System.ComponentModel.ISupportInitialize)QuantityIssued).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantityApproved).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantityRequested).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMaterialName;
        private Label label3;
        private NumericUpDown QuantityIssued;
        private Label label2;
        private NumericUpDown QuantityApproved;
        private Label label1;
        private ComboBox cmbRequestID;
        private ComboBox cmbBatchID;
        private ComboBox cmbRequestBy;
        private TextBox tbRequestItemID;
        private ComboBox cmbRequestStatus;
        private DateTimePicker RequestByDate;
        private DateTimePicker RequestDate;
        private NumericUpDown QuantityRequested;
        private ComboBox cmbUrgency;
        private Button btAdd;
        private Button button10;
        private Button button8;
        private DataGridView dataGridView2;
        private Label label35;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
    }
}