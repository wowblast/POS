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
        private int idEmpresa;
        private int idEmpresaProveedor;

        public FrmUpdateProvider()
        {
            InitializeComponent();
            idEmpresa = 0;
            idEmpresaProveedor = 0;
            CargarDatosEmpresa();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            if (cbEmpresa.Text != "Elige una opcion")
            {
                ProveedorControl proveedorControl = new ProveedorControl();

                string nombre = txtNombre.Text;
                string ubicacion = txtUbicacion.Text;

                proveedorControl.ActualizarProveedor(proveedor.CodigoProveedor, nombre, ubicacion);

                int idEmpresaProveedorSeleccionada = Convert.ToInt32(cbEmpresa.SelectedValue);

                EmpresaProveedorControl empresaProveedor = new EmpresaProveedorControl();
                empresaProveedor.ActualizarEmpresaProveedor(idEmpresaProveedor, idEmpresaProveedorSeleccionada, proveedor.CodigoProveedor);

                Close();
            }
            else
            {
                MessageBox.Show("Por favor selecciona una empresa", "¡Error!");
            }

        }
        public void CargarDatosEmpresa()
        {
            EmpresaControl empresaControl = new EmpresaControl();
            DataTable empresas = empresaControl.ListarEmpresas();
            cbEmpresa.DataSource = empresas;
            cbEmpresa.ValueMember = "Id Empresa";
            cbEmpresa.DisplayMember = "Nombre Empresa";
        }

        public void RellenarDatos(Proveedor proveedorSeleccionado, int idEmpresa, int idEmpresaProveedor)
        {
            this.proveedor = proveedorSeleccionado;
            txtNombre.Text = proveedor.NombreProveedor;
            txtUbicacion.Text = proveedor.Ubicacion;

            this.idEmpresa = idEmpresa;
            this.idEmpresaProveedor = idEmpresaProveedor;

            cbEmpresa.Text = "Elige una opcion";
        }
    }
}
