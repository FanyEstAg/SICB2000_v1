using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Entidades;
namespace CapaPresentacion
{
    public partial class frmDetalleVenta : Form
    {
        int id_venta;
        public frmDetalleVenta(int idventa)
        {
            InitializeComponent();
            this.id_venta = idventa;
        }
        private void CrearGrid() {
            try
            {
                lstDetalle.View = View.Details;
                lstDetalle.Columns.Add("CODIGO",80,HorizontalAlignment.Center);
                lstDetalle.Columns.Add("PRODUCTO",180,HorizontalAlignment.Center);
                lstDetalle.Columns.Add("PRECIO",70,HorizontalAlignment.Center);
                lstDetalle.Columns.Add("CANTIDAD",80,HorizontalAlignment.Center);
                lstDetalle.Columns.Add("VENDIDO A",80,HorizontalAlignment.Center);
                lstDetalle.Columns.Add("TOTAL",70,HorizontalAlignment.Center);

                lstDetalle.Columns[1].Width = 200;

                lstDetalle.FullRowSelect = true;
                lstDetalle.AllowColumnReorder = false;
                lstDetalle.MultiSelect = true;
               
            }
            catch (Exception)
            {

                throw;
            }
        }
        // variable global venta
        entVenta v;
        private void LlenarGrid(){
            double subtotal = 0.0, descuento = 0.0, igv = 0, montoigv = 0.0, total = 0.0;
            try
            {
                v = negVenta.Intancia.VentaDetalle(this.id_venta);
                List<entDetalleVenta> det = v.detalleventa;
                for (int i = 0; i < det.Count; i++) {
                    String[] fila = new String[] { det[i].producto.Codigo_Prod, det[i].producto.Nombre_Prod, det[i].producto.Precio_Prod.ToString("0.00"),
                    det[i].Cantidad_Det.ToString(),det[i].PrecProd_Det.ToString("0.00"),(det[i].Cantidad_Det * det[i].PrecProd_Det).ToString("0.00") };
                    ListViewItem item = new ListViewItem(fila);
                    lstDetalle.Items.Add(item);
                    subtotal += (det[i].Cantidad_Det * det[i].PrecProd_Det);   
                }
                descuento = v.Descuento_Venta;
                total += subtotal - descuento;
                igv = v.Igv_Venta;
                //double igvSub = Convert.ToDouble("1,"+igv);
                //double igvMon = igv / 100;
                subtotal = Convert.ToDouble(subtotal/ Convert.ToDouble("1," + igv));
                montoigv = subtotal * Convert.ToDouble("0," + igv);
                txtSubtotal.Text ="s/ "+ subtotal.ToString("0.00");
                txtDescuento.Text ="s/ "+ descuento.ToString("0.00");
                txtIgv.Text = igv.ToString()+"%";
                txtMontoIgv.Text = "s/ "+montoigv.ToString("0.00");
                txtTotal.Text = "s/ "+total.ToString("0.00");
                txtDescuento.Text = descuento.ToString("0.00");
            }
            catch (Exception)
            {

                throw;
            }
        } 
        private void LlenarCabecera() {
            try
            {
                txtVendedor.Text = v.usuario.Nombre_Usuario;
                txtSucursal.Text = v.sucursal.Direccion_Suc;
                txtEstado.Text = v.Estado_Venta;
                if (v.Estado_Venta == "A") txtEstado.BackColor = Color.Red;
                txtCodigo.Text = v.Codigo_Venta;
                txtSerie.Text = v.Serie_Venta.ToString("0000");
                txtNumero.Text = v.Correlativo_Venta;
                txtCliente.Text = v.cliente.Nombre_Cliente;
                txtNroDoc.Text = v.cliente.NumeroDoc_Cliente.Trim();
                txtTipoDoc.Text = v.cliente.tipodocumento.Nombre_TipDoc;
                txtTipComprobante.Text = v.tipocomprobante.Nombre_TipCom;
                txtMoneda.Text = v.moneda.Descripcion_Moneda.Trim();
                txtTipoPago.Text = v.tipopago.Descripcion_TipPago;
                dtpFecha.Value = Convert.ToDateTime(v.FechaVenta.ToShortDateString());
                txtHora.Text = (v.FechaVenta.AddHours(3)).ToString("HH:mm:ss");
                txtDescripcion.Text = v.Desc_Venta;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            try
            {
                CrearGrid();
                LlenarGrid();
                LlenarCabecera();
            }
            catch (ApplicationException ae) {
                MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
