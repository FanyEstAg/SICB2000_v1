using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class entMesa
    {
        public int Id_Mesa { get; set; }
        // Relaciones
        public entTipo id_tipo { get; set; }
        public entDisponibilidad Id_disponibilidad { get; set; }
    }
}
