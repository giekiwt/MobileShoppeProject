namespace Mobile_Shoppe_Project
{
    partial class AddMobileForm
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
            cbCompany = new ComboBox();
            cbModel = new ComboBox();
            label222 = new Label();
            txtIMEI = new TextBox();
            txtPrice = new TextBox();
            label3 = new Label();
            dtpWarranty = new DateTimePicker();
            label4 = new Label();
            btnAddMobile = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 81);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 8;
            label2.Text = "Chọn công ty:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 132);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 7;
            label1.Text = "Nhập tên/kiểu model:";
            // 
            // cbCompany
            // 
            cbCompany.FormattingEnabled = true;
            cbCompany.Location = new Point(251, 73);
            cbCompany.Name = "cbCompany";
            cbCompany.Size = new Size(248, 23);
            cbCompany.TabIndex = 5;
            cbCompany.SelectedIndexChanged += cbCompany_SelectedIndexChanged;
            // 
            // cbModel
            // 
            cbModel.FormattingEnabled = true;
            cbModel.Location = new Point(251, 124);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(248, 23);
            cbModel.TabIndex = 9;
            // 
            // label222
            // 
            label222.AutoSize = true;
            label222.Location = new Point(105, 179);
            label222.Name = "label222";
            label222.Size = new Size(77, 15);
            label222.TabIndex = 10;
            label222.Text = "Nhập số IMEI";
            // 
            // txtIMEI
            // 
            txtIMEI.Location = new Point(251, 171);
            txtIMEI.Name = "txtIMEI";
            txtIMEI.Size = new Size(248, 23);
            txtIMEI.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(251, 221);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(248, 23);
            txtPrice.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 229);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "Nhập giá";
            // 
            // dtpWarranty
            // 
            dtpWarranty.Location = new Point(251, 266);
            dtpWarranty.Name = "dtpWarranty";
            dtpWarranty.Size = new Size(248, 23);
            dtpWarranty.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 266);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 15;
            label4.Text = "Chọn ngày bảo hành";
            // 
            // btnAddMobile
            // 
            btnAddMobile.Location = new Point(251, 333);
            btnAddMobile.Name = "btnAddMobile";
            btnAddMobile.Size = new Size(191, 48);
            btnAddMobile.TabIndex = 16;
            btnAddMobile.Text = "Thêm điện thoại";
            btnAddMobile.UseVisualStyleBackColor = true;
            btnAddMobile.Click += btnAddMobile_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(68, 9);
            label5.Name = "label5";
            label5.Size = new Size(648, 40);
            label5.TabIndex = 17;
            label5.Text = "THÊM THÔNG TIN VỀ SẢN PHẨM ĐIỆN THOẠI";
            // 
            // AddMobileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnAddMobile);
            Controls.Add(label4);
            Controls.Add(dtpWarranty);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtIMEI);
            Controls.Add(label222);
            Controls.Add(cbModel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbCompany);
            Name = "AddMobileForm";
            Text = "AddMobileForm";
            Load += AddMobileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ComboBox cbCompany;
        private ComboBox cbModel;
        private Label label222;
        private TextBox txtIMEI;
        private TextBox txtPrice;
        private Label label3;
        private DateTimePicker dtpWarranty;
        private Label label4;
        private Button btnAddMobile;
        private Label label5;
    }
}