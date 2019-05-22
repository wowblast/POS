using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Control
{
    class DetalleVentaControl
    {
        private Connection conexion;

        public DetalleVentaControl()
        {
            conexion = new Connection();
        }

        public DataTable ListarReporteVentasPorEmpleado()
        { 
            string sql = @"SELECT EMPLEADOS.idEmpleado AS 'Id empleado', SUM(PRODUCTOS.precioUnitarioVenta * DETALLE_VENTA.cantidad) AS 'Monto vendido' FROM PRODUCTOS
                           INNER JOIN DETALLE_VENTA ON PRODUCTOS.idProducto = DETALLE_VENTA.idProducto
                           INNER JOIN VENTAS ON DETALLE_VENTA.idVenta = VENTAS.idVenta
                           INNER JOIN EMPLEADOS ON VENTAS.idEmpleado = EMPLEADOS.idEmpleado
                           WHERE " + ObtenerCondicionDeFecha() + " GROUP BY EMPLEADOS.idEmpleado";
            try
            {
                Log.Print("¡Reporte realizado exitosamente!");
                return (conexion.QuerySQL(sql));
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error: " + e.Message);
            }
            return null;
        }

        public DataTable ListarReportePorProductosVendidos()
        {
            string sql = @"SELECT PRODUCTOS.idProducto AS 'Id producto', COUNT(*) AS 'Cantidad vendida' FROM PRODUCTOS
                           INNER JOIN DETALLE_VENTA ON PRODUCTOS.idProducto = DETALLE_VENTA.idProducto
                           INNER JOIN VENTAS ON DETALLE_VENTA.idVenta = VENTAS.idVenta
                           INNER JOIN EMPLEADOS ON VENTAS.idEmpleado = EMPLEADOS.idEmpleado
                           WHERE " + ObtenerCondicionDeFecha() + " GROUP BY PRODUCTOS.idProducto";
            try
            {
                Log.Print("¡Reporte realizado exitosamente!");
                return (conexion.QuerySQL(sql));
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error: " + e.Message);
            }
            return null;
        }

        public DataTable ReporteGeneral()
        {
            string sql = @"SELECT EMPLEADOS.idEmpleado AS 'Id empleado', EMPLEADOS.nombres AS 'Nombres del empleado', EMPLEADOS.apellidoPaterno AS 'Apellido paterno', EMPLEADOS.apellidoMaterno AS 'Apellido materno', PRODUCTOS.idProducto AS 'Id producto', PRODUCTOS.nombre AS 'Nombre del producto', PRODUCTOS.precioUnitarioVenta AS 'Precio unitario', DETALLE_VENTA.cantidad AS 'Cantidad vendida', (PRODUCTOS.precioUnitarioVenta * DETALLE_VENTA.cantidad) AS 'Monto obtenido en Bs.'  FROM PRODUCTOS
                           INNER JOIN DETALLE_VENTA ON PRODUCTOS.idProducto = DETALLE_VENTA.idProducto
                           INNER JOIN VENTAS ON DETALLE_VENTA.idVenta = VENTAS.idVenta
                           INNER JOIN EMPLEADOS ON VENTAS.idEmpleado = EMPLEADOS.idEmpleado
                           WHERE " + ObtenerCondicionDeFecha();
            try
            {
                Log.Print("¡Reporte general realizado exitosamente!");
                return (conexion.QuerySQL(sql));
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error: " + e.Message);
            }
            return null;
        }

        public DataTable ReporteVentasPorEmpleado(int idEmpleado)
        {
            string sql = @"SELECT EMPLEADOS.idEmpleado AS 'Id empleado', EMPLEADOS.nombres AS 'Nombres del empleado', EMPLEADOS.apellidoPaterno AS 'Apellido paterno', EMPLEADOS.apellidoMaterno AS 'Apellido materno', PRODUCTOS.idProducto AS 'Id producto', PRODUCTOS.nombre AS 'Nombre del producto', PRODUCTOS.precioUnitarioVenta AS 'Precio unitario', DETALLE_VENTA.cantidad AS 'Cantidad vendida', SUM(PRODUCTOS.precioUnitarioVenta * DETALLE_VENTA.cantidad) AS 'Monto obtenido en Bs.'  FROM PRODUCTOS
                           INNER JOIN DETALLE_VENTA ON PRODUCTOS.idProducto = DETALLE_VENTA.idProducto
                           INNER JOIN VENTAS ON DETALLE_VENTA.idVenta = VENTAS.idVenta
                           INNER JOIN EMPLEADOS ON VENTAS.idEmpleado = EMPLEADOS.idEmpleado
                           WHERE " + ObtenerCondicionDeFecha() + "AND EMPLEADOS.idEmpleado = " + idEmpleado;
            try
            {
                Log.Print("¡Reporte general realizado exitosamente!");
                return (conexion.QuerySQL(sql));
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error: " + e.Message);
            }
            return null;
        }

        private string ObtenerCondicionDeFecha()
        {
            return "VENTAS.fecha BETWEEN DATEADD(dd, DATEDIFF(dd,0,'" + ObtenerFechaActual() + "'), 0) AND DATEADD(ss,-1,DATEADD(dd, DATEDIFF(dd,0,'" + ObtenerFechaActual() + "'), 1))";
        }

        private string ObtenerFechaActual()
        {
            return DateTime.Now.ToString("yyyy/MM/dd");
        }

        public string ObtenerMontoTotal()
        {
            string sql = @"SELECT SUM(PRODUCTOS.precioUnitarioVenta * DETALLE_VENTA.cantidad) AS 'Monto total' FROM PRODUCTOS
                           INNER JOIN DETALLE_VENTA ON PRODUCTOS.idProducto = DETALLE_VENTA.idProducto
                           INNER JOIN VENTAS ON DETALLE_VENTA.idVenta = VENTAS.idVenta
                           INNER JOIN EMPLEADOS ON VENTAS.idEmpleado = EMPLEADOS.idEmpleado
                           WHERE " + ObtenerCondicionDeFecha() + " GROUP BY EMPLEADOS.idEmpleado";
            try
            {
                Log.Print("¡Monto total obtenido correctamente!");
                
                DataTable tablaMontoTotal = conexion.QuerySQL(sql);
                if (tablaMontoTotal.Rows.Count > 0)
                    return tablaMontoTotal.Rows[0]["Monto total"].ToString();

            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error: " + e.Message);
            }

            return "0";
        }
    }
}
