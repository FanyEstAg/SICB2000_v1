using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CapaAccesoDatos
{
   public class datReporte
    {
        #region singleton
        private static readonly datReporte _intancia = new datReporte();
        public static datReporte Instancia
        {
            get { return datReporte._intancia; }
        }
        #endregion singleton


        public DataTable ConsultarVentasxFecha(int dia, int mes, int anio)//LISTO
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspConsultarVentasxFecha", cn);
                cmd.Parameters.AddWithValue("@prmDia", dia);//
                cmd.Parameters.AddWithValue("@prmMes", mes);//
                cmd.Parameters.AddWithValue("@prmAnio", anio);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return dt;
        }


        public DataTable ConsultarCobroxFecha(int dia, int mes, int anio)//LISTO
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspConsultarCobroxFecha", cn);
                cmd.Parameters.AddWithValue("@prmDia", dia);//
                cmd.Parameters.AddWithValue("@prmMes", mes);//
                cmd.Parameters.AddWithValue("@prmAnio", anio);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return dt;
        }

        public DataTable ConsultarCobroxTiempo()//LISTO
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspConsultarCobroxTiempo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return dt;
        }

        public DataTable ConsultarCobroxTipo()//LISTO
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspConsultarCobroxTipo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return dt;
        }
    }
}
