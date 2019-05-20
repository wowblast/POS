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
			try
			{
				using (SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=POS_BBDD;Integrated Security=True"))
				{
					cn.Open();
					using (SqlCommand cmd = new SqlCommand("insert into IMAGENES_PRODUCTO (idProducto,imagen) VALUES (@idProducto,@data)", cn))
					{
						cmd.Parameters.AddWithValue("@idProducto", idProducto);
						cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = imagen;
						cmd.ExecuteNonQuery();
					}
				}
				Log.Print("Query executed correctly image added \n");
			}
			catch (Exception e)
			{
				Log.Print("An exception has occurred. " + e.Message);
			}
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
