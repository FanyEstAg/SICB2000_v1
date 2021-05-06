using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using CapaAccesoDatos;

namespace CapaNegocio
{
    public class negMesa
    {
        #region singleton
        private static readonly negMesa _instancia = new negMesa();
        public static negMesa Instancia
        {
            get
            {
                return negMesa._instancia;
            }
        }

        #endregion singleton

        public int insertarMesa(entMesa m)
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<mesa ";
                cadXml += "idtipo='" + m.id_tipo + "' ";
                cadXml += "iddisponibilidad='" + m.Id_disponibilidad +  "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int result = datMesa.Instancia.insertarMesa(cadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int insertarTipoMesa(string n)
        {
            try
            {
                
                int result = datMesa.Instancia.insertarTipoMesa(n);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int EliminarMesa(int id_mesa)
        {
            try
            {
                int retorno = datMesa.Instancia.EliminarMesa(id_mesa);
                if (retorno == 0) throw new ApplicationException("No se pudo completar la acción");
                //Excepción en caso de no haberse eliminado
                return retorno;//en caso contrario regresa el valor
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
