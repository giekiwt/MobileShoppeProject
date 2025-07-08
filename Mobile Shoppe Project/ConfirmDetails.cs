using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mobile_Shoppe_Project
{
    public partial class ConfirmDetails : Form
    {
        // Các biến lưu thông tin bán hàng
        private string customerName, mobileNumber, email, address, companyName, modelNumber, imeiNumber, price, warranty;
        private string modelId, imeiNo, custId;
        public ConfirmDetails(string customerName, string mobileNumber, string email, string address, string companyName, string modelNumber, string imeiNumber, string price, string modelId, string imeiNo, string custId, string warranty)
        {
            InitializeComponent();
            this.customerName = customerName;
            this.mobileNumber = mobileNumber;
            this.email = email;
            this.address = address;
            this.companyName = companyName;
            this.modelNumber = modelNumber;
            this.imeiNumber = imeiNumber;
            this.price = price;
            this.modelId = modelId;
            this.imeiNo = imeiNo;
            this.custId = custId;
            this.warranty = warranty;
        }

        private void ConfirmDetails_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = customerName;
            lblMobileNumber.Text = mobileNumber;
            lblEmail.Text = email;
            lblAddress.Text = address;
            lblCompanyName.Text = companyName;
            lblModelNumber.Text = modelNumber;
            lblIMEI.Text = imeiNumber;
            lblPrice.Text = price;
            lblWarranty.Text = warranty;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Cập nhật database ở đây
            string connStr = "Data Source=.;Initial Catalog=MobileShoppeDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    // 1. Thêm khách hàng vào tbl_Customer
                    string sqlCust = "INSERT INTO tbl_Customer (CustId, CustName, MobileNumber, EmailId, Address) VALUES (@id, @name, @mobile, @email, @address)";
                    SqlCommand cmdCust = new SqlCommand(sqlCust, conn, tran);
                    cmdCust.Parameters.AddWithValue("@id", custId);
                    cmdCust.Parameters.AddWithValue("@name", customerName);
                    cmdCust.Parameters.AddWithValue("@mobile", mobileNumber);
                    cmdCust.Parameters.AddWithValue("@email", email);
                    cmdCust.Parameters.AddWithValue("@address", address);
                    cmdCust.ExecuteNonQuery();

                    // 2. Thêm vào bảng Sales
                    string saleId = Guid.NewGuid().ToString().Substring(0, 8);
                    string sqlSale = "INSERT INTO tbl_Sales (SaleId, IMEINo, PurchaseDate, Price, CustId) VALUES (@id, @imei, @date, @price, @custId)";
                    SqlCommand cmdSale = new SqlCommand(sqlSale, conn, tran);
                    cmdSale.Parameters.AddWithValue("@id", saleId);
                    cmdSale.Parameters.AddWithValue("@imei", imeiNo);
                    cmdSale.Parameters.AddWithValue("@date", DateTime.Now);
                    cmdSale.Parameters.AddWithValue("@price", price);
                    cmdSale.Parameters.AddWithValue("@custId", custId);
                    cmdSale.ExecuteNonQuery();

                    // 3. Cập nhật trạng thái mobile là "sold"
                    string sqlMobile = "UPDATE tbl_Mobile SET Status='sold' WHERE IMEINo=@imei";
                    SqlCommand cmdMobile = new SqlCommand(sqlMobile, conn, tran);
                    cmdMobile.Parameters.AddWithValue("@imei", imeiNo);
                    cmdMobile.ExecuteNonQuery();

                    // 4. Giảm tồn kho model
                    string sqlModel = "UPDATE tbl_Model SET AvailableQty = AvailableQty - 1 WHERE ModelId=@modelId";
                    SqlCommand cmdModel = new SqlCommand(sqlModel, conn, tran);
                    cmdModel.Parameters.AddWithValue("@modelId", modelId);
                    cmdModel.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("Bán hàng thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Không làm gì, chỉ đóng form
            this.Close();
        }
    }
}
