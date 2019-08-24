using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Control
{
	class ProductoControl
	{
		private Connection connection;

		public ProductoControl()
		{
			connection = new Connection();
		}
		public string InsertarProducto(int idEstante, string nombre, string descripcion , double precionUnitarioVenta, int cantidad)
		{
			string sql = "INSERT INTO PRODUCTOS (idEstante, nombre,descripcion,precioUnitarioVenta,cantidad) VALUES ('" + idEstante + "','" + nombre + "','" + descripcion + "','" + precionUnitarioVenta + "','" + cantidad + "'); SELECT SCOPE_IDENTITY()";
			try
			{
				DataTable Productos = connection.QuerySQL(sql);
				string[] idProducto = Productos.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();

				//connection.ExecuteSQL(sql);
				MessageBox.Show("¡Registro correcto de  producto!", "Completado");
				Log.Print("Query executed correctly \n" + sql);

				return idProducto[0];
			}
			catch (Exception e)
			{
				Log.Print("An exception has occurred. " + e.Message);
				return null;

			}
		}

		public void EliminarProducto(int idProducto)
		{
			string sql = "DELETE FROM PRODUCTOS WHERE idProducto = " + idProducto;

			try
			{
				connection.ExecuteSQL(sql);
				MessageBox.Show("Producto eliminado ", "Completado");
				Log.Print(sql);
			}
			catch (Exception e)
			{
				Log.Print("An exception has ocurred. " + e.Message);
			}
		}

		public DataTable ListarProductos()
		{
			string innerjoin = "INNER JOIN PRODUCTO_CATEGORIA ON PRODUCTOS.idProducto = PRODUCTO_CATEGORIA.idProducto)  INNER JOIN CATEGORIAS ON CATEGORIAS.idCategoria = PRODUCTO_CATEGORIA.idCategoria);";
			string sql = "SELECT PRODUCTOS.idProducto AS 'ID PRODUCTO', PRODUCTOS.idEstante AS 'ID ESTANTE', PRODUCTOS.nombre AS 'NOMBRE DEL PRODUCTO', PRODUCTOS.descripcion AS 'DESCRIPCION', PRODUCTOS.precioUnitarioVenta AS 'PRECIO UNITARIO DE VENTA DEL PRODUCTO', PRODUCTOS.cantidad AS 'CANTIDAD'  FROM PRODUCTOS ";

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

		public void ActualizarProducto(int idProducto,int idEstante, string nombre, string descripcion, double precionUnitarioVenta, int cantidad)
		{
			string sql = "UPDATE PRODUCTOS SET idEstante = '" + idEstante + "', nombre = '" + nombre+ "', descripcion = '" + descripcion + "', precioUnitarioVenta = '" + precionUnitarioVenta +"', cantidad = '" + cantidad + " WHERE idProducto = " + idProducto;
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
		public DataTable ListarEstantes()
		{
			string sql = "SELECT idEstante ,numero  from ESTANTES";

			try
			{
				DataTable estantes = connection.QuerySQL(sql);
				Log.Print("Successful listing");
				return estantes;
			}
			catch (Exception e)
			{
				Log.Print("An exception has ocurred. " + e.Message);
				return null;
			}
		}
		public void ActualizarCantidad(int idProducto,int cantidad,int totalCantidad)
		{
			string sql = "UPDATE PRODUCTOS SET  cantidad = " + (totalCantidad-cantidad) + " WHERE idProducto = " + idProducto;
			try
			{
				connection.ExecuteSQL(sql);
				Log.Print(sql);
			}
			catch (Exception e)
			{
				Log.Print("An exception has ocurred. " + e.Message);
			}
		}

		
	}
}
