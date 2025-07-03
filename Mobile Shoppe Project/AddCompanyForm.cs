using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Thêm dòng này để sử dụng SqlConnection, SqlCommand
using System.Data.SqlClient;

namespace Mobile_Shoppe_Project
{
    public partial class AddCompanyForm : Form
    {
        public AddCompanyForm()
        {
            InitializeComponent();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            // Sửa mật khẩu đúng của bạn ở đây
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "INSERT INTO tbl_Company (CompId, CName) VALUES (@id, @name)";
                // Tự động sinh CompId, ví dụ dùng Guid hoặc tự tăng số
                string compId = Guid.NewGuid().ToString().Substring(0, 8);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", compId);
                cmd.Parameters.AddWithValue("@name", txtCompanyName.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm công ty thành công!");
                    txtCompanyName.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}