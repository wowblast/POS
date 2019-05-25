using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Descripcion { get; set; }

        public Empresa(int idEmpresa, string nombre, string ubicacion, string descripcion)
        {
            IdEmpresa = idEmpresa;
            Nombre = nombre;
            Ubicacion = ubicacion;
            Descripcion = descripcion;
        }

        public Empresa(string nombre, string ubicacion, string descripcion)
        {
            Nombre = nombre;
            Ubicacion = ubicacion;
            Descripcion = descripcion;
        }

        public Empresa() { }
    }
}
