using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }

        public Proveedor(int idProveedor, string nombre, string ubicacion)
        {
            IdProveedor = idProveedor;
            Nombre = nombre;
            Ubicacion = ubicacion;
        }

        public Proveedor(string nombre, string ubicacion)
        {
            Nombre = nombre;
            Ubicacion = ubicacion;
        }

        public Proveedor() { }
    }
}
