using POS.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Control
{
    class EmpresaControl
    {
        private Connection conexion;

        public EmpresaControl()
        {
            conexion = new Connection();
        }

        public void RegistrarEmpresa(string nombre, string ubicacion, string descripcion)
        {
            string sql = "INSERT INTO EMPRESAS (nombre, ubicacion, descripcion) VALUES (" + "'" + nombre + "', '" + ubicacion + "','" + descripcion + "')";
            try
            {
                conexion.ExecuteSQL(sql);
                Log.Print("Query executed correctly \n" + sql);

            }
            catch (Exception e)
            {
                Log.Print("An exception has occurred. " + e.Message);
            }
        }

       public DataTable ListarEmpresas()
       {
            string sql = "SELECT idEmpresa AS 'Id empresa', nombre AS 'Nombre empresa', ubicacion AS 'Ubicacion', descripcion AS 'Descripcion' FROM EMPRESAS";
            try
            {
                Log.Print("¡Listado de empresas exitoso!");
                return (conexion.QuerySQL(sql));
            } catch(Exception e)
            {
                Log.Print("Ha ocurrido una excepcion: " + e.Message);
            }
            return null;
       }

        public void ActualizarEmpresa(Empresa empresa)
        {
            string sql = "UPDATE EMPRESA SET nombre = '" + empresa.NombreEmpresa + "', ubicacion = '" + empresa.Ubicacion + "', descripcion = '" + empresa.Descripcion + "' WHERE idEmpresa = " + empresa.CodigoEmpresa;

            try
            {
                conexion.ExecuteSQL(sql);
                MessageBox.Show("¡Actualizacion exitosa de la empresa!", "Completado");
                Log.Print("Query executed correctly \n" + sql);

            }
            catch (Exception e)
            {
                Log.Print("An exception has occurred. " + e.Message);
            }
        }

        public void EliminarEmpresa(int idEmpresa)
        {
            string sql = "DELETE FROM EMPRESAS WHERE idEmpresa = " + idEmpresa;
            try
            {
                conexion.ExecuteSQL(sql);
                Log.Print("Empresa eliminada correctamente.");
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido una excepcion: " + e.Message);
            }
        }
    }
}
