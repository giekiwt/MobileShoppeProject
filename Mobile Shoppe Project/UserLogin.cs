using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mobile_Shoppe_Project
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT COUNT(*) FROM tbl_User WHERE UserName=@user AND PWD=@pwd";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                    // Nếu đăng nhập thành công, kiểm tra loại tài khoản (admin hay nhân viên)
                    string checkAdmin = "SELECT COUNT(*) FROM tbl_User WHERE UserName=@user AND PWD=@pwd AND UserName='admin'";
                    SqlCommand cmdAdmin = new SqlCommand(checkAdmin, conn);
                    cmdAdmin.Parameters.AddWithValue("@user", txtUsername.Text);
                    cmdAdmin.Parameters.AddWithValue("@pwd", txtPassword.Text);

                    int isAdmin = (int)cmdAdmin.ExecuteScalar();
                    if (isAdmin == 1)
                    {
                        MessageBox.Show("Đăng nhập với quyền Admin!");
                        AdminHomepage adminForm = new AdminHomepage();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập với quyền Nhân viên!");
                        UserHomepage userForm = new UserHomepage();
                        userForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                }
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotForm = new ForgotPassword();
            forgotForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }
    }
}
