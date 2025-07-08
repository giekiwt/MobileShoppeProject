using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mobile_Shoppe_Project
{
    public partial class DaySalesReportForm : Form
    {
        public DaySalesReportForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=.;Initial Catalog=MobileShoppeDB;Integrated Security=True";
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
            WHERE CAST(s.PurchaseDate AS DATE) = @selectedDate
            ORDER BY s.SaleId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@selectedDate", dtpDate.Value.Date);
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