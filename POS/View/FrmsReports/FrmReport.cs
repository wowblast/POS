﻿using POS.Control;
using POS.Singleton;
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
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
            lbTexto.Text = "";
            lbFecha.Text = "Fecha actual: " + DateTime.Now.ToString("dd/MM/yyyy");
            txtNombreEmpleado.Text = "Usuario";
            txtMontoTotal.Text = "0";
            txtNombreEmpleado.Text = User.GetInstance().usuario.Nombre + " " + User.GetInstance().usuario.ApellidoPaterno; 
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnReportePorEmpleado_Click(object sender, EventArgs e)
        {
            lbTexto.Text = "Reporte de ventas por empleado del dia de hoy: ";
            DetalleVentaControl detalleVentaControl = new DetalleVentaControl();
            dataGridView3.DataSource = detalleVentaControl.ListarReporteVentasPorEmpleado();
            txtMontoTotal.Text = detalleVentaControl.ObtenerMontoTotal();
        }

        private void btnReporteGeneralProductos_Click(object sender, EventArgs e)
        {
            lbTexto.Text = "Reporte de venta de productos diario: ";
            DetalleVentaControl detalleVentaControl = new DetalleVentaControl();
            dataGridView3.DataSource = detalleVentaControl.ListarReportePorProductosVendidos();
            txtMontoTotal.Text = detalleVentaControl.ObtenerMontoTotal();
        }

        private void btnReporteGeneral_Click(object sender, EventArgs e)
        {
            lbTexto.Text = "Reporte general de ventas: ";
            DetalleVentaControl detalleVentaControl = new DetalleVentaControl();
            dataGridView3.DataSource = detalleVentaControl.ReporteGeneral();
            txtMontoTotal.Text = detalleVentaControl.ObtenerMontoTotal();
        }
    }
}
