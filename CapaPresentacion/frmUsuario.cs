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
namespace CapaPresentacion
{
    public partial class frmUsuario : Form
    {
        // instancia global de la clase AccionesEnControles para control de etiquetas del formulario
        AccionesEnControles ac = new AccionesEnControles();
        //int id_Usuario;
        public frmUsuario(string usuario)
        {
            //id_Usuario=(int)idusuario;
            InitializeComponent();
            
            
        }

        // metodos globales para etiquetas del formulario 

        //public void ControlBotones(bool nuevo, bool editar, bool grabar, bool eliminar, bool cancelar, bool salir)
        //{
        //    try
        //    {
        //        btnNuevo.Enabled = nuevo;//controlar funciones de los botones
        //        btnEditar.Enabled = editar;
        //        btnGuardar.Enabled = grabar;
        //        btnEliminar.Enabled = eliminar;
        //        btnCancelar.Enabled = cancelar;
        //        btnSalir.Enabled = salir;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        
        
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                dgvUsuarios.DataSource = negSeguridad.Instancia.CargarUsuarios();
                //combobox con los roles
                cbxRolINS.Text = "Seleccionar...";

                foreach (var dat in negSeguridad.Instancia.ListarRol())
                {
                    cbxRolINS.Items.Add(dat.Nom_Puesto);
                    cbxRolACT.Items.Add(dat.Nom_Puesto);
                }
               
                
                //ControlBotones(true, false, false, false, false, true);//mandar los boleanos para (des)habilitar los botones
                ac.BloquearText(this.panel1, false);//checar

                // conf textbox para ser multilineas(textarea)
                txaDecrpINS.ScrollBars = ScrollBars.Vertical;
                txaDecrpINS.AcceptsReturn = true;
                txaDecrpINS.AcceptsTab = true;
                txaDecrpINS.WordWrap = true;

                txtDescrpACT.ScrollBars = ScrollBars.Vertical;
                txtDescrpACT.AcceptsReturn = true;
                txtDescrpACT.AcceptsTab = true;
                txtDescrpACT.WordWrap = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void btnSalir_Click(object sender, EventArgs e)//listo
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea cerrar esta ventana?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) {
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        
        private void button3_Click(object sender, EventArgs e)//Registrar//LISTO
        {
            try
            {
                entRol ro = new entRol();
                entUsuario u = new entUsuario();
                entEmpleado em = new entEmpleado();
                ro.Id_Rol = Convert.ToInt32(cbxRolINS.SelectedIndex + 1);
                em.Id_Rol = ro;
                em.Nombre_empleado = txtNombreINS.Text;
                em.apepat_empelado = txtApepatINS.Text;
                em.apemat_empleado = txtApematINS.Text;
                em.direccion_empleado = txtDireccionINS.Text;
                em.telefono_empleado = txtTelefonoINS.Text;
                int emp = negSeguridad.Instancia.insertarEmpleado(em);
                em.Id_empleado = negSeguridad.Instancia.ObtenerIdEmpleado();
                
                u.Id_empleado = em;
                u.Nombre_Usuario = txtUusuarioINS.Text;
                u.Password_Usuario = txtPasswordINS.Text;
                
                int us = negSeguridad.Instancia.insertarUsuario(u);
                MessageBox.Show("¡Registro Correcto!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ControlBotones(true, false, false, false, false, true);
            ac.BloquearText(this.panel1, false);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        private void button1_Click(object sender, EventArgs e)//Listo
            //Botón eliminar usuario
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea eliminar el usuario seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int result = negSeguridad.Instancia.EliminarUsuarioxId(Convert.ToInt32(txtIdEliminar.Text));//enviar id
                    MessageBox.Show("Usuario Eliminado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //ControlBotones(true, false, false, false, false, true);//pendiente
                //ac.BloquearText(this.panel1, false);//pendiente
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxRolINS_SelectedIndexChanged(object sender, EventArgs e)//Listo
            //Cuando se seleccione un item
        {
            try
            {
                Int32 i = Convert.ToInt32(cbxRolINS.SelectedIndex+1);//enviar el id del rol
                txaDecrpINS.Text = negSeguridad.Instancia.ListarRolDescrp(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)//LISTO
        {
            try
            {
                DialogResult res = MessageBox.Show("¿Desea cancelar la operaicón?","Cancelar operación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
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

        private void btnCambiarContra_Click(object sender, EventArgs e)//LISTO
        {
            try
            {
                entUsuario u = new entUsuario();

                u.Id_Usuario = Convert.ToInt32(txtIdCC.Text);
                u.Password_Usuario = txtContrasenaCC.Text;
                bool existencia = negSeguridad.Instancia.VerificarDatosCambioContrasena(txtIdCC.Text, txtContrasenaCC.Text);
                
                    if (txtContrasenaNuevaCC.Text != txtConfirmarCC.Text)
                    {
                        MessageBox.Show("Las contraseñas no coinciden, por favor verifique", "Avertencia",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }//meter verificaicón de minimo y maximo de caracteres
                    else
                    {
                        int us = negSeguridad.Instancia.cambiarContrasena(u, txtContrasenaNuevaCC.Text);
                        MessageBox.Show("¡Actualización de contraseña Correcto!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //ControlBotones(true, false, false, false, false, true);
                        ac.BloquearText(this.panel1, false);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvUsuarios.DataSource = negSeguridad.Instancia.BuscarUsuario(txtBuscarCONS.Text);
                //ControlBotones(true, true, false, true, false, true);
                ac.BloquearText(this.panel1, false);
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

        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizar ventana
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //El usuario regresa al menú
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entUsuario u = new entUsuario();
                entEmpleado em = new entEmpleado();
                entRol ro = new entRol();
                u.Id_Usuario = Convert.ToInt32(txtIdUsuarioACT.Text);
                MessageBox.Show(u.Id_Usuario.ToString());
                ro.Id_Rol = Convert.ToInt32(cbxRolACT.SelectedIndex + 1);
                em.Id_Rol = ro;
                em.Nombre_empleado = txtNombreACT.Text;
                em.apepat_empelado = txtApepatACT.Text;
                em.apemat_empleado = txtApematACT.Text;
                em.direccion_empleado = txtDireccionACT.Text;
                em.telefono_empleado = txtTelefonoACT.Text;
                em.Id_empleado = negSeguridad.Instancia.ObtenerIdEmpleado(Convert.ToInt32(txtIdUsuarioACT.Text));
                int emp = negSeguridad.Instancia.actualizarEmpleado(em);
                
                u.Id_empleado = em;
                u.Nombre_Usuario = txtUsuarioACT.Text;
                u.Password_Usuario = txtPasswordACT.Text;
                int us = negSeguridad.Instancia.actualizarUsuario(u);
                MessageBox.Show("¡Actualización de usuario Correcto!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ControlBotones(true, false, false, false, false, true);
                //ac.BloquearText(this.panel1, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxRolACT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 i = Convert.ToInt32(cbxRolACT.SelectedIndex + 1);//enviar el id del rol
                txtDescrpACT.Text = negSeguridad.Instancia.ListarRolDescrp(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

