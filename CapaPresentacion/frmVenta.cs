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
        string user = "";
        AccionesEnControles ac = new AccionesEnControles();
        double total = 0;
        public frmVenta(string user)
        {
            InitializeComponent();
            this.user = user;
            lblUsuario.Text = user.ToString();
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

        private void CrearGrid()//LISTO
        {
            try
            {
                dgvVenta.Columns.Add("ColumnIdProd", "ID");
                dgvVenta.Columns.Add("ColumnNombreProd", "Producto");
                dgvVenta.Columns.Add("ColumnDecrpProd", "Descripción");
                dgvVenta.Columns.Add("ColumnPrecio", "Precio");
                dgvVenta.Columns.Add("ColumnCantidad", "Cantidad");
                dgvVenta.Columns.Add("ColumnTotal", "Subtotal");
                dgvVenta.Columns[2].Visible = false;
                dgvVenta.Columns[2].Width = 70;

                //Se establece que solumnas peuden alterarse directamente y cuales seran solo lectura
                dgvVenta.Columns[2].ReadOnly = true;
                dgvVenta.Columns[3].ReadOnly = true;
                dgvVenta.Columns[4].ReadOnly = true;
                dgvVenta.Columns[5].ReadOnly = false;
                dgvVenta.Columns[6].ReadOnly = true;
                //Enfoque en la columa total
                dgvVenta.Columns[6].DefaultCellStyle.BackColor = Color.GreenYellow;

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


        private void CargarGridVenta(List<string> Lista)
        {
            try
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvVenta);
                fila.Cells[1].Value = Lista[0];
                fila.Cells[2].Value = Lista[1];
                fila.Cells[3].Value = Lista[2];
                fila.Cells[4].Value = Lista[3];
                fila.Cells[5].Value = Lista[4];
                fila.Cells[6].Value = Lista[5];
                dgvVenta.Rows.Add(fila);
                total += Convert.ToDouble(Lista[5]);
                lblTotalINS.Text = total.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

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
                    entProducto p = new entProducto();
                    entEstado es = new entEstado();
                    u.Id_Usuario = Convert.ToInt32(lblUsuario.Text);
                    v.usuario = u;
                    v.folio = Convert.ToInt32(lblIdVenta.Text);
                    v.Fecha_Venta = Convert.ToDateTime(lblFecha.Text);
                    es.Id_Estado = "C";//Confirmado
                    v.Estado_Venta = es;
                    List<entVenta> venta = new List<entVenta>();//se crea una lista de los productso vendidos
                    foreach (DataGridViewRow row in dgvVenta.Rows)//se extraen los datos de la tabla
                    {
                        p.Id_Prod = Convert.ToInt32(row.Cells[1].Value);
                        v.Id_producto = p;
                        v.cantidad = Convert.ToInt32(row.Cells[5].Value);
                        v.Subtotal_Venta = Convert.ToInt32(row.Cells[6].Value);
                        int result = negVenta.Instancia.GuardarVenta(v);
                        //venta.Add(v);//se añaden los datos a la lista
                    }
                    //v.productos = venta;//se adjudica la lista a productos dela venta


                    MessageBox.Show("Venta registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvVenta.Enabled = false; ControlBotones(true, false, false, false);//pendiente, control de disponibilidad  botones
                    //ac.BloquearText(this.panel1, false);//pendeinte para bloquear texto de determinado panel
                    lblTotal.Text = ("0.00");
                    dgvVenta.Rows.Clear();
                    cbxCantidad.Text = "1";
                    txtBuscar.Text = "";
                    btnImprimir.Enabled = true;
                }
            }//Excepción de la app
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
            }
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
                    int result = negVenta.Instancia.EliminarVentaxId(Convert.ToInt32(txtIdELI.Text));
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
        {//Cancelar
            dgvVentasELI.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvVenta.Rows.Clear();
        }


        private void frmVenta_Load(object sender, EventArgs e)
        {
            try
            {
                CrearGrid();
                dgvVentasELI.DataSource = negVenta.Instancia.CargarVenta();
                dgvVentasACT.DataSource = negVenta.Instancia.CargarVenta();
                lblFecha.Text = DateTime.Now.ToShortDateString();
                lblTotal.Text = total.ToString();
                btnImprimir.Enabled = false;
                btnImprimirACT.Enabled = false;
                btnEliminarACT.Enabled = false;
                lblIdVenta.Text = negVenta.Instancia.ObtenerIdVenta().ToString();
                //ControlBotones(true, false, false, false); btnBuscarXid.Enabled = false;
                //txtSubtotal.Text = 0.ToString(); txtDescuento.Text = 0.ToString(); txtTotal.Text = 0.ToString();
                //us = negSeguridad.Instancia.BuscarUsario("Id", this.id_user.ToString());
                //this.id_user = us.Id_Usuario;
                //txtCodUsuario.Text = us.Codigo_Usuario;
                btnImprimir.Enabled = false;
                dgvProductos.DataSource = negProducto.Instancia.CargarProducto();
                dgvProductos.Columns[0].Visible = false;//Id
                dgvProductos.Columns[2].Visible = false;//Unmed
                dgvProductos.Columns[5].Visible = false;//Marca
                dgvProductos.Columns[6].Visible = false;//Costo
                dgvProductos.Columns[8].Visible = false;//Estado
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Se selecciona un producto para añadirlo a la venta

        private void txtBuscar_TextChanged(object sender, EventArgs e)//listo
        {//Busqueda, filtrado
            if (txtBuscar.Text != "")
            {
                try
                {
                    dgvProductos.DataSource = negProducto.Instancia.BuscarProducto(txtBuscar.Text);
                    //ControlBotones(true, true, false, true, false, true);
                    //ac.BloquearText(this.panel1, false);
                }
                catch (ApplicationException ae)
                {
                    MessageBox.Show(ae.Message, "Aviso",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)//LISTO
        {
            DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
            List<string> lista = new List<string>();
            if (row != null)
            {
                if (cbxCantidad.Text != "Seleccionar...")
                {
                    lista.Add(row.Cells[0].Value.ToString());//Id
                    lista.Add(row.Cells[1].Value.ToString());//Nombre
                    lista.Add(row.Cells[3].Value.ToString());//Descrp
                    lista.Add(row.Cells[7].Value.ToString());//precio
                    lista.Add(cbxCantidad.Text);//cantidad
                    lista.Add((Convert.ToInt32(cbxCantidad.Text) * Convert.ToDouble(row.Cells[7].Value)).ToString());//subtotal
                    //MessageBox.Show((Convert.ToInt32(cbxCantidad.Text) * Convert.ToDouble(row.Cells[6].Value)).ToString());
                    CargarGridVenta(lista);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarACT_Click(object sender, EventArgs e)
        {
            dgvVentasACT.Rows.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //(Convert.ToInt32(cbxCantidad.Text) * Convert.ToDouble(dgvVenta.Rows.Cells[5].Value)).ToString()
        }

        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvVenta.Columns["Eliminar"].Index)
            {
                DialogResult result;
                //result = MessageBox.Show("¿Desea eliminar este usuario?", "Eliminar registro de usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //if (result == DialogResult.OK)
                //{
                    foreach (DataGridViewRow row in dgvVenta.SelectedRows)
                    {
                    total -= Convert.ToDouble(row.Cells[6].Value);
                    lblTotalINS.Text = total.ToString();
                    dgvVenta.Rows.RemoveAt(row.Index);
                    }
                //}

            }
        }

        private void txtIdELI_TextChanged(object sender, EventArgs e)
        {
            if (txtIdELI.Text != "")
            {
                lblFolioELI.Text = txtIdELI.Text;
                dgvVentasELI.DataSource = negVenta.Instancia.BuscarVenta(Convert.ToInt32(txtIdELI.Text));
                dgvVentasELI.DataSource = negVenta.Instancia.CargarVenta();
            }
            
        }
    }
}
