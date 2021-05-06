using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;
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


        
        public int insertarEmpleado( entEmpleado e)
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<empleado ";
                cadXml += "nombre='" + e.Nombre_empleado + "' ";
                cadXml += "apepat='" + e.Nombre_empleado + "' ";
                cadXml += "apemat='" + e.Nombre_empleado + "' ";
                cadXml += "telefono='" + e.telefono_empleado + "' ";
                cadXml += "direccion='" + e.direccion_empleado + "' ";
                cadXml += "idrol='" + e.Id_rol +  "'/>";
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

        public int EliminarUsuarioxId(int id_usuario)
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
        public int insertarUsuario(entUsuario u)
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
        
        public entUsuario BuscarUsuario( String valor) {
            try
            {
                
                entUsuario u = null;
                //u = datSeguridad.Instancia.BuscarUsuario(valor);
                if (u == null) {
                    throw new ApplicationException("No se encontraron registros");
                }
                return u;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public entRol ListarRolDescrp(Int32 idRol)//--listo
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
