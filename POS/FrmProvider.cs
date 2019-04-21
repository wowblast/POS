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
    public partial class FrmProvider : Form
    {
        public FrmProvider()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnRegisterProvider_Click(object sender, EventArgs e)
        {
            ProveedorControl proveedorControl = new ProveedorControl();
            proveedorControl.InsertarProveedor(txtNameProvider.Text, txtUbicationProvider.Text);
            txtNameProvider.Text = "";
            txtUbicationProvider.Text = "";
        }

        private void tabControl1_MouseClick_1(object sender, MouseEventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            ProveedorControl proveedorControl = new ProveedorControl();
            dataGridView1.DataSource = proveedorControl.ListarProveedor();
            dataGridView2.DataSource = proveedorControl.ListarProveedor();
        }

        private void btnDeleteProvider_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el proveedor?", "Importante", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int idProveedor = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);
                    ProveedorControl providerController = new ProveedorControl();
                    providerController.EliminarProveedor(idProveedor);
                    Listar();
                }
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
            }
        }

        private void btnUpdateProvider_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int idProveedor = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                string nombre = dataGridView1.SelectedCells[1].Value.ToString();
                string ubicacion = dataGridView1.SelectedCells[2].Value.ToString();

                FrmUpdateProvider frmUpdateProvider = new FrmUpdateProvider();
                frmUpdateProvider.Show();
                frmUpdateProvider.RellenarDatos(idProveedor, nombre, ubicacion);
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
            }
        }
    }
}
