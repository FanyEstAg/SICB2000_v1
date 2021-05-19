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
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        //Mover ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);


        private void frmLogeo_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void chkmostrarPass_CheckedChanged(object sender, EventArgs e)
        {   //Cambiar letra por punto
            if (chkmostrarPass.CheckState == CheckState.Checked){
                txtPassword.UseSystemPasswordChar = false;   
            }else {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                String usuario = txtUsuario.Text;
                String password = txtPassword.Text;
                entUsuario u = null;//crear un objeto tipo usuario(entidad)
                u = negSeguridad.Instancia.IngresoSisema(usuario, password); //Ir  a la capa del negocio
                u.Id_Usuario = negSeguridad.Instancia.ObtenerIdUsuario(usuario, password);
                frmPrincipal frmprincipal = new frmPrincipal(u);//mandar el usuario a la venta principal
                frmprincipal.Show();
            }
            catch (ApplicationException ae)
            {//en caso de errores

                MessageBox.Show(ae.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Cierra formulario libera recursos                           
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {   //Color en letras
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {   // Application.Exit(); - Cierra todo la aplicacion liberando recursos
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {   //Minimizar ventana
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmInicioSesion_MouseDown(object sender, MouseEventArgs e)
        {   //Mover ventana
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
