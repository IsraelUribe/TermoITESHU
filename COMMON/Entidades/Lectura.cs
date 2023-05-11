using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Lectura:Base
    {
        public string IdDIspositivo { get; set; }
        public float Temperatura { get; set; }
        public float Humedad { get; set; }
        public float Luminosidad { get; set; }
        public bool EstatusReLe1 { get; set; }
        public bool EstatusReLe2 { get; set; }
        public bool EstatusReLe3 { get; set; }
        public bool EstatusReLe4 { get; set; }

    }
}
