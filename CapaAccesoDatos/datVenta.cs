using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;
namespace CapaAccesoDatos
{
    public class datVenta
    {
        #region singleton
        private static readonly datVenta _intancia = new datVenta();
        public static datVenta Instancia
        {
            get { return datVenta._intancia; }
        }
        #endregion singleton


        #region metodos


        public DataTable CargarProductosVentas()//LISTO
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspCargarProductosVentas", cn);
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
        
        //  Método para eliminar Venta - Capa Acceso de Datos
        //--Fecha de creación 04.05.2021
        //--Fecha de entrega 06.05.2021
        //--Número de equipo Equipo #6 
        // By Fany Estrada
        public int EliminarVentaXid(int id_venta, int idproducto) {//LISTO
            SqlCommand cmd = null;
            var retorno=0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspEliminarVentaXid", cn);
                cmd.Parameters.AddWithValue("@prmId_venta", id_venta);
                cmd.Parameters.AddWithValue("@prmId_producto", idproducto);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                retorno = cmd.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
        }

        public int ModificarVentaXid(int id_venta)
        {//verificar-1/2 listo
            SqlCommand cmd = null;
            var retorno = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspModificarVentaXid", cn);
                cmd.Parameters.AddWithValue("@prmId_venta", id_venta);
                cmd.Parameters.AddWithValue("@prmId_venta", id_venta);
                cmd.Parameters.AddWithValue("@prmId_venta", id_venta);
                cmd.Parameters.AddWithValue("@prmId_venta", id_venta);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                retorno = cmd.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
        }

        //  Método para eliminar Venta - Capa Acceso a Datos
        //--Fecha de creación 04.05.2021
        //--Fecha de entrega 06.05.2021
        //--Número de equipo Equipo #6 
        // By Fany Estrada
        public int GuardarVenta(String cadXml)//LISTO
        {
            SqlCommand cmd = null;
            var result = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspGuardarVenta", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadXml);//se envia el xml
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                result = cmd.ExecuteNonQuery();//Se ve si algun registro fue afectado
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
        }

        public int  ModificarVenta(String cadXml)//LISTO
        {
            SqlCommand cmd = null;
            var result = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspModificarVenta", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadXml);//se envia el xml
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
        }
        public int ObtenerIdVenta()//---listo
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            int r = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspObtenerIdVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r = Convert.ToInt32(dr["folio"]);
                }
                cn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return r;
        }

        public DataTable BuscarVenta(int id)//LISTO
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspBuscarVentas", cn);
                cmd.Parameters.AddWithValue("@prmIdVenta", id);
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
        public DataTable CargarVenta()//LISTO
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspCargarVentas", cn);
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
        #endregion metodos


    }
}
