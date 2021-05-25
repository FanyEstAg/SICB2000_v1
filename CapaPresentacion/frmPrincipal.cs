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
            //MessageBox.Show(u.Id_Usuario.ToString());
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
                    tsmReportes.Enabled = true;

                    //-------------------Acceso a todo
                }
                if (u.Id_empleado.Id_Rol.Nom_Puesto == "Cajero")
                {
                    tsmSeguridad.Enabled = false;
                    tsmInventario.Enabled = false;
                    tsmMesas.Enabled = true;
                    tsmVentas.Enabled = true; 
                    tsmCobrarMesa.Enabled = true;
                    tsmReportes.Enabled = true;
                    btnConfig.Enabled = false;
                    btnInventario.Enabled = false;
                }
                if (u.Id_empleado.Id_Rol.Nom_Puesto == "Jefe Inventario")
                {
                    tsmSeguridad.Enabled = false;
                    tsmInventario.Enabled = true;
                    tsmMesas.Enabled = false;
                    tsmVentas.Enabled = false;
                    tsmCobrarMesa.Enabled = true;
                    tsmReportes.Enabled = true;
                    btnConfig.Enabled = false;
                    btnMesas.Enabled = false;
                    btnVentaProd.Enabled = false;
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
                frmProducto.Parent = this.MdiParent;
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
            catch (Exception)
            {

                throw;
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
                frmVenta frmventa = new frmVenta(u);
                frmventa.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmVenta)
                    {
                        frm.Show();
                        return;
                    }
                }
                frmventa.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        private void tsmMesas_Click(object sender, EventArgs e)//Formulario de mesas
        {
            btnVolver.Visible = false;
            try
            {
                btnVolver.Visible = false;
                frmMesas frmMesa = new frmMesas(u);
                frmMesa.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmMesas)
                    {
                        frm.Show();
                        return;
                    }
                }
                frmMesa.Show();
            }
            catch (Exception)
            {

                throw;
            }
            
        }


        private void tsmSeguridad_Click(object sender, EventArgs e)
        {
            try
            {
                btnVolver.Visible = false;
                frmUsuario frmusuario = new frmUsuario(u);
                frmusuario.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmUsuario)
                    {
                        frm.Show();
                        return;
                    }
                }
                frmusuario.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }



        //BOTONES DEL MENÚ
        private void btnMesas_Click(object sender, EventArgs e)
        {
            //this.Hide();
            try
            {
                btnVolver.Visible = false;
                frmMesas frmMesa = new frmMesas(u);
                frmMesa.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmMesas)
                    {
                        frm.Show();
                        return;
                    }
                }
                frmMesa.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCobroMesa_Click(object sender, EventArgs e)
        {
            //this.Hide();
            try
            {
                btnVolver.Visible = false;
                frmCobroMesa frmcobro = new frmCobroMesa(u);
                frmcobro.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmInfoApp)
                    {
                        frm.Show();
                        return;
                    }
                }
                frmcobro.Show();
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        private void btnVentaProd_Click(object sender, EventArgs e)
        {
            //this.Hide();
            try
            {
                btnVolver.Visible = false;
                frmVenta frmventa = new frmVenta(u);
                frmventa.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmVenta)
                    {
                        frm.Show();
                        return;
                    }
                }
                frmventa.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            //this.Hide();
            try
            {
                btnVolver.Visible = false;
                frmInventario frmProducto = new frmInventario(u);//
                frmProducto.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmInventario)
                    {
                        frm.Show();
                        return;
                    }
                }
                frmProducto.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //this.Hide();
            try
            {
                btnVolver.Visible = false;
                frmReportes frmreporte = new frmReportes(u);
                frmreporte.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmReportes)
                    {
                        frm.Show();
                        return;
                    }
                }
                frmreporte.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            //this.Hide();
            try
            {
                btnVolver.Visible = false;
                frmUsuario frmusuario = new frmUsuario(u);
                frmusuario.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmUsuario)
                    {
                        frm.Show();
                        return;
                    }
                }
                frmusuario.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            //Minimizar ventana
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            //mandar el usuario al logearse
            frmInicioSesion frmInicioSesion = new frmInicioSesion();
            frmInicioSesion.Show();
        }

        private void tsmCobrarMesa_Click(object sender, EventArgs e)
        {
            try
            {
                btnVolver.Visible = false;
                frmCobroMesa frmcobro = new frmCobroMesa(u);
                frmcobro.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmInfoApp)
                    {
                        frm.Show();
                        return;
                    }
                }
                frmcobro.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsmReportes_Click(object sender, EventArgs e)
        {
            try
            {
                btnVolver.Visible = false;
                frmReportes frmreporte = new frmReportes(u);
                frmreporte.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmReportes)
                    {
                        frm.Show();
                        return;
                    }
                }
                frmreporte.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                btnVolver.Visible = false;
                frmInfoApp frminfo = new frmInfoApp();
                frminfo.Parent = this.MdiParent;
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm is frmInfoApp)
                    {
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
    }
}

