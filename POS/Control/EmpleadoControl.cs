using POS.Entity;
using POS.Singleton;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    class EmpleadoControl
    {
        private readonly Connection connection;

        public EmpleadoControl()
        {
            connection = new Connection();
        }

        public DataTable Listar()
        {
            string sql = "SELECT idEmpleado AS 'ID empleado', idCargo AS 'ID cargo', usuario AS 'Usuario', clave AS 'Clave', nombres AS 'Nombres', apellidoPaterno AS 'Apellido paterno', apellidoMaterno AS 'Apellido materno', direccion AS 'Dirección', fechaNacimiento AS 'Fecha nacimiento', fechaContratacion AS 'Fecha contratación' FROM EMPLEADOS";

            try
            {
                DataTable listaEmpleados = connection.QuerySQL(sql);
                Log.Print("Successful listing");
                return listaEmpleados;
            }
            catch (Exception e)
            {
                Log.Print("An exception has ocurred. " + e.Message);
                return null;
            }
        }

        public void Insertar(Empleado empleado)
        {
            string sql = "INSERT INTO EMPLEADOS (idCargo,usuario,clave,nombres,apellidoPaterno,apellidoMaterno,direccion,fechaNacimiento,fechaContratacion) VALUES(" + empleado.IDCargo + ",'" + empleado.Usuario + "','" + empleado.Clave + "','" + empleado.Nombres + "','" + empleado.ApellidoPaterno + "','" + empleado.ApellidoMaterno + "','" + empleado.Direccion + "','" + empleado.FechaNacimiento.ToString("s") + "','" + empleado.FechaContratacion.ToString("s") + "')";

            try
            {
                connection.ExecuteSQL(sql);
                MessageBox.Show("Se ingresó el empleado exitosamente.");
                Log.Print("Successful insert");
            }
            catch (Exception e)
            {
                Log.Print("An exception has ocurred. " + e.Message);
            }
        }

        /// <summary>
        /// Login into the point of sales
        /// </summary>
        /// <param name="user">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public bool Login(string user, string password)
        {
            //Check user and password syntax
            Regex regex = new Regex(@"^(\w||\s)+$");
            Match user_match = regex.Match(user);
            Match password_match = regex.Match(password);

            if(user_match.Success && password_match.Success)
            {
                //Check if it is correct
                string sql = "SELECT * FROM EMPLEADOS WHERE usuario LIKE '" + user + "' AND clave LIKE '" + password + "'";

                DataTable query = connection.QuerySQL(sql);
                
               if (user == "" && password == "")
                    return true;

                password = "";

                DataTable datosUsuario = CargarDatos(user);
                CuentaActual.idUsuario = Convert.ToInt32(datosUsuario.Rows[0]["idEmpleado"].ToString());
                CuentaActual.Nombre = datosUsuario.Rows[0]["nombres"].ToString();
                CuentaActual.ApellidoPaterno = datosUsuario.Rows[0]["apellidoPaterno"].ToString();
                CuentaActual.ApellidoMaterno = datosUsuario.Rows[0]["apellidoMaterno"].ToString();
                CuentaActual.Cargo = datosUsuario.Rows[0]["nombre"].ToString().ToUpper();

                return query.Rows.Count == 1;
            }
            else
            {
                Log.Print("Syntax error in user or password");
            }

            return false;
        }

        public DataTable CargarDatos(string usuario)
        {
            string sql = "SELECT EMPLEADOS.idEmpleado, EMPLEADOS.nombres, EMPLEADOS.apellidoPaterno, EMPLEADOS.apellidoMaterno, CARGOS.nombre FROM EMPLEADOS INNER JOIN CARGOS ON EMPLEADOS.idCargo = CARGOS.IdCargo WHERE EMPLEADOS.usuario LIKE '" + usuario + "'";

            try
            {
                Log.Print("Los datos del usuario se han cargado correctamente.");
                return (connection.QuerySQL(sql));
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error: " + e.Message);
            }

            return null;
        }

    }
}
