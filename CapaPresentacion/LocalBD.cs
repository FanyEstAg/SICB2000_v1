using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaNegocio;
namespace CapaPresentacion
{
    public class LocalBD
    {
        #region singleton
        private static readonly LocalBD _intancia = new LocalBD();
        public static LocalBD Instancia
        {
            get { return LocalBD._intancia; }
        }
        #endregion singleton

        #region metodos
        int Iidcliente = 0, idClienteNV=0;
        int IdProd = 0;
        int intento = 0;
        // logica para comprbra que formulario invoco al frmbusqueda
        int invocador=0; // 1: frmboleta, 2: frmnotaventa, 3: frmfactura
        private int _idsucrusal;
        public int IdSucursal {
            get { return _idsucrusal; }
            set { _idsucrusal = value; }
        }


        List<entProducto> detBoleta = new List<entProducto>();
        List<entProducto> detNotaVenta = new List<entProducto>();

        public int Invocar(int getset,int frm) {
            try
            {
                if (getset == 1) invocador = frm;
            }
            catch (Exception)
            {
                throw;
            }return invocador;
        }

        public int ReturnIntento(int getset, int intent)
        {
            try
            {
                if (getset == 1)
                {
                    intento = intent;
                }
                return intento;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public int ReturnIdClienteNV(int getset, int idCliente)
        {
            try
            {
                if (getset == 1)
                {
                    idClienteNV = idCliente;
                }
                return idClienteNV;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public int ReturnIdCliente(int getset, int idCliente)
        {
            try
            {
                if (getset == 1)
                {
                    Iidcliente = idCliente;
                }
                return Iidcliente;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public int ReturnIdprod(int getset, int idprod)
        {
            try
            {
                if (getset == 1)
                {
                    IdProd = idprod;
                }
                return IdProd;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<entProducto> ReturnDetVenta(int getset, int idprod, int cantidad)
        {
            try
            {
                if (getset == 1)
                {
                    if (cantidad > 1)
                    {
                        for (int i = 0; i < detBoleta.Count; i++)
                        {
                            if (detBoleta[i].Id_Prod == idprod)
                            {
                                detBoleta[i].Cantidad_ = cantidad;
                                break;
                            }
                        }
                    }
                    else
                    {

                        for (int i = 0; i < detBoleta.Count; i++)
                        {
                            if (detBoleta[i].Id_Prod == idprod)
                            {
                                throw new ApplicationException("Este producto ya fue agreado");  
                            }
                        }
                        entProducto pr = negProducto.Instancia.BuscarProducto(idprod);
                        pr.Cantidad_ = cantidad;
                        detBoleta.Add(pr);
                    }
                }
                return detBoleta;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<entProducto> ReturnDetNotaVenta(int getset, int idprod, int cantidad)
        {
            try
            {
                if (getset == 1)
                {
                    if (cantidad > 1)
                    {
                        for (int i = 0; i < detNotaVenta.Count; i++)
                        {
                            if (detNotaVenta[i].Id_Prod == idprod)
                            {
                                detNotaVenta[i].Cantidad_ = cantidad;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < detNotaVenta.Count; i++)
                        {
                            if (detNotaVenta[i].Id_Prod == idprod)
                            {
                                throw new ApplicationException("Este producto ya fue agreado");
                            }
                        }
                        entProducto pr = negProducto.Instancia.BuscarProducto(idprod);
                        pr.Cantidad_ = cantidad;
                        detNotaVenta.Add(pr);
                    }
                }
                return detNotaVenta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void QuitarItemPorducto(int id_prod)
        {
            try
            {
                foreach (entProducto p in detBoleta)
                {
                    if (p.Id_Prod == id_prod)
                    {
                        detBoleta.Remove(p);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void QuitarItemPorductoNV(int id_prod)
        {
            try
            {
                foreach (entProducto p in detNotaVenta)
                {
                    if (p.Id_Prod == id_prod)
                    {
                        detNotaVenta.Remove(p);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void LimpiarDetalleVenta()
        {
            try
            {
                detBoleta.RemoveRange(0, detBoleta.Count);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void LimpiarDetalNV()
        {
            try
            {
                detNotaVenta.RemoveRange(0, detNotaVenta.Count);
            }
            catch (Exception)
            {

                throw;
            }
        }

        #endregion metodos

    }
}
