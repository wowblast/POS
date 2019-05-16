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

		public void AñadirCategoria(string nombre, string descripcion, int subcategoria)
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
		public void EliminarCategoria(int idCategoria)
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
		public void ModificarCategoria(int idCategoria, string nombre, string descripcion, int subcategoria)
		{
			string sql = "UPDATE CATEGORIAS SET nombre = '" + nombre + "', descripcion = '" + descripcion + "', subcategoria = '" + subcategoria +"' WHERE idCategoria = " + idCategoria;
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
			string sql = "SELECT idCategoria AS 'ID CATEGORIA', nombre AS 'NOMBRE CATEGORIA', descripcion AS 'DESCRIPCIÓN', subcategoria as 'SUBCATEGORIA' FROM CATEGORIAS";

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
