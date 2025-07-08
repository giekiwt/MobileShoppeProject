namespace Mobile_Shoppe_Project
{
    partial class AdminLogin
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
            btnBack = new Button();
            linkForgotPassword = new LinkLabel();
            btnAdminLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtAdminPass = new TextBox();
            txtAdminUser = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(440, 353);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(126, 52);
            btnBack.TabIndex = 13;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Location = new Point(464, 325);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(102, 15);
            linkForgotPassword.TabIndex = 12;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forget password ?";
            linkForgotPassword.LinkClicked += linkForgotPassword_LinkClicked;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.Location = new Point(308, 353);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(126, 52);
            btnAdminLogin.TabIndex = 11;
            btnAdminLogin.Text = "Đăng nhập";
            btnAdminLogin.UseVisualStyleBackColor = true;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 294);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 236);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 9;
            label1.Text = "Username:";
            // 
            // txtAdminPass
            // 
            txtAdminPass.Location = new Point(225, 283);
            txtAdminPass.Name = "txtAdminPass";
            txtAdminPass.PasswordChar = '*';
            txtAdminPass.Size = new Size(345, 23);
            txtAdminPass.TabIndex = 8;
            // 
            // txtAdminUser
            // 
            txtAdminUser.Location = new Point(225, 233);
            txtAdminUser.Name = "txtAdminUser";
            txtAdminUser.Size = new Size(345, 23);
            txtAdminUser.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(222, 9);
            label3.Name = "label3";
            label3.Size = new Size(370, 47);
            label3.TabIndex = 14;
            label3.Text = "ĐĂNG NHẬP ADMIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avt;
            pictureBox1.Location = new Point(308, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(linkForgotPassword);
            Controls.Add(btnAdminLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAdminPass);
            Controls.Add(txtAdminUser);
            Name = "AdminLogin";
            Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private LinkLabel linkForgotPassword;
        private Button btnAdminLogin;
        private Label label2;
        private Label label1;
        private TextBox txtAdminPass;
        private TextBox txtAdminUser;
        private Label label3;
        private PictureBox pictureBox1;
    }
}