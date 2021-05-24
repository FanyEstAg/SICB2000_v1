using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class negReporte
    {
        #region singleton
        private static readonly negReporte _intancia = new negReporte();
        public static negReporte Instancia
        {
            get { return negReporte._intancia; }
        }
        #endregion singleton

        public DataTable ConsultarVentasxFecha(int dia, int mes, int anio)
        {
            try
            {
                DataTable dt = datReporte.Instancia.ConsultarVentasxFecha(dia, mes, anio);//Llamar el método de acceso a datos

                if (dt.Rows.Count == 0)
                {
                    //Pendiente: Mandar o no mensaje, en caso de no haber venta deja la tabla vacia
                    //throw new ApplicationException("No se encontraron registros");
                }
                return dt;//Enviar la tabla resultante
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ConsultarCobroxFecha(int dia, int mes, int anio)
        {
            try
            {
                DataTable dt = datReporte.Instancia.ConsultarCobroxFecha(dia, mes, anio);//Llamar el método de acceso a datos

                if (dt.Rows.Count == 0)
                {
                    //Pendiente: Mandar o no mensaje, en caso de no haber venta deja la tabla vacia
                    //throw new ApplicationException("No se encontraron registros");
                }
                return dt;//Enviar la tabla resultante
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ConsultarCobroxTiempo()
        {
            try
            {
                DataTable dt = datReporte.Instancia.ConsultarCobroxTiempo();//Llamar el método de acceso a datos

                if (dt.Rows.Count == 0)
                {
                    //Pendiente: Mandar o no mensaje, en caso de no haber venta deja la tabla vacia
                    //throw new ApplicationException("No se encontraron registros");
                }
                return dt;//Enviar la tabla resultante
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable ConsultarCobroxTipo()
        {
            try
            {
                DataTable dt = datReporte.Instancia.ConsultarCobroxTipo();//Llamar el método de acceso a datos

                if (dt.Rows.Count == 0)
                {
                    //Pendiente: Mandar o no mensaje, en caso de no haber venta deja la tabla vacia
                    //throw new ApplicationException("No se encontraron registros");
                }
                return dt;//Enviar la tabla resultante
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
