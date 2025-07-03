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
    public partial class UpdateStockForm : Form
    {
        public UpdateStockForm()
        {
            InitializeComponent();
        }

        private void UpdateStockForm_Load(object sender, EventArgs e)
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

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // 1. Thêm bản ghi vào bảng Transaction
                string transId = Guid.NewGuid().ToString().Substring(0, 8);
                string sqlTrans = "INSERT INTO tbl_Transaction (TransId, ModelId, Quantity, Date, Amount) VALUES (@id, @modelId, @qty, @date, @amount)";
                SqlCommand cmdTrans = new SqlCommand(sqlTrans, conn);
                cmdTrans.Parameters.AddWithValue("@id", transId);
                cmdTrans.Parameters.AddWithValue("@modelId", cbModel.SelectedValue.ToString());
                cmdTrans.Parameters.AddWithValue("@qty", int.Parse(txtQuantity.Text));
                cmdTrans.Parameters.AddWithValue("@date", dtpDate.Value);
                cmdTrans.Parameters.AddWithValue("@amount", decimal.Parse(txtAmount.Text));

                // 2. Cập nhật số lượng tồn kho trong bảng Model
                string sqlUpdate = "UPDATE tbl_Model SET AvailableQty = AvailableQty + @qty WHERE ModelId = @modelId";
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);
                cmdUpdate.Parameters.AddWithValue("@qty", int.Parse(txtQuantity.Text));
                cmdUpdate.Parameters.AddWithValue("@modelId", cbModel.SelectedValue.ToString());

                try
                {
                    conn.Open();
                    cmdTrans.ExecuteNonQuery();
                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật kho thành công!");
                    txtQuantity.Clear();
                    txtAmount.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
