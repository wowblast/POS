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
    public partial class FrmRegisterShelves : Form
    {
        public FrmRegisterShelves()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string niveles = txtNiveles.Text;

            TiendaControl tiendaControl = new TiendaControl();
            tiendaControl.AñadirEstantería(nombre, Int32.Parse(niveles));

            MessageBox.Show("Estantería añadida exitosamente", "Registro exitoso");
        }
    }
}
