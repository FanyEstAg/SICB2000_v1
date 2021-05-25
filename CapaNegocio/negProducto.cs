using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;
using System.Data;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class negProducto
    {
        #region singleton
        private static readonly negProducto _intancia = new negProducto();
        public static negProducto Instancia
        {
            get { return negProducto._intancia; }
        }
        #endregion singleton

        #region metodos

        public List<entProducto> ActExtraerProductos(int id)
        {
            try
            {
                List<entProducto> Lista = null;
                Lista = datProducto.Instancia.ActExtraerProductos(id);
                if (Lista.Count == 0) throw new ApplicationException("Lista de productos vacia");
                else if (Lista == null) throw new ApplicationException("Se produjo un error en la carga de la lista de productos");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public int MantenimientoProducto(entProducto p, int tipoedicion)
        //{
        //    try
        //    {

        //        String cadXml = "";
        //        cadXml += "<producto ";
        //        cadXml += "idproducto='" + p.Id_Prod + "' ";
        //        cadXml += "idcat='" + p.categoria.Id_Cat + "' ";
        //        cadXml += "idunmed='" + p.unidmedida.Id_Umed + "' ";
        //        cadXml += "idprov='" + p.proveedor.Id_Proveedor + "' ";
        //        cadXml += "nombre='" + p.Nombre_Prod + "' ";
        //        cadXml += "marca='" + p.Marca_Prod + "' ";
        //        cadXml += "preciocompra='" + p.PrecioCompra_Prod.ToString().Replace(",", ".") + "' ";
        //        cadXml += "precio='" + p.Precio_Prod.ToString().Replace(",", ".") + "' ";
        //        cadXml += "stock='" + p.Stock_Prod + "' ";
        //        cadXml += "stockprom='" + p.StockProm_Prod + "' ";
        //        cadXml += "stockmin='" + p.StockMin_Prod + "' ";
        //        cadXml += "usuariocreacion='" + p.UsuarioCreacion_Prod + "' ";
        //        cadXml += "usuarioupdate='" + p.UsuarioUpdate_Prod + "' ";
        //        cadXml += "tipoedicion='" + tipoedicion + "' ";
        //        cadXml += "idmaterial='" + p.material.Id + "'/>";

        //        cadXml = "<root>" + cadXml + "</root>";
        //        int i = datProducto.Instancia.MantenimientoProducto(cadXml);
        //        if (i <= 0)
        //        {
        //            throw new ApplicationException("No se pudo completar la acción, Intentelo otra vez");
        //        }
        //        return i;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

       

        //public int MantenimientoUnidMedida(entUnidadMedida ume, int tipoedicion)
        //{
        //    try
        //    {
        //        entUnidadMedida um = new entUnidadMedida();
        //        um = ume;
        //        String cadXml = "";
        //        cadXml += "<unmedida ";
        //        cadXml += "idunmedida='" + um.Id_Umed + "' ";
        //        cadXml += "descripcion='" + um.Descripcion_Umed + "' ";
        //        cadXml += "abreviatura='" + um.Abreviatura_Umed + "' ";
        //        cadXml += "tipoedicion='" + tipoedicion + "'/>";
        //        cadXml = "<root>" + cadXml + "</root>";
        //        int i = datProducto.Instancia.MantenimientoUnidMedida(cadXml);
        //        if (i <= 0)
        //        {
        //            throw new ApplicationException("No se pudo completar la acción, Intentelo otra vez");
        //        }
        //        return i;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}


        public List<entUnidadMedida> ListarUnidMed()//LISTO
        {
            try
            {
                List<entUnidadMedida> Lista = null;
                Lista = datProducto.Instancia.ListarUniMedida();
                if (Lista.Count == 0) throw new ApplicationException("No se encontraron registros");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entMarca> ListarMarca()//LISTO
        {
            try
            {
                List<entMarca> Lista = null;
                Lista = datProducto.Instancia.ListarMarca();
                if (Lista.Count == 0) throw new ApplicationException("No se encontraron registros");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int insertarProducto(entProducto p)//listo
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<producto ";
                cadXml += "nomproducto='" + p.Nombre_Prod + "' ";
                cadXml += "idumed='" + p.Id_umed.Id_Umed + "' ";
                cadXml += "existencia='" + p.existencia + "' ";
                cadXml += "idmarca='" + p.id_marca.Id_Marca + "' ";
                cadXml += "costo='" + p.Costo_Prod + "' ";
                cadXml += "precio='" + p.Precio_Prod + "' ";
                cadXml += "descripcion='" + p.Descripcion_Prod + "' ";
                cadXml += "idestado='" + p.estado.Id_Estado+ "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int result = datProducto.Instancia.insertarProducto(cadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int EliminarProducto(int id_producto)
        {
            try
            {
                int retorno = datProducto.Instancia.EliminarProducto(id_producto);
                if (retorno == 0) throw new ApplicationException("No se pudo completar la acción");
                //Excepción en caso de no haberse eliminado
                return retorno;//en caso contrario regresa el valor
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int insertarMarca(string m)
        {
            try
            {

                int result = datProducto.Instancia.insertarMarca(m);
                if (result == 0) throw new ApplicationException("Ocurrio un error al registrar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable CargarProducto()
        {
            try
            {
                DataTable dt = datProducto.Instancia.CargarProductos();

                if (dt.Rows.Count == 0)
                {
                    //throw new ApplicationException("No se encontraron registros");
                }
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable BuscarProducto(string busqueda)
        {
            try
            {

                DataTable dt = datProducto.Instancia.BuscarProducto(busqueda);

                if (dt.Rows.Count == 0)
                {
                    //throw new ApplicationException("No se encontraron registros");
                }
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable BuscarProductoExistencia(int id)
        {
            try
            {

                DataTable dt = datProducto.Instancia.BuscarProductoExistencia(id);

                if (dt.Rows.Count == 0)
                {
                    //throw new ApplicationException("No se encontraron registros");
                }
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarProducto(entProducto p)
        {
            try
            {
                String cadXml = "";//se creara la cadena del xml
                cadXml += "<actProducto ";
                cadXml += "idproducto='" + p.Id_Prod + "' ";
                cadXml += "nomproducto='" + p.Nombre_Prod + "' ";
                cadXml += "idumed='" + p.Id_umed.Id_Umed + "' ";
                cadXml += "existencia='" + p.existencia + "' ";
                cadXml += "idmarca='" + p.id_marca.Id_Marca + "' ";
                cadXml += "costo='" + p.Costo_Prod + "' ";
                cadXml += "precio='" + p.Precio_Prod + "' ";
                cadXml += "descripcion='" + p.Descripcion_Prod + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                //MessageBox.Show(p.Nombre_Prod);
                int result = datProducto.Instancia.actualizarProducto(cadXml);
                if (result == 0) throw new ApplicationException("Ocurrio un error al actualizar, intentelo nuevamente");

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int agregarExistencia(int e, int id)
        {
            try
            {
                int result = datProducto.Instancia.agregarExistencia(e, id);
                if (result == 0) throw new ApplicationException("Ocurrio un error al añadir la existencia, intentelo nuevamente");

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
