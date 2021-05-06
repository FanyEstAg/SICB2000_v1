using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class frmVenta : Form
    {
        entUsuario us = null;
        string user="";
        AccionesEnControles ac = new AccionesEnControles();
        public frmVenta(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        //private void ControlBotones(Boolean nuevo, Boolean guardar, Boolean imprimir, Boolean quitaritem)
        //{
        //    try
        //    {
        //        btnNuevo.Enabled = nuevo;
        //        btnGuardar.Enabled = guardar;
        //        btnImprimir.Enabled = imprimir;
        //        btnQuitarItem.Enabled = quitaritem;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        private void CrearGrid()
        {
            try
            {
                dgvVenta.Columns.Add("ColumnIdProd", "Idprod");
                dgvVenta.Columns.Add("ColumnNombreProd", "Producto");
                dgvVenta.Columns.Add("ColumnDecrpProd", "Descripción");
                dgvVenta.Columns.Add("ColumnPrecio", "Precio");
                dgvVenta.Columns.Add("ColumnCantidad", "Cantidad");
                dgvVenta.Columns.Add("ColumnTotal", "Subtotal");
                //Se estabelcen tamaños
                dgvVenta.Columns[0].Visible = false;
                dgvVenta.Columns[1].Width = 70;
                dgvVenta.Columns[2].Width = 200;
                dgvVenta.Columns[3].Width = 70;
                dgvVenta.Columns[4].Width = 70;
                dgvVenta.Columns[5].Width = 70;
                //Se establece que solumnas peuden alterarse directamente y cuales seran solo lectura
                dgvVenta.Columns[1].ReadOnly = true;
                dgvVenta.Columns[2].ReadOnly = true;
                dgvVenta.Columns[3].ReadOnly = true;
                dgvVenta.Columns[4].ReadOnly = false;
                dgvVenta.Columns[5].ReadOnly = true;
                //Enfoque en la columa total
                dgvVenta.Columns[5].DefaultCellStyle.BackColor = Color.GreenYellow;

                DataGridViewCellStyle cssabecera = new DataGridViewCellStyle();//objeto del estilo de las columnas
                cssabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;//alineacion
                dgvVenta.ColumnHeadersDefaultCellStyle = cssabecera;//se asigna el tipo de alineacion a aprtir del estilo

                dgvVenta.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);//fuente de los titulos
                dgvVenta.DefaultCellStyle.Font = new Font("Arial", 9);//fuente del cuerpo

                dgvVenta.AllowUserToAddRows = false;//Añadir filas 
                dgvVenta.MultiSelect = false;//multiselección falsa
                dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//seleccionar fila completa

            }
            catch (Exception)
            {

                throw;
            }
        }
        //private void ContarItems()
        //{
        //    try
        //    {
        //        int num = 0;
        //        foreach (DataGridViewRow row in dgvVenta.Rows)
        //        {
        //            num++;
        //        }
        //        lblNumItems.Text = "Nº Items:  " + num;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void CargarGrid(List<entProducto> Lista)
        //{
        //    try
        //    {
        //        dgvVenta.Rows.Clear();
        //        for (int i = 0; i < Lista.Count; i++)
        //        {
        //            String[] fila = new string[] { Lista[i].Id_Prod.ToString(), Lista[i].Nombre_Prod, Lista[i].Cantidad_.ToString(), Lista[i].Precio_Prod.ToString(), (Lista[i].Precio_Prod * 5).ToString() };
        //            dgvVenta.Rows.Add(fila);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //  Método para registrar Venta - Capa Presentación
        //--Fecha de creación 04.05.2021        //--Fecha de entrega 06.05.2021
        //--Número de equipo Equipo #6        // By Fany Estrada
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea guardar la venta?", "Confirmar", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    double total = 0;
                    entVenta v = new entVenta();
                    entUsuario u = new entUsuario();
                    u = us;
                    v.usuario = u;
                    List<entVenta> venta = new List<entVenta>();//se crea una lista de los productso vendidos
                    foreach (DataGridViewRow row in dgvVenta.Rows)//se extraen los datos de la tabla
                    {
                        v.Id_producto.Id_Prod = Convert.ToInt32(row.Cells[0].Value);
                        v.cantidad = Convert.ToInt32(row.Cells[4].Value);
                        v.Subtotal_Venta = Convert.ToInt32(row.Cells[5].Value);
                        total += Convert.ToDouble(row.Cells[5].Value);
                        venta.Add(v);//se añaden los datos a la lista
                    }
                    v.productos = venta;//se adjudica la lista a productos dela venta
                    v.Fecha_Venta = DateTime.Now.ToUniversalTime();
                    v.Estado_Venta.Nom_Estado = "C";//Confirmado
                    int result = negVenta.Intancia.GuardarVenta(v);
                    MessageBox.Show("Venta registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvVenta.Enabled = false; ControlBotones(true, false, false, false);//pendiente, control de disponibilidad  botones
                    //ac.BloquearText(this.panel1, false);//pendeinte para bloquear texto de determinado panel
                    lblTotal.Text =  total.ToString();
                }
            }//Excepción de la app
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, 
                MessageBoxIcon.Warning); }
            catch (Exception ex)//Cualqueir excepción
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  Método para eliminar Venta - Capa Presentación
        //--Fecha de creación 04.05.2021
        //--Fecha de entrega 06.05.2021
        //--Número de equipo Equipo #6 
        // By Fany Estrada
        private void button7_Click(object sender, EventArgs e)//boton de eliminación //Listo
        {
            try//en caso de excepciones
            {
                DialogResult dr = MessageBox.Show("¿Desea eliminar la venta?", "Confirmar", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Confirmación
                if (dr == DialogResult.Yes)
                {
                    int result = negVenta.Intancia.EliminarVentaxId(Convert.ToInt32(txtIdEliminar.Text));
                    //enviar el id dado por el usuario
                    MessageBox.Show("Venta Eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void cancelar()
        {
            //DialogResult dr = MessageBox.Show("Desea cerra venta actual", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dr == DialogResult.Yes)
            //{
            //    LocalBD.Instancia.LimpiarDetalleVenta();
            //    LocalBD.Instancia.ReturnIdCliente(1, 0);
            //    this.Dispose();
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void cbxCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void frmVenta_Load(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        CrearGrid();
        //        ContarItems();
        //        ac.LlenarCboTipDoc(this.gbCliente);
        //        ac.LlenarCboMoneda(this.gbCliente);
        //        ac.LlenarTipoPago(this.gbCliente);
        //        ControlBotones(true, false, false, false); btnBuscarXid.Enabled = false;
        //        //txtSubtotal.Text = 0.ToString(); txtDescuento.Text = 0.ToString(); txtTotal.Text = 0.ToString();
        //        us = negSeguridad.Instancia.BuscarUsario("Id", this.id_user.ToString());
        //        this.id_user = us.Id_Usuario;
        //        txtCodUsuario.Text = us.Codigo_Usuario;
        //        CargarSerie_correlativo();
        //        btnAnular.Enabled = false;
        //        int idCliente = LocalBD.Instancia.ReturnIdCliente(0, 0);
        //        if (idCliente != 0) { btnBuscarCliente.Enabled = false; btnBuscarXid.Enabled = true; }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //}
    }
}
