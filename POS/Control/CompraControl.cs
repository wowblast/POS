using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Control
{
    class CompraControl
    {
        private Connection connection;

        public CompraControl()
        {
            connection = new Connection();
        }

        public void RealizarCompra(int idProveedor, int idEmpleado)
        {
            int numeroRecibido = 0;
            DateTime fechaActual = DateTime.Today;
            string sql = "INSERT INTO COMPRAS (idProveedor, idEmpleado, numeroRecibido, fecha) VALUES ('" + idProveedor +
                "','" + idEmpleado + "','" + numeroRecibido + "','" + fechaActual + "')";
            try
            {
                connection.ExecuteSQL(sql);
                Log.Print("Query executed correctly \n" + sql);
            }
            catch (Exception e)
            {
                Log.Print("An exception has occurred. " + e.Message);
            }
        }

        public DataTable ObtenerUltimaCompra()
        {
            string sql = "SELECT MAX(idCompra) FROM COMPRAS";
            try
            {
                DataTable idCompra = connection.QuerySQL(sql);
                Log.Print("Successful listing");
                return idCompra;
            }
            catch (Exception e)
            {
                Log.Print("An exception has ocurred. " + e.Message);
                return null;
            }
        }

    }
}
