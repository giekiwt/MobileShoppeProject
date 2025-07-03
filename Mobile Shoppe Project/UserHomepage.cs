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
    public partial class UserHomepage : Form
    {
        public UserHomepage()
        {
            InitializeComponent();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesForm f = new SalesForm();
            f.ShowDialog();
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            ViewStockForm f = new ViewStockForm();
            f.ShowDialog();
        }

        private void btnSearchByIMEI_Click(object sender, EventArgs e)
        {
            SearchByIMEIForm f = new SearchByIMEIForm();
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserLogin login = new UserLogin();
            login.Show();
            this.Close();
        }

        private void UserHomepage_Load(object sender, EventArgs e)
        {

        }

        private void btnViewStock_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
