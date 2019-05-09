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
    public partial class FrmRegisterProvider : Form
    {
        public FrmRegisterProvider()
        {
            InitializeComponent();
            CargarDatosEmpresa();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ProveedorControl proveedorControl = new ProveedorControl();
            proveedorControl.InsertarProveedor(txtNombre.Text, txtUbicacion.Text);

            int idProveedor = proveedorControl.SeleccionarId();
            int idEmpresa = Convert.ToInt32(cbEmpresa.SelectedValue);

            EmpresaProveedorControl empresaProveedorControl = new EmpresaProveedorControl();
            empresaProveedorControl.RegistrarEmpresaProveedor(idEmpresa, idProveedor);

            MessageBox.Show("Se ha registrado al proveedor exitosamente", "Registro exitoso");
        }

        public void CargarDatosEmpresa()
        {
            EmpresaControl empresaControl = new EmpresaControl();
            DataTable empresas = empresaControl.ListarEmpresas();
            cbEmpresa.DataSource = empresas;
            cbEmpresa.ValueMember = "Id Empresa";
            cbEmpresa.DisplayMember = "Nombre Empresa";
        }
    }
}
