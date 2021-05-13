//Nombre del programa: SolutionFinal
//Fecha de creación de la base de datos:28.03.2021
//Fecha de entrega: 06.05.2021
//Autor: Elizabeth Lucas García
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
            //tratar o devolver expeción
            try
            {
                String cadXml = "";//se crea la cadena del xml
                cadXml += "<mesa ";//Datos a tratar
                cadXml += "idmesa='" + co.Id_mesa + "'/>";
                cadXml += "idtipo='" + co.Id_mesa.id_tipo + "'/>";
                cadXml += "tiempoTotal='" + co.Tiempo_total + "'/>";
                cadXml += "pagoTotal='" + co.PagoTotal + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int result = datMesa.Instancia.GuardarCobroMesa(cadXml);//Conexión con la BD
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
