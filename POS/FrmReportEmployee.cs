using POS.Control;
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
    public partial class FrmReportEmployee : Form
    {
        public FrmReportEmployee()
        {
            InitializeComponent();
            lbTexto.Text = "";
            lbFecha.Text = "Fecha actual: " + DateTime.Now.ToString("dd/MM/yyyy");
            txtNombreUsuario.Text = CuentaActual.Nombre + " " + CuentaActual.ApellidoPaterno; 
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            if (CuentaActual.Cargo == "ADMINISTRADOR")
            {
                FrmMainMenu frmMainMenu = new FrmMainMenu();
                frmMainMenu.Show();
                Close();
            }
            else
            {
                FrmMainMenuEmployee frmMainMenuEmployee = new FrmMainMenuEmployee();
                frmMainMenuEmployee.Show();
                Close();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (CuentaActual.Cargo == "ADMINISTRADOR")
            {
                FrmMainMenu frmMainMenu = new FrmMainMenu();
                frmMainMenu.Show();
                Close();
            }
            else
            {
                FrmMainMenuEmployee frmMainMenuEmployee = new FrmMainMenuEmployee();
                frmMainMenuEmployee.Show();
                Close();
            }
        }

        private void btnReporteGeneralEmpleado_Click(object sender, EventArgs e)
        {
            DetalleVentaControl detalleVentaControl = new DetalleVentaControl();
            dataGridView3.DataSource = detalleVentaControl.ReporteVentasPorEmpleado(CuentaActual.idUsuario);

            if (dataGridView3.Rows.Count > 0)
            {
                txtMontoTotal.Text = dataGridView3.Rows[0].Cells[8].Value.ToString();
            }
        }
    }
}
