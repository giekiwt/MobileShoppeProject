using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Shoppe_Project
{
    public partial class AdminHomepage : Form
    {
        public AdminHomepage()
        {
            InitializeComponent();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            AddCompanyForm addCompanyForm = new AddCompanyForm();
            addCompanyForm.ShowDialog();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            AddModelForm addModelForm = new AddModelForm();
            addModelForm.ShowDialog();
        }

        private void btnAddMobile_Click(object sender, EventArgs e)
        {
            AddMobileForm addMobileForm = new AddMobileForm();
            addMobileForm.ShowDialog();
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            UpdateStockForm updateStockForm = new UpdateStockForm();
            updateStockForm.ShowDialog();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm salesReportForm = new SalesReportForm();
            salesReportForm.ShowDialog();
        }
    }
}
