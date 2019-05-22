using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Control
{
    class EmpresaProveedorControl
    {
        private Connection conexion;

        public EmpresaProveedorControl()
        {
            conexion = new Connection();
        }

        public void RegistrarEmpresaProveedor(int idEmpresa, int idProveedor)
        {
            string sql = "INSERT INTO EMPRESA_PROVEEDOR (idEmpresa, idProveedor) VALUES(" + idEmpresa + "," + idProveedor + ")";
            try
            {
                conexion.ExecuteSQL(sql);
                Log.Print("¡Registrado correctamente! " + sql);
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error. " + e.Message);
            }
        }

        public DataTable ListarEmpresaProveedor()
        {
            string sql = @"SELECT PROVEEDORES.idProveedor AS 'Id Proveedor', PROVEEDORES.nombre AS 'Nombre del proveedor', PROVEEDORES.ubicacion AS 'Ubicacion', EMPRESAS.idEmpresa AS 'Id Empresa', EMPRESAS.nombre AS 'Nombre de la empresa', EMPRESAS.descripcion AS 'Descripcion de la empresa', EMPRESA_PROVEEDOR.idEmpresaProveedor AS 'Id Empresa Proveedor' FROM EMPRESAS 
                           INNER JOIN EMPRESA_PROVEEDOR ON EMPRESAS.idEmpresa = EMPRESA_PROVEEDOR.idEmpresa
                           INNER JOIN PROVEEDORES ON EMPRESA_PROVEEDOR.idProveedor = PROVEEDORES.idProveedor";
            try
            {
                Log.Print("¡Listado de empresas proveedores exitoso!");
                return (conexion.QuerySQL(sql));
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error. " + e.Message);
            }
            return null;
        }

        public void ActualizarEmpresaProveedor(int idEmpresaProveedor, int idEmpresa, int idProveedor)
        {
            string sql = "UPDATE EMPRESA_PROVEEDOR SET idEmpresa = " + idEmpresa +  ", idProveedor = " + idProveedor + " WHERE idEmpresaProveedor =" + idEmpresaProveedor;
            try
            {
                conexion.ExecuteSQL(sql);
                Log.Print("¡Actualizado correctamente! " + sql);
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error. " + e.Message);
            }
        }

        public void EliminarEmpresaProveedor(int idEmpresaProveedor)
        {
            string sql = "DELETE FROM EMPRESA_PROVEEDOR WHERE idEmpresaProveedor = " + idEmpresaProveedor;
            try
            {
                conexion.ExecuteSQL(sql);
                Log.Print("¡Se ha eliminado la empresa_proveedor correctamente!");
            }
            catch (Exception e)
            {
                Log.Print("Ha ocurrido un error: " + e.Message);
            }
        }
    }
}
