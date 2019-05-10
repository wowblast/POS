using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Control
{
	class CategoriaControl
	{
		private Connection connection;

		public CategoriaControl()
		{
			connection = new Connection();
		}

		public void AñadirEstantería(string nombre, string descripcion, string subcategoria)
		{
			string sql = "INSERT INTO CATEGORIAS (nombre, descripcion, subcategoria) VALUES ('" + nombre + "', '" + descripcion + "',' "+ subcategoria +"')";
			try
			{
				connection.ExecuteSQL(sql);
				MessageBox.Show("¡Categoria añadida exitosamente!", "Completado");
				Log.Print("Query executed correctly \n" + sql);
			}
			catch (Exception e)
			{
				Log.Print("An exception has occurred. " + e.Message);
			}
		}
		public void EliminarEstantería(int idCategoria)
		{
			string sql = "DELETE FROM CATEGORIAS WHERE idCategoria = " + idCategoria;

			try
			{
				connection.ExecuteSQL(sql);
				MessageBox.Show("¡categoria eliminada exitosamente!", "Completado");
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
		public DataTable ListarCateogorias()
		{
			string sql = "SELECT idCategoria AS 'ID CATEGORIAS', nombre AS 'NOMBRE CATEGORIA', descripcion AS 'DESCRIPCIÓN', subcategoria as 'SUBCATEGORIA FROM CATEGORIAS";

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
