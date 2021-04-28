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
        int id_Usuario;
        public frmUsuario(int? idusuario)
        {
            id_Usuario=(int)idusuario;
            InitializeComponent();
            
        }

        // metodos globales para etiquetas del formulario 

        public void ControlBotones(bool nuevo, bool editar, bool grabar, bool eliminar, bool cancelar, bool salir)
        {
            try
            {
                btnNuevo.Enabled = nuevo;//controlar funciones de los botones
                btnEditar.Enabled = editar;
                btnGuardar.Enabled = grabar;
                btnEliminar.Enabled = eliminar;
                btnCancelar.Enabled = cancelar;
                btnSalir.Enabled = salir;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                //combobox con los roles
                cboRol.ValueMember = "Id_NivelAcc";
                cboRol.DisplayMember = "Numero_NivelAcc";
                cboRol.DataSource = negSeguridad.Instancia.ListarRol();
               
                ControlBotones(true, false, false, false, false, true);//mandar los boleanos para (des)habilitar los botones
                ac.BloquearText(this.panel1, false);

                // conf textbox para ser multilineas(textarea)
                txtDescNivelAcceso.ScrollBars = ScrollBars.Vertical;
                txtDescNivelAcceso.AcceptsReturn = true;
                txtDescNivelAcceso.AcceptsTab = true;
                txtDescNivelAcceso.WordWrap = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNivelAcceso_SelectedIndexChanged(object sender, EventArgs e)//Elegir tal rol--listo
        {
            try
            {
                Int32 i = Convert.ToInt32(cboRol.SelectedValue.ToString());
                entRol r = null;
                r = negSeguridad.Instancia.ListarRolDescrp(i);
                txtDescNivelAcceso.Text = r.Descripcion_Rol;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                ac.LimpiarText(this.panel1);
                ac.BloquearText(this.panel1, true);
                ControlBotones(false, false, true, false, true, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)//FALTA
        {
            try
            {
                ControlBotones(false, false, true, false, true, false);
                ac.BloquearText(this.panel1, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)//registrar usuario---cmabiar UPS
        {
            try
            {
                int tipoedicion = 1;
                entUsuario u = new entUsuario();
                entEmpleado em = new entEmpleado();
                entRol r = new entRol();
                r.Id_Rol= Convert.ToInt32(cboRol.SelectedValue);
                em.Id_rol = r;
                em.Nombre_empleado = txtnombre.Text;
                em.apepat_empelado = txtApepat.Text;
                em.apemat_empleado = txtApemat.Text;
                em.direccion_empleado = txtDireccion.Text;
                em.telefono_empleado = txtTelefono.Text;
                u.Id_empleado = em;
                
                u.Nombre_Usuario = txtUusuario.Text;
                u.Password_Usuario = txtPassword.Text;

                if (txtUusuario.Text != "") { tipoedicion = 2; u.Id_Usuario = 0; } //modificar: tipo de operacion
                int i = negSeguridad.Instancia.MantenimientoUsuario(u, tipoedicion);
                MessageBox.Show("¡Registro Correcto!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ControlBotones(true, false, false, false, false, true);
                ac.BloquearText(this.panel1, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)//eliminar usuario-modificar ups
        {
            try
            {
                entUsuario u = new entUsuario();
                entEmpleado em = new entEmpleado();
                if (!txtUusuario.Equals(""))  
                    u.Nombre_Usuario = txtUusuario.Text;
                entRol r = new entRol();
                em.Id_rol = r;
                u.Id_empleado = em;
                DialogResult res = MessageBox.Show("¿Desea eliminar el usuario seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    int result = negSeguridad.Instancia.MantenimientoUsuario(u, 3);//---
                    MessageBox.Show("Usuario Eliminado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ControlBotones(true, false, false, false, false, true);
                ac.BloquearText(this.panel1, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        private void btnCancelar_Click(object sender, EventArgs e)//listo
        {
            try
            {
                ControlBotones(true, true, false, true, false, true);
                ac.BloquearText(this.panel1, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        
        private void btnBuscar_Click(object sender, EventArgs e)//listo creo
        {
            try
            {
                String valor = txtBuscar.Text;
                entUsuario u = null;
                u = negSeguridad.Instancia.BuscarUsuario(valor);
               
                txtnombre.Text = u.Nombre_Usuario;
                txtUusuario.Text = u.Nombre_Usuario;
                txtPassword.Text = u.Password_Usuario;
                txtTelefono.Text = u.Id_empleado.telefono_empleado;
                txtApepat.Text = u.Id_empleado.apepat_empelado;
                txtApemat.Text = u.Id_empleado.apemat_empleado;
                txtDireccion.Text = u.Id_empleado.direccion_empleado;
                cboRol.SelectedIndex = u.Id_empleado.Id_rol.Id_Rol;
                                       
                ControlBotones(true, true, false, true, false, true);
                ac.BloquearText(this.panel1, false);
            }
            catch (ApplicationException ae) {
                MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
