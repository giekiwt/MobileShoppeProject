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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=.;Initial Catalog=MobileShoppeDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT PWD FROM tbl_User WHERE UserName=@user AND Hint=@hint";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@hint", txtHint.Text);
                conn.Open();
                object pwd = cmd.ExecuteScalar();
                if (pwd != null)
                {
                    lblPasswordResult.Text = "Mật khẩu của bạn là: " + pwd.ToString();
                }
                else
                {
                    lblPasswordResult.Text = "Không tìm thấy tài khoản hoặc gợi ý không đúng!";
                }
            }
        }
    }
}
