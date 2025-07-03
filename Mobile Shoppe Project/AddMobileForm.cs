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
    public partial class AddMobileForm : Form
    {
        public AddMobileForm()
        {
            InitializeComponent();
        }

        private void AddMobileForm_Load(object sender, EventArgs e)
        {
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
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
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
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

        private void btnAddMobile_Click(object sender, EventArgs e)
        {
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "INSERT INTO tbl_Mobile (ModelId, IMEINo, Status, Warranty, Price) VALUES (@modelId, @imei, @status, @warranty, @price)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@modelId", cbModel.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@imei", txtIMEI.Text);
                cmd.Parameters.AddWithValue("@status", "Not sold");
                cmd.Parameters.AddWithValue("@warranty", dtpWarranty.Value);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm điện thoại thành công!");
                    txtIMEI.Clear();
                    txtPrice.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
