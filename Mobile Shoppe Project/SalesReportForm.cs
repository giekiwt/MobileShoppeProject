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
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = @"
            SELECT 
                s.SaleId, 
                c.CName AS CompanyName, 
                m.ModelNum, 
                s.IMEINo, 
                s.Price, 
                cu.CustName AS CustomerName, 
                s.PurchaseDate
            FROM tbl_Sales s
            INNER JOIN tbl_Mobile mb ON s.IMEINo = mb.IMEINo
            INNER JOIN tbl_Model m ON mb.ModelId = m.ModelId
            INNER JOIN tbl_Company c ON m.CompId = c.CompId
            INNER JOIN tbl_Customer cu ON s.CustId = cu.CustId
            WHERE s.PurchaseDate BETWEEN @startDate AND @endDate
            ORDER BY s.PurchaseDate";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value.Date);
                cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value.Date);
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvSalesReport.DataSource = dt;

                // Tính tổng số tiền
                decimal total = 0;
                foreach (DataRow row in dt.Rows)
                {
                    total += row["Price"] != DBNull.Value ? Convert.ToDecimal(row["Price"]) : 0;
                }
                txtTotalAmount.Text = total.ToString("N0");
            }
        }
    }
}
