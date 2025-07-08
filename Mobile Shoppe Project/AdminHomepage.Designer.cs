namespace Mobile_Shoppe_Project
{
    partial class AdminHomepage
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
            btnSalesReport = new Button();
            btnAddEmployee = new Button();
            btnUpdateStock = new Button();
            btnAddMobile = new Button();
            btnAddModel = new Button();
            btnAddCompany = new Button();
            label1 = new Label();
            label2 = new Label();
            btnDaySalesReport = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnSalesReport
            // 
            btnSalesReport.Location = new Point(233, 476);
            btnSalesReport.Margin = new Padding(3, 4, 3, 4);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(162, 108);
            btnSalesReport.TabIndex = 11;
            btnSalesReport.Text = "Báo cáo theo Date to Date";
            btnSalesReport.UseVisualStyleBackColor = true;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(14, 476);
            btnAddEmployee.Margin = new Padding(3, 4, 3, 4);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(162, 108);
            btnAddEmployee.TabIndex = 10;
            btnAddEmployee.Text = "Thêm nhân viên";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(233, 319);
            btnUpdateStock.Margin = new Padding(3, 4, 3, 4);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(162, 108);
            btnUpdateStock.TabIndex = 9;
            btnUpdateStock.Text = "Nhập kho";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // btnAddMobile
            // 
            btnAddMobile.Location = new Point(14, 319);
            btnAddMobile.Margin = new Padding(3, 4, 3, 4);
            btnAddMobile.Name = "btnAddMobile";
            btnAddMobile.Size = new Size(162, 108);
            btnAddMobile.TabIndex = 8;
            btnAddMobile.Text = "Thêm điện thoại";
            btnAddMobile.UseVisualStyleBackColor = true;
            btnAddMobile.Click += btnAddMobile_Click;
            // 
            // btnAddModel
            // 
            btnAddModel.Location = new Point(233, 175);
            btnAddModel.Margin = new Padding(3, 4, 3, 4);
            btnAddModel.Name = "btnAddModel";
            btnAddModel.Size = new Size(162, 108);
            btnAddModel.TabIndex = 7;
            btnAddModel.Text = "Thêm model";
            btnAddModel.UseVisualStyleBackColor = true;
            btnAddModel.Click += btnAddModel_Click;
            // 
            // btnAddCompany
            // 
            btnAddCompany.Location = new Point(14, 175);
            btnAddCompany.Margin = new Padding(3, 4, 3, 4);
            btnAddCompany.Name = "btnAddCompany";
            btnAddCompany.Size = new Size(162, 108);
            btnAddCompany.TabIndex = 6;
            btnAddCompany.Text = "Thêm công ty";
            btnAddCompany.UseVisualStyleBackColor = true;
            btnAddCompany.Click += btnAddCompany_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(126, 12);
            label1.Name = "label1";
            label1.Size = new Size(753, 60);
            label1.TabIndex = 12;
            label1.Text = "TRANG QUẢN TRỊ MOBILE SHOPEE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(14, 103);
            label2.Name = "label2";
            label2.Size = new Size(477, 28);
            label2.TabIndex = 13;
            label2.Text = "Vui lòng chọn chức năng mà bạn muốn sử dụng !";
            // 
            // btnDaySalesReport
            // 
            btnDaySalesReport.Location = new Point(452, 476);
            btnDaySalesReport.Margin = new Padding(3, 4, 3, 4);
            btnDaySalesReport.Name = "btnDaySalesReport";
            btnDaySalesReport.Size = new Size(162, 108);
            btnDaySalesReport.TabIndex = 14;
            btnDaySalesReport.Text = "Báo cáo theo Day";
            btnDaySalesReport.UseVisualStyleBackColor = true;
            btnDaySalesReport.Click += btnDaySalesReport_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(669, 490);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 81);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminHomepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.homepage;
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalesReport);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnUpdateStock);
            Controls.Add(btnAddMobile);
            Controls.Add(btnAddModel);
            Controls.Add(btnAddCompany);
            Controls.Add(btnDaySalesReport);
            Controls.Add(btnLogout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminHomepage";
            Text = "AdminHomepage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalesReport;
        private Button btnAddEmployee;
        private Button btnUpdateStock;
        private Button btnAddMobile;
        private Button btnAddModel;
        private Button btnAddCompany;
        private Label label1;
        private Label label2;
        private Button btnDaySalesReport;
        private Button btnLogout;
    }
}