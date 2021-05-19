using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        //Campos - Declaracion variables globales
        
        entUsuario u = new entUsuario();

        //Constructor
        public frmPrincipal(entUsuario usuario)
        {
            InitializeComponent();
            u = usuario;//recibimoas al usuario de la ventana anterior
        }
        private void RestriccionesUsuario()
        {//Acessos--modificar
            try
            {
                if (u.Id_empleado.Id_Rol.Nom_Puesto == "Admin")
                {
                    tsmSeguridad.Enabled = true;
                    tsmInventario.Enabled = true;
                    tsmMesas.Enabled = true;
                    tsmVentas.Enabled = true;
                    tsmCobrarMesa.Enabled = true;
                    tsmreporteproductos.Enabled = true;
                    tsmreporteventas.Enabled = true;
                    tsmReporteMesas.Enabled = true;
                    //-------------------Acceso a todo
                }
                if (u.Id_empleado.Id_Rol.Nom_Puesto == "Cajero")
                {
                    tsmSeguridad.Enabled = false;
                    tsmInventario.Enabled = false;
                    tsmMesas.Enabled = true;
                    tsmVentas.Enabled = true;
                    tsmCobrarMesa.Enabled = true;
                    tsmreporteproductos.Enabled = false;
                    tsmreporteventas.Enabled = false;
                    tsmReporteMesas.Enabled = false;

                }
                if (u.Id_empleado.Id_Rol.Nom_Puesto == "Jefe Inventario")
                {
                    tsmSeguridad.Enabled = false;
                    tsmInventario.Enabled = true;
                    tsmMesas.Enabled = false;
                    tsmVentas.Enabled = false;
                    tsmreporteproductos.Enabled = true;
                    tsmreporteventas.Enabled = false;
                    tsmReporteMesas.Enabled = false;
                    tsmCobrarMesa.Enabled = false;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)//-LISTO
        {
            try
            {
                // recorre todos los formularios abiertos en busca de frmLogeo
                Form frmlogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmInicioSesion);
                // si existe una instancia de frmlogeo:  visible = false (oculta)
                if (frmlogin != null)
                {
                    frmlogin.Visible = false;
                }

                lblUsuario.Text = "Bienvenido: \n" + u.Nombre_Usuario + " - "+ u.Id_empleado.Id_Rol.Nom_Puesto;

                RestriccionesUsuario();//Restringir las ventanas por rol
            }
            catch (ArgumentNullException ne) {
                MessageBox.Show(ne.Message, "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void tsmSalir_Click(object sender, EventArgs e)//Cierre de la app
        {
            DialogResult result = MessageBox.Show("Desea cerrar la aplicación", "Mensaje", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
            if (result==DialogResult.Yes) {
                Application.Exit(); 
            }
       

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)//Abrir inventario
        {
            try
            {
                btnVolver.Visible = false;
                frmInventario frmProducto = new frmInventario(u);//
                frmProducto.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmInventario)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmProducto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)//Acerca de
        {
            try
            {
                btnVolver.Visible = false;
                frmInfoApp frminfo = new frmInfoApp();
                frminfo.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms) {
                    if (frm is frmInfoApp) {
                        frm.Show();
                        return;
                    }
                }
                frminfo.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsmVentas_Click(object sender, EventArgs e)
        {
            try
            {
                btnVolver.Visible = false;
                frmVenta frmNotaventa = new frmVenta(u);
                frmNotaventa.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmVenta)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmNotaventa.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void tsmMesas_Click(object sender, EventArgs e)//Formulario de mesas
        {
            btnVolver.Visible = false;
            try
            {
                frmMesas frmMesa= new frmMesas(u);
                frmMesa.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmMesas)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmMesa.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)//Cerrar
        {
            this.Close();
            Application.Exit();

        }

        private void tsmSeguridad_Click(object sender, EventArgs e)
        {
            try
            {
                btnVolver.Visible = false;
                frmUsuario frmusuario = new frmUsuario(u);//Mnadamos el usuario
                frmusuario.MdiParent = this;//Adquiere el tamaño de la actual
                foreach (Form frm in Application.OpenForms)//se ven las ventanas que hay y se acomodan
                {
                    if (frm is frmUsuario)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmusuario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {   //Minimizar ventana
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {   //mandar el usuario al logearse
            frmInicioSesion frmInicioSesion = new frmInicioSesion();
            frmInicioSesion.Show();
        }

        //BOTONES DEL MENÚ
        private void btnMesas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMesas fm = new frmMesas(u);
            fm.Show();
        }

        private void btnCobroMesa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCobroMesa fcm = new frmCobroMesa(u);
            fcm.Show();
        }

        private void btnVentaProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVenta fv = new frmVenta(u);
            fv.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventario fi = new frmInventario(u);
            fi.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            this.Hide();
            ///??
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario fu = new frmUsuario(u);
            fu.Show();
        }

        private void cobrarMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                btnVolver.Visible = false;
                frmCobroMesa frmCobro = new frmCobroMesa(u);
                frmCobro.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmCobroMesa)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmCobro.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

