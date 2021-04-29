using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;
namespace CapaNegocio
{
   public class negVenta {

        #region singleton
        private static readonly negVenta _intancia = new negVenta();
        public static negVenta Intancia {
            get { return negVenta._intancia; }
        }
        #endregion singleton

        #region metodos

        

        public int EliminarVentaxId(int id_venta) {
            try
            {
                int retorno = datVenta.Instancia.EliminarVentaXid(id_venta);
                if (retorno == 0) throw new ApplicationException("No se pudo completar la acción");
                return retorno;
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
