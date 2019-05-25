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
    public partial class FrmRegisterCompany : Form
    {
        public FrmRegisterCompany()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrarEmpresa_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEmpresa.Text;
            string ubicacion = txtUbicacion.Text;
            string descripcion = txtDescripcion.Text;

            EmpresaControl empresaControl = new EmpresaControl();
            Empresa empresa = new Empresa(nombre, ubicacion, descripcion);
            empresaControl.RegistrarEmpresa(empresa);

            MessageBox.Show("Se ha registrado a la empresa exitosamente", "Registro exitoso");
            Close();
        }
    }
}
