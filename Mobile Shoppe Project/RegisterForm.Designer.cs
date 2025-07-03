namespace Mobile_Shoppe_Project
{
    partial class RegisterForm
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
            label2 = new Label();
            label1 = new Label();
            txtAddress = new TextBox();
            txtEmployeeName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtMobile = new TextBox();
            label6 = new Label();
            txtHint = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtRePassword = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 76);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 7;
            label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 6;
            label1.Text = "Họ tên:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(142, 68);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(267, 23);
            txtAddress.TabIndex = 5;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(142, 18);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(267, 23);
            txtEmployeeName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 184);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 11;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 131);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 10;
            label4.Text = "Số điện thoại:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(142, 176);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(267, 23);
            txtUsername.TabIndex = 9;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(142, 123);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(267, 23);
            txtMobile.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 334);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 18;
            label6.Text = "Hint:";
            // 
            // txtHint
            // 
            txtHint.Location = new Point(142, 326);
            txtHint.Name = "txtHint";
            txtHint.Size = new Size(267, 23);
            txtHint.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 284);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 15;
            label7.Text = "RePassword:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 234);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 14;
            label8.Text = "Password:";
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(142, 276);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.PasswordChar = '*';
            txtRePassword.Size = new Size(267, 23);
            txtRePassword.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(142, 226);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(267, 23);
            txtPassword.TabIndex = 12;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(186, 373);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(115, 48);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(txtHint);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtRePassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(txtMobile);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtEmployeeName);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtEmployeeName;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtMobile;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox txtHint;
        private Label label7;
        private Label label8;
        private TextBox txtRePassword;
        private TextBox txtPassword;
        private Button btnRegister;
    }
}