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
        double total2 = 0;
        double total3 = 0;
        double total4 = 0;
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

        private void CrearGrid(DataGridView dgv, byte op)//LISTO
        {
            try
            {
                if (op == 1)
                {
                    dgv.Columns.Add("ColumnIdProd", "ID");
                    dgv.Columns.Add("ColumnNombreProd", "Producto");
                    dgv.Columns.Add("ColumnDecrpProd", "Descripción");
                    dgv.Columns.Add("ColumnPrecio", "Precio");
                    dgv.Columns.Add("ColumnCantidad", "Cantidad");
                    dgv.Columns.Add("ColumnTotal", "Subtotal");
                    dgv.Columns[2].Visible = false;
                    dgv.Columns[2].Width = 70;

                    //Se establece que solumnas peuden alterarse directamente y cuales seran solo lectura
                    dgv.Columns[2].ReadOnly = true;
                    dgv.Columns[3].ReadOnly = true;
                    dgv.Columns[4].ReadOnly = true;
                    dgv.Columns[5].ReadOnly = false;
                    dgv.Columns[6].ReadOnly = true;
                    //Enfoque en la columa total
                    dgv.Columns[6].DefaultCellStyle.BackColor = Color.GreenYellow;

                    DataGridViewCellStyle cssabecera = new DataGridViewCellStyle();//objeto del estilo de las columnas
                    cssabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;//alineacion
                    dgv.ColumnHeadersDefaultCellStyle = cssabecera;//se asigna el tipo de alineacion a aprtir del estilo

                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);//fuente de los titulos
                    dgv.DefaultCellStyle.Font = new Font("Arial", 9);//fuente del cuerpo

                    dgv.AllowUserToAddRows = false;//Añadir filas 
                    dgv.MultiSelect = false;//multiselección falsa
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//seleccionar fila completa
                }
                //else
                //{
                //    dgv.Columns.Add("ColumnFolio", "Folio");
                //    dgv.Columns.Add("ColumnFecha", "Fecha");
                //    dgv.Columns.Add("ColumnIdProd", "ID");
                //    dgv.Columns.Add("ColumnDecrpProd", "Descripción");
                //    dgv.Columns.Add("ColumnPrecio", "Precio");
                //    dgv.Columns.Add("ColumnCantidad", "Cantidad");
                //    dgv.Columns.Add("ColumnTotal", "Subtotal");
                //    //dgv.Columns[2].Visible = false;
                //    //dgv.Columns[2].Width = 70;

                //    //Se establece que solumnas peuden alterarse directamente y cuales seran solo lectura
                //    dgv.Columns[1].ReadOnly = true;
                //    dgv.Columns[2].ReadOnly = true;
                //    dgv.Columns[3].ReadOnly = false;//prod
                //    dgv.Columns[4].ReadOnly = true;
                //    dgv.Columns[5].ReadOnly = false;//cantidad
                //    dgv.Columns[6].ReadOnly = true;
                //    //Enfoque en la columa total
                //    dgv.Columns[6].DefaultCellStyle.BackColor = Color.GreenYellow;

                //    DataGridViewCellStyle cssabecera = new DataGridViewCellStyle();//objeto del estilo de las columnas
                //    cssabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;//alineacion
                //    dgv.ColumnHeadersDefaultCellStyle = cssabecera;//se asigna el tipo de alineacion a aprtir del estilo

                //    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);//fuente de los titulos
                //    dgv.DefaultCellStyle.Font = new Font("Arial", 9);//fuente del cuerpo

                //    dgv.AllowUserToAddRows = false;//Añadir filas 
                //    dgv.MultiSelect = false;//multiselección falsa
                //    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//seleccionar fila completa
                //}

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
                    //MessageBox.Show(Convert.ToInt32(v.folio).ToString());
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

                    dgvVenta.Rows.Clear();
                    cbxCantidad.Text = "1";

                    lblIdVenta.Text = negVenta.Instancia.ObtenerIdVenta().ToString();
                    txtBuscar.Text = "";
                    btnImprimir.Enabled = true;
                    actTablasCarga();
                    total = 0;
                    lblTotalINS.Text = (total.ToString());
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
                //foreach (DataGridViewRow row in dgvVentasELI.SelectedRows)
                //    MessageBox.Show(row.Cells[2].Value.ToString());
                DialogResult dr = MessageBox.Show("¿Desea eliminar la venta?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Confirmación
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvVentasELI.SelectedRows)
                    {

                        int result = negVenta.Instancia.EliminarVentaxId(Convert.ToInt32(txtIdELI.Text), Convert.ToInt32(row.Cells[2].Value));
                        total2 = 0;
                        lblTotalELI.Text = total2.ToString();
                    }

                    //enviar el id dado por el usuario
                    MessageBox.Show("Venta Eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actTablasCarga();
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
            total = 0;
            lblTotalINS.Text = total.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.RowCount != 0)
                dgvVenta.Rows.Clear();
        }


        private void frmVenta_Load(object sender, EventArgs e)
        {
            try
            {
                CrearGrid(dgvVenta, 1);
                //CrearGrid(dgvVentasACT,2);

                dgvProductos.DataSource = negProducto.Instancia.CargarProducto();
                dgvProductos.Columns[0].Visible = false;//Id
                dgvProductos.Columns[2].Visible = false;//Unmed
                dgvProductos.Columns[5].Visible = false;//Marca
                dgvProductos.Columns[6].Visible = false;//Costo
                dgvProductos.Columns[8].Visible = false;//Estado

                lblFecha.Text = DateTime.Now.ToShortDateString();
                lblTotalELI.Text = total.ToString();
                btnImprimir.Enabled = false;
                btnImprimirACT.Enabled = false;
                lblIdVenta.Text = negVenta.Instancia.ObtenerIdVenta().ToString();

                actTablasCarga();

                //ControlBotones(true, false, false, false); btnBuscarXid.Enabled = false;
                //txtSubtotal.Text = 0.ToString(); txtDescuento.Text = 0.ToString(); txtTotal.Text = 0.ToString();
                //us = negSeguridad.Instancia.BuscarUsario("Id", this.id_user.ToString());
                //this.id_user = us.Id_Usuario;
                //txtCodUsuario.Text = us.Codigo_Usuario;
                btnImprimir.Enabled = false;

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
            else
            {
                dgvProductos.DataSource = negProducto.Instancia.BuscarProducto(txtBuscar.Text);
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
            if (dgvVentasACT.RowCount != 0)
                dgvVentasACT.Rows.Clear();
            actTablasCarga();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbxCantidad_TextChanged(object sender, EventArgs e)
        {

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

            if (txtIdELI.Text == "")
            {
                dgvVentasELI.DataSource = negVenta.Instancia.CargarVenta();

            }
            else
            {
                lblFolioELI.Text = txtIdELI.Text;
                try
                {
                    dgvVentasELI.DataSource = negVenta.Instancia.BuscarVenta(Convert.ToInt32(txtIdELI.Text));
                    foreach (DataGridViewRow row in dgvVentasELI.Rows)//se extraen los datos de la tabla
                    {
                        total2 += Convert.ToDouble(row.Cells[6].Value);
                        //venta.Add(v);//se añaden los datos a la lista
                    }

                    lblTotalELI.Text = total2.ToString();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizar ventana
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void dgvVentasACT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtIdACT.Text == "")
                MessageBox.Show("Inserte el folio de venta que desea modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void dgvVentasACT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvVentasACT.Columns[5].Index)//Cantidad
            {

                //actualizarTabla();
                //foreach (DataGridViewRow row in dgvVentasACT.SelectedRows)
                //{
                //    row.Cells[6].Value = Convert.ToDouble(row.Cells[4].Value) * Convert.ToDouble(row.Cells[5].Value);
                //    MessageBox.Show((Convert.ToDouble(row.Cells[4].Value) * Convert.ToDouble(row.Cells[5].Value)).ToString());
                //    total3 = Convert.ToDouble(row.Cells[6].Value);
                //    lblTotalACT.Text = total3.ToString();
                //    dgvVentasACT.Rows.RemoveAt(row.Index);
                //}
            }
            else
            {

            }
        }

        private void actTablasCarga()
        {
            dgvVentasELI.DataSource = negVenta.Instancia.CargarVenta();
            dgvVentasACT.DataSource = negVenta.Instancia.CargarVenta();
            dgvProductos.DataSource = negProducto.Instancia.CargarProducto();

        }

        private void txtIdACT_TextChanged(object sender, EventArgs e)
        {
            if (txtIdACT.Text == "")
            {
                dgvVentasACT.DataSource = negVenta.Instancia.CargarVenta();

            }
            else
            {
                lblFolioACT.Text = txtIdACT.Text;
                try
                {
                    dgvVentasACT.DataSource = negVenta.Instancia.BuscarVenta(Convert.ToInt32(txtIdACT.Text));

                    foreach (DataGridViewRow row in dgvVentasACT.Rows)//se extraen los datos de la tabla
                    {
                        total3 += Convert.ToDouble(row.Cells[6].Value);
                        //venta.Add(v);//se añaden los datos a la lista
                    }

                    lblTotalACT.Text = total3.ToString();
                    dgvVentasACT.Columns[0].ReadOnly = true;
                    dgvVentasACT.Columns[1].ReadOnly = true;
                    dgvVentasACT.Columns[2].ReadOnly = true;
                    dgvVentasACT.Columns[3].ReadOnly = true;
                    dgvVentasACT.Columns[4].ReadOnly = true;
                    dgvVentasACT.Columns[5].ReadOnly = false;//cantidad
                    dgvVentasACT.Columns[6].ReadOnly = true;//subtotal
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

        private void btnEliminarFila_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvVentasACT.SelectedRows)
            {
                total3 -= Convert.ToDouble(row.Cells[6].Value);
                lblTotalACT.Text = total3.ToString();
                dgvVentasACT.Rows.RemoveAt(row.Index);
            }

        }


        private void dgvVentasACT_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvVentasACT.Columns[5].Index)//Cantidad
            {
                total3 = 0;
                //actualizarTabla();
                foreach (DataGridViewRow row in dgvVentasACT.Rows)
                {
                    if (row.Selected == true)
                    {
                        //MessageBox.Show(row.Cells[6].Value.ToString());
                        row.Cells[6].Value = Convert.ToDouble(row.Cells[4].Value) * Convert.ToDouble(row.Cells[5].Value);

                    }
                    total3 += Convert.ToDouble(row.Cells[6].Value);
                    lblTotalACT.Text = total3.ToString();

                }
            }
            else
            {
                MessageBox.Show("No editable");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea actualizar la venta?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    entVenta v = new entVenta();
                    entUsuario u = new entUsuario();
                    entProducto p = new entProducto();
                    entEstado es = new entEstado();
                    u.Id_Usuario = Convert.ToInt32(lblUsuario.Text);
                    v.usuario = u;
                    v.folio = Convert.ToInt32(lblFolioACT.Text);
                    //MessageBox.Show(Convert.ToInt32(v.folio).ToString());
                    v.Fecha_Venta = Convert.ToDateTime(lblFecha.Text);
                    es.Id_Estado = "C";//Confirmado
                    v.Estado_Venta = es;
                    List<entVenta> venta = new List<entVenta>();//se crea una lista de los productso vendidos
                    foreach (DataGridViewRow row in dgvVentasACT.Rows)//se extraen los datos de la tabla
                    {
                        p.Id_Prod = Convert.ToInt32(row.Cells[2].Value);
                        v.Id_producto = p;
                        v.cantidad = Convert.ToInt32(row.Cells[5].Value);
                        v.Subtotal_Venta = Convert.ToInt32(row.Cells[6].Value);
                        int result = negVenta.Instancia.ActualizarVenta(v);
                        //venta.Add(v);//se añaden los datos a la lista
                    }
                    //v.productos = venta;//se adjudica la lista a productos dela venta


                    MessageBox.Show("Venta actualizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgvVenta.Enabled = false; ControlBotones(true, false, false, false);//pendiente, control de disponibilidad  botones
                    //ac.BloquearText(this.panel1, false);//pendeinte para bloquear texto de determinado panel

                    //cbxCantidad.Text = "1";
                    total3 = 0;
                    btnImprimir.Enabled = true;
                    actTablasCarga();
                    lblTotalACT.Text = (total3.ToString());
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

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtIdCONS_TextChanged_1(object sender, EventArgs e)
        {
            if (txtIdCONS.Text == "")
                dgvVentasCONS.DataSource = negVenta.Instancia.CargarVenta();
            else
            {
                try
                {
                    total4 = 0;
                    dgvVentasCONS.DataSource = negVenta.Instancia.BuscarVenta(Convert.ToInt32(txtIdCONS.Text));
                    lblFolioCONS.Text = txtIdCONS.Text;
                    foreach (DataGridViewRow row in dgvVentasCONS.Rows)//se extraen los datos de la tabla
                    {
                        total4+= Convert.ToInt32(row.Cells[6].Value);
                    }
                    lblTotalCONS.Text = total4.ToString();
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
    }
}
