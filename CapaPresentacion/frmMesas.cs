using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)//abrir ventana de tipo
        {
            //Abrir ventana frmMesaAgregarTipo
            frmMesaAgregarTipo tipo = new frmMesaAgregarTipo();
            tipo.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                entMesa m= new entMesa();
                m.Id_disponibilidad.Id_Disponibilidad = 0;
                m.id_tipo.Id_Tipo = cbxTipoMesa.SelectedIndex;
                
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

        private void btnEliminarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea eliminar la mesa?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int result = negMesa.Instancia.EliminarMesa(Convert.ToInt32(txtIdEliminar.Text));//enviar id
                    MessageBox.Show("Mesa Eliminada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //ControlBotones(true, false, false, false, false, true);//pendiente
                //ac.BloquearText(this.panel1, false);//pendiente
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Cierra formulario libera recursos
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmNuevaMarca nm  = new frmNuevaMarca();
            nm.Show();
            this.Hide();
        }
    }
}
