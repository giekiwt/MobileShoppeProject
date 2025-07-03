namespace Mobile_Shoppe_Project
{
    partial class UpdateStockForm
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
            cbCompany = new ComboBox();
            cbModel = new ComboBox();
            txtQuantity = new TextBox();
            txtAmount = new TextBox();
            dtpDate = new DateTimePicker();
            btnUpdateStock = new Button();
            csv = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // cbCompany
            // 
            cbCompany.FormattingEnabled = true;
            cbCompany.Location = new Point(222, 77);
            cbCompany.Name = "cbCompany";
            cbCompany.Size = new Size(335, 23);
            cbCompany.TabIndex = 0;
            cbCompany.SelectedIndexChanged += cbCompany_SelectedIndexChanged;
            // 
            // cbModel
            // 
            cbModel.FormattingEnabled = true;
            cbModel.Location = new Point(222, 125);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(335, 23);
            cbModel.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(222, 180);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(335, 23);
            txtQuantity.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(222, 236);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(335, 23);
            txtAmount.TabIndex = 3;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(222, 287);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(335, 23);
            dtpDate.TabIndex = 4;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new Point(299, 333);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(133, 59);
            btnUpdateStock.TabIndex = 5;
            btnUpdateStock.Text = "Cập nhật kho";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // csv
            // 
            csv.AutoSize = true;
            csv.Location = new Point(117, 85);
            csv.Name = "csv";
            csv.Size = new Size(79, 15);
            csv.TabIndex = 6;
            csv.Text = "Chọn công ty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 133);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 7;
            label2.Text = "Chọn model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 239);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 9;
            label3.Text = "Nhập tổng tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 183);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 8;
            label4.Text = "Nhập số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 293);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 10;
            label5.Text = "Ngày nhập kho:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(183, 9);
            label8.Name = "label8";
            label8.Size = new Size(402, 47);
            label8.TabIndex = 24;
            label8.Text = "CẬP NHẬT KHO HÀNG";
            // 
            // UpdateStockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(csv);
            Controls.Add(btnUpdateStock);
            Controls.Add(dtpDate);
            Controls.Add(txtAmount);
            Controls.Add(txtQuantity);
            Controls.Add(cbModel);
            Controls.Add(cbCompany);
            Name = "UpdateStockForm";
            Text = "UpdateStockForm";
            Load += UpdateStockForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCompany;
        private ComboBox cbModel;
        private TextBox txtQuantity;
        private TextBox txtAmount;
        private DateTimePicker dtpDate;
        private Button btnUpdateStock;
        private Label csv;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
    }
}