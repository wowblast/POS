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
		public void InsertarProducto(int idEstante, string nombre, string descripcion , int precionUnitarioVenta, int cantidad)
		{
			string sql = "INSERT INTO PRODUCTOS (idEstante, nombre,descripcion,precioUnitarioVenta) VALUES ('" + idEstante + "','" + nombre + "','" + descripcion + "','" + precionUnitarioVenta + "','" + cantidad + "')";
			try
			{
				connection.ExecuteSQL(sql);
				MessageBox.Show("¡Registro correcto de  producto!", "Completado");
				Log.Print("Query executed correctly \n" + sql);
			}
			catch (Exception e)
			{
				Log.Print("An exception has occurred. " + e.Message);
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
			string sql = "SELECT idProducto AS 'ID PRODUCTO', idEstante AS 'ID ESTANTE', nombre AS 'NOMBRE DEL PRODUCTO', descripcion AS 'DESCRIPCION', precionUnitarioVenta AS 'PRECIO UNITARIO DE VENTA DEL PRODUCTO', cantidad AS 'CANTIDAD' FROM PRODUCTOS";

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

		public void ActualizarProducto(int idProducto,int idEstante, string nombre, string descripcion, int precionUnitarioVenta, int cantidad)
		{
			string sql = "UPDATE PRODUCTOS SET idEstante = '" + idEstante + "', nombre = '" + nombre+ "', descripcion = '" + descripcion + "', precionUnitarioVenta = '" + precionUnitarioVenta +"', cantidad = '" + cantidad + " WHERE idProducto = " + idProducto;
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
