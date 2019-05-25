using POS.Control;
using POS.Entity;
using POS.FrmsEmployee;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar este empleado?", "Importante", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string idEmpleado = dgvEmpleados.SelectedCells[0].Value.ToString();
                    EmpleadoControl empleadoControl = new EmpleadoControl();
                    empleadoControl.Eliminar(idEmpleado);
                    Listar();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "¡Error!");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 1)
            {
                int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedCells[0].Value);
                int idCargo = Convert.ToInt32(dgvEmpleados.SelectedCells[1].Value);
                string usuario = dgvEmpleados.SelectedCells[2].Value.ToString();
                string clave = dgvEmpleados.SelectedCells[3].Value.ToString();
                string nombres = dgvEmpleados.SelectedCells[4].Value.ToString();
                string apellidoPaterno = dgvEmpleados.SelectedCells[5].Value.ToString();
                string apellidoMaterno = dgvEmpleados.SelectedCells[6].Value.ToString();
                string direccion = dgvEmpleados.SelectedCells[7].Value.ToString();
                DateTime fechaNacimiento = Convert.ToDateTime(dgvEmpleados.SelectedCells[8].Value.ToString());
                DateTime fechaContratacion = Convert.ToDateTime(dgvEmpleados.SelectedCells[9].Value.ToString());

                Empleado empleado = new Empleado(idEmpleado, idCargo, usuario, clave, nombres, apellidoPaterno, apellidoMaterno, direccion, fechaNacimiento, fechaContratacion);

                FrmEmployeeUpdate frmEmployeeUpdate = new FrmEmployeeUpdate();
                frmEmployeeUpdate.Show();
                frmEmployeeUpdate.RellenarDatos(empleado);
            }
            else
            {
                MessageBox.Show("¡Debes seleccionar a un empleado!", "Error");
            }
        }
    }
}
