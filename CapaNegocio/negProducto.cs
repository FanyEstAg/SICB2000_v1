﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaAccesoDatos;

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

       
        public List<entProducto> BuscarprodAvanzadaIndicador(String name)
        {
            try
            {
                List<entProducto> Lista = null;
                Lista = datProducto.Instancia.LstProdIndicadorAvanzada(name);
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

       
        public entProducto BuscarProducto(int id_producto)
        {
            try
            {
                entProducto p = null;
                p = datProducto.Instancia.BuscarProducto(id_producto);
                if (p == null) throw new ApplicationException("No se encontro producto seleccionado en la BD");
                return p;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entProducto> ListarProducto()
        {
            try
            {
                List<entProducto> Lista = null;
                Lista = datProducto.Instancia.ListarProducto();
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


        public List<entUnidadMedida> ListarUnidMed()
        {
            try
            {
                List<entUnidadMedida> Lista = null;
                Lista = datProducto.Instancia.ListarUniMedida();
                //if (Lista.Count == 0) throw new ApplicationException("No se encontraron registros");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

     

        #endregion metodos

    }
}
