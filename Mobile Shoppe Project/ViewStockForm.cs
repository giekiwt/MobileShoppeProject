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
    public partial class ViewStockForm : Form
    {
        public ViewStockForm()
        {
            InitializeComponent();
        }

        private void ViewStockForm_Load(object sender, EventArgs e)
        {
            string connStr = "Data Source=.;Initial Catalog=MobileShoppeDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT CompId, CName FROM tbl_Company";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cbCompany.DataSource = dt;
                cbCompany.DisplayMember = "CName";
                cbCompany.ValueMember = "CompId";
            }
        }

        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "Data Source=.;Initial Catalog=MobileShoppeDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT ModelId, ModelNum FROM tbl_Model WHERE CompId=@compId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@compId", cbCompany.SelectedValue.ToString());
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cbModel.DataSource = dt;
                cbModel.DisplayMember = "ModelNum";
                cbModel.ValueMember = "ModelId";
            }
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "Data Source=.;Initial Catalog=MobileShoppeDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT AvailableQty FROM tbl_Model WHERE ModelId=@modelId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@modelId", cbModel.SelectedValue.ToString());
                conn.Open();
                object qty = cmd.ExecuteScalar();
                txtStockAvailable.Text = qty != null ? qty.ToString() : "0";
            }
        }
    }
}
