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
    public partial class FrmReportEmployee : Form
    {
        public FrmReportEmployee()
        {
            InitializeComponent();
            lbTexto.Text = "";
            lbFecha.Text = "Fecha actual: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnReporteGeneralEmpleado_Click(object sender, EventArgs e)
        {
            DetalleVentaControl detalleVentaControl = new DetalleVentaControl();
            dataGridView3.DataSource = detalleVentaControl.ReporteVentasPorEmpleado(1);
            if (dataGridView3.Rows.Count > 0)
            {
                txtNombreUsuario.Text = "Usuario";
                txtMontoTotal.Text = (detalleVentaControl.ReporteVentasPorEmpleado(1)).Rows[0]["Monto obtenido en Bs."].ToString();
            }
        }
    }
}
