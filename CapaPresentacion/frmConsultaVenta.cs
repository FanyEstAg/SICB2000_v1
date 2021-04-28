using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmConsultaVenta : Form
    {
        public frmConsultaVenta()
        {
            InitializeComponent();
        }
        private void CrearGrid() {
            try
            {
                dgvHistorialVentas.Columns.Add("ColumnId", "Id");
                dgvHistorialVentas.Columns.Add("ColumnCodigo", "Codigo");
                dgvHistorialVentas.Columns.Add("ColumnEstado", "Estado");
                dgvHistorialVentas.Columns.Add("ColumnComprobante", "Comprobante");
                dgvHistorialVentas.Columns.Add("ColumnCorrelativo", "Número");
                dgvHistorialVentas.Columns.Add("ColumnFecha", "Fecha");
                dgvHistorialVentas.Columns.Add("ColumnHora", "Hora");
                dgvHistorialVentas.Columns.Add("ColumnIgv", "Igv");
                dgvHistorialVentas.Columns.Add("ColumnTotal", "Total");
                dgvHistorialVentas.Columns.Add("ColumnUtilidad", "Utilidades");

                dgvHistorialVentas.Columns[0].Visible=false;
                dgvHistorialVentas.Columns[2].Width = 60;
                dgvHistorialVentas.Columns[5].Width = 60;
                dgvHistorialVentas.Columns[6].Width = 58;
                dgvHistorialVentas.Columns[7].Width = 40;
                dgvHistorialVentas.Columns[8].Width = 70;
                dgvHistorialVentas.Columns[9].Width = 70;
                dgvHistorialVentas.Columns[9].DefaultCellStyle.BackColor = Color.LawnGreen;
                
                DataGridViewCellStyle csscabecera = new DataGridViewCellStyle();
                csscabecera.Alignment = DataGridViewContentAlignment.TopCenter;
                dgvHistorialVentas.ColumnHeadersDefaultCellStyle = csscabecera;
                dgvHistorialVentas.AllowUserToAddRows = false;
                dgvHistorialVentas.AllowUserToResizeColumns = false;
                dgvHistorialVentas.AllowUserToResizeRows = false;
                dgvHistorialVentas.ReadOnly = false;
                dgvHistorialVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LlenarGrid() {
            try
            {
                // Variables de reporte
                double descuento=0.0,total = 0, boleta = 0.0, factura = 0.0,notaventa=0.0,
                    efectivo=0.0,tarjetacred=0.0,contrareembolso=0.0,deposito=0.0,dolares=0.0,inversion=0.0,totalUtilidades = 0.0;
                dgvHistorialVentas.Rows.Clear();
                int idSucursal = (int)cboSucursal.SelectedValue;
                List<entVenta> Lista = negVenta.Intancia.ListarVenta(dtpDesde.Value.ToString("yyyy/MM/dd"), dtpHasta.Value.ToString("yyyy/MM/dd"),idSucursal);
                for (int i = 0; i < Lista.Count; i++) {
                    String[] fila = new String[] { Lista[i].Id_Venta.ToString(), Lista[i].Codigo_Venta,Lista[i].Estado_Venta,Lista[i].tipocomprobante.Nombre_TipCom,
                    Lista[i].Correlativo_Venta,Lista[i].FechaVenta.ToString("dd-MM-yy"),Lista[i].FechaVenta.ToString("HH:mm:ss"),Lista[i].Igv_Venta.ToString(),(Lista[i].Total-Lista[i].Descuento_Venta).ToString("0.00"),(Lista[i].Utilidad).ToString("0.00")};
                    dgvHistorialVentas.Rows.Add(fila);
                    dgvHistorialVentas.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                    if (Lista[i].Estado_Venta == 'A'.ToString()) dgvHistorialVentas.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                    if (Lista[i].Estado_Venta == 'E'.ToString())
                    {
                        total += Lista[i].Total-Lista[i].Descuento_Venta;
                        descuento += Lista[i].Descuento_Venta;
                        inversion += Lista[i].Inversion;
                        totalUtilidades += Lista[i].Utilidad; 

                        if (Lista[i].tipocomprobante.Id_TipCom == 1) boleta += Lista[i].Total;
                        else if (Lista[i].tipocomprobante.Id_TipCom == 2) factura += Lista[i].Total;
                        else if (Lista[i].tipocomprobante.Id_TipCom == 5) notaventa += Lista[i].Total-Lista[i].Descuento_Venta;

                        if (Lista[i].tipopago.Id_TipPago == 1) efectivo += Lista[i].Total-Lista[i].Descuento_Venta;
                        else if (Lista[i].tipopago.Id_TipPago == 2) tarjetacred += Lista[i].Total - Lista[i].Descuento_Venta;
                        else if (Lista[i].tipopago.Id_TipPago == 3) contrareembolso += Lista[i].Total - Lista[i].Descuento_Venta;
                        else if (Lista[i].tipopago.Id_TipPago == 4) deposito += Lista[i].Total- Lista[i].Descuento_Venta;

                    }
                }
                lblTotal.Text =string.Format("S/ ")+ total.ToString("0.00"); lblBoleta.Text = boleta.ToString("0.00"); lblFactura.Text = factura.ToString("0.00");
                lblNotaventa.Text =notaventa.ToString("0.00");lblEfectivo.Text = efectivo.ToString("0.00");lblTarjetacredito.Text = tarjetacred.ToString("0.00");
                lblContrarembolso.Text = contrareembolso.ToString("0.00");lbldeposito.Text = deposito.ToString("0.00");lblsoles.Text ="S/ "+ total.ToString("0.00");lbldolares.Text = "$ " + dolares.ToString("0.00");
                lbldescuento.Text = descuento.ToString("0.00");

                /*CÁLCULO DE UTILIDADES*/
                lblImporteInversion.Text = "S/ " + inversion.ToString("0.00");
                lblTotalUtilidades.Text = "S/ " + totalUtilidades.ToString("0.00");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void llenarCboSucursal() {
            try
            {
                List<entSucursal> lista = new List<entSucursal>();
                lista.Add(new entSucursal() { Id_Suc = 0, Direccion_Suc = "Mostrar Todo" });
                foreach (entSucursal item in negSeguridad.Instancia.ListarSucursal()) {
                    lista.Add(item);
                }
                cboSucursal.ValueMember = "Id_Suc";
                cboSucursal.DisplayMember = "Direccion_Suc";
                cboSucursal.DataSource = lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmConsultaVenta_Load(object sender, EventArgs e)
        {
            try
            {
                CrearGrid();
                llenarCboSucursal();
                btnDetalle.Enabled = false;
                btnAnular.Enabled = false;
                dtpHasta.MaxDate = DateTime.Now;
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid();
            }catch(ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                int id_venta = Convert.ToInt32(dgvHistorialVentas.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("¿Desea anular comprobante?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int i = negVenta.Intancia.AnularVentaxId(id_venta);
                    MessageBox.Show("Comprobante anulado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarGrid();
                    
                }
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                int id_venta = Convert.ToInt32(dgvHistorialVentas.CurrentRow.Cells[0].Value);
                frmDetalleVenta dv = new frmDetalleVenta(id_venta);
                dv.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHistorialVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDetalle.Enabled = true;
            btnAnular.Enabled = true;
        }
    }
}
