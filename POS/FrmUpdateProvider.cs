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
    public partial class FrmUpdateProvider : Form
    {
        private Proveedor proveedor;
        private EmpresaProveedor empresaProveedor;

        public FrmUpdateProvider()
        {
            InitializeComponent();
            proveedor = new Proveedor();
            empresaProveedor = new EmpresaProveedor();
            CargarDatosEmpresa();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            ProveedorControl proveedorControl = new ProveedorControl();
            proveedor.Nombre = txtNombre.Text;
            proveedor.Ubicacion = txtUbicacion.Text;

            proveedorControl.ActualizarProveedor(proveedor);

            empresaProveedor.IdEmpresa = Convert.ToInt32(cbEmpresa.SelectedValue);

            EmpresaProveedorControl empresaProveedorControl = new EmpresaProveedorControl();
            empresaProveedorControl.ActualizarEmpresaProveedor(empresaProveedor);

            MessageBox.Show("¡Datos de proveedor actualizados correctamente!");

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

        public void RellenarDatos(Proveedor proveedorSeleccionado, EmpresaProveedor empresaProveedorSeleccionada)
        {
            proveedor.IdProveedor = proveedorSeleccionado.IdProveedor;
            txtNombre.Text = proveedorSeleccionado.Nombre;
            txtUbicacion.Text = proveedorSeleccionado.Ubicacion;

            empresaProveedor.IdEmpresaProveedor = empresaProveedorSeleccionada.IdEmpresaProveedor;
            empresaProveedor.IdEmpresa = empresaProveedorSeleccionada.IdEmpresa;
            empresaProveedor.IdProveedor = empresaProveedorSeleccionada.IdProveedor;
        }
    }
}
