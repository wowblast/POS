using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Control
{
	public class ImagenProducto
	{
		private Connection connection;
		public ImagenProducto()
		{
			connection = new Connection();
		}
		public void InsertarImagen(int idProducto,byte [] imagen)
		{
			try
			{
				using (SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=POS_BBDD;Integrated Security=True"))
				{
					cn.Open();
					using (SqlCommand cmd = new SqlCommand("insert into IMAGENES_PRODUCTO (idProducto,imagen) VALUES (@idProducto,@data)", cn))
					{
						cmd.Parameters.AddWithValue("@idProducto", idProducto);
						cmd.Parameters.AddWithValue("@data", imagen);
						cmd.ExecuteNonQuery();
					}
				}


				MessageBox.Show("¡Registro correcto de  imagen!", "Completado");
				Log.Print("Query executed correctly image added \n" );
			}
			catch (Exception e)
			{
				Log.Print("An exception has occurred. " + e.Message);
			}
		}
		public void BorrarImagen()
		{

		}
	}
}
