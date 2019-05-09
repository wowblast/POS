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
        public Proveedor proveedor;

        public FrmUpdateProvider()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            ProveedorControl proveedorControl = new ProveedorControl();

            string nombre = txtNombre.Text;
            string ubicacion = txtUbicacion.Text;

            proveedorControl.ActualizarProveedor(proveedor.CodigoProveedor, nombre, ubicacion);

            Close();
        }

        public void RellenarDatos(int idProveedor, string nombre, string ubicacion)
        {
            this.proveedor =  new Proveedor(idProveedor, nombre, ubicacion);
            txtNombre.Text = proveedor.NombreProveedor;
            txtUbicacion.Text = proveedor.Ubicacion;
        }
    }
}
