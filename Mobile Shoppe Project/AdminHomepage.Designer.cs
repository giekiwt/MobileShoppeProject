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
            SuspendLayout();
            // 
            // btnSalesReport
            // 
            btnSalesReport.Location = new Point(204, 357);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(142, 81);
            btnSalesReport.TabIndex = 11;
            btnSalesReport.Text = "Xem báo cáo bán hàng";
            btnSalesReport.UseVisualStyleBackColor = true;
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(12, 357);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(142, 81);
            btnAddEmployee.TabIndex = 10;
            btnAddEmployee.Text = "Thêm nhân viên";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(204, 239);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(142, 81);
            btnUpdateStock.TabIndex = 9;
            btnUpdateStock.Text = "Nhập kho";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // btnAddMobile
            // 
            btnAddMobile.Location = new Point(12, 239);
            btnAddMobile.Name = "btnAddMobile";
            btnAddMobile.Size = new Size(142, 81);
            btnAddMobile.TabIndex = 8;
            btnAddMobile.Text = "Thêm điện thoại";
            btnAddMobile.UseVisualStyleBackColor = true;
            btnAddMobile.Click += btnAddMobile_Click;
            // 
            // btnAddModel
            // 
            btnAddModel.Location = new Point(204, 131);
            btnAddModel.Name = "btnAddModel";
            btnAddModel.Size = new Size(142, 81);
            btnAddModel.TabIndex = 7;
            btnAddModel.Text = "Thêm model";
            btnAddModel.UseVisualStyleBackColor = true;
            btnAddModel.Click += btnAddModel_Click;
            // 
            // btnAddCompany
            // 
            btnAddCompany.Location = new Point(12, 131);
            btnAddCompany.Name = "btnAddCompany";
            btnAddCompany.Size = new Size(142, 81);
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
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(607, 47);
            label1.TabIndex = 12;
            label1.Text = "TRANG QUẢN TRỊ MOBILE SHOPEE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(386, 21);
            label2.TabIndex = 13;
            label2.Text = "Vui lòng chọn chức năng mà bạn muốn sử dụng !";
            // 
            // AdminHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.homepage;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalesReport);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnUpdateStock);
            Controls.Add(btnAddMobile);
            Controls.Add(btnAddModel);
            Controls.Add(btnAddCompany);
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
    }
}