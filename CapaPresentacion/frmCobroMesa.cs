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
    public partial class frmCobroMesa : Form
    {
       
        public frmCobroMesa(/*string user*/)
        {
            InitializeComponent();
            //this.user = user;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Mostrar notificación de qye se ha imprimido correctamente
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Cierra formulario libera recursos
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    entCobroMesa co = new entCobroMesa();
                    co.Id_mesa.Id_Mesa = cbxIdMesa.SelectedIndex;
                    //co.Id_mesa.id_tipo = 
                    //co.Tiempo_total =
                    //co.PagoTotal =

                    int cobro = negMesa.Instancia.GuardarCobroMesa(co);
                    MessageBox.Show("¡Cobro exitoso!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                      
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
