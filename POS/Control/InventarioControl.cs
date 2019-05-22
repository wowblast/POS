using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Control
{
    class InventarioControl
    {
        private Connection conexion;

        public InventarioControl()
        {
            conexion = new Connection();
        }

        public DataTable ConsultarProductosExistentes()
        {
            string sql = @"SELECT PRODUCTOS.idProducto AS 'Id producto', PRODUCTOS.nombre AS 'Nombre del producto', PRODUCTOS.precioUnitarioVenta AS 'Precio unitario de venta', PRODUCTOS.cantidad AS 'Cantidad existente', ESTANTES.numero AS 'Numero de estante', ESTANTES.nivel AS 'Nivel del estante' FROM PRODUCTOS
                           INNER JOIN ESTANTES ON PRODUCTOS.idEstante = ESTANTES.idEstante";

            try
            {
                Log.Print("¡Inventado ejecutado exitosamente!");
                return (conexion.QuerySQL(sql));
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error en la consulta: " +  e.Message);
            }

            return null;
        }
    }
}
