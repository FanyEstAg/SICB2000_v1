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
        //FALTAN VALIDACIONES DE CAJAS DE TEXTO
        public frmMesas()
        {
            InitializeComponent();
            //Falta jalar usuario
        }

        private void pictureBox2_Click(object sender, EventArgs e)//LISTO
            //abrir ventana de TIPO
        {
            //Abrir ventana frmMesaAgregarTipo
            frmMesaAgregarTipo tipo = new frmMesaAgregarTipo();
            tipo.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)//LISTO
        {
            try
            {
                entMesa m= new entMesa();
                entDisponibilidad d = new entDisponibilidad();
                entTipo t = new entTipo();
                d.Id_Disponibilidad = "Si";//Desocuoada
                m.Id_disponibilidad= d;
               
                t.Id_Tipo = cbxTipoMesa.SelectedIndex+1;
                m.id_tipo=t;
                
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

        private void btnEliminarMesa_Click(object sender, EventArgs e)//LISTO
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea eliminar la mesa?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int result = negMesa.Instancia.EliminarMesa(Convert.ToInt32(txtIdEliminar.Text));//enviar id
                    MessageBox.Show("Mesa Eliminada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvMesasELI.DataSource = negMesa.Instancia.CargarMesas();
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
            frmMesaAgregarTipo mt = new frmMesaAgregarTipo();
            mt.Show();
            //this.Hide();
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            try
            {
                txtIdMesa.Text = Convert.ToInt32(negMesa.Instancia.ObtenerIdMesa() + 1).ToString();
                dgvMesasELI.DataSource = negMesa.Instancia.CargarMesas();
                dgvMesasCONS.DataSource = negMesa.Instancia.CargarMesas();
                //combobox con los roles
                cbxTipoMesa.Text = "Seleccionar...";
                cbxTipoMesaACT.Text = "Seleccionar...";
                //cbxTipoMesa.ValueMember = "Id_Mesa";
                //cbxTipoMesa.DisplayMember = "Tipo";
                foreach (var dat in negMesa.Instancia.ListarTipo())
                {
                    cbxTipoMesa.Items.Add(dat.Nom_Tipo);
                    cbxTipoMesaACT.Items.Add(dat.Nom_Tipo);
                }

                //ControlBotones(true, false, false, false, false, true);//mandar los boleanos para (des)habilitar los botones
                //ac.BloquearText(this.panel1, false);//checar

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxTipoMesa_SelectedIndexChanged(object sender, EventArgs e)//LISTO
        {
            txtIdMesa.Text = Convert.ToInt32(negMesa.Instancia.ObtenerIdMesa() + 1).ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                entMesa m = new entMesa();
                entTipo t = new entTipo();
                entDisponibilidad d = new entDisponibilidad();
                m.Id_Mesa= Convert.ToInt32(txtIdMesaACT.Text);
                t.Id_Tipo= Convert.ToInt32(cbxTipoMesaACT.SelectedIndex + 1);
                m.id_tipo = t;
                if (cbxDispoACT.SelectedItem.Equals("Ocupada") )
                    d.Id_Disponibilidad = "No";
                if (cbxDispoACT.SelectedItem.Equals("Desocupada"))
                    d.Id_Disponibilidad = "Si";
                m.Id_disponibilidad = d;
                
                int us = negMesa.Instancia.actualizarMesa(m);
                MessageBox.Show("¡Actualización de mesa Correcto!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ControlBotones(true, false, false, false, false, true);
                //ac.BloquearText(this.panel1, false);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMesasCONS.DataSource = negMesa.Instancia.BuscarMesa(txtBuscarMesa.Text);
                //ControlBotones(true, true, false, true, false, true);
                //ac.BloquearText(this.panel1, false);
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
