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

namespace POS.FrmsEmployee
{
    public partial class FrmEmployeeUpdate : Form
    {
        private int idEmpleado;

        public FrmEmployeeUpdate()
        {
            InitializeComponent();
        }

        public void RellenarDatos(Empleado empleado)
        {
            idEmpleado = empleado.IDEmpleado;

            tbNombres.Text = empleado.Nombres;
            tbApellidoPaterno.Text = empleado.ApellidoPaterno;
            tbApellidoMaterno.Text = empleado.ApellidoMaterno;
            tbUsuario.Text = empleado.Usuario;
            tbClave.Text = empleado.Clave;
            tbDireccion.Text = empleado.Direccion;
            cbCargo.SelectedValue = empleado.IDCargo;
        }

        private void FrmEmployeeUpdate_Load(object sender, EventArgs e)
        {
            CargoControl cargoControl = new CargoControl();
            cbCargo.DataSource = cargoControl.Listar();
            cbCargo.DisplayMember = "nombre";
            cbCargo.ValueMember = "idCargo";
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

            Empleado empleado = new Empleado(idEmpleado, Convert.ToInt32(cargo), usuario, clave, nombres, apellidoPaterno, apellidoMaterno, direccion, fechaNacimiento, fechaContratacion);

            EmpleadoControl empleadoControl = new EmpleadoControl();
            empleadoControl.Actualizar(empleado);
        }
    }
}
