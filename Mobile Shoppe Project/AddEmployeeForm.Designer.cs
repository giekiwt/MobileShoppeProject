namespace Mobile_Shoppe_Project
{
    partial class AddEmployeeForm
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
            label6 = new Label();
            txtHint = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtRePassword = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtMobile = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtAddress = new TextBox();
            txtEmployeeName = new TextBox();
            btnAddEmployee = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(183, 385);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 32;
            label6.Text = "Hint:";
            // 
            // txtHint
            // 
            txtHint.Location = new Point(268, 377);
            txtHint.Name = "txtHint";
            txtHint.Size = new Size(401, 23);
            txtHint.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(183, 335);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 30;
            label7.Text = "RePassword:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(186, 285);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 29;
            label8.Text = "Password:";
            // 
            // txtRePassword
            // 
            txtRePassword.Location = new Point(268, 327);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.PasswordChar = '*';
            txtRePassword.Size = new Size(401, 23);
            txtRePassword.TabIndex = 28;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(268, 277);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(401, 23);
            txtPassword.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 235);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 26;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 182);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 25;
            label4.Text = "Số điện thoại:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(268, 227);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(401, 23);
            txtUsername.TabIndex = 24;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(268, 174);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(401, 23);
            txtMobile.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 127);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 22;
            label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 77);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 21;
            label1.Text = "Tên nhân viên";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(268, 119);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(401, 23);
            txtAddress.TabIndex = 20;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(268, 69);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(401, 23);
            txtEmployeeName.TabIndex = 19;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(348, 406);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(158, 32);
            btnAddEmployee.TabIndex = 33;
            btnAddEmployee.Text = "Thêm nhân viên";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(268, 9);
            label5.Name = "label5";
            label5.Size = new Size(330, 47);
            label5.TabIndex = 34;
            label5.Text = "THÊM NHÂN VIÊN";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnAddEmployee);
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
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtHint;
        private Label label7;
        private Label label8;
        private TextBox txtRePassword;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtMobile;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtEmployeeName;
        private Button btnAddEmployee;
        private Label label5;
    }
}