using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
	public class Producto
	{
		public int idProducto { get; set; }
		public int idEstante { get; set; }
		public int nombre { get; set; }
		public int descripcion { get; set; }
		public int precioUnitarioVenta { get; set; }
		public int cantidad { get; set; }

		public Producto( int idEstante, int nombre, int descripcion, int precioUnitarioVenta, int cantidad)
		{
			
			this.idEstante = idEstante;
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.precioUnitarioVenta = precioUnitarioVenta;
			this.cantidad = cantidad;
		}
	}
}
