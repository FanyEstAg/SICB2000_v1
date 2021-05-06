using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Entidades;

namespace CapaAccesoDatos
{
    class datMesa
    {
        #region singleton
        private static readonly datMesa _intancia = new datMesa();
        public static datMesa Instancia
        {
            get { return datMesa._intancia; }
        }
        #endregion singleton


        #region metodos

        //public entTipo LstTipoMesa()
        //{
        //    SqlCommand cmd = null;
        //    IDataReader idr = null;
           
        //    List<entTipo> t = null;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cn.Open();
        //        idr = cmd.ExecuteReader();
        //        if (idr.Read())
        //        {
                   

        //            //falta
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally { cmd.Connection.Close(); }
        //    return v;
        //}

        public int EliminarCobroMesaXid(int id)//verificar
        {
            SqlCommand cmd = null;
            try
            {
                int retorno = 0;
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspEliminarCobroMesaXid", cn);
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

        public List<entCobroMesa> ListarCobroMesaXid(String fechadesde, String fechahasta, int idSucursal)
        {
            SqlCommand cmd = null;
            List<entCobroMesa> Lista = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListarCobroMesaXid", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entCobroMesa>();
                while (dr.Read())
                {
                    entCobroMesa cm = new entCobroMesa();
                    entMesa m = new entMesa();
                    m.Id_Mesa = Convert.ToInt32(dr["Id_pagoMesa"]);
                    cm.Id_mesa = m;
                    entUsuario u = new entUsuario();
                    u.Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]);
                    cm.Id_Usuario = u;
                    cm.PagoTotal=Convert.ToDouble(dr["PagoTotal"]);
                    //cm.Tiempo_inicio
                   //terminar
                    Lista.Add(cm);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }


        
        public int GuardarCobroMesa(String cadXml, int id_tipdocventa)//modifcar
        {
            SqlCommand cmd = null;
            var result = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spGuardarVenta", cn);
                //cmd.Parameters.AddWithValue("@Cadxml", cadXml);
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
