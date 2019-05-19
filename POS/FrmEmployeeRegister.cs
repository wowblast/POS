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
    public partial class FrmEmployeeRegister : Form
    {
        public FrmEmployeeRegister()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
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

            Empleado empleado = new Empleado(Convert.ToInt32(cargo), usuario, clave, nombres, apellidoPaterno, apellidoMaterno, direccion, fechaNacimiento, fechaContratacion);

            EmpleadoControl empleadoControl = new EmpleadoControl();
            empleadoControl.Insertar(empleado);
        }

        private void FrmEmployeeRegister_Load(object sender, EventArgs e)
        {
            CargoControl cargoControl = new CargoControl();
            cbCargo.DataSource = cargoControl.Listar();
            cbCargo.DisplayMember = "nombre";
            cbCargo.ValueMember = "idCargo";
        }
    }
}
