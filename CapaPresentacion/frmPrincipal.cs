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
        // Declaracion variables globales------------------
        entUsuario u = new entUsuario();
        public frmPrincipal(entUsuario usuario)
        {
            InitializeComponent();
            u = usuario;//recibimoas al usuario de la ventana anterior
        }
        private void RestriccionesUsuario() {//Acessos--modificar
            try
            {
                if (u.Id_empleado.Id_rol.Nom_Puesto == "Admin")
                {
                    tsmRegmovimientos.Enabled = true;
                    tsmInventario.Enabled = true;
                    tsmMesas.Enabled = true;
                    tsmVentas.Enabled = true;
                    tsmreporteproductos.Enabled = true;
                    tsmreporteventas.Enabled = true;
                    tsmReporteMesas.Enabled = true;
                    //-------------------
                    tsmfactura.Enabled = true;
                    tsmnotacargo.Enabled = false;
                    tsmreporteproductos.Enabled = false;
                    tsmreporteventas.Enabled = false;
                }
                if (u.Id_empleado.Id_rol.Nom_Puesto == "Cajero")
                {
                    tsmSeguridad.Enabled = false;
                    tsmInventario.Enabled = false;
                    tsmMesas.Enabled = true;
                    tsmVentas.Enabled = true;
                    tsmreporteproductos.Enabled = false;
                    tsmreporteventas.Enabled = false;
                    tsmReporteMesas.Enabled = false;
                    //----------------------
                    tsmConsultaProd.Enabled = true;
                    tsmConsultaVenta.Enabled = false;

                    tsmRegmovimientos.Enabled = false;
                    tsmordencompra.Enabled = false;
                    tsmfactura.Enabled = false;
                    tsmnotacargo.Enabled = false;
                    tsmnotacredito.Enabled = false;
                    tsmreporteproductos.Enabled = false;
                    tsmreporteventas.Enabled = false;

                }
                if (u.Id_empleado.Id_rol.Nom_Puesto == "Jefe Inventario")
                {
                    tsmSeguridad.Enabled = false;
                    tsmInventario.Enabled = true;
                    tsmMesas.Enabled = false;
                    tsmVentas.Enabled = false;
                    tsmreporteproductos.Enabled = true;
                    tsmreporteventas.Enabled = false;
                    tsmReporteMesas.Enabled = false;
                    //------------
                    tsmConsultaProd.Enabled = true;
                    tsmConsultaVenta.Enabled = false;
                    tsmRegmovimientos.Enabled = false;
                    tsmordencompra.Enabled = false;
                    tsmfactura.Enabled = false;
                    tsmnotacargo.Enabled = false;
                    tsmnotacredito.Enabled = false;
                    tsmreporteproductos.Enabled = false;
                    tsmreporteventas.Enabled = false;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

      

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // recorre todos los formularios abiertos en busca de frmLogeo
                Form frmlogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmLogeo);
                // si existe una instancia de frmlogeo:  visible = false (oculta)
                if (frmlogin != null)
                {
                    frmlogin.Visible = false;
                }

                lblUsuario.Text = "Bienvenido: " + u.Nombre_Usuario + " -  " + u.Id_empleado.Id_rol.Nom_Puesto;

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

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)//Ir a  usuarios
        {
            try
            {
                frmUsuario frmusuario = new frmUsuario(u.Id_Usuario);
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

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)//Abrir inventario
        {
            try
            {
                frmInventario frmProducto = new frmInventario(u.Id_Usuario);//
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

        

      

        
        private void ventasToolStripMenuItem2_Click(object sender, EventArgs e)//--MODIFICAR
        {
            try
            {
                frmConsultaVenta frmcventa = new frmConsultaVenta();
                frmcventa.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmConsultaVenta)
                    {
                        frm.Show();
                        frm.Size = MinimumSize;
                        frm.WindowState = FormWindowState.Normal;
                        return;
                    }
                }
                frmcventa.Show();
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

        private void tsmVentas_Click(object sender, EventArgs e)//Formulario de ventas
        {
            try
            {
                frmNotaVenta frmNotaventa = new frmNotaVenta(u.Id_Usuario);
                frmNotaventa.MdiParent = this;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmNotaVenta)
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

        }
    }
}
