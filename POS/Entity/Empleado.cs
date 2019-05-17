using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    class Empleado
    {
        public int IDEmpleado { get; set; }
        public int IDCargo { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }

        public Empleado(int iDEmpleado, int iDCargo, string usuario, string clave, string nombres, string apellidoPaterno, string apellidoMaterno, string direccion, DateTime fechaNacimiento, DateTime fechaContratacion)
        {
            IDEmpleado = iDEmpleado;
            IDCargo = iDCargo;
            Usuario = usuario;
            Clave = clave;
            Nombres = nombres;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            FechaContratacion = fechaContratacion;
        }

        public Empleado(int iDCargo, string usuario, string clave, string nombres, string apellidoPaterno, string apellidoMaterno, string direccion, DateTime fechaNacimiento, DateTime fechaContratacion)
        {
            IDCargo = iDCargo;
            Usuario = usuario;
            Clave = clave;
            Nombres = nombres;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            FechaContratacion = fechaContratacion;
        }

    }
}
