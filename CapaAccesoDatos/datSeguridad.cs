using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using Entidades;
using System.Windows.Forms;

namespace CapaAccesoDatos
{
    public class datSeguridad{

        #region singleton
        private static readonly datSeguridad _instancia = new datSeguridad();
        public static datSeguridad Instancia{
            get { return datSeguridad._instancia; }
        }
        #endregion singleton

        #region metodos


        public int insertarUsuario(String cadXml)//LISTO
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspInsertarUsuario", cn);
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

        public int insertarEmpleado(String cadXml)//LISTO
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspInsertarEmpleado", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter p = new SqlParameter("@retorno", DbType.Int32);
                //p.Direction = ParameterDirection.ReturnValue;
                //cmd.Parameters.Add(p);
                cn.Open();
                var result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int actualizarUsuario(String cadXml)//LISTO
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspActualizarUsuario", cn);
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

        public int actualizarEmpleado(String cadXml)//LISTO
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspActualizarEmpleado", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add(p);
                cn.Open();
                var result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int EliminarUsuarioXid(int id_usuario) //LISTO
        {//LISTO
            SqlCommand cmd = null;
            var retorno = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspEliminarUsuario", cn);
                cmd.Parameters.AddWithValue("@prmId_Usuario", id_usuario);
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

        public bool VerificarDatosCambioContrasena(String usuario, String clave)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            var result = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspVerificarDatosCambioContrasena", cn);
                cmd.Parameters.AddWithValue("@prmUsuario", Convert.ToInt32(usuario));
                cmd.Parameters.AddWithValue("@prmContrasena", clave);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr= cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    result = true;
                }
               
                cn.Close();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public int cambiarContrasena(String cadXml)//LISTO
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspCambiarContrasena", cn);
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

        public DataTable BuscarUsuario(String busqueda){//
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspBuscarUsuario", cn);
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

        public DataTable CargarUsuarios()
        {//listo
            SqlCommand cmd = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspCargarUsuarios", cn);
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
        public int ObtenerIdEmpleado()//---listo
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            int r = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspObtenerIdEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r = Convert.ToInt32(dr["Id_empleado"]);
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

        public int ObtenerIdEmpleado(int id)//---listo
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            int r = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspObtenerIdEmpleadoActualizar", cn);
                cmd.Parameters.AddWithValue("@prmUsuario", id);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r = Convert.ToInt32(dr["Id_Empleado"]);
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

        public string ListarRolDescrp(Int32 idRol)//---listo
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string r="";
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspMostrarDescrpRol", cn);
                cmd.Parameters.AddWithValue("@prmRol", idRol);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    r=dr["Descrp_rol"].ToString();
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

        public List<entRol> ListarRol() {//--listo
            SqlCommand cmd = null;
            SqlDataReader dr = null;
           List<entRol> Lista = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspListaRol", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<entRol>();
                while (dr.Read())
                {
                    entRol r = new entRol();
                    r.Id_Rol = Convert.ToInt32(dr["Id_Rol"]);
                    r.Nom_Puesto = dr["Nom_puesto"].ToString();
                    r.Descripcion_Rol = dr["Descrp_rol"].ToString();
                    Lista.Add(r);
                    //MessageBox.Show("" + Lista);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        
        public entUsuario VerificarAcceso(String usuario,String clave){//logeo --listo
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entUsuario u = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspIniciar_Sesion", cn);
                cmd.Parameters.AddWithValue("@prmUsuario", usuario);
                cmd.Parameters.AddWithValue("@prmContrasena", clave);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    u = new entUsuario();
                    u.Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]);
                    u.Nombre_Usuario = dr["nombre_Usuario"].ToString();
                    entEmpleado e = new entEmpleado();
                    entRol r = new entRol();
                    e.Id_empleado = Convert.ToInt32(dr["Id_Empleado"]);
                    r.Id_Rol = Convert.ToInt32(dr["Id_Rol"]);
                    r.Nom_Puesto = dr["Nom_puesto"].ToString();
                    e.Id_Rol = r;
                    u.Id_empleado = e;
                }
                cn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return u;
        }


        #endregion metodos


    }
}
