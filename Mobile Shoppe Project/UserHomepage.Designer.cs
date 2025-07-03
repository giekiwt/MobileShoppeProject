namespace Mobile_Shoppe_Project
{
    partial class UserHomepage
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
            btnLogout = new Button();
            btnSearchByIMEI = new Button();
            btnViewStock = new Button();
            btnSales = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(191, 233);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 81);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSearchByIMEI
            // 
            btnSearchByIMEI.Location = new Point(12, 233);
            btnSearchByIMEI.Name = "btnSearchByIMEI";
            btnSearchByIMEI.Size = new Size(142, 81);
            btnSearchByIMEI.TabIndex = 12;
            btnSearchByIMEI.Text = "Tìm kiếm theo IMEI";
            btnSearchByIMEI.UseVisualStyleBackColor = true;
            btnSearchByIMEI.Click += btnSearchByIMEI_Click;
            // 
            // btnViewStock
            // 
            btnViewStock.Location = new Point(191, 120);
            btnViewStock.Name = "btnViewStock";
            btnViewStock.Size = new Size(142, 81);
            btnViewStock.TabIndex = 11;
            btnViewStock.Text = "Xem tồn kho";
            btnViewStock.UseVisualStyleBackColor = true;
            btnViewStock.Click += btnViewStock_Click;
            // 
            // btnSales
            // 
            btnSales.Location = new Point(12, 120);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(142, 81);
            btnSales.TabIndex = 10;
            btnSales.Text = "Bán hàng";
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(4, 77);
            label2.Name = "label2";
            label2.Size = new Size(386, 21);
            label2.TabIndex = 15;
            label2.Text = "Vui lòng chọn chức năng mà bạn muốn sử dụng !";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(84, 18);
            label1.Name = "label1";
            label1.Size = new Size(669, 47);
            label1.TabIndex = 14;
            label1.Text = "TRANG NGƯỜI DÙNG MOBILE SHOPEE";
            // 
            // UserHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.homepage;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnSearchByIMEI);
            Controls.Add(btnViewStock);
            Controls.Add(btnSales);
            Name = "UserHomepage";
            Text = "UserHomepage";
            Load += UserHomepage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Button btnSearchByIMEI;
        private Button btnViewStock;
        private Button btnSales;
        private Label label2;
        private Label label1;
    }
}