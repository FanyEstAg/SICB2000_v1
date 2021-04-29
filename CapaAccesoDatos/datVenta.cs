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

        public entVenta LstVentaDetalle(int id_venta) {
            SqlCommand cmd = null;
            IDataReader idr = null;
            entVenta v = null;
            List<entDetalleVenta> det = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spMostrarCabeceraVenta", cn);
                cmd.Parameters.AddWithValue("@prmid_venta", id_venta);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                idr = cmd.ExecuteReader();
                if (idr.Read())
                {
                    v = new entVenta();
                    v.Codigo_Venta = idr["Codigo_Venta"].ToString();
                    v.Serie_Venta = Convert.ToInt32(idr["Serie_Venta"].ToString());
                    v.Correlativo_Venta = idr["Correlativo_Venta"].ToString();
                    v.Igv_Venta = Convert.ToInt32(idr["Igv_Venta"]);
                    v.FechaVenta = Convert.ToDateTime(idr["FechaVenta"]);
                    v.Estado_Venta = idr["Estado_Venta"].ToString();
                    v.Descuento_Venta = Convert.ToDouble(idr["Descuento_Venta"]);
                    v.Desc_Venta = idr["Desc_Venta"].ToString();

                    entCliente c = new entCliente();
                    c.Nombre_Cliente = idr["Nombre_Cliente"].ToString();
                    c.NumeroDoc_Cliente = idr["NumeroDoc_Cliente"].ToString();
                    entTipoDocumento td = new entTipoDocumento();
                    td.Nombre_TipDoc = idr["Nombre_TipDoc"].ToString();
                    c.tipodocumento = td;
                    v.cliente = c;

                    entSucursal s = new entSucursal();
                    s.Direccion_Suc = idr["Direccion_Suc"].ToString();
                    v.sucursal = s;

                    entUsuario u = new entUsuario();
                    u.Nombre_Usuario = idr["Nombre_Usuario"].ToString();
                    v.usuario = u;

                    entTipComprobante tc = new entTipComprobante();
                    tc.Nombre_TipCom = idr["Nombre_TipCom"].ToString();
                    v.tipocomprobante = tc;

                    entMoneda m = new entMoneda();
                    m.Descripcion_Moneda = idr["Descripcion_Moneda"].ToString();
                    v.moneda = m;

                    entTipoPago tp = new entTipoPago();
                    tp.Descripcion_TipPago = idr["Descripcion_TipPago"].ToString();
                    v.tipopago = tp;

                    if (idr.NextResult())
                    {
                        det = new List<entDetalleVenta>();
                        while (idr.Read())
                        {
                            entDetalleVenta d = new entDetalleVenta();
                            d.PrecProd_Det = Convert.ToDouble(idr["PrecProd_Det"]);
                            d.Cantidad_Det = Convert.ToInt32(idr["Cantidad_Det"]);
                            entProducto p = new entProducto();
                            p.Codigo_Prod = idr["Codigo_Prod"].ToString();
                            p.Nombre_Prod = idr["Nombre_Prod"].ToString();
                            p.Precio_Prod = Convert.ToDouble(idr["Precio_Prod"]);
                            d.producto = p;
                            det.Add(d);
                        }
                        v.detalleventa = det;
                    }
                }
               
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }return v;
        }

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
