namespace Mobile_Shoppe_Project
{
    partial class SalesReportForm
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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSearch = new Button();
            dgvSalesReport = new DataGridView();
            txtTotalAmount = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).BeginInit();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(280, 88);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(280, 132);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 96);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 138);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 3;
            label2.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 214);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Tổng tiền";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(280, 161);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(97, 39);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvSalesReport
            // 
            dgvSalesReport.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReport.Location = new Point(12, 240);
            dgvSalesReport.Name = "dgvSalesReport";
            dgvSalesReport.Size = new Size(776, 198);
            dgvSalesReport.TabIndex = 6;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(88, 211);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(150, 23);
            txtTotalAmount.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(204, 9);
            label8.Name = "label8";
            label8.Size = new Size(384, 47);
            label8.TabIndex = 23;
            label8.Text = "BÁO CÁO ĐƠN HÀNG";
            // 
            // SalesReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(txtTotalAmount);
            Controls.Add(dgvSalesReport);
            Controls.Add(btnSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Name = "SalesReportForm";
            Text = "SalesReportForm";
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSearch;
        private DataGridView dgvSalesReport;
        private TextBox txtTotalAmount;
        private Label label8;
    }
}