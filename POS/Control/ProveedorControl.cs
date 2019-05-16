using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Control
{
    class ProveedorControl
    {
        private Connection connection;

        public ProveedorControl()
        {
            connection = new Connection();
        }

        public int SeleccionarId()
        {
            string sql = "SELECT TOP 1 * FROM PROVEEDORES ORDER BY IdProveedor DESC ";
            try
            {
                DataTable provider = connection.QuerySQL(sql);
                DataRow row = provider.Rows[0];

                int idProveedor = Convert.ToInt32(row["idProveedor"].ToString());
                Log.Print("Identificador seleccionado correctamente!");
                return idProveedor;
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido una excepcion al momento de seleccionar el id del proveedor. " + e.Message);
                return -1;
            }
        }

        public void InsertarProveedor(string nombre, string ubicacion)
        {
            string sql = "INSERT INTO PROVEEDORES (nombre, ubicacion) VALUES ('" + nombre + "','" + ubicacion + "')";
            try
            {
                connection.ExecuteSQL(sql);
                MessageBox.Show("¡Registro exitoso del proveedor!", "Completado");
                Log.Print("Query executed correctly \n" + sql);
            }
            catch (Exception e)
            {
                Log.Print("An exception has occurred. " + e.Message);
            }
        }

        public void EliminarProveedor(int idProveedor)
        {
            string sql = "DELETE FROM PROVEEDORES WHERE idProveedor = " + idProveedor;

            try
            {
                connection.ExecuteSQL(sql);
                MessageBox.Show("¡Proveedor eliminado exitosamente!", "Completado");
                Log.Print(sql);
            }
            catch (Exception e)
            {
                Log.Print("An exception has ocurred. " + e.Message);
            }
        }

        public DataTable ListarProveedor()
        {
            string sql = "SELECT idProveedor AS 'Id proveedor', nombre AS 'Nombre del proveedor', ubicacion AS 'Ubicacion' FROM PROVEEDORES";

            try
            {
                DataTable listProvider = connection.QuerySQL(sql);
                Log.Print("Successful listing");
                return listProvider;
            }
            catch (Exception e)
            {
                Log.Print("An exception has ocurred. " + e.Message);
                return null;
            }
        }

        public void ActualizarProveedor(int idProveedor, string nombreProveedor, string ubicacion)
        {
            string sql = "UPDATE PROVEEDORES SET nombre = '" + nombreProveedor + "', ubicacion = '" + ubicacion + "' WHERE idProveedor = " + idProveedor;
            try
            {
                connection.ExecuteSQL(sql);
                MessageBox.Show("¡Datos actualizados correctamente!", "Completado");
                Log.Print(sql);
            }
            catch (Exception e)
            {
                Log.Print("An exception has ocurred. " + e.Message);
            }
        }

    }
}
