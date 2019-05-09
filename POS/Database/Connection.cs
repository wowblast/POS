using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class Connection
    {
        private readonly string connectionString;

        public Connection()
        {
            connectionString = "Data Source=.;Initial Catalog=POS_BBDD;Integrated Security=True";
        }

        public void ExecuteSQL(string sql)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                Log.Print("EXECUTING SQL: " + sql);

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

		internal void UploadImage(int idProducto, byte[] imagen)
		{
			throw new NotImplementedException();
		}

		public DataTable QuerySQL(string sql)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                Log.Print("EXECUTING SQL: " + sql);

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                {
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(dataReader);

                        return dataTable;
                    }
                }
            }
        }

		internal void UpdateImage(int idProducto, byte[] image)
		{
			throw new NotImplementedException();
		}
	}
}
