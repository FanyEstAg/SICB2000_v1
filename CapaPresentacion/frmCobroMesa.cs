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
        public frmCobroMesa()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Mostrar notificación de qye se ha imprimido correctamente
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entCobroMesa cm = new entCobroMesa();
                //cm.Id_Usuario.Id_Usuario=
                cm.fecha = DateTime.Now.ToUniversalTime();
                cm.Id_mesa.Id_Mesa = cbxIdMesaRegistro.SelectedIndex;
                cm.Tiempo_inicio=
                int mesa = negMesa.Instancia.insertarMesa(m);
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
    }
}
