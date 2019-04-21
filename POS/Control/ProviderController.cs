using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Control
{
    class ProviderController
    {
        private Connection connection;

        public ProviderController()
        {
            connection = new Connection();
        }

        public void InsertProvider(string nombre, string ubicacion)
        {
            string sql = "INSERT INTO PROVEEDORES (nombre, ubicacion) VALUES ('" +  nombre + "','" + ubicacion + "')";
            try
            {
                connection.ExecuteSQL(sql);
                MessageBox.Show("¡Registro exitoso del proveedor!", "Completado");
                Log.Print("Query executed correctly \n" + sql);
            }
            catch (Exception e)
            {
                Log.Print("An exception has occurred");
            }
        }
    }
}
