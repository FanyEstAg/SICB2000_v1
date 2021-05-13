﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using CapaAccesoDatos;
using System.Data;

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

        public int insertarMesa(entMesa m)//LISTO
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<mesa ";
                cadXml += "idtipo='" + m.id_tipo.Id_Tipo + "' ";
                cadXml += "iddisponibilidad='" + m.Id_disponibilidad.Id_Disponibilidad +  "'/>";
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

        public List<entTipo> ListarTipo()//--listo
        {
            try
            {
                return datMesa.Instancia.ListarTipo();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int ObtenerIdMesa()//--listo
        {
            try
            {
                return datMesa.Instancia.ObtenerIdMesa();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int insertarTipoMesa(string tp)
        {
            try
            {
                
                int result = datMesa.Instancia.insertarTipoMesa(tp);
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

        public int actualizarMesa(entMesa m)
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<actMesa ";
                cadXml += "idmesa='" + m.Id_Mesa + "' ";
                cadXml += "idtipo='" + m.id_tipo.Id_Tipo + "' ";
                cadXml += "iddisponibilidad='" + m.Id_disponibilidad.Id_Disponibilidad + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int result = datMesa.Instancia.actualizarMesa(cadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al actualizar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable CargarMesas()
        {
            try
            {
                DataTable dt = datMesa.Instancia.CargarMesas();

                if (dt.Rows.Count == 0)
                {
                    throw new ApplicationException("No se encontraron registros");
                }
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable BuscarMesa(string busqueda)
        {
            try
            {

                DataTable dt = datMesa.Instancia.BuscarMesa(busqueda);

                if (dt.Rows.Count == 0)
                {
                    throw new ApplicationException("No se encontraron registros");
                }
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GuardarCobroMesa(entCobroMesa co)
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
