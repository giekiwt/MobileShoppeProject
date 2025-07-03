namespace Mobile_Shoppe_Project
{
    partial class ForgotPassword
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
            txtUsername = new TextBox();
            txtHint = new TextBox();
            btnGetPassword = new Button();
            lblPasswordResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(200, 98);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(289, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtHint
            // 
            txtHint.Location = new Point(200, 162);
            txtHint.Name = "txtHint";
            txtHint.Size = new Size(289, 23);
            txtHint.TabIndex = 1;
            // 
            // btnGetPassword
            // 
            btnGetPassword.Location = new Point(200, 214);
            btnGetPassword.Name = "btnGetPassword";
            btnGetPassword.Size = new Size(112, 50);
            btnGetPassword.TabIndex = 2;
            btnGetPassword.Text = "Lấy lại mật khẩu";
            btnGetPassword.UseVisualStyleBackColor = true;
            btnGetPassword.Click += btnGetPassword_Click;
            // 
            // lblPasswordResult
            // 
            lblPasswordResult.AutoSize = true;
            lblPasswordResult.Location = new Point(112, 301);
            lblPasswordResult.Name = "lblPasswordResult";
            lblPasswordResult.Size = new Size(172, 15);
            lblPasswordResult.TabIndex = 3;
            lblPasswordResult.Text = "Hiển thị mật khẩu nếu tìm thấy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 101);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 170);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Hint";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(187, 20);
            label3.Name = "label3";
            label3.Size = new Size(344, 47);
            label3.TabIndex = 22;
            label3.Text = "QUÊN MẬT KHẨU ?";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPasswordResult);
            Controls.Add(btnGetPassword);
            Controls.Add(txtHint);
            Controls.Add(txtUsername);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtHint;
        private Button btnGetPassword;
        private Label lblPasswordResult;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}