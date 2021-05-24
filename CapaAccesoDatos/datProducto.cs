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

        
        public List<entProducto> ActExtraerProductos(int Id)
        {
            SqlCommand cmd = null;
            List<entProducto> Lista = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspBuscarProductoxId", cn);
                cmd.Parameters.AddWithValue("@prmId", Id);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entProducto>();
                while (dr.Read())
                {
                    entProducto p = new entProducto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Nombre_Prod = dr["Nom_producto"].ToString();
                    p.existencia= Convert.ToInt32(dr["Existencia"]);
                    p.Costo_Prod = Convert.ToDouble(dr["Costo"]);
                    p.Precio_Prod = Convert.ToDouble(dr["Precio"]);
                    p.Descripcion_Prod = dr["Descp_producto "].ToString();
                    entUnidadMedida um = new entUnidadMedida();
                    um.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
                    um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                    p.Id_umed = um;
                    entMarca m = new entMarca();
                    m.Id_Marca = Convert.ToInt32(dr["Id_Marca"]);
                    m.Nombre_Marca = dr["Nom_marca"].ToString();
                    p.id_marca = m;//--verificar error
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

        public DataTable ProductoExistencia(int id)//revisar
        {
            SqlCommand cmd = null;
            DataTable dt;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListarProdExistencia", cn);
                cmd.Parameters.AddWithValue("@prmId", id);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                 dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return dt;
        }

        public entProducto BuscarProducto(int id_producto)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entProducto p = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspBuscarProducto", cn);
                cmd.Parameters.AddWithValue("@prmId_Prod", id_producto);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p = new entProducto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Nombre_Prod = dr["Nom_producto"].ToString();
                    p.existencia = Convert.ToInt32(dr["Existencia"]);
                    p.Costo_Prod = Convert.ToDouble(dr["Costo"]);
                    p.Precio_Prod = Convert.ToDouble(dr["Precio"]);
                    p.Descripcion_Prod = dr["Descrp_producto"].ToString();
                    entUnidadMedida um = new entUnidadMedida();
                    //um.Id_Umed = Convert.ToInt32(dr.["Id_Umed"]);
                    um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                    p.Id_umed = um;
                    entMarca m = new entMarca();
                    m.Id_Marca = Convert.ToInt32(dr["Id_Marca"]);
                    m.Nombre_Marca = dr["Nom_marca"].ToString();
                    //p.Marca_Prod = m;--verificar error
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return p;
        }

        public List<entProducto> ListarProducto()//modificar
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
                    p.Nombre_Prod = dr["Nom_producto"].ToString();
                    p.existencia = Convert.ToInt32(dr["Existencia"]);
                    p.Costo_Prod = Convert.ToDouble(dr["Costo"]);
                    p.Precio_Prod = Convert.ToDouble(dr["Precio"]);
                    p.Descripcion_Prod = dr["Descrp_producto"].ToString();
                    entUnidadMedida um = new entUnidadMedida();
                    //um.Id_Umed = Convert.ToInt32(dr.["Id_Umed"]);
                    um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                    p.Id_umed = um;
                    entMarca m = new entMarca();
                    m.Id_Marca = Convert.ToInt32(dr["Id_Marca"]);
                    m.Nombre_Marca = dr["Nom_marca"].ToString();
                    //p.Marca_Prod = m;--verificar error
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

       
        //public int MantenimientoProducto(String cadXml)
        //{
        //    SqlCommand cmd = null;
        //    var result = 0;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spInsEditElimProducto", cn);
        //        cmd.Parameters.AddWithValue("@prmCadXml", cadXml);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cn.Open();
        //        result = cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally { cmd.Connection.Close(); }
        //    return result;
        //}

        //public int MantenimientoUnidMedida(String cadXml)
        //{
        //    SqlCommand cmd = null;
        //    var result = 0;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spInsEditElimUnidMed", cn);
        //        cmd.Parameters.AddWithValue("@prmCadXml", cadXml);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cn.Open();
        //        result = cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally { cmd.Connection.Close(); }
        //    return result;
        //}

        
        //public entUnidadMedida BuscarUniMedida(int id_unMed)
        //{
        //    SqlCommand cmd = null;
        //    SqlDataReader dr = null;
        //    entUnidadMedida um = null;
        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("spBuscarUnMedida", cn);
        //        cmd.Parameters.AddWithValue("@prmidUniMed", id_unMed);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cn.Open();
        //        dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            um = new entUnidadMedida();
        //            um.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
        //            um.Codigo_Umed = dr["Codigo_Umed"].ToString();
        //            um.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
        //            um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally { cmd.Connection.Close(); }
        //    return um;
        //}

        public List<entUnidadMedida> ListarUniMedida()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entUnidadMedida> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListarUnidMed", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entUnidadMedida>();
                while (dr.Read())
                {
                    entUnidadMedida um = new entUnidadMedida();
                    um.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
                    um.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
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

        public List<entMarca> ListarMarca()//LISTO
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<entMarca> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListarMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entMarca>();
                while (dr.Read())
                {
                    entMarca m = new entMarca();
                    m.Id_Marca = Convert.ToInt32(dr["Id_Marca"].ToString());
                    m.Nombre_Marca = dr["Nom_marca"].ToString();
                    Lista.Add(m);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }
        public int EliminarProducto(int id_producto)//LISTO
        {
            SqlCommand cmd = null;
            var retorno = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspEliminarProducto", cn);
                cmd.Parameters.AddWithValue("@prmId_Producto", id_producto);
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

        public int insertarProducto(String cadXml)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspInsertarProducto", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@retorno", DbType.Int32);
                p.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(p);
                cn.Open();
                var result = cmd.ExecuteNonQuery();
                cn.Close();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int insertarMarca(String nom)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspInsertarMarca", cn);
                cmd.Parameters.AddWithValue("@prmNombre", nom);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                var result = cmd.ExecuteNonQuery();
                cn.Close();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable CargarProductos()//LISTO
        {
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspCargarProductos", cn);
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

        public DataTable BuscarProducto(string busqueda)
        {//
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspBuscarProducto", cn);
                cmd.Parameters.AddWithValue("@prmBusqueda", busqueda);
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

        public DataTable BuscarProductoExistencia(int id)
        {//
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspBuscarProductoExistencia", cn);
                cmd.Parameters.AddWithValue("@prmBusqueda", id);
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

        public int actualizarProducto(String cadXml)//LISTO
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspActualizarProducto", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                var result = cmd.ExecuteNonQuery();
                cn.Close();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int agregarExistencia(int existencia, int id)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspAgregarExistencia", cn);
                cmd.Parameters.AddWithValue("@prmExistencia", existencia);
                cmd.Parameters.AddWithValue("@prmId", id);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                var result = cmd.ExecuteNonQuery();
                cn.Close();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion metodos

    }
}
