using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Entity
{
    public class Recibo
    {
        public int Numero { get; set; }
        public string NombreQuienPaga { get; set; }
        public float MontoTotal { get; set; }
        public string Concepto { get; set; }
        public string PersonaContacto { get; set; }
        public DateTime Fecha { get; set; }

        public Recibo(int numero, string nombreQuienPaga, string concepto, float montoTotal, DateTime fecha)
        {
            Numero = numero;
            NombreQuienPaga = nombreQuienPaga;
            Concepto = concepto;
            MontoTotal = montoTotal;
            Fecha = fecha;
        }
    }
}
