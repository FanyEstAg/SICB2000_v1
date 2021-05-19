using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;
using System.Data;

namespace CapaNegocio
{
    public class negSeguridad{
        #region singleton
        private  static readonly negSeguridad  _instancia=new negSeguridad();
        public static negSeguridad Instancia {
            get{
                return negSeguridad._instancia; 
            }
        }

        #endregion singleton

        public int ObtenerIdUsuario(string us, string pass)//--listo
        {
            if (us == "") throw new ApplicationException("Ingrese un usuario");
            if (pass == "") throw new ApplicationException("Ingrese una contraseña");
            entUsuario u = null;
            u = datSeguridad.Instancia.ObtenerIdUsuario(usuario, password);
            if (u == null)
            {
                throw //new ApplicationException("Usuario ó contraseña inválido");
            }

            return u;
        }
        public int insertarEmpleado( entEmpleado e)//listo
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<empleado ";
                cadXml += "nombre='" + e.Nombre_empleado + "' ";
                cadXml += "apepat='" + e.apepat_empelado + "' ";
                cadXml += "apemat='" + e.apemat_empleado + "' ";
                cadXml += "telefono='" + e.telefono_empleado + "' ";
                cadXml += "direccion='" + e.direccion_empleado + "' ";
                cadXml += "idrol='" + e.Id_Rol.Id_Rol+  "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int result = datSeguridad.Instancia.insertarEmpleado(cadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarEmpleado(entEmpleado e)//listo
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<actEmpleado ";
                cadXml += "idempleado='" + e.Id_empleado + "' ";
                cadXml += "nombre='" + e.Nombre_empleado + "' ";
                cadXml += "apepat='" + e.apepat_empelado + "' ";
                cadXml += "apemat='" + e.apemat_empleado + "' ";
                cadXml += "telefono='" + e.telefono_empleado + "' ";
                cadXml += "direccion='" + e.direccion_empleado + "' ";
                cadXml += "idrol='" + e.Id_Rol.Id_Rol + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int result = datSeguridad.Instancia.actualizarEmpleado(cadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int EliminarUsuarioxId(int id_usuario)//LISTO
        {
            try
            {
                int retorno = datSeguridad.Instancia.EliminarUsuarioXid(id_usuario);
                if (retorno == 0) throw new ApplicationException("No se pudo completar la acción");
                //Excepción en caso de no haberse eliminado
                return retorno;//en caso contrario regresa el valor
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int insertarUsuario(entUsuario u)//LISTO
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<usuario ";
                cadXml += "usuario='" + u.Nombre_Usuario + "' ";
                cadXml += "contrasena='" + u.Password_Usuario + "' ";
                cadXml += "idempleado='" + u.Id_empleado.Id_empleado + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int result = datSeguridad.Instancia.insertarUsuario(cadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarUsuario(entUsuario u)//LISTO
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<actUsuario ";
                cadXml += "idusuario='" + u.Id_Usuario + "' ";
                cadXml += "usuario='" + u.Nombre_Usuario + "' ";
                cadXml += "contrasena='" + u.Password_Usuario + "' ";
                cadXml += "idempleado='" + u.Id_empleado.Id_empleado + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int result = datSeguridad.Instancia.actualizarUsuario(cadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool VerificarDatosCambioContrasena(String usuario, String password)//--listo
        {
            try
            {
                if (usuario == "") throw new ApplicationException("Ingrese un usuario");
                if (password == "") throw new ApplicationException("Ingrese una contraseña");
                
                bool r = datSeguridad.Instancia.VerificarDatosCambioContrasena(usuario, password);
                if (r ==false)
                {
                    throw new ApplicationException("Usuario y/o contraseña incorrectos");
                }

                return r;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public int cambiarContrasena(entUsuario u, string nuevaContrasena)//LISTO
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<cambioContra ";
                cadXml += "usuario='" + u.Id_Usuario + "' ";
                cadXml += "contrasena='" + u.Password_Usuario + "' ";
                cadXml += "nuevaContrasena='" + nuevaContrasena + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int result = datSeguridad.Instancia.cambiarContrasena(cadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al actualizar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable BuscarUsuario( String busqueda) {
            try
            {
                
                DataTable dt= datSeguridad.Instancia.BuscarUsuario(busqueda);
                
                if (dt.Rows.Count == 0) {
                    throw new ApplicationException("No se encontraron registros");
                }
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable CargarUsuarios()
        {
            try
            {

                DataTable dt = datSeguridad.Instancia.CargarUsuarios();

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

        public string ListarRolDescrp(Int32 idRol)//--listo
        {
            try
            {
                return datSeguridad.Instancia.ListarRolDescrp(idRol);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ObtenerIdEmpleado()//--listo
        {
            try
            {
                return datSeguridad.Instancia.ObtenerIdEmpleado();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int ObtenerIdEmpleado(int idemp)//--listo
        {
            try
            {
                return datSeguridad.Instancia.ObtenerIdEmpleado(idemp);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<entRol> ListarRol()//--listo
        {
            try
            {
                return datSeguridad.Instancia.ListarRol();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public entUsuario IngresoSisema(String usuario,String password)//--listo
        {
            try
            {
                if (usuario == "") throw new ApplicationException("Ingrese un usuario");
                if (password == "") throw new ApplicationException("Ingrese una contraseña");
                entUsuario u = null;
                u = datSeguridad.Instancia.VerificarAcceso(usuario, password);
                if (u == null)
                {
                    throw new ApplicationException("Usuario ó contraseña inválido");
                }
                
                return u;
            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}
