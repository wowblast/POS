﻿using System;
using System.Collections.Generic;
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
    }
}
