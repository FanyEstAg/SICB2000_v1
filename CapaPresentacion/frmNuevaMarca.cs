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
    public partial class frmNuevaMarca : Form
    {
        public frmNuevaMarca()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Cierra formulario libera recursos
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               
                int i = negProducto.Instancia.insertarMarca(txtNombre.Text);
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
    }
    
}
