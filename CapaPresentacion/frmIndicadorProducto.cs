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
using System.IO;

namespace CapaPresentacion
{
    public partial class frmIndicadorProducto : Form
    {
        public frmIndicadorProducto()
        {
            InitializeComponent();
        }
        private void CrearGrid()
        {
            try
            {
                dgvProducto.Columns.Add("ColumnId", "Id");
                dgvProducto.Columns.Add("ColumnCodigo", "Código");
                dgvProducto.Columns.Add("ColumnNombre", "Nombre");
                dgvProducto.Columns.Add("ColumnPrecioCompra", "P Compra");
                dgvProducto.Columns.Add("ColumnPrecio", "P Venta");
                dgvProducto.Columns.Add("ColumnStock", "Stock");
                dgvProducto.Columns.Add("ColumnUniMedida", "Categoria");
                dgvProducto.Columns.Add("ColumnMaterila", "Uni. Medida");
                dgvProducto.Columns.Add("ColumnUniMedida", "Material");
                DataGridViewImageColumn dgvImagenColumn = new DataGridViewImageColumn();
                dgvImagenColumn.HeaderText = "Estado";
                dgvImagenColumn.Name = "ColumnEstado";
                dgvProducto.Columns.Add(dgvImagenColumn);

                dgvProducto.Columns[0].Visible = false;
                dgvProducto.Columns[2].Width = 300;
                dgvProducto.Columns[3].Width = 88;
                dgvProducto.Columns[4].Width =88;
                dgvProducto.Columns[5].Width = 88;
                dgvProducto.Columns[6].Width = 100;
                dgvProducto.Columns[7].Width = 100;
                dgvProducto.Columns[8].Width = 110;
                dgvProducto.Columns[9].Width = 55;
               


                DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
                cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProducto.ColumnHeadersDefaultCellStyle = cssCabecera;

                dgvProducto.AllowUserToAddRows = false;
                dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvProducto.AllowUserToResizeColumns = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LlenarCombo() {
            try
            {
                cboCategoria.ValueMember = "Id_Cat";
                cboCategoria.DisplayMember = "Nombre_Cat";
                cboCategoria.DataSource = negProducto.Instancia.ListarCategoria();
                // cargar estado rbstock
                rbStock.Checked = true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void LlenarGrid(String name) {
            try
            {
                int cat = 0;
                if (name==null) {
                    if (cboCategoria.SelectedValue == null) throw new ApplicationException("Debe seleccionar una categoria");
                }
                if (!String.IsNullOrEmpty(Convert.ToString(cboCategoria.SelectedValue))) cat = (int)cboCategoria.SelectedValue;
                dgvProducto.Rows.Clear();
                int rango = 0; Image img = null;
                if (rbStock.Checked == true) rango = 3;
                else if (rbStockPromedio.Checked == true) rango = 2;
                else if (rbStcokMin.Checked == true) rango = 1;
                else if (rbstockcero.Checked == true) rango = 0;
                List<entProducto> Lista = null;
                if (name == null) { Lista = negProducto.Instancia.ListarProductoIndicador(txtCodigo.Text,(int)cat , rango); }
                else { Lista = negProducto.Instancia.BuscarprodAvanzadaIndicador(name); }
                for (int i = 0; i < Lista.Count; i++)
                {
                    if (Lista[i].Stock_Prod >= 0 && Lista[i].Stock_Prod <= Lista[i].StockMin_Prod)
                    {
                        img = Properties.Resources.circulorojo_24x24;
                    }//Image.FromFile(Path.Combine(Application.StartupPath, "ImgAplicacion\\circulorojo_24x24.png")); }
                    else if (Lista[i].Stock_Prod > Lista[i].StockMin_Prod && Lista[i].Stock_Prod <= Lista[i].StockProm_Prod)
                    {
                        img = Properties.Resources.CirculoNaranja24x24;  //Image.FromFile(Path.Combine(Application.StartupPath, "ImgAplicacion\\CirculoNaranja24x24.png"));
                    }
                    else if (Lista[i].Stock_Prod > Lista[i].StockProm_Prod)
                    {
                        img = Properties.Resources.circulo_verde24x24; //Image.FromFile(Path.Combine(Application.StartupPath, "ImgAplicacion\\circulo_verde24x24.png"));
                    }
                    String[] fila = new String[] { Lista[i].Id_Prod.ToString(),Lista[i].Codigo_Prod,Lista[i].Nombre_Prod,Lista[i].PrecioCompra_Prod.ToString(),Lista[i].Precio_Prod.ToString(),
                    Lista[i].Stock_Prod.ToString(),Lista[i].categoria.Nombre_Cat,Lista[i].unidmedida.Abreviatura_Umed,Lista[i].material.Nombre};
                    dgvProducto.Rows.Add(fila);
                    dgvProducto.Rows[i].Cells[9].Value = img;

                }
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmIndicadorProducto_Load(object sender, EventArgs e)
        {
            try
            {
                CrearGrid();
                LlenarCombo();
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid(null);
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreProd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                LlenarGrid(txtNombreProd.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
