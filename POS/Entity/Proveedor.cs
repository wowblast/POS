using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    public class Proveedor
    {
		//t
        public int CodigoProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string Ubicacion { get; set; }

        public Proveedor(int idProveedor, string nombre, string ubicacion)
        {
            CodigoProveedor = idProveedor;
            NombreProveedor = nombre;
            Ubicacion = ubicacion;
        }
    }
}
