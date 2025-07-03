namespace Mobile_Shoppe_Project
{
    partial class AddModelForm
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
            txtModelNum = new TextBox();
            btnAddModel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cbCompany
            // 
            cbCompany.FormattingEnabled = true;
            cbCompany.Location = new Point(330, 104);
            cbCompany.Name = "cbCompany";
            cbCompany.Size = new Size(268, 23);
            cbCompany.TabIndex = 0;
            cbCompany.SelectedIndexChanged += cbCompany_SelectedIndexChanged;
            // 
            // txtModelNum
            // 
            txtModelNum.Location = new Point(330, 191);
            txtModelNum.Name = "txtModelNum";
            txtModelNum.Size = new Size(268, 23);
            txtModelNum.TabIndex = 1;
            // 
            // btnAddModel
            // 
            btnAddModel.Location = new Point(384, 261);
            btnAddModel.Name = "btnAddModel";
            btnAddModel.Size = new Size(149, 42);
            btnAddModel.TabIndex = 2;
            btnAddModel.Text = "Thêm Model";
            btnAddModel.UseVisualStyleBackColor = true;
            btnAddModel.Click += btnAddModel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 199);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 3;
            label1.Text = "Nhập tên/kiểu model:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 107);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Chọn công ty:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(172, 18);
            label3.Name = "label3";
            label3.Size = new Size(456, 47);
            label3.TabIndex = 5;
            label3.Text = "THÊM MODEL SẢN PHẨM";
            // 
            // AddModelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddModel);
            Controls.Add(txtModelNum);
            Controls.Add(cbCompany);
            Name = "AddModelForm";
            Text = "AddModelForm";
            Load += AddModelForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCompany;
        private TextBox txtModelNum;
        private Button btnAddModel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}