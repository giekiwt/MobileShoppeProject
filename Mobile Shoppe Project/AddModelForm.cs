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
    public partial class AddModelForm : Form
    {
        public AddModelForm()
        {
            InitializeComponent();
        }

        private void cbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddModelForm_Load(object sender, EventArgs e)
        {
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT CompId, CName FROM tbl_Company";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cbCompany.DataSource = dt;
                cbCompany.DisplayMember = "CName";
                cbCompany.ValueMember = "CompId";
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "INSERT INTO tbl_Model (ModelId, CompId, ModelNum, AvailableQty) VALUES (@id, @compId, @modelNum, 0)";
                string modelId = Guid.NewGuid().ToString().Substring(0, 8);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", modelId);
                cmd.Parameters.AddWithValue("@compId", cbCompany.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@modelNum", txtModelNum.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm model thành công!");
                    txtModelNum.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
