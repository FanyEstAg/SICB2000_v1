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
        entUsuario us = null;
        string user = "";
        AccionesEnControles ac = new AccionesEnControles();

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
            if (txtIdMesa.Text == "")
            {
                MessageBox.Show("¡Campo vacío!", "     ¡ADVERTENCIA!");
            }
            else
            {
                entCobroMesa cobro = new entCobroMesa();
                entEstado estado = new entEstado();
                entMesa mesa = new entMesa();
                double pago = 0;
                int minutos = 0;
                cobro.Id_pagoMesa = int.Parse(txtIdMesa.Text);

                List<entCobroMesa> lc = new List<entCobroMesa>();//se crea una lista de los productso vendidos
                foreach (DataGridViewRow row in dgvRegistrar.Rows)//se extraen los datos de la tabla
                {
                    cobro.Id_pagoMesa = Convert.ToInt32(row.Cells[0].Value);
                    mesa.id_tipo.Nom_Tipo = "Pool";                    
                    cobro.Tiempo_total = 62;
                    pago = 1.5 * 62;
                    cobro.PagoTotal = pago;
                    lc.Add(cobro);
                    MessageBox.Show("Cobro registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                MessageBox.Show("Cobro registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
