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
    public partial class frmMesaAgregarTipo : Form
    {
        public frmMesaAgregarTipo()
        {
            InitializeComponent();
        }
        //Faltan verificaciones de textbox

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                int mesa = negMesa.Instancia.insertarTipoMesa(txtNuevoTipo.Text);
                MessageBox.Show("¡Registro Correcto!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ControlBotones(true, false, false, false, false, true);
                //ac.BloquearText(this.panel1, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea salir?", "Cancelar operación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
