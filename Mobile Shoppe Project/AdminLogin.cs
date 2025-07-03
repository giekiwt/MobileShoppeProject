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
using System.Data.SqlClient;
namespace Mobile_Shoppe_Project
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT COUNT(*) FROM tbl_User WHERE UserName=@user AND PWD=@pwd AND Role='Admin'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", txtAdminUser.Text.Trim());
                cmd.Parameters.AddWithValue("@pwd", txtAdminPass.Text.Trim());
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                    MessageBox.Show("Đăng nhập Admin thành công!");
                    AdminHomepage adminForm = new AdminHomepage();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu Admin!");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserLogin login = new UserLogin();
            login.Show();
            this.Close();
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotForm = new ForgotPassword();
            forgotForm.Show();
            this.Hide();
        }
    }
}
