using POS.Control;
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
    public partial class FrmCompany : Form
    {
        public FrmCompany()
        {
            InitializeComponent();
            Listar();
        }

        private void btnActualizarEmpresa_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                int idEmpresa = Convert.ToInt32(dataGridView3.SelectedCells[0].Value);
                string nombre = dataGridView3.SelectedCells[1].Value.ToString();
                string ubicacion = dataGridView3.SelectedCells[2].Value.ToString();
                string descripcion = dataGridView3.SelectedCells[3].Value.ToString();

                FrmUpdateCompany frmUpdateCompany = new FrmUpdateCompany();
                frmUpdateCompany.Show();
                frmUpdateCompany.RellenarDatos(idEmpresa, nombre, ubicacion, descripcion);
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegisterCompany frmRegisterCompany = new FrmRegisterCompany();
            frmRegisterCompany.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                int idEmpresa = Convert.ToInt32(dataGridView3.SelectedCells[0].Value);
                string nombre = dataGridView3.SelectedCells[1].Value.ToString();
                string ubicacion = dataGridView3.SelectedCells[2].Value.ToString();
                string descripcion = dataGridView3.SelectedCells[3].Value.ToString();

                FrmUpdateCompany frmUpdateCompany = new FrmUpdateCompany();
                frmUpdateCompany.Show();
                frmUpdateCompany.RellenarDatos(idEmpresa, nombre, ubicacion, descripcion);
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar la empresa?", "Importante", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int idEmpresa = Convert.ToInt32(dataGridView3.SelectedCells[0].Value);
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

        private void brnAtras_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void Listar()
        {
            EmpresaControl empresaControl = new EmpresaControl();
            DataTable listaEmpresas = empresaControl.ListarEmpresas();
            dataGridView3.DataSource = listaEmpresas;
        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
