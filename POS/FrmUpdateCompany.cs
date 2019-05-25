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
            empresa = new Empresa();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualzarDatos_Click(object sender, EventArgs e)
        {
            empresa.Nombre = txtNombreEmpresa.Text;
            empresa.Ubicacion = txtUbicacion.Text;
            empresa.Descripcion = txtDescripcion.Text;

            EmpresaControl empresaControl = new EmpresaControl();
            empresaControl.ActualizarEmpresa(empresa);
            MessageBox.Show("Se ha actualizado correctamente", "Terminado");
            Close();
        }

        public void RellenarDatos(Empresa datosEmpresa)
        {
            empresa.IdEmpresa = datosEmpresa.IdEmpresa;
            txtNombreEmpresa.Text = datosEmpresa.Nombre;
            txtUbicacion.Text = datosEmpresa.Ubicacion;
            txtDescripcion.Text = datosEmpresa.Descripcion;
        }
    }
}
