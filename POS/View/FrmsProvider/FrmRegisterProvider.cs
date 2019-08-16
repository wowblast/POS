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
            string nombre = txtNombre.Text;
            string ubicacion = txtUbicacion.Text;
            Proveedor proveedor = new Proveedor(nombre, ubicacion);

            ProveedorControl proveedorControl = new ProveedorControl();
            proveedorControl.InsertarProveedor(proveedor);

            int idProveedor = proveedorControl.SeleccionarId();
            int idEmpresa = Convert.ToInt32(cbEmpresa.SelectedValue);
            EmpresaProveedor empresaProveedor = new EmpresaProveedor(idEmpresa, idProveedor);

            EmpresaProveedorControl empresaProveedorControl = new EmpresaProveedorControl();
            empresaProveedorControl.RegistrarEmpresaProveedor(empresaProveedor);

            MessageBox.Show("Se ha registrado al proveedor exitosamente", "Registro exitoso");
            Close();
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
