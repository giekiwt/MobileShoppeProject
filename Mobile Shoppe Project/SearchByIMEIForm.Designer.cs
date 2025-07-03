namespace Mobile_Shoppe_Project
{
    partial class SearchByIMEIForm
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
            txtIMEI = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            dgvCustomerInfo = new DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInfo).BeginInit();
            SuspendLayout();
            // 
            // txtIMEI
            // 
            txtIMEI.Location = new Point(109, 153);
            txtIMEI.Name = "txtIMEI";
            txtIMEI.Size = new Size(264, 23);
            txtIMEI.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 156);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Nhập số IMEI";
            label1.Click += label1_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(397, 144);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 39);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvCustomerInfo
            // 
            dgvCustomerInfo.BackgroundColor = Color.FromArgb(255, 224, 192);
            dgvCustomerInfo.BorderStyle = BorderStyle.Fixed3D;
            dgvCustomerInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerInfo.Location = new Point(12, 192);
            dgvCustomerInfo.Name = "dgvCustomerInfo";
            dgvCustomerInfo.Size = new Size(776, 246);
            dgvCustomerInfo.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(177, 18);
            label8.Name = "label8";
            label8.Size = new Size(408, 47);
            label8.TabIndex = 23;
            label8.Text = "NHẬP IMEI SẢN PHẨM";
            // 
            // SearchByIMEIForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(dgvCustomerInfo);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtIMEI);
            Name = "SearchByIMEIForm";
            Text = "SearchByIMEIForm";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIMEI;
        private Label label1;
        private Button btnSearch;
        private DataGridView dgvCustomerInfo;
        private Label label8;
    }
}