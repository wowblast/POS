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

            CargoControl cargoControl = new CargoControl();
            cbCargo.DataSource = cargoControl.Listar();
            cbCargo.DisplayMember = "nombre";
            cbCargo.ValueMember = "idCargo";
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            EmpleadoControl empleadoControl = new EmpleadoControl();
            dgvEmpleados.DataSource = empleadoControl.Listar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombres = tbNombres.Text;
            string apellidoPaterno = tbApellidoPaterno.Text;
            string apellidoMaterno = tbApellidoMaterno.Text;
            string usuario = tbUsuario.Text;
            string clave = tbClave.Text;
            string cargo = cbCargo.SelectedValue.ToString();
            string direccion = tbDireccion.Text;
            DateTime fechaNacimiento = dtpNacimiento.Value;
            DateTime fechaContratacion = dtpContratacion.Value;

            int x = 3;
        }
        
    }
}
