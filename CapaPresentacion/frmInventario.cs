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
    public partial class frmInventario : Form
    {
        entUsuario us = null;
        int userId = 0;
        string userName = "";
        public frmInventario(entUsuario user)
        {
            InitializeComponent();
            this.userId = user.Id_Usuario;
            this.userName = user.Nombre_Usuario;
        }

        // metodos globales para etiquetas del formulario 

        AccionesEnControles ac = new AccionesEnControles();


        //public void ControlBotones(string pantalla, bool nuevo, bool editar, bool grabar, bool eliminar, bool cancelar, bool salir)
        //{
        //    try
        //    {
        //        if (pantalla == "P")
        //        {
        //            btnNuevoP.Enabled = nuevo;
        //            btnEditarP.Enabled = editar;
        //            btnGuardarP.Enabled = grabar;
        //            btnEliminarP.Enabled = eliminar;
        //            btnCancelarP.Enabled = cancelar;
        //            btnSalirP.Enabled = salir;
        //        }

        //        else if (pantalla == "UM")
        //        {

        //            btnNuevoUM.Enabled = nuevo;
        //            btnEditarUM.Enabled = editar;
        //            btnGuardarUM.Enabled = grabar;
        //            btnEliminarUM.Enabled = eliminar;
        //            btnCancelarUM.Enabled = cancelar;
        //            btnSalirUM.Enabled = salir;
        //        }else{
        //            btnNuevoMarca.Enabled = nuevo;
        //            btnEditarMarca.Enabled = editar;
        //            btnGrabarMarca.Enabled = grabar;
        //            btnEliminarMarca.Enabled = eliminar;
        //            btnCancelarMarca.Enabled = cancelar;
        //            btnSalirMarca.Enabled = salir;
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        // Crear diseño del GRID
        //private void CrearGrid()
        //{
        //    dgvProductos.Columns.Add("ColumnId", "Id");
        //    dgvProductos.Columns.Add("ColumnNumero", "#");
        //    dgvProductos.Columns.Add("ColumnCodigo", "Codigo");
        //    dgvProductos.Columns.Add("ColumnNombre", "Nombre");
        //    dgvProductos.Columns.Add("ColumnMarca", "Marca");
        //    dgvProductos.Columns.Add("ColumnCategoria", "Categoria");
        //    dgvProductos.Columns.Add("ColumnUnidMed", "Unid. Med");
        //    dgvProductos.Columns.Add("ColumnProveedor", "Proveedor");

        //    dgvProductos.Columns[0].Visible = false;
        //    dgvProductos.Columns[1].Width = 30;
        //    dgvProductos.Columns[1].Width = 60;

        //    DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
        //    cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvProductos.ColumnHeadersDefaultCellStyle = cssCabecera;

        //    dgvProductos.AllowUserToAddRows = false;
        //    dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    dgvProductos.MultiSelect = false;

        //}

        //private void CrearGridUniMed()
        //{
        //    dgvUnidadMedida.Columns.Add("ColumnId", "id");
        //    dgvUnidadMedida.Columns.Add("ColumnNumero", "#");
        //    dgvUnidadMedida.Columns.Add("ColumnCodigo", "Codigo");
        //    dgvUnidadMedida.Columns.Add("ColumnDescripcion", "Descripción");
        //    dgvUnidadMedida.Columns.Add("ColumnAbrev", "Abreviatura");

        //    dgvUnidadMedida.Columns[0].Visible = false;
        //    dgvUnidadMedida.Columns[1].Width = 30;
        //    dgvUnidadMedida.Columns[3].Width = 300;
        //    dgvUnidadMedida.Columns[4].Width = 150;


        //    DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
        //    cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvUnidadMedida.ColumnHeadersDefaultCellStyle = cssCabecera;

        //    dgvUnidadMedida.AllowUserToAddRows = false;
        //    dgvUnidadMedida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        //}


        //private void CrearGridMarca()
        //{
        //    dgvMarca.Columns.Add("ColumnId", "id");
        //    dgvMarca.Columns.Add("ColumnNumero", "#");
        //    dgvMarca.Columns.Add("ColumnCodigo", "Codigo");
        //    dgvMarca.Columns.Add("ColumnNombre", "Nombre");

        //    dgvMarca.Columns[0].Visible = false;
        //    dgvMarca.Columns[1].Width = 30;
        //    dgvMarca.Columns[2].Width = 150;
        //    dgvMarca.Columns[3].Width = 300;


        //    DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
        //    cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvMarca.ColumnHeadersDefaultCellStyle = cssCabecera;

        //    dgvMarca.AllowUserToAddRows = false;
        //    dgvMarca.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        //}

        // cargar combos para producto
        private void LlenarCombos()//Listo
        {
            try
            {
                foreach (var dat in negProducto.Instancia.ListarUnidMed())
                {
                    cbxUnmed.Items.Add(dat.Abreviatura_Umed);
                    cbxUnmedACT.Items.Add(dat.Abreviatura_Umed);
                }
              
                foreach (var dat in negProducto.Instancia.ListarMarca())
                {
                    cbxMarca.Items.Add(dat.Nombre_Marca);
                    cbxMarcaACT.Items.Add(dat.Nombre_Marca);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        //// funcion validar entrada solo caracteres validos jojojo
        //private bool EntradaDecimales(KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        Boolean result;
        //        String cadena = "1234567890," + (char)5;
        //        if (cadena.Contains(e.KeyChar))
        //        {
        //            result = true;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Esta intentando ingresar un caracter inválido", "Aviso",
        //         MessageBoxButtons.OK, MessageBoxIcon.Warning); result = false;
        //        }
        //        return result;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
      
        private void frmInventario_Load(object sender, EventArgs e)
        {
            try
            {
                //ControlBotones("P", true, false, false, false, false, true);//Producto
                //ControlBotones("UM", true, false, false, false, false, true);//Unidad de medida
                //ControlBotones("M", true, false, false, false, false, true);//Marca


                //ac.BloquearText(this.tbcProducto, false);
                //ac.BloquearText(this.tbcUnidMedida, false);

                //CrearGrid();
                //CrearGridUniMed();
                LlenarCombos();
                ActTablas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        e.Handled = ac.EntradaDecimales(e);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        e.Handled = ac.EntradaDecimales(e);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        e.Handled = ac.EntradaSoloNumeros(e);
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message, "Error",
        //                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void txtStockPromedio_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        e.Handled = ac.EntradaSoloNumeros(e);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void txtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        e.Handled = ac.EntradaSoloNumeros(e);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        private void pictureBox3_Click(object sender, EventArgs e)//LISTO
        {
            this.Dispose(); // Cierra formulario libera recursos
        }

        private void btnAgregarTipo_Click(object sender, EventArgs e)//LISTO
        {
            frmNuevaMarca nm = new frmNuevaMarca(us);
            nm.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)//LISTO
        {//Perfeccionar metodo con verificaciones
            try
            {
                //Comprobar en primer lugar que los cbx no estén vacios
                if (cbxUnmed.Text== "Seleccionar..." || cbxMarca.Text == "Seleccionar...") 
                    throw new ApplicationException("Deber tener seleccionada una Marca");
                //instancias d elas entidades involucradas
                entEstado es = new entEstado();
                entProducto p = new entProducto();
                p.Descripcion_Prod = txtDescrp.Text;
                p.Nombre_Prod = txtNomProd.Text;
                entUnidadMedida um = new entUnidadMedida();
                um.Id_Umed = Convert.ToInt32(cbxUnmed.SelectedIndex+1);
                p.Id_umed = um;
                if (txtExistencia.Text == "") 
                    p.existencia = 0; 
                else 
                    p.existencia = Convert.ToInt32(txtExistencia.Text);
                entMarca m = new entMarca();
                m.Id_Marca = Convert.ToInt32(cbxMarca.SelectedIndex+1);
                p.id_marca = m;
                if (txtCosto.Text == "")
                    p.Costo_Prod = 0;
                else
                    p.Costo_Prod = Convert.ToDouble(txtCosto.Text);

                if (txtPrecio.Text == "") 
                    p.Precio_Prod = 0; 
                else 
                    p.Precio_Prod = Convert.ToDouble(txtPrecio.Text);
                es.Id_Estado = "C";
                p.estado = es;
                int i = negProducto.Instancia.insertarProducto(p);
                MessageBox.Show("¡Registro Correcto!", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActTablas();
                //ControlBotones("P", true, false, false, false, false, true);
                //ac.BloquearText(this.tbcProducto, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = negProducto.Instancia.EliminarProducto(Convert.ToInt32(txtIdEliminar.Text));
                    MessageBox.Show("Producto eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActTablas();
                }

                //ControlBotones("P", true, false, false, false, false, true);
                //ac.BloquearText(this.tbcProducto, false);
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Perfeccionar metodo con verificaciones
            try
            {
                entProducto p = new entProducto();
                entMarca m = new entMarca();
                entUnidadMedida um = new entUnidadMedida();
                if (cbxUnmedACT.Text == "Seleccionar..." || cbxMarcaACT.Text == "Seleccionar...")
                    throw new ApplicationException("Deber tener seleccionada una Marca");
                p.Id_Prod = Convert.ToInt32(txtIdProductoACT.Text);
                p.Nombre_Prod = txtNombreACT.Text;
                //MessageBox.Show(p.Nombre_Prod);
                p.Descripcion_Prod = txtDescrpACT.Text;
                um.Id_Umed = Convert.ToInt32(cbxUnmedACT.SelectedIndex + 1);
                p.Id_umed = um;
                if (txtExistenciaACT.Text == "")
                    p.existencia = 0;
                else
                    p.existencia = Convert.ToInt32(txtExistenciaACT.Text);
                m.Id_Marca = Convert.ToInt32(cbxMarcaACT.SelectedIndex + 1);
                p.id_marca = m;
                if (txtCostoACT.Text == "")
                    p.Costo_Prod = 0;
                else
                    p.Costo_Prod = Convert.ToDouble(txtCostoACT.Text);

                if (txtPrecioACT.Text == "")
                    p.Precio_Prod = 0;
                else
                    p.Precio_Prod = Convert.ToDouble(txtPrecioACT.Text);

                int am = negProducto.Instancia.actualizarProducto(p);
                MessageBox.Show("¡Actualización de producto Correcto!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ControlBotones(true, false, false, false, false, true);
                //ac.BloquearText(this.panel1, false);
                ActTablas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIdProductoEX_TextChanged(object sender, EventArgs e)
        {
            if(txtIdProductoEX.Text!="")
                dgvProductosEX.DataSource = negProducto.Instancia.BuscarProductoExistencia(Convert.ToInt32(txtIdProductoEX.Text));
            else if(txtIdProductoEX.Text == "")
                ActTablas();
        }

        private void btnAgregarEX_Click(object sender, EventArgs e)
        {
            try
            {

                int i = negProducto.Instancia.agregarExistencia(Convert.ToInt32(txtCantidadEX.Text), Convert.ToInt32(txtIdProductoEX.Text));
                MessageBox.Show("¡Existencia agregada correctamente!", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActTablas();
                //ControlBotones("P", true, false, false, false, false, true);
                //ac.BloquearText(this.tbcProducto, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
                ActTablas();
            else
            {
                try
                {
                    dgvProductosCONS.DataSource = negProducto.Instancia.BuscarProducto(txtBusqueda.Text);
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

        private void txtIdEliminar_TextChanged(object sender, EventArgs e)
        {
            if (txtIdEliminar.Text == "")
                ActTablas();
        }

        private void ActTablas()
        {
            dgvProductosCONS.DataSource = negProducto.Instancia.CargarProducto();
            dgvProductosEX.DataSource = negProducto.Instancia.CargarProducto();
            dgvProductosELI.DataSource = negProducto.Instancia.CargarProducto();
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
    }
}
