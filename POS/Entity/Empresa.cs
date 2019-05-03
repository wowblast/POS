using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    class Empresa
    {
        public int CodigoEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }

        public Empresa(int codigoEmpresa, string nombre, string ubicacion, string descripcion)
        {
            CodigoEmpresa = codigoEmpresa;
            NombreEmpresa = nombre;
            Ubicacion = ubicacion;
            Descripcion = descripcion;
        }
    }
}
