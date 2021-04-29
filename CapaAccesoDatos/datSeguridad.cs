using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using Entidades;
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

        
        public int MantenimientoUsuario(String cadXml) {//Oendiente
            SqlCommand cmd = null;
            
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsEditElimUsario", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@retorno", DbType.Int32);
                p.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(p);
                cn.Open();
                var result =  cmd.ExecuteNonQuery();
                cn.Close();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public entUsuario BuscarUsuario(String valor){//listo
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entUsuario u = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("uspBuscarUsuario", cn);
                cmd.Parameters.AddWithValue("@prmValor", valor);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    u = new entUsuario();
                    entEmpleado em = new entEmpleado();
                    u.Nombre_Usuario = dr["nombre_Usuario"].ToString();
                    u.Password_Usuario = dr["Contrasena_Usuario"].ToString();
                    
                    em.telefono_empleado = dr["telefonoEmpleado"].ToString();
                  
                    entRol r = new entRol();
                    r.Id_Rol= Convert.ToInt32(dr["Id_Rol"]);
                    r.Nom_Puesto = dr["Nom_puesto"].ToString();
                    r.Descripcion_Rol= dr["Descrp_rol"].ToString();
                    em.Id_rol = r;
                    em.Id_empleado= Convert.ToInt32(dr["Id_empleado"]);
                    u.Id_empleado = em;
                    em.Nombre_empleado= dr["Nom_empleado"].ToString();
                    em.apepat_empelado = dr["apepatEmpleado"].ToString();
                    em.apemat_empleado = dr["apematEmpleado"].ToString();
                    em.telefono_empleado = dr["telefonoEmpleado"].ToString();
                    em.direccion_empleado = dr["direccionEmpleado"].ToString();
                    cn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return u;
        }

       

        public entRol ListarRolDescrp(Int32 idRol)//---listo
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            entRol r = null;
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
                     r = new entRol();
                    r.Descripcion_Rol = dr["Descrp_rol"].ToString();
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
                }
                cn.Close();
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
                cmd = new SqlCommand("uspVerificarAcceso", cn);
                cmd.Parameters.AddWithValue("@prmUsuario", usuario);
                cmd.Parameters.AddWithValue("@prmpassword", clave);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    u = new entUsuario();
                    u.Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]);
                    u.Nombre_Usuario = dr["nombre_Usuario"].ToString();
                    entRol r = new entRol();
                    r.Id_Rol = Convert.ToInt32(dr["Id_Rol"]);
                    r.Nom_Puesto = dr["Nom_puesto"].ToString();

                    entEmpleado e = new entEmpleado();
                    e.Id_empleado= Convert.ToInt32(dr["Id_empleado"]);
                    e.Id_rol = r;
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
