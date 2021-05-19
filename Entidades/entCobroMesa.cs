//Nombre del programa: SolutionFinal
//Fecha de creación de la base de datos:28.03.2021
//Fecha de entrega: 06.05.2021
//Autor: Elizabeth Lucas García
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class entCobroMesa
    {
        //Encapsulamiento
        public int Id_pagoMesa { get; set; }
        public DateTime fecha { get; set; }
        public DateTime Tiempo_inicio { get; set; }
        public DateTime Tiempo_fin { get; set; }
        public int Tiempo_total { get; set; }//cálculo automático
        public double PagoTotal { get; set; }
        // Relaciones
        public entUsuario Id_Usuario { get; set; }
        public entMesa Id_mesa { get; set; }
    }
}
