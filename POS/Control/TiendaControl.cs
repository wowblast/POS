using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Control
{
    class TiendaControl
    {
        private Connection connection;

        public TiendaControl()
        {
            connection = new Connection();
        }

        public void AñadirEstantería(string nombre, int niveles)
        {
            for (int i = 0; i < niveles; i++)
            {
                string sql = "INSERT INTO ESTANTES (numero, nivel) VALUES ('" + nombre + "', '" + (i+1) + "')";
                try
                {
                    connection.ExecuteSQL(sql);
                    MessageBox.Show("¡Estantería añadida exitosamente!", "Completado");
                    Log.Print("Query executed correctly \n" + sql);
                }
                catch (Exception e)
                {
                    Log.Print("An exception has occurred. " + e.Message);
                }
            }
        }
        public void EliminarEstantería(int idEstante)
        {
            string sql = "DELETE FROM ESTANTES WHERE idEstante = " + idEstante;

            try
            {
                connection.ExecuteSQL(sql);
                MessageBox.Show("¡Estantería eliminada exitosamente!", "Completado");
                Log.Print(sql);
            }
            catch (Exception e)
            {
                Log.Print("An exception has ocurred. " + e.Message);
            }
        }
        public void ModificarEstante(int idEstante, string nombre, string niveles)
        {
            string sql = "UPDATE ESTANTES SET numero = '" + nombre + "', nivel = '" + niveles + "' WHERE idEstante = " + idEstante;
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
        public DataTable ListarEstantes()
        {
            string sql = "SELECT idEstante AS 'ID ESTANTE', numero AS 'ESTANTE', nivel AS 'NIVEL' FROM ESTANTES";

            try
            {
                DataTable listShelve = connection.QuerySQL(sql);
                Log.Print("Successful listing");
                return listShelve;
            }
            catch (Exception e)
            {
                Log.Print("An exception has ocurred. " + e.Message);
                return null;
            }
        }
    }

}
