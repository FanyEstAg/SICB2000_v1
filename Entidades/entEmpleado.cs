using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class entEmpleado
    {
        public int Id_empleado { get; set; }
        public String Nombre_empleado { get; set; }
        public String apepat_empelado { get; set; }
        public String apemat_empleado { get; set; }
        public String telefono_empleado { get; set; }
        public String direccion_empleado { get; set; }
        // Relaciones -----------------------------------
        public entRol Id_Rol { get; set; }
    }
}
