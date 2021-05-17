using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class entVenta
    {
        public int Id_Venta { get; set; }
        public int folio { get; set; }
        public DateTime Fecha_Venta { get; set; }
        public int cantidad { get; set; }
        public double Subtotal_Venta { get; set; }
            
        public double Total { get; set; }//calculo automático
        // Relaciones
        public entUsuario usuario { get; set; }
        public entProducto Id_producto { get; set; }
        public entEstado Estado_Venta { get; set; }
        public List<entVenta> productos { get; set; }
    }
}
