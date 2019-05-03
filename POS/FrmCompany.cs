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
    public partial class FrmCompany : Form
    {
        public FrmCompany()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnRegistrarEmpresa_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEmpresa.Text;
            string ubicacion = txtUbicacion.Text;
            string descripcion = txtDescripcion.Text;

            EmpresaControl empresaControl = new EmpresaControl();
            empresaControl.RegistrarEmpresa(nombre, ubicacion, descripcion);

            LimpiarCampos();
        }

        private void Listar()
        {
            EmpresaControl empresaControl = new EmpresaControl();
            DataTable listaEmpresas =  empresaControl.ListarEmpresas();
            dataGridView1.DataSource = listaEmpresas;
            dataGridView2.DataSource = listaEmpresas;
        }

        private void LimpiarCampos()
        {
            txtNombreEmpresa.Text = "";
            txtDescripcion.Text = "";
            txtUbicacion.Text = "";
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            Listar();
        }

        private void btnEliminarEmpresa_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar la empresa?", "Importante", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int idEmpresa = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);
                    EmpresaControl empresaControl = new EmpresaControl();
                    empresaControl.EliminarEmpresa(idEmpresa);
                    Listar();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "¡Error!");
            }
        }

        private void btnActualizarEmpresa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int idEmpresa = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                string nombre = dataGridView1.SelectedCells[1].Value.ToString();
                string ubicacion = dataGridView1.SelectedCells[2].Value.ToString();
                string descripcion = dataGridView1.SelectedCells[3].Value.ToString();

                FrmUpdateCompany frmUpdateCompany = new FrmUpdateCompany();
                frmUpdateCompany.Show();
                frmUpdateCompany.RellenarDatos(idEmpresa, nombre, ubicacion, descripcion);
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
            }
        }
    }
}
