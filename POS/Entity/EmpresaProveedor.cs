using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    public class EmpresaProveedor
    {
        public int IdEmpresaProveedor { get; set; }
        public int IdEmpresa { get; set; }
        public int IdProveedor { get; set; }

        public EmpresaProveedor(int idEmpresaProveedor, int idEmpresa, int idProveedor)
        {
            IdEmpresaProveedor = idEmpresaProveedor;
            IdEmpresa = idEmpresa;
            IdProveedor = idProveedor;
        }

        public EmpresaProveedor(int idEmpresa, int idProveedor)
        {
            IdEmpresa = idEmpresa;
            IdProveedor = idProveedor;
        }

        public EmpresaProveedor() { }
    }
}
