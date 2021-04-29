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

        
        public int obtenerIDVenta()
        {//verificar-1/2 listo
            SqlCommand cmd = null;
            try
            {
                int id;
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspObtenerID",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar());
                return id;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
        }
        public int EliminarVentaXid(int id_venta) {//verificar-1/2 listo
            SqlCommand cmd = null;
            var retorno=0;
            try
            {
                
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspEliminarVentaXid", cn);
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

        public int ModificarVentaXid(int id_venta)
        {//verificar-1/2 listo
            SqlCommand cmd = null;
            var retorno = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspModificarVentaXid", cn);
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

        public int GuardarVenta(String cadXml, int id_tipdocventa)
        {
            SqlCommand cmd = null;
            var result = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spGuardarVenta", cn);
                //añadir lineas de parametros
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

       

        #endregion metodos


    }
}
