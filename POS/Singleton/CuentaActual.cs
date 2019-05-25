using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Singleton
{
    public static class CuentaActual
    {
        public static int idUsuario { get; set; }
        public static string Nombre { get; set; }
        public static string ApellidoPaterno { get; set; }
        public static string ApellidoMaterno { get; set; }
        public static string Cargo { get; set; }
    }
}
