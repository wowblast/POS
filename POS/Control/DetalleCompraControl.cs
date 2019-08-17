using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Control
{
    class DetalleCompraControl
    {
        private Connection connection;

        public DetalleCompraControl()
        {
            connection = new Connection();
        }
        public void InsertarDetalleCompra(int idCompra, int idProducto, int cantidadCompra, double precioCompra)
        {
            string sql = "INSERT INTO DETALLE_COMPRA (idCompra, idProducto, cantidad, precioUnitarioCompra) VALUES ('" + idCompra +
                "','" + idProducto + "','" + cantidadCompra + "','" + precioCompra + "')";
            try
            {
                connection.ExecuteSQL(sql);
                Log.Print("Query executed correctly \n" + sql);
            }
            catch (Exception e)
            {
                Log.Print("An exception has occurred. " + e.Message);
            }
        }
        public DataTable ListarCompras()
        {
            string sql = @"SELECT COMPRAS.idCompra AS 'Id compra', PROVEEDORES.nombre AS 'proveedor', COMPRAS.idEmpleado AS 'Id empleado', COMPRAS.fecha AS 'fecha', PRODUCTOS.nombre AS 'producto', DETALLE_COMPRA.cantidad AS 'cantidad'  FROM PRODUCTOS
                           INNER JOIN DETALLE_COMPRA ON PRODUCTOS.idProducto = DETALLE_COMPRA.idProducto
                           INNER JOIN COMPRAS ON DETALLE_COMPRA.idCompra = COMPRAS.idCompra
                           INNER JOIN PROVEEDORES ON COMPRAS.idProveedor = PROVEEDORES.idProveedor";
            try
            {
                Log.Print("¡Reporte general realizado exitosamente!");
                return (connection.QuerySQL(sql));
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error: " + e.Message);
            }
            return null;
        }
    }
}
