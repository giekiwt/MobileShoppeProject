namespace Mobile_Shoppe_Project
{
    partial class SalesForm
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
            txtCustomerName = new TextBox();
            txtEmail = new TextBox();
            txtPrice = new TextBox();
            txtAddress = new TextBox();
            txtMobileNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label222 = new Label();
            cbModel = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cbCompany = new ComboBox();
            cbIMEI = new ComboBox();
            btnSubmit = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(189, 59);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(229, 23);
            txtCustomerName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(189, 175);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(229, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(189, 117);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(229, 23);
            txtAddress.TabIndex = 3;
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Location = new Point(189, 88);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(229, 23);
            txtMobileNumber.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 67);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 5;
            label1.Text = "Tên khách hàng";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 91);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 6;
            label2.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 125);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 187);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 154);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 8;
            label5.Text = "Email ID";
            // 
            // label222
            // 
            label222.AutoSize = true;
            label222.Location = new Point(40, 269);
            label222.Name = "label222";
            label222.Size = new Size(77, 15);
            label222.TabIndex = 16;
            label222.Text = "Nhập số IMEI";
            // 
            // cbModel
            // 
            cbModel.FormattingEnabled = true;
            cbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModel.Location = new Point(189, 232);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(229, 23);
            cbModel.TabIndex = 15;
            cbModel.SelectedIndexChanged += cbModel_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 212);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 14;
            label6.Text = "Chọn công ty:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 240);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 13;
            label7.Text = "Nhập tên/kiểu model:";
            // 
            // cbCompany
            // 
            cbCompany.FormattingEnabled = true;
            cbCompany.Location = new Point(189, 204);
            cbCompany.Name = "cbCompany";
            cbCompany.Size = new Size(229, 23);
            cbCompany.TabIndex = 12;
            cbCompany.SelectedIndexChanged += cbCompany_SelectedIndexChanged;
            // 
            // cbIMEI
            // 
            cbIMEI.FormattingEnabled = true;
            cbIMEI.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIMEI.Location = new Point(189, 261);
            cbIMEI.Name = "cbIMEI";
            cbIMEI.Size = new Size(229, 23);
            cbIMEI.TabIndex = 17;
            cbIMEI.SelectedIndexChanged += cbIMEI_SelectedIndexChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(189, 303);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(131, 66);
            btnSubmit.TabIndex = 18;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(192, 9);
            label8.Name = "label8";
            label8.Size = new Size(424, 47);
            label8.TabIndex = 22;
            label8.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(btnSubmit);
            Controls.Add(cbIMEI);
            Controls.Add(label222);
            Controls.Add(cbModel);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(cbCompany);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMobileNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtPrice);
            Controls.Add(txtEmail);
            Controls.Add(txtCustomerName);
            Name = "SalesForm";
            Text = "SalesForm";
            Load += SalesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private TextBox txtEmail;
        private TextBox txtPrice;
        private TextBox txtAddress;
        private TextBox txtMobileNumber;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label222;
        private ComboBox cbModel;
        private Label label6;
        private Label label7;
        private ComboBox cbCompany;
        private ComboBox cbIMEI;
        private Button btnSubmit;
        private Label label8;
    }
}