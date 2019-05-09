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
		public void InsertarImagen(int idProducto, byte[] imagen)
		{
			try
			{
				connection.UploadImage(idProducto, imagen);
				MessageBox.Show("¡Registro correcto de  imagen!", "Completado");
				Log.Print("Query executed correctly image added \n");
			}
			catch (Exception e)
			{
				Log.Print("An exception has occurred. " + e.Message);
			}
		}
		public void BorrarImagen(int idProducto)
		{
			string sql = "DELETE FROM IMAGENES_PRODUCTO WHERE idProducto = " + idProducto;

			try
			{
				connection.ExecuteSQL(sql);
				MessageBox.Show("¡imagen eliminado exitosamente!", "Completado");
				Log.Print(sql);
			}
			catch (Exception e)
			{
				Log.Print("An exception has ocurred. " + e.Message);
			}
		}
		public void UpdateImage(int idProducto, byte[] image)
		{
			try
			{
				connection.UpdateImage(idProducto, image);
				MessageBox.Show("¡Actualizado  correcto de  imagen!", "Completado");
				Log.Print("Query executed correctly image added \n");
			}
			catch (Exception e)
			{
				Log.Print("An exception has occurred. " + e.Message);
			}
		}
	}
}
