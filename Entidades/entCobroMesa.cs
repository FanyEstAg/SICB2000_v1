using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class entCobroMesa
    {
        public int Id_pagoMesa { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan Tiempo_inicio { get; set; }
        public TimeSpan Tiempo_fin { get; set; }
        public int Tiempo_total { get; set; }//calculo automatico
        public double PagoTotal { get; set; }
        // Relaciones
        public entUsuario Id_Usuario { get; set; }
        public entMesa Id_mesa { get; set; }
    }
}
