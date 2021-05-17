//Nombre del programa: SolutionFinal
//Fecha de creación de la base de datos:28.03.2021
//Fecha de entrega: 06.05.2021
//Autor: Elizabeth Lucas García
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
       
        public frmCobroMesa()
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
        {       //Botón que registra o guarda un cobro
            
                try
                //intentar esto:
                {
                
                entCobroMesa co = new entCobroMesa();//Traer clase
                entMesa m = new entMesa();//Traer clase
                m.Id_Mesa = cbxIdMesa.SelectedIndex;//Leer índice
                co.Id_mesa = m;//Asignar id mesa a m

                int cobro = negMesa.Instancia.GuardarCobroMesa(co);//Guardar en capa de negocio
                    MessageBox.Show("¡Cobro exitoso!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Notificación de proceso correcto
                }
                catch (Exception ex)
                //Especificar respuesta si existe error
                {
                    MessageBox.Show(ex.Message, "Error",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                      
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();//Extraer hora del equipo
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {

        }

        private void cbxTipoMesa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarMesa_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarMesa_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
