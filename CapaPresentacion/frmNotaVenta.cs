using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class frmNotaVenta : Form
    {
        int idusuario = 0;
        public frmNotaVenta(int? id_userr)
        {
            InitializeComponent();
            this.idusuario = (int)id_userr;
        }
        // zona de variables e instancias
        AccionesEnControles ac = new AccionesEnControles();
        entSerie serie = new entSerie();
        entUsuario u = new entUsuario();
        String ser, corr;

        private void CrearGrid()
        {
            try
            {
                dgvDetalleNotaVenta.Columns.Add("ColumnIdProd", "Idprod");
                dgvDetalleNotaVenta.Columns.Add("ColumnNombreProd", "Producto");
                dgvDetalleNotaVenta.Columns.Add("ColumnCantidad", "Cantidad");
                dgvDetalleNotaVenta.Columns.Add("ColumnPrecio", "Precio");
                dgvDetalleNotaVenta.Columns.Add("ColumnTotal", "Total");

                dgvDetalleNotaVenta.Columns[0].Visible = false;
                dgvDetalleNotaVenta.Columns[1].Width = 315;
                dgvDetalleNotaVenta.Columns[2].Width = 70;
                dgvDetalleNotaVenta.Columns[3].Width = 70;
                dgvDetalleNotaVenta.Columns[4].Width = 70;

                dgvDetalleNotaVenta.Columns[1].ReadOnly = true;
                dgvDetalleNotaVenta.Columns[2].ReadOnly = false;
                dgvDetalleNotaVenta.Columns[3].ReadOnly = false;
                dgvDetalleNotaVenta.Columns[4].ReadOnly = true;

                dgvDetalleNotaVenta.Columns[4].DefaultCellStyle.BackColor = Color.GreenYellow;

                DataGridViewCellStyle cssabecera = new DataGridViewCellStyle();
                cssabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleNotaVenta.ColumnHeadersDefaultCellStyle = cssabecera;

                dgvDetalleNotaVenta.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dgvDetalleNotaVenta.DefaultCellStyle.Font = new Font("Arial", 9);


                dgvDetalleNotaVenta.AllowUserToAddRows = false;
                dgvDetalleNotaVenta.MultiSelect = false;
                dgvDetalleNotaVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ContarItems()
        {
            try
            {
                int num = 0;
                foreach (DataGridViewRow row in dgvDetalleNotaVenta.Rows)
                {
                    num++;
                }
                lblNumItems.Text = "Nº Items:  " + num;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ControlBotones(Boolean nuevo, Boolean guardar, Boolean imprimir, Boolean quitaritem)
        {
            try
            {
                btnNuevo.Enabled = nuevo;
                btnGuardar.Enabled = guardar;
                btnImprimir.Enabled = imprimir;
                btnQuitarItem.Enabled = quitaritem;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CargarSerie_correlativo()
        {
            try
            {
                serie = negVenta.Intancia.CargarSerie(1, 5);
                ser = serie.Numero_Serie;
                lblCorrelativo.Text =negVenta.Intancia.CargarCorrelativo(serie.tipocom.Id_TipCom, serie.Numero_Serie);
                corr = negVenta.Intancia.CargarCorrelativo(serie.tipocom.Id_TipCom, serie.Numero_Serie);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CargarGrid(List<entProducto> Lista)
        {
            try
            {
                dgvDetalleNotaVenta.Rows.Clear();
                for (int i = 0; i < Lista.Count; i++)
                {
                    String[] fila = new string[] { Lista[i].Id_Prod.ToString(), Lista[i].Nombre_Prod, Lista[i].Cantidad_.ToString(), Lista[i].Precio_Prod.ToString(), (Lista[i].Precio_Prod * 5).ToString() };
                    dgvDetalleNotaVenta.Rows.Add(fila);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ActualizarMontosDgv()
        {
            try
            {
                double subtotal = 0.0;
                foreach (DataGridViewRow row in dgvDetalleNotaVenta.Rows)
                {
                    if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                    row.Cells[4].Value = (Convert.ToDouble((row.Cells[2].Value)) * Convert.ToDouble((row.Cells[3].Value)));
                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                    row.Cells[4].Value = (Convert.ToDouble((row.Cells[2].Value)) * Convert.ToDouble((row.Cells[3].Value)));
                    subtotal += Convert.ToDouble(row.Cells[4].Value);
                    txtSubtotal.Text = subtotal.ToString(".00");
                    txtTotal.Text = (subtotal - Convert.ToDouble(txtDescuento.Text)).ToString(".00");
                }
                if (dgvDetalleNotaVenta.Rows.Count == 0) { txtSubtotal.Text = "0"; txtDescuento.Text = "0"; txtTotal.Text = "0"; }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void SoloNumCeldaGrid()
        {
            try
            {
                int i = 0; decimal j = 0; String valor, valor_01; Boolean res = false;
                foreach (DataGridViewRow row in dgvDetalleNotaVenta.Rows)
                {
                    if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                    valor = row.Cells[2].Value.ToString();
                    res = int.TryParse(valor, out i);
                    if (res == false)
                    {
                        MessageBox.Show("Intentó ingresar un valor no numérico en 'Cantidad', valor se reducira a cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells[2].Value = i;
                       
                    }
                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                    valor_01 = row.Cells[3].Value.ToString().Replace(".", ",");
                    //  res_01 = SoloDecimales(valor);
                    if (!Decimal.TryParse(valor_01, out j))
                    {
                        MessageBox.Show("Intentó ingresar un valor no numérico en 'Precio', valor se reducira a cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells[3].Value = 0;
                    }
                    else
                    {
                        row.Cells[3].Value = valor_01;

                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void EscribirNuevoMonto()
        {
            try
            {
                int id_prod = 0, cantidad_ = 0;
                foreach (DataGridViewRow row in dgvDetalleNotaVenta.Rows)
                {
                    if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                    id_prod = Convert.ToInt32(row.Cells[0].Value); cantidad_ = Convert.ToInt32(row.Cells[2].Value);
                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                    if (cantidad_ > 1)
                    {
                        List<entProducto> Lista = LocalBD.Instancia.ReturnDetNotaVenta(1, id_prod, cantidad_);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = null;
                String num_doc = txtNumDoc.Text;
                c = negCliente.Intancia.BuscarCliente(0, num_doc);
                txtNombreCliente.Text = c.Nombre_Cliente;
                txtNumDoc.Text = c.NumeroDoc_Cliente.Trim();
                LocalBD.Instancia.ReturnIdClienteNV(1, c.Id_Cliente);
            }
            catch (ApplicationException)
            {
                DialogResult r = MessageBox.Show("No se encontro registro, ¿Desea realiza búsqueda avanzada?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    /* escribe en el metodo el formulario q invoco a buscar cliente para saber en que lista
                    detalle agregar <este aplica en caso que se encuentre mas de 1 comprobante ejecutandose en paralelo>*/
                    LocalBD.Instancia.Invocar(1, 2);
                    //-----------------------------------------------------------------------------------------------------
                    frmCliente SearchCli = new frmCliente(this.idusuario);
                    SearchCli.ShowDialog();
                    btnBuscarCliente.Enabled = false; btnBuscarXid.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarXid_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = null;

                int id_cliente = LocalBD.Instancia.ReturnIdClienteNV(0, 0);
                c = negCliente.Intancia.BuscarCliente(id_cliente, 0.ToString());
                btnBuscarXid.Enabled = false; btnBuscarCliente.Enabled = true;
                txtNombreCliente.Text = c.Nombre_Cliente;
                txtNumDoc.Text = c.NumeroDoc_Cliente.Trim();
            }
            catch (ApplicationException) { btnBuscarXid.Enabled = false; btnBuscarCliente.Enabled = true; }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            try
            {    /* si intento==1 indica que ya existe un producto seleccionado y lo agregara a la lista,
                  de los contrario abrira formulario de busqueda*/
                    int intento = LocalBD.Instancia.ReturnIntento(0, 0);
                /* escribe en el metodo el formulario q invoco a buscar producto para saber en que lista
                detalle agregar <este aplica en caso que se encuentre mas de 1 comprobante ejecutandose en paralelo>*/
                    LocalBD.Instancia.Invocar(1, 2);
                if (intento != 0)
                {
                    List<entProducto> Lista = LocalBD.Instancia.ReturnDetNotaVenta(0, 0, 0);
                    intento = LocalBD.Instancia.ReturnIntento(1, 0);
                    CargarGrid(Lista);
                    ContarItems();
                    ActualizarMontosDgv();
                }
                else
                {
                    LocalBD.Instancia.Invocar(1, 2);
                    frmProductoBuscar SearchProd = new frmProductoBuscar(this.idusuario);
                    SearchProd.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleBoleta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ControlBotones(true, true, false, true);
                SoloNumCeldaGrid();
                EscribirNuevoMonto();
                ActualizarMontosDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleBoleta_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SoloNumCeldaGrid();
                EscribirNuevoMonto();
                ActualizarMontosDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = ac.EntradaDecimales(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescuento_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtDescuento.Text == null || txtDescuento.Text == "") txtDescuento.Text = "0";
                txtTotal.Text = (Convert.ToDouble(txtSubtotal.Text) - Convert.ToDouble(txtDescuento.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea guardar esta nota de venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    SoloNumCeldaGrid();
                    EscribirNuevoMonto();
                    ActualizarMontosDgv();
                    CargarSerie_correlativo();
                    entVenta v = new entVenta();

                    entCliente c = new entCliente();
                    c.Id_Cliente = LocalBD.Instancia.ReturnIdClienteNV(0, 0);
                    v.cliente = c;

                    v.usuario = u;

                    entSucursal s = new entSucursal();
                    s.Id_Suc = LocalBD.Instancia.IdSucursal;
                    v.sucursal = s;

                    entTipComprobante tc = new entTipComprobante();
                    tc.Id_TipCom = serie.tipocom.Id_TipCom;
                    v.tipocomprobante = tc;

                    entMoneda m = new entMoneda();
                    m.Id_Moneda = Convert.ToInt32(CboMoneda.SelectedValue);
                    v.moneda = m;

                    entTipoPago tp = new entTipoPago();
                    tp.Id_TipPago = Convert.ToInt32(cboTipoPago.SelectedValue);
                    v.tipopago = tp;

                    v.Igv_Venta = 0;
                    v.Descuento_Venta = Convert.ToDouble(txtDescuento.Text);

                    List<entDetalleVenta> Detalle = new List<entDetalleVenta>();
                    foreach (DataGridViewRow row in dgvDetalleNotaVenta.Rows)
                    {
                        entDetalleVenta dt = new entDetalleVenta();
                        dt.Id_Prod_Det = Convert.ToInt32(row.Cells[0].Value);
                        dt.PrecProd_Det = Convert.ToDouble(row.Cells[3].Value);
                        dt.Cantidad_Det = Convert.ToInt32(row.Cells[2].Value);
                        Detalle.Add(dt);
                    }
                    v.detalleventa = Detalle;
                    v.Desc_Venta = rtxtDescripcion.Text;
                    CargarSerie_correlativo();
                    int result = negVenta.Intancia.GuardarVenta(v, serie.tipocom.Id_TipCom, serie.Numero_Serie);
                    MessageBox.Show("Nota de venta guardo de manera correcta!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDetalleNotaVenta.Enabled = false; ControlBotones(true, false, false, false); btnAgregarItem.Enabled = false; btnAnular.Enabled = true;
                    ac.BloquearText(this.gbCliente, false); ac.BloquearText(this.panel1, false);
                   // lblMontoEnletras.Text = "Son: " + ac.enletras(txtTotal.Text).ToLower() + " Soles";

                }
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea anular esta nota de venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int result = negVenta.Intancia.AnularComprobante(ser, corr, 5);
                    MessageBox.Show("Nota de venta anulada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAnular.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea realizar una nueva venta?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    int id_cli = LocalBD.Instancia.ReturnIdClienteNV(1, 0);
                    LocalBD.Instancia.LimpiarDetalNV();
                    List<entProducto> Lista = LocalBD.Instancia.ReturnDetNotaVenta(0, 0, 0);
                    CargarGrid(Lista);
                    ac.LimpiarText(this.gbCliente);
                    ContarItems();
                    ActualizarMontosDgv();
                    CargarSerie_correlativo();
                    LocalBD.Instancia.LimpiarDetalNV();
                    dgvDetalleNotaVenta.Enabled = true; ControlBotones(true, true, false, false); btnAgregarItem.Enabled = true;
                    ac.BloquearText(this.gbCliente, true); ac.BloquearText(this.panel1, true);
                    rtxtDescripcion.Clear();
                    btnAnular.Enabled = false;
                }
                else
                {  // no hacer nada 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea cerra venta actual", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                LocalBD.Instancia.LimpiarDetalNV();
                LocalBD.Instancia.ReturnIdClienteNV(1, 0);
                this.Dispose();
            }
        }

        private void rtxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (rtxtDescripcion.Text.Length == rtxtDescripcion.MaxLength)
                {
                    e.Handled = true;
                    MessageBox.Show("Se a completado el máximo de caracteres 200", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnQuitarItem_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult r = MessageBox.Show("¿Desea quitar producto seleccionado?", "Mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int id_prod = Convert.ToInt32(dgvDetalleNotaVenta.CurrentRow.Cells[0].Value);
                    LocalBD.Instancia.QuitarItemPorductoNV(id_prod);
                    List<entProducto> Lista = LocalBD.Instancia.ReturnDetNotaVenta(0, 0, 0);
                    if (Lista.Count == 0) ControlBotones(true, false, false, false);
                    CargarGrid(Lista);
                    ContarItems();
                    ActualizarMontosDgv();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
        private void frmNotaVenta_Load(object sender, EventArgs e)
        {
            try
            {
              
                CrearGrid();
                ContarItems();
                ac.LlenarCboMoneda(this.gbCliente);
                ac.LlenarTipoPago(this.gbCliente);
                ControlBotones(true, false, true, false); btnBuscarXid.Enabled = false;
                txtSubtotal.Text = 0.ToString(); txtDescuento.Text = 0.ToString(); txtTotal.Text = 0.ToString();
                CargarSerie_correlativo();
                u = negSeguridad.Instancia.BuscarUsario("Id", this.idusuario.ToString());
                txtCodUsuario.Text = u.Codigo_Usuario;
                btnAnular.Enabled = false;
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
