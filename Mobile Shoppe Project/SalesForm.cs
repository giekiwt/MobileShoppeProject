using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Mobile_Shoppe_Project
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SalesForm_Load(object sender, EventArgs e)
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
                string sql = "SELECT IMEINo FROM tbl_Mobile WHERE ModelId=@modelId AND Status='Not sold'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@modelId", cbModel.SelectedValue.ToString());
                conn.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cbIMEI.DataSource = dt;
                cbIMEI.DisplayMember = "IMEINo";
                cbIMEI.ValueMember = "IMEINo";
            }
        }

        private void cbIMEI_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "Data Source=.;Initial Catalog=MobileShoppeDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT Price FROM tbl_Mobile WHERE IMEINo=@imei";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@imei", cbIMEI.SelectedValue.ToString());
                conn.Open();
                object price = cmd.ExecuteScalar();
                txtPrice.Text = price != null ? price.ToString() : "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control
            string customerName = txtCustomerName.Text;
            string mobileNumber = txtMobileNumber.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string companyName = cbCompany.Text;
            string modelNumber = cbModel.Text;
            string imeiNumber = cbIMEI.Text;
            string price = txtPrice.Text;
            string modelId = cbModel.SelectedValue?.ToString();
            string imeiNo = cbIMEI.SelectedValue?.ToString();
            string custId = Guid.NewGuid().ToString().Substring(0, 8);
            string warranty = "";
            string connStr = "Data Source=.;Initial Catalog=MobileShoppeDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT Warranty FROM tbl_Mobile WHERE IMEINo=@imei";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@imei", imeiNo);
                conn.Open();
                object w = cmd.ExecuteScalar();
                warranty = w != null ? w.ToString() : "";
            }
            // Hiển thị form xác nhận, truyền dữ liệu sang
            ConfirmDetails confirmForm = new ConfirmDetails(customerName, mobileNumber, email, address, companyName, modelNumber, imeiNumber, price, modelId, imeiNo, custId, warranty);
            confirmForm.ShowDialog();
            // Sau khi xác nhận xong, nếu muốn xóa dữ liệu nhập thì xóa ở đây (nếu cần)
            // txtCustomerName.Clear();
            // txtMobileNumber.Clear();
            // txtAddress.Clear();
            // txtEmail.Clear();
            // txtPrice.Clear();
        }
    }
}
