using CapaAccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class negCobroMesa 
    {
        public int GuardarCobroMesa (entCobroMesa co)
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<mesa ";
                cadXml += "idmesa='" + co.Id_mesa + "'/>";
                cadXml += "idtipo='" + co.Id_mesa.id_tipo + "'/>";
                cadXml += "tiempoTotal='" + co.Tiempo_total + "'/>";
                cadXml += "pagoTotal='" + co.PagoTotal + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int result = datMesa.Instancia.GuardarCobroMesa(cadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
