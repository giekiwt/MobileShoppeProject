namespace Mobile_Shoppe_Project
{
    partial class RoleSelectionForm
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
            btnUserLogin = new Button();
            btnAdminLogin = new Button();
            label3 = new Label();
            label1 = new Label();
            btnGioiThieu = new Button();
            SuspendLayout();
            // 
            // btnUserLogin
            // 
            btnUserLogin.Location = new Point(171, 142);
            btnUserLogin.Name = "btnUserLogin";
            btnUserLogin.Size = new Size(178, 109);
            btnUserLogin.TabIndex = 0;
            btnUserLogin.Text = "Đăng nhập Nhân viên";
            btnUserLogin.UseVisualStyleBackColor = true;
            btnUserLogin.Click += btnUserLogin_Click;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.Location = new Point(370, 142);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(178, 109);
            btnAdminLogin.TabIndex = 1;
            btnAdminLogin.Text = "Đăng nhập Admin";
            btnAdminLogin.UseVisualStyleBackColor = true;
            btnAdminLogin.Click += btnAdminLogin_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(695, 47);
            label3.TabIndex = 23;
            label3.Text = "WELCOME TO MOBILE SHOPEE PROJECT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(110, 85);
            label1.Name = "label1";
            label1.Size = new Size(521, 25);
            label1.TabIndex = 24;
            label1.Text = "Chọn cách thức đăng nhập. Bạn là Nhân viên hay Admin ?";
            // 
            // btnGioiThieu
            // 
            btnGioiThieu.Location = new Point(270, 260);
            btnGioiThieu.Name = "btnGioiThieu";
            btnGioiThieu.Size = new Size(178, 40);
            btnGioiThieu.TabIndex = 2;
            btnGioiThieu.Text = "Giới thiệu nhóm";
            btnGioiThieu.UseVisualStyleBackColor = true;
            btnGioiThieu.Click += btnGioiThieu_Click;
            // 
            // RoleSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 323);
            Controls.Add(btnGioiThieu);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnAdminLogin);
            Controls.Add(btnUserLogin);
            Name = "RoleSelectionForm";
            Text = "RoleSelectionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUserLogin;
        private Button btnAdminLogin;
        private Label label3;
        private Label label1;
        private Button btnGioiThieu;
    }
}