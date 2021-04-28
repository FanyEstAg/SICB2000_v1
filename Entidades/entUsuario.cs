using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entUsuario
    {
        public int Id_Usuario { get; set; }
        public String Nombre_Usuario { get; set; }
        public String Password_Usuario { get; set; }
        // Relaciones -----------------------------------
        public entEmpleado Id_empleado { get; set; }

    }
}
