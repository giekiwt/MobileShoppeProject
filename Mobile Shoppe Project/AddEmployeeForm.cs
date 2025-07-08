using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Shoppe_Project
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Kiểm tra hợp lệ
            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string connStr = "Data Source=.;Initial Catalog=MobileShoppeDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // Kiểm tra trùng username
                string checkSql = "SELECT COUNT(*) FROM tbl_User WHERE UserName=@user";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@user", txtUsername.Text);
                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                    return;
                }
                // Thêm nhân viên mới
                string sql = "INSERT INTO tbl_User (EmployeeName, Address, MobileNumber, UserName, PWD, Hint) VALUES (@name, @address, @mobile, @user, @pwd, @hint)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@mobile", txtMobile.Text);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                cmd.Parameters.AddWithValue("@hint", txtHint.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!");
                    // Xóa dữ liệu nhập
                    txtEmployeeName.Clear();
                    txtAddress.Clear();
                    txtMobile.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtRePassword.Clear();
                    txtHint.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
