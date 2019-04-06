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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPurchaseAmount frmPurchaseAmount = new FrmPurchaseAmount();
            frmPurchaseAmount.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult button = MessageBox.Show("¿Esta seguro que desea eliminar el producto seleccionado?","Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (button == DialogResult.OK)
                {
                    //Eliminar el producto
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "¡Error!");
            }
        }

        private void btnUpdateProductData_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                FrmUpdateProduct frmUpdateProduct = new FrmUpdateProduct();
                frmUpdateProduct.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "¡Error!");
            }
        }
    }
}
