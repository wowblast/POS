using POS.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
	public partial class FrmInicioSesion : Form
	{
		public FrmInicioSesion()
		{
			InitializeComponent();
		}

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string password = txt_password.Text;

            EmpleadoControl empleadoControl = new EmpleadoControl();
            bool login = empleadoControl.Login(user, password);

            password = "";

            if (login)
            {
                // Comentar esta linea para poder utilizar la cuenta actual
                CuentaActual.Cargo = "ADMINISTRADOR";

                if (CuentaActual.Cargo == "ADMINISTRADOR")
                {
                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    frmMainMenu.Show();
                    Hide();
                }
                else
                {
                    FrmMainMenuEmployee frmMainMenuEmployee = new FrmMainMenuEmployee();
                    frmMainMenuEmployee.Show();
                    Hide();
                } 
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
