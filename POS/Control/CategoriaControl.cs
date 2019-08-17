using POS.Entity;
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

        public DataTable ListarParcialmente(int idCategoria)
        {
            string sql = "SELECT idCategoria AS 'ID CATEGORIA', nombre AS 'NOMBRE', descripcion AS 'DESCRIPCIÓN', subcategoria as 'CATEGORÍA A LA QUE PERTENECE' FROM CATEGORIAS WHERE idCategoria != " + idCategoria;

            try
            {
                DataTable dataTable = connection.QuerySQL(sql);
                Log.Print("Successful listing");
                return dataTable;
            }
            catch (Exception e)
            {
                Log.Print("An exception has ocurred. " + e.Message);
                return null;
            }
        }

        public DataTable Listar()
        {
            string sql = "SELECT idCategoria AS 'ID CATEGORIA', nombre AS 'NOMBRE', descripcion AS 'DESCRIPCION', subcategoria as 'CATEGORIA A LA QUE PERTENECE' FROM CATEGORIAS WHERE idCategoria != 1";

            try
            {
                DataTable dataTable = connection.QuerySQL(sql);
                Log.Print("Successful listing");
                return dataTable;
            }
            catch (Exception e)
            {
                Log.Print("An exception has ocurred. " + e.Message);
                return null;
            }
        }

        public void Ingresar(Categoria categoria)
		{
			string sql = "INSERT INTO CATEGORIAS (nombre, descripcion, subcategoria) VALUES ('" + categoria.Nombre + "', '" + categoria.Descripcion + "', "+ categoria.Subcategoria +")";
			try
			{
				connection.ExecuteSQL(sql);
				MessageBox.Show("¡Categoría añadida exitosamente!", "Completado");
				Log.Print("Query executed correctly \n" + sql);
			}
			catch (Exception e)
			{
				Log.Print("An exception has occurred. " + e.Message);
			}
		}

		public void Eliminar(int idCategoria)
		{
			string sql = "DELETE FROM CATEGORIAS WHERE idCategoria = " + idCategoria;

			try
			{
				connection.ExecuteSQL(sql);
				MessageBox.Show("¡Categoría eliminada exitosamente!", "Completado");
				Log.Print(sql);
			}
			catch (Exception e)
			{
				Log.Print("An exception has ocurred. " + e.Message);
			}
		}

		public void Modificar(Categoria categoria)
		{
			string sql = "UPDATE CATEGORIAS SET nombre = '" + categoria.Nombre + "', descripcion = '" + categoria.Descripcion + "', subcategoria = " + categoria.Subcategoria +" WHERE idCategoria = " + categoria.IdCategoria;
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

	}
}
