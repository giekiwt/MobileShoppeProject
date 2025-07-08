namespace Mobile_Shoppe_Project
{
    partial class ViewStockForm
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
            cbModel = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            cbCompany = new ComboBox();
            txtStockAvailable = new TextBox();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cbModel
            // 
            cbModel.FormattingEnabled = true;
            cbModel.Location = new Point(289, 163);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(367, 23);
            cbModel.TabIndex = 19;
            cbModel.SelectedIndexChanged += cbModel_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 107);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 18;
            label6.Text = "Chọn công ty:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(133, 171);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 17;
            label7.Text = "Nhập tên/kiểu model:";
            // 
            // cbCompany
            // 
            cbCompany.FormattingEnabled = true;
            cbCompany.Location = new Point(289, 104);
            cbCompany.Name = "cbCompany";
            cbCompany.Size = new Size(364, 23);
            cbCompany.TabIndex = 16;
            cbCompany.SelectedIndexChanged += cbCompany_SelectedIndexChanged;
            // 
            // txtStockAvailable
            // 
            txtStockAvailable.Location = new Point(289, 211);
            txtStockAvailable.Name = "txtStockAvailable";
            txtStockAvailable.Size = new Size(121, 23);
            txtStockAvailable.TabIndex = 20;
            txtStockAvailable.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 219);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 21;
            label1.Text = "Hiển thị số lượng tồn kho";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(289, 18);
            label3.Name = "label3";
            label3.Size = new Size(212, 47);
            label3.TabIndex = 22;
            label3.Text = "KHO HÀNG";
            // 
            // ViewStockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtStockAvailable);
            Controls.Add(cbModel);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(cbCompany);
            Name = "ViewStockForm";
            Text = "ViewStockForm";
            Load += new System.EventHandler(this.ViewStockForm_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbModel;
        private Label label6;
        private Label label7;
        private ComboBox cbCompany;
        private TextBox txtStockAvailable;
        private Label label1;
        private Label label3;
    }
}