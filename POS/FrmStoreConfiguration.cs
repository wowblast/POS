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
    public partial class FrmStoreConfiguration : Form
    {
        public FrmStoreConfiguration()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            listar();
        }

        private void insShelveBtn_Click(object sender, EventArgs e)
        {
            TiendaControl tiendaControl = new TiendaControl();
            tiendaControl.AñadirEstantería(numTxt.Text, lvlTxt.Text);
            numTxt.Text = "";
            lvlTxt.Text = "";
        }
        public void listar()
        {
            TiendaControl tiendaControl = new TiendaControl();
            dataGridView1.DataSource = tiendaControl.ListarEstantes();
            dataGridView2.DataSource = tiendaControl.ListarEstantes();
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
            if (dataGridView2.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el proveedor?", "Importante", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int idEstante = Convert.ToInt32(dataGridView2.SelectedCells[0].Value);
                    TiendaControl tiendaControl = new TiendaControl();
                    tiendaControl.EliminarEstantería(idEstante);
                    listar();
                }
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
            }
        }
    }
}
