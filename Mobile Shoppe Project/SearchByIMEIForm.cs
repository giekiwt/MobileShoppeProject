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
    public partial class SearchByIMEIForm : Form
    {
        public SearchByIMEIForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
            SELECT c.CustName, c.MobileNumber, c.EmailId, c.Address
            FROM tbl_Sales s
            INNER JOIN tbl_Customer c ON s.CustId = c.CustId
            WHERE s.IMEINo = @imei";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@imei", txtIMEI.Text.Trim());
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count > 0)
                {
                    dgvCustomerInfo.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng với IMEI này!");
                    dgvCustomerInfo.DataSource = null;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
