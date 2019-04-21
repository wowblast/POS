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
        public int idProveedor;
        public string nombre;
        public string ubicacion;

        public FrmUpdateProvider()
        {
            InitializeComponent();
            idProveedor = 0;
            nombre = "";
            ubicacion = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            ProveedorControl proveedorControl = new ProveedorControl();
            string nombre = txtName.Text;
            string ubicacion = txtUbication.Text;
            proveedorControl.ActualizarProveedor(idProveedor, nombre, ubicacion);
        }

        public Proveedor RellenarDatos(int idProveedor, string nombre, string ubicacion)
        {
            Proveedor proveedor = new Proveedor(idProveedor, nombre, ubicacion);
            return proveedor;
        }
    }
}
