using POS.FmsProductsCategory;
using POS.FrmsCategoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSales_Click_1(object sender, EventArgs e)
        {
            FrmPrincipal frmSales = new FrmPrincipal();
            frmSales.Show();
            Close();
        }

        private void btnProducts_Click_1(object sender, EventArgs e)
        {
			FrmProductCategoryMainMenu frmProducts = new FrmProductCategoryMainMenu();
            frmProducts.Show();
            Close();
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            FrmReport frmReport = new FrmReport();
            frmReport.Show();
            Close();
        }

        private void btnInvoice_Click_1(object sender, EventArgs e)
        {
            FrmInvoice frmInvoice = new FrmInvoice();
            frmInvoice.Show();
            Close();
        }

        private void btnPurchases_Click_1(object sender, EventArgs e)
        {
            FrmPurchases frmPurchases = new FrmPurchases();
            frmPurchases.Show();
            Close();
        }

        private void btnCompany_Click_1(object sender, EventArgs e)
        {
            FrmCompany frmCompany = new FrmCompany();
            frmCompany.Show();
            Close();
        }

        private void btnProvider_Click_1(object sender, EventArgs e)
        {
            FrmProvider frmProvider = new FrmProvider();
            frmProvider.Show();
            Close();
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {
            FrmStock frmStock = new FrmStock();
            frmStock.Show();
            Close();
        }

        private void btnStoreConfiguration_Click_1(object sender, EventArgs e)
        {
            FrmStoreConfiguration frmStoreConfiguration = new FrmStoreConfiguration();
            frmStoreConfiguration.Show();
            Close();
        }

		private void button11_Click(object sender, EventArgs e)
		{
			FrmCategoryMainMenu category = new FrmCategoryMainMenu();
			category.Show();
		}

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmEmployee frmEmployee = new FrmEmployee();
            frmEmployee.Show();
            Close();
        }
    }
}
