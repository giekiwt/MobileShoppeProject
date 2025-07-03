namespace Mobile_Shoppe_Project
{
    partial class AddCompanyForm
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
            txtCompanyName = new TextBox();
            btnAddCompany = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(242, 105);
            txtCompanyName.MinimumSize = new Size(0, 45);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(329, 23);
            txtCompanyName.TabIndex = 0;
            // 
            // btnAddCompany
            // 
            btnAddCompany.Location = new Point(242, 158);
            btnAddCompany.Name = "btnAddCompany";
            btnAddCompany.Size = new Size(116, 67);
            btnAddCompany.TabIndex = 1;
            btnAddCompany.Text = "Thêm Công ty";
            btnAddCompany.UseVisualStyleBackColor = true;
            btnAddCompany.Click += btnAddCompany_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(242, 9);
            label1.Name = "label1";
            label1.Size = new Size(285, 47);
            label1.TabIndex = 2;
            label1.Text = "THÊM CÔNG TY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 103);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 3;
            label2.Text = "Nhập tên công ty:";
            // 
            // AddCompanyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddCompany);
            Controls.Add(txtCompanyName);
            Name = "AddCompanyForm";
            Text = "AddCompanyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCompanyName;
        private Button btnAddCompany;
        private Label label1;
        private Label label2;
    }
}