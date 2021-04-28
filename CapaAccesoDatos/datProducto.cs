using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace CapaAccesoDatos
{
    public class datProducto
    {
        #region singleton
        private static readonly datProducto _intancia = new datProducto();
        public static datProducto Instancia
        {
            get { return datProducto._intancia; }
        }
        #endregion singleton

        #region metodos

        
        public List<entProducto> LstProdIndicadorAvanzada(String name)
        {
            SqlCommand cmd = null;
            List<entProducto> Lista = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("splistarProdIndicador", cn);
                cmd.Parameters.AddWithValue("@prmname", name);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entProducto>();
                while (dr.Read())
                {
                    entProducto p = new entProducto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    p.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    p.PrecioCompra_Prod = Convert.ToDouble(dr["PrecioCompra_Prod"]);
                    p.Precio_Prod = Convert.ToDouble(dr["Precio_Prod"]);
                    p.Stock_Prod = Convert.ToInt32(dr["Stock_Prod"]);
                    p.StockProm_Prod = Convert.ToInt32(dr["StockProm_Prod"]);
                    p.StockMin_Prod = Convert.ToInt32(dr["StockMin_Prod"]);

                    entCategoria c = new entCategoria();
                    c.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    p.categoria = c;
                    entUnidadMedida um = new entUnidadMedida();
                    um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                    p.unidmedida = um;
                    entMaterial M = new entMaterial();
                    M.Nombre = dr["Nombre_Material"].ToString();
                    p.material = M;
                    Lista.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public List<entProducto> ListarProductoIndicador(String codigo,int id_cat,int rango)
        {
            SqlCommand cmd = null;
            List<entProducto> Lista = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProdStatus", cn);
                cmd.Parameters.AddWithValue("@prmCodigo",codigo);
                cmd.Parameters.AddWithValue("@prmcat",id_cat);
                cmd.Parameters.AddWithValue("@prmstockrango",rango);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entProducto>();
                while (dr.Read())
                {
                    entProducto p = new entProducto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    p.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    p.PrecioCompra_Prod = Convert.ToDouble(dr["PrecioCompra_Prod"]);
                    p.Precio_Prod = Convert.ToDouble(dr["Precio_Prod"]);
                    p.Stock_Prod = Convert.ToInt32(dr["Stock_Prod"]);
                    p.StockProm_Prod = Convert.ToInt32(dr["StockProm_Prod"]);
                    p.StockMin_Prod = Convert.ToInt32(dr["StockMin_Prod"]);

                    entCategoria c = new entCategoria();
                    c.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    p.categoria = c;
                    entUnidadMedida um = new entUnidadMedida();
                    um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                    p.unidmedida = um;
                    entMaterial m = new entMaterial();
                    m.Nombre = dr["Nombre_Material"].ToString();
                    p.material = m;
                    Lista.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }


        public List<entProducto> BuscarProductoAvanzada(int tip_entrada, String valor_entrada)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
           List<entProducto> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProdAvanzada", cn);
                cmd.Parameters.AddWithValue("@prmTipEntrada", tip_entrada);
                cmd.Parameters.AddWithValue("@prmValorEntrada", valor_entrada);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entProducto>();
                while (dr.Read())
                {
                    entProducto p = new entProducto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    p.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    p.Marca_Prod = dr["Marca_Prod"].ToString();
                    p.Precio_Prod = Convert.ToDouble(dr["Precio_Prod"].ToString());
                    p.Stock_Prod = Convert.ToInt32(dr["Stock_Prod"]);
                    entCategoria c = new entCategoria();
                    c.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    p.categoria = c;
                    entUnidadMedida um = new entUnidadMedida();
                    um.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    p.unidmedida = um;
                    entMaterial m = new entMaterial();
                    m.Nombre = dr["Nombre_Material"].ToString();
                    p.material = m;
                    Lista.Add(p);

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public entProducto BuscarProducto(int id_producto)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entProducto p = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProducto", cn);
                cmd.Parameters.AddWithValue("@prmId_Prod", id_producto);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p = new entProducto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    p.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    p.Marca_Prod = dr["Marca_Prod"].ToString();
                    p.PrecioCompra_Prod =Convert.ToDouble(dr["PrecioCompra_Prod"].ToString());
                    p.Precio_Prod = Convert.ToDouble(dr["Precio_Prod"].ToString());
                    p.Stock_Prod = Convert.ToInt32(dr["Stock_Prod"]);
                    p.StockProm_Prod = Convert.ToInt32(dr["StockProm_Prod"]);
                    p.StockMin_Prod = Convert.ToInt32(dr["StockMin_Prod"]);
                    entCategoria c = new entCategoria();
                    c.Id_Cat = Convert.ToInt32(dr["Id_Cat"]);
                    p.categoria = c;
                    entUnidadMedida um = new entUnidadMedida();
                    um.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
                    p.unidmedida = um;
                    entProveedor pr = new entProveedor();
                    pr.Id_Proveedor = Convert.ToInt32(dr["Id_Proveedor"]);
                    p.proveedor = pr;
                    entMaterial m = new entMaterial();
                    m.Id = Convert.ToInt32(dr["Id_Material"]);
                    p.material = m;

                       
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return p;
        }

        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> Lista = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entProducto>();
                while (dr.Read())
                {
                    entProducto p = new entProducto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    p.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    p.Marca_Prod = dr["Marca_Prod"].ToString();
                    entCategoria c = new entCategoria();
                    c.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    p.categoria = c;
                    entUnidadMedida um = new entUnidadMedida();
                    um.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    p.unidmedida = um;
                    entProveedor pr = new entProveedor();
                    pr.RazSocial_Proveedor = dr["RazSocial_Proveedor"].ToString();
                    p.proveedor = pr;
                    Lista.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public int MantenimientoProducto(String cadXml)
        {
            SqlCommand cmd = null;
            var result = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsEditElimProducto", cn);
                cmd.Parameters.AddWithValue("@prmCadXml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return result;
        }

       

        public int MantenimientoUnidMedida(String cadXml)
        {
            SqlCommand cmd = null;
            var result = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsEditElimUnidMed", cn);
                cmd.Parameters.AddWithValue("@prmCadXml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return result;
        }

        
        public entUnidadMedida BuscarUniMedida(int id_unMed)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entUnidadMedida um = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarUnMedida", cn);
                cmd.Parameters.AddWithValue("@prmidUniMed", id_unMed);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    um = new entUnidadMedida();
                    um.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
                    um.Codigo_Umed = dr["Codigo_Umed"].ToString();
                    um.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return um;
        }

        

        public List<entUnidadMedida> ListarUniMedida()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entUnidadMedida> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarUnidMed", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entUnidadMedida>();
                while (dr.Read())
                {
                    entUnidadMedida um = new entUnidadMedida();
                    um.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
                    um.Codigo_Umed = dr["Codigo_Umed"].ToString();
                    um.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                    um.Estado_Umed = Convert.ToInt32(dr["Estado_Umed"]);
                    Lista.Add(um);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

      
        #endregion metodos



    }
}
