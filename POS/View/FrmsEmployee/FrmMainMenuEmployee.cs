using POS.Singleton;
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
    public partial class FrmMainMenuEmployee : Form
    {
        public FrmMainMenuEmployee()
        {
            InitializeComponent();
            lbCargo.Text = User.GetInstance().usuario.Nombre + " " + User.GetInstance().usuario.ApellidoPaterno; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmSales = new FrmPrincipal();
            frmSales.Show();
            Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReportEmployee frmReportEmployee = new FrmReportEmployee();
            frmReportEmployee.Show();
            Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FrmStock frmStock = new FrmStock();
            frmStock.Show();
            Close();
        }
    }
}
