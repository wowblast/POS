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

        public void RegistrarEmpresa(Empresa empresa)
        {
            string sql = "INSERT INTO EMPRESAS (nombre, ubicacion, descripcion) VALUES (" + "'" + empresa.Nombre + "', '" + empresa.Ubicacion + "','" + empresa.Descripcion + "')";
            try
            {
                conexion.ExecuteSQL(sql);
                Log.Print("Empresa registrada correctamente." + sql);

            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido una excepcion: " + e.Message);
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
            string sql = "UPDATE EMPRESAS SET nombre = '" + empresa.Nombre + "', ubicacion = '" + empresa.Ubicacion + "', descripcion = '" + empresa.Descripcion + "' WHERE idEmpresa = " + empresa.IdEmpresa;
            try
            {
                conexion.ExecuteSQL(sql);
                Log.Print("Actualización de empresa ejecutada correctamente." + sql);

            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido una excepcion: " + e.Message);
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
