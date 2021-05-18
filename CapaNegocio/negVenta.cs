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
   public class negVenta {

        #region singleton
        private static readonly negVenta _intancia = new negVenta();
        public static negVenta Instancia {
            get { return negVenta._intancia; }
        }
        #endregion singleton

        #region metodos


        //  Método para eliminar Venta - Capa Negocio
        //--Fecha de creación 04.05.2021
        //--Fecha de entrega 06.05.2021
        //--Número de equipo Equipo #6
        // By Fay Estrada
        public int EliminarVentaxId(int id_venta, int idproducto) {
            try
            {
                int retorno = datVenta.Instancia.EliminarVentaXid(id_venta, idproducto);
                if (retorno == 0) throw new ApplicationException("No se pudo completar la acción");
                //En caos de que no haya ningun cambio en la BD se envía excepción
                return retorno;//si no se devuelve el valor
            }
            catch (Exception)
            {

                throw;
            }
        }

        //  Método para registrar Venta - Capa Negocio
        //--Fecha de creación 04.05.2021      //--Fecha de entrega 06.05.2021
        //--Número de equipo Equipo #6         // By Fany Estrada
        public int GuardarVenta(entVenta v)//listo
        {//Método en el que se hace Altas a partir de un xml
            try
            {
                String Cadxml = "";//Variable donde se guardar la generación del texto xml
                Cadxml += "<venta ";//Se añaden todos los parametros con estrustura xml
                Cadxml += "folio='" + v.folio + "' ";
                Cadxml += "idusuario='" + v.usuario.Id_Usuario + "' ";
                Cadxml += "fecha='" + DateTime.Now.ToString() + "' ";
                Cadxml += "idestado='" + v.Estado_Venta.Id_Estado + "' "; /*"'>";*/
                //foreach (entVenta pr in v.productos)//Se añade cada producto de la lista de productos
                //{
                //Cadxml += "<detalle ";
                Cadxml += "idproducto='" + v.Id_producto.Id_Prod + "' ";
                Cadxml += "cantidad='" + v.cantidad + "' ";
                Cadxml += "subtotal='" + v.Subtotal_Venta + "'/>";
                //Cadxml += "idproducto='" + pr.Id_producto + "' ";
                //Cadxml += "cantidad='" + pr.cantidad + "' ";
                //Cadxml += "subtotal='" + v.Subtotal_Venta +  "'/>";
                //}
                //Cadxml += "</venta>";
                Cadxml = "<root>" + Cadxml + "</root>";
                int i = datVenta.Instancia.GuardarVenta(Cadxml);// se envia la cadena y se guarda el resultado en i
                if (i <= 0) throw new ApplicationException("Ocurrio un error al guardar venta actual");
                //si es 0 se envia excepción
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Modificaicón de ventas a aprtir de XML
        public int ActualizarVenta(entVenta v)//listo
        {
            try
            {
                String Cadxml = "";//Variable donde se guardar la generaicon del texto xml
                Cadxml += "<actVenta ";
                Cadxml += "folio='" + v.folio + "' ";
                Cadxml += "idusuario='" + v.usuario.Id_Usuario + "' ";
                Cadxml += "fecha='" + v.Fecha_Venta + "' ";
                Cadxml += "idproducto='" + v.Id_producto.Id_Prod + "' ";
                Cadxml += "cantidad='" + v.cantidad + "' ";
                Cadxml += "subtotal='" + v.Subtotal_Venta + "' ";
                Cadxml += "idestado='" + v.Estado_Venta.Id_Estado + "'/>";
                //Cadxml += "</venta>";
                Cadxml = "<root>" + Cadxml + "</root>";
                int i = datVenta.Instancia.ActualizarVenta(Cadxml);// se envia la cadena
                if (i <= 0) throw new ApplicationException("Ocurrio un error al guardar venta actual");
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable BuscarVenta(int id)
        {
            try
            {
                DataTable dt = datVenta.Instancia.BuscarVenta(id);

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
        public DataTable CargarVenta()
        {
            try
            {
                DataTable dt = datVenta.Instancia.CargarVenta();

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
        public int ObtenerIdVenta()//--listo
        {
            try
            {
                return datVenta.Instancia.ObtenerIdVenta()+1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //public List<entVenta> ListarVenta(String fdesde)//modificar
        //{
        //    try
        //    {
        //        List<entVenta> Lista = datVenta.Instancia.ListarVenta(fdesde, fhasta,idSucursal);
        //        if (Lista == null) throw new ApplicationException("Error al cargar historial de ventas");
        //        else if (Lista.Count == 0) throw new ApplicationException("Lista de historial de ventas vacia");
        //        return Lista;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}



        //public int GuardarVenta(entVenta v,int id_tipdocventa,String serie) {
        //    try
        //    {

        //        String Cadxml = "";
        //        Cadxml += "<venta ";
        //        Cadxml += "idcliente='"+v.cliente.Id_Cliente +"' ";
        //        Cadxml += "idusuario='" + v.usuario.Id_Usuario + "' ";
        //        Cadxml += "idsucursal='" + v.sucursal.Id_Suc +"' ";
        //        Cadxml += "istipcom='" + v.tipocomprobante.Id_TipCom +"' ";
        //        Cadxml += "idmoneda='" + v.moneda.Id_Moneda +"' ";
        //        Cadxml += "idtipopago='" + v.tipopago.Id_TipPago + "' ";
        //        Cadxml += "igv='" + v.Igv_Venta + "' ";
        //        Cadxml += "serie='" + serie + "' ";
        //        Cadxml += "descuento='" + v.Descuento_Venta.ToString().Replace(",",".") + "' ";
        //        Cadxml += "descripcion='" + v.Desc_Venta.ToString() + "'>";

        //        foreach (entDetalleVenta dt in v.detalleventa) {
        //            Cadxml += "<detalle ";
        //            Cadxml += "idproducto='" +dt.Id_Prod_Det +"' ";
        //            Cadxml += "precioprod='" +dt.PrecProd_Det.ToString().Replace(",",".") +"' ";
        //            Cadxml += "cantidad='" +dt.Cantidad_Det +"'/>";
        //        }
        //        Cadxml += "</venta>";
        //        Cadxml = "<root>" + Cadxml + "</root>";
        //        int i = datVenta.Instancia.GuardarVenta(Cadxml, id_tipdocventa);
        //        if (i <= 0) throw new ApplicationException("Ocurrio un erro al guardar venta actual");
        //        return i;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}


        #endregion metodos


    }
}
