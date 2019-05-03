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
    public partial class FrmUpdateCompany : Form
    {
        private Empresa empresa;

        public FrmUpdateCompany()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualzarDatos_Click(object sender, EventArgs e)
        {
            EmpresaControl empresaControl = new EmpresaControl();
            empresaControl.ActualizarEmpresa(empresa);
            MessageBox.Show("Se ha actualizado correctamente", "Terminado");
            Close();
        }

        public void RellenarDatos(int idEmpresa, string nombre, string ubicacion, string descripcion)
        {
            empresa = new Empresa(idEmpresa, nombre, ubicacion, descripcion);

            txtNombreEmpresa.Text = empresa.NombreEmpresa;
            txtUbicacion.Text = empresa.Ubicacion;
            txtDescripcion.Text = empresa.Descripcion;
        }
    }
}
