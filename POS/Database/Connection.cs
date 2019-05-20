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

		public void UploadImage(int idProducto, byte[] imagen)
		{
			try
			{
				using (SqlConnection cn = new SqlConnection(connectionString))
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

		public void UpdateImage(int idProducto, byte[] imagen)
		{
			try
			{
				//string sql = "UPDATE CATEGORIAS SET imagen =@data  WHERE idProducto =@idProducto ";

				using (SqlConnection cn = new SqlConnection(connectionString))
				{
					cn.Open();
					using (SqlCommand cmd = new SqlCommand("UPDATE IMAGENES_PRODUCTO SET imagen = @data  WHERE idProducto = @idProducto ", cn))
					{
						cmd.Parameters.AddWithValue("@idProducto", idProducto);
						cmd.Parameters.Add("@data", SqlDbType.VarBinary).Value = imagen;
						cmd.ExecuteNonQuery();
					}
					cn.Close();
				}
			
				Log.Print("Query executed correctly image added \n");
			}
			catch (Exception e)
			{
				Log.Print("An exception has occurred. " + e.Message);
			}
		}
	}
}
