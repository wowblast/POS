using POS.Control;
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
    public partial class FrmPurchases : Form
    {
        public FrmPurchases()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            FrmMakePurchase hacerCompra = new FrmMakePurchase();
            hacerCompra.Show();
        }

        private void FrmPurchases_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            DetalleCompraControl DetalleCompraControl = new DetalleCompraControl();
            dataGridView1.DataSource = DetalleCompraControl.ListarCompras();
        }
    }
}
