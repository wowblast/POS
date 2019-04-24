using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    public class Estante
    {
        public int CodigoEstante { get; set; }
        public string NumeroEstante { get; set; }
        public string Niveles { get; set; }

        public Estante(int idEstante, string numero, string nivel)
        {
            CodigoEstante = idEstante;
            NumeroEstante = numero;
            Niveles = nivel;
        }
    }
}
