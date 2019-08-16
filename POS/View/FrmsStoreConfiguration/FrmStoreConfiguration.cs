using POS.Control;
using POS.Entity;
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
    public partial class FrmStoreConfiguration : Form
    {
        public FrmStoreConfiguration()
        {
            InitializeComponent();
        }

        public void listar()
        {
            TiendaControl tiendaControl = new TiendaControl();
            dataGridView1.DataSource = tiendaControl.ListarEstantes();
        }

        private void UpdateShelveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int idEstante = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                string numero = dataGridView1.SelectedCells[1].Value.ToString();
                string nivel = dataGridView1.SelectedCells[2].Value.ToString();

                FrmUpdateShelve frmUpdateShelve = new FrmUpdateShelve();
                frmUpdateShelve.Show();
                frmUpdateShelve.cambiarDatos(idEstante, numero, nivel);
                listar();
            }
            else
            {
                MessageBox.Show("¡Seleccione una estantería!", "Error");
            }
        }

        private void delShelveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el estante/nivel de estante?", "Importante", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int idEstante = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                    TiendaControl tiendaControl = new TiendaControl();
                    tiendaControl.EliminarEstantería(idEstante);
                    listar();
                }
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar un estante!", "Error");
            }
        }

        private void insShelveBtn_Click_1(object sender, EventArgs e)
        {
            FrmRegisterShelves registerShelve = new FrmRegisterShelves();
            registerShelve.Show();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void FrmStoreConfiguration_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
