using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entProducto
    {
        public int Id_Prod { get; set; }
        public string Nombre_Prod { get; set; } 
        public double Costo_Prod { get; set; }
        public double Precio_Prod { get; set; }
        public int existencia { get; set; }
        public string Descripcion_Prod { get; set; }
        // Relaciones
        public entMarca id_marca { get; set; }
        public entUnidadMedida Id_umed { get; set; }
    
        public entEstado estado { get; set; }
    }
}
