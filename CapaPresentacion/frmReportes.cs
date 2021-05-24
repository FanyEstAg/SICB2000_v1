using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using Entidades;

namespace CapaPresentacion
{
    public partial class frmReportes : Form
    {
        AccionesEnControles ac = new AccionesEnControles();
        entUsuario us = null;
        int userId = 0;
        string userName = "";
        public frmReportes(entUsuario user)
        {
            InitializeComponent();
            this.userId = user.Id_Usuario;
            this.userName = user.Nombre_Usuario;
        }

        private void btnBuscarV_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVentasR.DataSource = negVenta.Instancia.BuscarVenta(Convert.ToInt32(txtIdVentasR.Text));
                
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

        private void btnImprimirV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMesasR.DataSource = negMesa.Instancia.BuscarMesa(txtIdMesaR.Text);

                //ac.BloquearText(this.panel2, false);
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

        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductosR.DataSource = negProducto.Instancia.BuscarProducto(txtIdProductoR.Text);

                //ac.BloquearText(this.panel2, false);
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

        private void frmReportes_Load(object sender, EventArgs e)
        {
            dgvMesasR.DataSource = negMesa.Instancia.CargarMesas();
            dgvProductosR.DataSource = negProducto.Instancia.CargarProducto();
            dgvVentasR.DataSource = negVenta.Instancia.CargarVenta();
        }
    }
}