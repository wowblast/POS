using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Control
{
    class CargoControl
    {
        private readonly Connection connection;

        public CargoControl()
        {
            connection = new Connection();
        }

        public DataTable Listar()
        {
            string sql = "SELECT * FROM CARGOS";

            try
            {
                DataTable listaCargos = connection.QuerySQL(sql);
                Log.Print("Successful listing");
                return listaCargos;
            }
            catch (Exception e)
            {
                Log.Print("An exception has ocurred. " + e.Message);
                return null;
            }
        }

    }
}
