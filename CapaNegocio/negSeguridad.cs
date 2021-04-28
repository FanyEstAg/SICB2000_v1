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
        public int MantenimientoUsuario(entUsuario u,int tipoedicion) {
            try
            {
                String cadXml = "";
                cadXml += "<usuario ";
                cadXml += "idusuario='" + u.Id_Usuario + "' ";
                cadXml += "idnivelacceso='" + u.nivel_acceso.Id_NivelAcc + "' ";
                cadXml+= "idsucusuario='"+u.sucursal.Id_Suc+"' ";
                cadXml += "nombre='" + u.Nombre_Usuario + "' ";
                cadXml += "logeo='" + u.Login_Usuario + "' ";
                cadXml += "pass='" + u.Password_Usuario + "' ";
                cadXml += "telefono='" + u.Telefono_Usuario + "' ";
                cadXml += "celular='" + u.Celular_Usuario + "' ";
                cadXml += "correo='" + u.Correo_Usuario + "' ";
                cadXml += "estado='" + u.Estado_Usuario + "' ";
                cadXml += "usuariocreacion='" + u.UsuarioCreacion_Usuario + "' ";
                cadXml += "expiracion='" + u.Expiracion_Usuario + "' ";
                cadXml += "tipoedicion='" + tipoedicion + "'/>";

                cadXml = "<root>" + cadXml + "</root>";
                int result = datSeguridad.Instancia.MantenimientoUsuario(cadXml);
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
                u = datSeguridad.Instancia.BuscarUsuario(valor);
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
