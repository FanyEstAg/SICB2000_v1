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
        Int32 idUsuario;
        public frmInventario(Int32? id_Usuario)
        {
            InitializeComponent();
            idUsuario = (Int32)id_Usuario;
        }

        // metodos globales para etiquetas del formulario 

        AccionesEnControles ac = new AccionesEnControles();

        ////TABS
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

        //// cargar combos para producto
        //private void LlenarCombos()
        //{
        //    try
        //    {

        //        cboUnidMed.ValueMember = "Id_Umed";
        //        cboUnidMed.DisplayMember = "Descripcion_Umed";
        //        cboUnidMed.DataSource = negProducto.Instancia.ListarUnidMed();

        //        cboMarca.ValueMember = "Id";
        //        cboMarca.DisplayMember = "Nombre";
        //        cboMarca.DataSource = negProducto.Instancia.ListarMaterial();


        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
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
        //private void Mostrarfila_select(int id_prod)
        //{
        //    try
        //    {
        //        entProducto p = null;
        //        // int id_prod = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
        //        p = negProducto.Instancia.BuscarProducto(id_prod);
        //        txtIdP.Text = p.Id_Prod.ToString();
        //        txtCodigoP.Text = p.Codigo_Prod;
        //        txtNombre.Text = p.Nombre_Prod;
        //        txtMarca.Text = p.Marca_Prod;
        //        txtPrecioCompra.Text = p.PrecioCompra_Prod.ToString();
        //        txtPrecioVenta.Text = p.Precio_Prod.ToString();
        //        txtStock.Text = p.Stock_Prod.ToString();
        //        txtStockPromedio.Text = p.StockProm_Prod.ToString();
        //        txtStockMin.Text = p.StockMin_Prod.ToString();
        //        cboCategoria.SelectedValue = p.categoria.Id_Cat;
        //        cboUnidMed.SelectedValue = p.unidmedida.Id_Umed;
        //        cboProveedor.SelectedValue = p.proveedor.Id_Proveedor;
        //        cboMarca.SelectedValue = p.material.Id;
        //        ac.BloquearText(this.tbcProducto, false);
        //        ControlBotones("P",true, true, false, true, false, true);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}




        //private void frmProducto_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ControlBotones("P",true, false, false, false, false, true);//Producto
        //        ControlBotones("UM", true, false, false, false, false, true);//Unidad de medida
        //        ControlBotones("M", true, false, false, false, false, true);//Marca


        //        ac.BloquearText(this.tbcProducto, false);
        //        ac.BloquearText(this.tbcUnidMedida, false);

        //        CrearGrid();
        //        CrearGridUniMed();
        //        LlenarCombos();
        //        CargarGridProducto();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Aviso",
        //         MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //private void btnNuevo_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ac.LimpiarText(this.tbcProducto);
        //        ac.BloquearText(this.tbcProducto, true);
        //        ControlBotones("P",false, false, true, false, true, false);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //          MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnEditar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ControlBotones("P",false, false, true, false, true, false);
        //        ac.BloquearText(this.tbcProducto, true);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        if (String.IsNullOrEmpty(Convert.ToString(cboCategoria.SelectedValue))) throw new ApplicationException("Deber tener seleccionada una Categoria");
        //        else if (String.IsNullOrEmpty(Convert.ToString(cboProveedor.SelectedValue))) throw new ApplicationException("Deber tener seleccionado un Proveedor");
        //        else if (String.IsNullOrEmpty(Convert.ToString(cboUnidMed.SelectedValue))) throw new ApplicationException("Deber tener seleccionada una Unidad de Medida ");


        //        entProducto p = new entProducto();
        //        int tipoedicion = 1;
        //        if (txtIdP.Text != "") { tipoedicion = 2; p.Id_Prod = Convert.ToInt32(txtIdP.Text); }
        //        p.Nombre_Prod = txtNombre.Text;
        //        p.Marca_Prod = txtMarca.Text;
        //        if (txtPrecioCompra.Text == "") p.PrecioCompra_Prod = 0; else p.PrecioCompra_Prod = Convert.ToDouble(txtPrecioCompra.Text);
        //        if (txtPrecioVenta.Text == "") p.Precio_Prod = 0; else p.Precio_Prod = Convert.ToDouble(txtPrecioVenta.Text);
        //        if (txtStock.Text == "") p.Stock_Prod = 0; else p.Stock_Prod = Convert.ToInt32(txtStock.Text);
        //        if (txtStockPromedio.Text == "") p.StockProm_Prod = 0; else p.StockProm_Prod = Convert.ToInt32(txtStockPromedio.Text);
        //        if (txtStockMin.Text == "") p.StockMin_Prod = 0; else p.StockMin_Prod = Convert.ToInt32(txtStockMin.Text);
        //        entCategoria c = new entCategoria();
        //        c.Id_Cat = Convert.ToInt32(cboCategoria.SelectedValue);
        //        p.categoria = c;
        //        entUnidadMedida um = new entUnidadMedida();
        //        um.Id_Umed = Convert.ToInt32(cboUnidMed.SelectedValue);
        //        p.unidmedida = um;
        //        entProveedor pr = new entProveedor();
        //        pr.Id_Proveedor = Convert.ToInt32(cboProveedor.SelectedValue);
        //        p.proveedor = pr;
        //        entMaterial m = new entMaterial();
        //        m.Id = Convert.ToInt32(cboMarca.SelectedValue);
        //        p.material = m;

        //        p.UsuarioCreacion_Prod = idUsuario;
        //        p.UsuarioUpdate_Prod = idUsuario;
        //        int i = negProducto.Instancia.MantenimientoProducto(p, tipoedicion);
        //        MessageBox.Show("¡Registro Correcto!", "Mensaje",
        //                        MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        ControlBotones("P",true, false, false, false, false, true);
        //        ac.BloquearText(this.tbcProducto, false);
        //        CargarGridProducto();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        entProducto p = new entProducto();
        //        entCategoria c = new entCategoria();
        //        entUnidadMedida um = new entUnidadMedida();
        //        entProveedor pr = new entProveedor();
        //        p.Id_Prod = Convert.ToInt32(txtIdP.Text);
        //        p.categoria = c;
        //        p.proveedor = pr;
        //        p.unidmedida = um;
        //        DialogResult r = MessageBox.Show("¿Desea eliminar Registro seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (r == DialogResult.Yes)
        //        {
        //            int i = negProducto.Instancia.MantenimientoProducto(p, 3);
        //            MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }

        //        ControlBotones("P",true, false, false, false, false, true);
        //        ac.BloquearText(this.tbcProducto, false);
        //        CargarGridProducto();
        //    }
        //    catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ControlBotones("P",true, true, false, true, false, true);
        //        ac.BloquearText(this.tbcProducto, false);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnSalir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult res = MessageBox.Show("¿Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (res == DialogResult.Yes)
        //        {
        //            this.Close();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void tbcCategoria_Click(object sender, EventArgs e)
        //{

        //}

        //private void CargarGrid()
        //{
        //    try
        //    {
        //        dgvCategoria.Rows.Clear();
        //        List<entCategoria> Lista = null;
        //        Lista = negProducto.Instancia.ListarCategoria();
        //        int num = 0;
        //        for (int i = 0; i < Lista.Count; i++)
        //        {
        //            num++;
        //            String[] fila = new string[] { Lista[i].Id_Cat.ToString(), num.ToString(), Lista[i].Codigo_Cat, Lista[i].Nombre_Cat, Lista[i].Descripcion_Cat };
        //            dgvCategoria.Rows.Add(fila);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        //private void CargarGridMaterial()
        //{
        //    try
        //    {
        //        dgvMarca.Rows.Clear();
        //        List<entMaterial> Lista = null;
        //        Lista = negProducto.Instancia.ListarMaterial();
        //        int num = 0;
        //        for (int i = 0; i < Lista.Count; i++)
        //        {
        //            num++;
        //            String[] fila = new string[] { Lista[i].Id.ToString(), num.ToString(), Lista[i].Id.ToString("000"),Lista[i].Nombre};
        //           dgvMarca.Rows.Add(fila);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //private void CargarGridUnidMedida()
        //{
        //    try
        //    {
        //        int num = 0;
        //        dgvUnidadMedida.Rows.Clear();
        //        List<entUnidadMedida> um = null;
        //        um = negProducto.Instancia.ListarUnidMed();
        //        for (int i = 0; i < um.Count; i++)
        //        {
        //            num++;
        //            String[] fila = new string[] { um[i].Id_Umed.ToString(), num.ToString(), um[i].Codigo_Umed, um[i].Descripcion_Umed, um[i].Abreviatura_Umed };
        //            dgvUnidadMedida.Rows.Add(fila);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void CargarGridProducto()
        //{
        //    try
        //    {
        //        dgvProductos.Rows.Clear();
        //        List<entProducto> Lista = negProducto.Instancia.ListarProducto();
        //        int num = 0;
        //        for (int i = 0; i < Lista.Count(); i++)
        //        {
        //            num++;
        //            String[] fila = new String[] { Lista[i].Id_Prod.ToString(),num.ToString(),Lista[i].Codigo_Prod,Lista[i].Nombre_Prod,Lista[i].Marca_Prod,
        //            Lista[i].categoria.Nombre_Cat,Lista[i].unidmedida.Descripcion_Umed,Lista[i].proveedor.RazSocial_Proveedor};
        //            dgvProductos.Rows.Add(fila);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void btnCargarUM_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        CargarGridUnidMedida();
        //        btnCargarUM.Visible = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //private void btnNuevoUM_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ac.LimpiarText(this.tbcUnidMedida);
        //        ac.BloquearText(this.tbcUnidMedida, true);
        //        ControlBotones("UM",false, false, true, false, true, false);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //          MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnEditarUM_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ControlBotones("UM",false, false, true, false, true, false);
        //        ac.BloquearText(this.tbcUnidMedida, true);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnGuardarUM_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        entUnidadMedida um = new entUnidadMedida();
        //        int tipoedicion = 1;
        //        if (txtidUM.Text != "") { tipoedicion = 2; um.Id_Umed = Convert.ToInt32(txtidUM.Text); }
        //        um.Descripcion_Umed = txtDescripcionUM.Text;
        //        um.Abreviatura_Umed = txtAbrev.Text;
        //        int i = negProducto.Instancia.MantenimientoUnidMedida(um, tipoedicion);
        //        MessageBox.Show("¡Registro Correcto!", "Mensaje",
        //                        MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        ControlBotones("UM",true, false, false, false, false, true);
        //        ac.BloquearText(this.tbcUnidMedida, false);
        //        CargarGridUnidMedida();
        //        LlenarCombos();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnEliminarUM_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        entUnidadMedida um = new entUnidadMedida();
        //        um.Id_Umed = Convert.ToInt32(txtidUM.Text);
        //        DialogResult r = MessageBox.Show("¿Desea eliminar registro seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (r == DialogResult.Yes)
        //        {
        //            int i = negProducto.Instancia.MantenimientoUnidMedida(um, 3);
        //            MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        ControlBotones("UM",true, false, false, false, false, true);
        //        ac.BloquearText(this.tbcUnidMedida, false);
        //        CargarGridUnidMedida();
        //        LlenarCombos();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnCancelarUM_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ControlBotones("UM",true, true, false, true, false, true);
        //        ac.BloquearText(this.tbcUnidMedida, false);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnSalirUM_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult res = MessageBox.Show("¿Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (res == DialogResult.Yes)
        //        {
        //            this.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void dgvUnidadMedida_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        int id_Unidmed = Convert.ToInt32(dgvUnidadMedida.CurrentRow.Cells[0].Value);
        //        entUnidadMedida um = null;
        //        um = negProducto.Instancia.BuscarUnidMedida(id_Unidmed);
        //        txtidUM.Text = um.Id_Umed.ToString();
        //        txtCodigoUM.Text = um.Codigo_Umed;
        //        txtDescripcionUM.Text = um.Descripcion_Umed;
        //        txtAbrev.Text = um.Abreviatura_Umed;
        //        ControlBotones("UM",true, true, false, true, false, true);
        //        ac.BloquearText(this.tbcUnidMedida, false);
        //    }
        //    catch (ApplicationException ae)
        //    {
        //        MessageBox.Show(ae.Message, "Aviso",
        //             MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        //private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        int id_prod = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
        //        Mostrarfila_select(id_prod);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

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

        //private void btnBuscarP_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        frmProductoBuscar frmProdBuscar = new frmProductoBuscar(this.idUsuario);
        //        //frmProdBuscar.MdiParent = this.ParentForm;

        //        frmProdBuscar.ShowDialog();
        //        int id = LocalBD.Instancia.ReturnIdprod(0, 0);
        //        for (int i = 0; i < dgvProductos.RowCount; i++)
        //        {
        //            if (Convert.ToInt32(dgvProductos.Rows[i].Cells[0].Value) == id)
        //            {
        //                dgvProductos.Rows[i].Selected = true;
        //                Mostrarfila_select(id);
        //                LocalBD.Instancia.ReturnIdprod(1, 0);
        //                return;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        //}

        //private void btnCargarMaterial_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        CargarGridMaterial();
        //        btnCargarMarca.Visible = false;
        //    }
        //    catch (ApplicationException ae)
        //    {
        //        MessageBox.Show(ae.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //private void btnNuevoMarca_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        txtNombreMarca.Enabled = true;
        //        txtNombreMarca.Text = "";
        //        txtIdMarca.Text = "";
        //        ControlBotones("M", false, false, true, false, true, false);
        //    }
        //    catch (ApplicationException ae)
        //    {
        //        MessageBox.Show(ae.Message, "Mensaje",
        //     MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnEditarMarca_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ControlBotones("M", false, false, true, false, true, false);
        //        txtNombreMarca.Enabled = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnGrabarMarca_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!String.IsNullOrEmpty(txtIdMarca.Text)) { /*editar*/ int i = negProducto.Instancia.EditarMaterial(Convert.ToInt32(txtIdMarca.Text), txtNombreMarca.Text); }
        //        else { /*guardar*/int i = negProducto.Instancia.RegistrarMaterial(txtNombreMarca.Text); }

        //        ControlBotones("M", true, false, false, false, false, true);
        //        txtNombreMarca.Enabled = false;
        //        MessageBox.Show("Material registrado exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        CargarGridMaterial();
        //        txtNombreMarca.Enabled = false;
        //        LlenarCombos();
        //    }
        //    catch (ApplicationException ae)
        //    {
        //        MessageBox.Show(ae.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnEliminarMarca_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Int32 id_material = 0;
        //        id_material = Convert.ToInt32(txtIdMarca.Text);
        //        DialogResult r = MessageBox.Show("¿Desea eliminar Material seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (r == DialogResult.Yes)
        //        {
        //            int i = negProducto.Instancia.EliminarMaterial(id_material);
        //            MessageBox.Show("Registro eliminado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }

        //        ControlBotones("M", true, false, false, false, false, true);
        //        CargarGridMaterial();
        //        LlenarCombos();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnCancelarMarca_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ControlBotones("M", false, false, true, false, true, false);
        //        txtNombreMarca.Enabled = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnSalirMarca_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult res = MessageBox.Show("¿Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (res == DialogResult.Yes)
        //        {
        //            this.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        int id_material = Convert.ToInt32(dgvMarca.CurrentRow.Cells[0].Value);
        //        entMaterial m = null;
        //        m = negProducto.Instancia.BuscarMaterial(id_material);
        //        txtIdMarca.Text = m.Id.ToString();
        //        txtCodigoMarca.Text = m.Id.ToString("000");
        //        txtNombreMarca.Text = m.Nombre;
        //        ControlBotones("M", true, true, false, true, false, true);
        //    }
        //    catch (ApplicationException ae)
        //    {
        //        MessageBox.Show(ae.Message, "Mensaje",
        //            MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error",
        //                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btnCargarMarca_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Cierra formulario libera recursos
        }

        private void btnAgregarTipo_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)//listo
        {
            try
            {
                //Comprobar en primer lugar que los cbx no estén vacios
                if (String.IsNullOrEmpty(Convert.ToString(cbxMarca.SelectedValue))) throw new ApplicationException("Deber tener seleccionada una Categoria");
                else if (String.IsNullOrEmpty(Convert.ToString(cbxUnmed.SelectedValue))) throw new ApplicationException("Deber tener seleccionada una Unidad de Medida ");
                //instancias d elas entidades involucradas
                entProducto p = new entProducto();
                p.Nombre_Prod = txtNomProd.Text;
                entUnidadMedida um = new entUnidadMedida();
                um.Id_Umed = Convert.ToInt32(cbxUnmed.SelectedIndex);
                p.Id_umed = um;
                if (txtExistencia.Text == "") 
                    p.existencia = 0; 
                else 
                    p.existencia = Convert.ToInt32(txtExistencia.Text);
                entMarca m = new entMarca();
                m.Id_Marca = Convert.ToInt32(cbxMarca.SelectedIndex);
                p.id_marca = m;
                if (txtCosto.Text == "")
                    p.Costo_Prod = 0;
                else
                    p.Costo_Prod = Convert.ToDouble(txtCosto.Text);

                if (txtPrecio.Text == "") 
                    p.Precio_Prod = 0; 
                else 
                    p.Precio_Prod = Convert.ToDouble(txtPrecio.Text);
                
                int i = negProducto.Instancia.insertarProducto(p);
                MessageBox.Show("¡Registro Correcto!", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //ControlBotones("P", true, false, false, false, false, true);
                //ac.BloquearText(this.tbcProducto, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)//Agregar existencia
        {

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
    }
}
