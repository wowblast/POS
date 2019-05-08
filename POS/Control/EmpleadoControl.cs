using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            string sql = "SELECT * FROM EMPLEADOS";

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

        public void Insertar()
        {

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

                return query.Rows.Count == 1;
            }
            else
            {
                Log.Print("Syntax error in user or password");
            }

            return false;
        }

    }
}
