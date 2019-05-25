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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            EmpleadoControl empleadoControl = new EmpleadoControl();
            dgvEmpleados.DataSource = empleadoControl.Listar();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            FrmEmployeeRegister frmEmployeeRegister = new FrmEmployeeRegister();
            frmEmployeeRegister.Show();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }
    }
}
