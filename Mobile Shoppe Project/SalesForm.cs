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

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
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
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
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
            string connStr = "Server=.;Database=MobileShoppeDB;uid=sa;pwd=Giakiet@123;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    // 1. Thêm khách hàng
                    string custId = Guid.NewGuid().ToString().Substring(0, 8);
                    string sqlCust = "INSERT INTO tbl_Customer (CustId, CustName, MobileNumber, EmailId, Address) VALUES (@id, @name, @mobile, @email, @address)";
                    SqlCommand cmdCust = new SqlCommand(sqlCust, conn, tran);
                    cmdCust.Parameters.AddWithValue("@id", custId);
                    cmdCust.Parameters.AddWithValue("@name", txtCustomerName.Text);
                    cmdCust.Parameters.AddWithValue("@mobile", txtMobileNumber.Text);
                    cmdCust.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmdCust.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmdCust.ExecuteNonQuery();

                    // 2. Thêm vào bảng Sales
                    string saleId = Guid.NewGuid().ToString().Substring(0, 8);
                    string sqlSale = "INSERT INTO tbl_Sales (SaleId, IMEINo, PurchaseDate, Price, CustId) VALUES (@id, @imei, @date, @price, @custId)";
                    SqlCommand cmdSale = new SqlCommand(sqlSale, conn, tran);
                    cmdSale.Parameters.AddWithValue("@id", saleId);
                    cmdSale.Parameters.AddWithValue("@imei", cbIMEI.SelectedValue.ToString());
                    cmdSale.Parameters.AddWithValue("@date", DateTime.Now);
                    cmdSale.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmdSale.Parameters.AddWithValue("@custId", custId);
                    cmdSale.ExecuteNonQuery();

                    // 3. Cập nhật trạng thái mobile là "sold"
                    string sqlMobile = "UPDATE tbl_Mobile SET Status='sold' WHERE IMEINo=@imei";
                    SqlCommand cmdMobile = new SqlCommand(sqlMobile, conn, tran);
                    cmdMobile.Parameters.AddWithValue("@imei", cbIMEI.SelectedValue.ToString());
                    cmdMobile.ExecuteNonQuery();

                    // 4. Giảm tồn kho model
                    string sqlModel = "UPDATE tbl_Model SET AvailableQty = AvailableQty - 1 WHERE ModelId=@modelId";
                    SqlCommand cmdModel = new SqlCommand(sqlModel, conn, tran);
                    cmdModel.Parameters.AddWithValue("@modelId", cbModel.SelectedValue.ToString());
                    cmdModel.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Bán hàng thành công!");
                    // Xóa dữ liệu nhập
                    txtCustomerName.Clear();
                    txtMobileNumber.Clear();
                    txtAddress.Clear();
                    txtEmail.Clear();
                    txtPrice.Clear();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
