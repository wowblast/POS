﻿using POS.Control;
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
    public partial class FrmMakePurchase : Form
    {
        public FrmMakePurchase()
        {
            InitializeComponent();
            valPrecioCompra.DecimalPlaces = 2;
            valPrecioCompra.Increment = 0.01M;
            valPrecioCompra.Minimum = 0;
            valCantidad.Minimum = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbProductos.Text == "" || cbProveedores.Text == "")
            {
                MessageBox.Show("no existen productos y/o proveedores", "Conflecto detectado");
               
            }
            else
            {
                int cantidad = Convert.ToInt32(valCantidad.Text);
                double precio = Convert.ToDouble(valPrecioCompra.Text);
                int idempleado = Convert.ToInt32(txtIDEmpleado.Text);
                int idproveedor = Convert.ToInt32(cbProveedores.SelectedValue);
                int idproducto = Convert.ToInt32(cbProductos.SelectedValue);

                CompraControl compraControl = new CompraControl();
                compraControl.RealizarCompra(idproveedor, idempleado);

                DataTable ultimaCompra = compraControl.ObtenerUltimaCompra();
                int idcompra = ultimaCompra.Rows[0].Field<int>(0);

                DetalleCompraControl detalleCompraControl = new DetalleCompraControl();
                detalleCompraControl.InsertarDetalleCompra(idcompra, idproducto, cantidad, precio);

                MessageBox.Show("Compra realizada exitosamente", "Compra exitosa!");

            }

        }

        private void FrmMakePurchase_Load(object sender, EventArgs e)
        {
            ProductoControl control = new ProductoControl();
            ProveedorControl proveedor = new ProveedorControl();
            DataTable tablaProductos = control.ListarProductos();
            DataTable tablaProveedores = proveedor.ListarProveedor();

            cbProductos.DataSource = tablaProductos;
            cbProductos.ValueMember = "ID PRODUCTO";
            cbProductos.DisplayMember = "NOMBRE DEL PRODUCTO";
            cbProveedores.DataSource = tablaProveedores;
            cbProveedores.ValueMember = "Id proveedor";
            cbProveedores.DisplayMember = "Nombre del proveedor";
        }
    }
}
