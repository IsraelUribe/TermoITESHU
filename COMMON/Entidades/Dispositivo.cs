using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Dispositivo:Base
    {
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public DateTime FechaColocacion { get; set; }
        public string NombreReLe1 { get; set; }
        public string NombreReLe2 { get; set; }
        public string NombreReLe3 { get; set; }
        public string NombreReLe4 { get; set; }
        public bool EstatusReLe1 { get; set; }
        public bool EstatusReLe2 { get; set; }
        public bool EstatusReLe3 { get; set; }
        public bool EstatusReLe4 { get; set; }
    }
}
