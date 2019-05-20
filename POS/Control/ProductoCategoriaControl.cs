using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Control
{
	class ProductoCategoriaControl
	{
		private Connection connection;

		public ProductoCategoriaControl()
		{
			connection = new Connection();
		}
		public string InsertarProductoCategoria(int idProducto, int idCategoria)
		{
			string sql = "INSERT INTO PRODUCTO_CATEGORIA (idProducto,idCategoria) VALUES (" + idProducto + "," + idCategoria + "); SELECT SCOPE_IDENTITY()";
			try
			{
				DataTable Productos = connection.QuerySQL(sql);
				string[] idProductos = Productos.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();

				//connection.ExecuteSQL(sql);
				MessageBox.Show("¡Registro correcto de  producto categoria !", "Completado");
				Log.Print("Query executed correctly \n" + sql);

				return idProductos[0];
			}
			catch (Exception e)
			{
				Log.Print("An exception has occurred. " + e.Message);
				return null;

			}
		}

		public void EliminarProductoCategoria(int idProductoCategoria)
		{
			string sql = "DELETE FROM PRODUCTO_CATEGORIA WHERE idProductoCategoria = " + idProductoCategoria;

			try
			{
				connection.ExecuteSQL(sql);
				MessageBox.Show("Producto Categoria eliminado ", "Completado");
				Log.Print(sql);
			}
			catch (Exception e)
			{
				Log.Print("An exception has ocurred. " + e.Message);
			}
		}

		public DataTable ListarProductosCategoria()
		{
			string innerjoin = "INNER JOIN PRODUCTO_CATEGORIA ON PRODUCTOS.idProducto = PRODUCTO_CATEGORIA.idProducto)  INNER JOIN CATEGORIAS ON CATEGORIAS.idCategoria = PRODUCTO_CATEGORIA.idCategoria);";
			string sql = "SELECT PRODUCTO_CATEGORIA.idProductoCategoria AS 'ID PRODUCTO CATEGORIA' ,PRODUCTOS.idProducto AS 'ID PRODUCTO', PRODUCTOS.idEstante AS 'ID ESTANTE', PRODUCTOS.nombre AS 'NOMBRE DEL PRODUCTO', PRODUCTOS.descripcion AS 'DESCRIPCION', PRODUCTOS.precioUnitarioVenta AS 'PRECIO UNITARIO DE VENTA DEL PRODUCTO', PRODUCTOS.cantidad AS 'CANTIDAD',CATEGORIAS.nombre as 'CATEGORIA' FROM  ((PRODUCTOS " + innerjoin;

			try
			{
				DataTable products = connection.QuerySQL(sql);
				Log.Print("Successful listing");
				return products;
			}
			catch (Exception e)
			{
				Log.Print("An exception has ocurred. " + e.Message);
				return null;
			}
		}

		public void ActualizarProductoCategoria(int idProductoCateogria, int idCategoria)
		{
			string sql = "UPDATE PRODUCTO_CATEGORIA SET idCategoria = " + idCategoria + " WHERE idProductoCategoria = " + idProductoCateogria;
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
