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
        List<entCobroMesa> mesasAsignadas = new List<entCobroMesa>();
        List<string> mesasOcupadas = new List<string>();//para el cbx
        List<string> mesasDesocupadas = new List<string>();

        string user = "";
        int iduser = 0;

        public frmCobroMesa(string user, int iduser)
        {
            InitializeComponent();
            this.user = user;
            this.iduser = iduser;
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
                entUsuario u = new entUsuario();//Traer clase
                int tiempototal = 0;
                u.Id_Usuario = iduser;
                co.Id_Usuario = u;
                co.fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                foreach (entCobroMesa item in mesasAsignadas)
                {
                    if (item.Id_mesa.Id_Mesa == Convert.ToInt32(cbxIdMesaINS.SelectedItem))
                    {
                        m.Id_Mesa = item.Id_mesa.Id_Mesa;
                        co.Id_mesa = m;
                        co.Tiempo_inicio = item.Tiempo_inicio;
                        tiempototal = DateTime.Now.Minute - item.Tiempo_inicio.Minute;
                    }
                }
                co.Tiempo_fin = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                co.Tiempo_total = tiempototal;
                co.PagoTotal = tiempototal * 2;//$2 el minuto

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
            this.Hide();
        }

        private void frmCobroMesa_Load(object sender, EventArgs e)
        {
            crearGridRegistro(dgvMesaINS);
            //mesasOcupadas.Add("Seleccionar...");
            foreach (var dat in negMesa.Instancia.ListarMesas())
            {
                cbxMesasASIG.Items.Add(dat.Id_Mesa);
                mesasDesocupadas.Add(dat.Id_Mesa.ToString());
                //cbxTipoMesaACT.Items.Add(dat.Nom_Tipo);
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                entCobroMesa asignacion = new entCobroMesa();
                entMesa m = new entMesa();
                m.Id_Mesa = Convert.ToInt32(cbxMesasASIG.Text);
                asignacion.Id_mesa = m;
                asignacion.Tiempo_inicio = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
                //MessageBox.Show(DateTime.Now.ToShortTimeString());
               //se agrega a una lista
               mesasAsignadas.Add(asignacion);
                MessageBox.Show("¡Asignación de mesa Correcto!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Acciones despues de la asignacion
                //MessageBox.Show(cbxMesasASIG.SelectedIndex.); 
                
                //Actualizar el cbx
                for (int i = 0; i < cbxMesasASIG.Items.Count;i++)
                {
                    if (mesasDesocupadas[i] == cbxMesasASIG.SelectedItem.ToString())
                    {
                        mesasDesocupadas.Remove(cbxMesasASIG.SelectedItem.ToString());
                        mesasOcupadas.Add(cbxMesasASIG.SelectedItem.ToString());
                        cbxMesasASIG.Items.Clear();
                        cbxMesasASIG.Items.AddRange(mesasDesocupadas.ToArray());
                        break;
                    }
                }
                //Restaurar componentes
                cbxMesasASIG.Text = "Seleccionar...";
                lblHoraInicioASIG.Text = "00:00";
                lblTipoASIG.Text = "---";
                lblIdMesaASIG.Text = "---";
                //Actualizar combos dependientes
                //MessageBox.Show(mesasOcupadas.Count.ToString());
                cbxIdMesasOriginalCAMBIAR.Items.Clear();
                cbxIdMesasDestinoCAMBIAR.Items.Clear();
                
                foreach (var item in cbxMesasASIG.Items)
                {
                    cbxIdMesasDestinoCAMBIAR.Items.Add(item);
                }
                cbxIdMesasOriginalCAMBIAR.Items.AddRange(mesasOcupadas.ToArray());
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cbxMesasASIG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMesasASIG.Text != "Seleccionar...")
            {
                lblHoraInicioASIG.Text = DateTime.Now.ToShortTimeString();
                lblIdMesaASIG.Text = cbxMesasASIG.Text;

                lblTipoASIG.Text = negMesa.Instancia.ListarTipoMesa(Convert.ToInt32(cbxMesasASIG.Text));
            }
            else
                MessageBox.Show("Seleccione una mesa");//COnfigurar el tipo de mensaje
        }

        private void cbxIdMesasOriginalCAMBIAR_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            //Al seleccionar la mesa que se va a cambiar lanzar datos informativos
            int tiempototal = 0;
            for(int i=0; i < mesasAsignadas.Count; i++)
            {
                if (mesasAsignadas[i].Id_mesa.Id_Mesa == Convert.ToInt32(cbxIdMesasOriginalCAMBIAR.SelectedItem))
                {
                    lblIdMesaCAMBIAR.Text = mesasAsignadas[i].Id_mesa.Id_Mesa.ToString();
                    //MessageBox.Show(mesasAsignadas[i].Id_mesa.Id_Mesa.ToString());
                    lblHoraInicioCAMBIAR.Text = mesasAsignadas[i].Tiempo_inicio.ToShortTimeString();
                    tiempototal = DateTime.Now.Minute - mesasAsignadas[cbxIdMesasOriginalCAMBIAR.SelectedIndex].Tiempo_inicio.Minute;

                    break;
                }
            }
            lblTipoCAMBIAR.Text= negMesa.Instancia.ListarTipoMesa(Convert.ToInt32(cbxIdMesasOriginalCAMBIAR.SelectedItem));
            lblHoraInicioCAMBIAR.Text = mesasAsignadas[cbxIdMesasOriginalCAMBIAR.SelectedIndex].Tiempo_inicio.ToShortTimeString();
            //Calculo automatico
            txtTiempoTotalCAMBIAR.Text = tiempototal.ToString();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (cbxIdMesasOriginalCAMBIAR.SelectedIndex != -1 || cbxIdMesasDestinoCAMBIAR.SelectedIndex != -1)
            {
                //try
                //{
                entCobroMesa asignacion = new entCobroMesa();
                entMesa m = new entMesa();
                m.Id_Mesa = Convert.ToInt32(cbxIdMesasDestinoCAMBIAR.SelectedItem);
                asignacion.Id_mesa = m;

                // pasar datos de la mesas ocupada orginal a la de destino
                for (int i = 0; i < mesasAsignadas.Count; i++)
                {
                    if (mesasAsignadas[i].Id_mesa.Id_Mesa == Convert.ToInt32(cbxIdMesasOriginalCAMBIAR.SelectedItem))
                    {
                        //MessageBox.Show("Entra");
                        asignacion.Tiempo_inicio = mesasAsignadas[i].Tiempo_inicio;
                        break;
                    }
                }


                //Eliminar la mesa ocupada original de las mesas asignadas
                for (int i = 0; i < mesasAsignadas.Count; i++)
                {
                    if (mesasAsignadas[i].Id_mesa.Id_Mesa == Convert.ToInt32(cbxIdMesasOriginalCAMBIAR.SelectedItem))
                    {
                        mesasAsignadas.RemoveAt(i);
                        break;
                    }
                }
                //Actualizar el array de los combobox
                for (int i = 0; i < mesasOcupadas.Count; i++)//Eliminacion de estado ocupado de la mesa original
                {
                    //MessageBox.Show(cbxIdMesasOriginalCAMBIAR.SelectedItem.ToString());
                    if (mesasOcupadas[i] == cbxIdMesasOriginalCAMBIAR.SelectedItem.ToString())
                    {
                        //MessageBox.Show("Entra 2do if"+i);
                        mesasOcupadas.RemoveAt(i);
                        //MessageBox.Show("Eliminacion de mesa ocupada");
                        break;
                    }
                }
                //Añadir la mesa destino en ocupadas
                mesasOcupadas.Add(cbxIdMesasDestinoCAMBIAR.SelectedItem.ToString());//Añadir Mesa destino como ocupada
                //Añadir la mesa origen en desocupadas
                mesasDesocupadas.Add(cbxIdMesasOriginalCAMBIAR.SelectedItem.ToString());//Añadir mesa origen a desocupadas
                mesasDesocupadas.Remove(cbxIdMesasDestinoCAMBIAR.SelectedItem.ToString());//Añadir mesa origen a desocupadas

                //Añadir la asignación de mesa destino
                mesasAsignadas.Add(asignacion);


                //Lanzar los datos actuales
                int tiempototal = 0;
                for (int i = 0; i < mesasAsignadas.Count; i++)
                {
                    if (mesasAsignadas[i].Id_mesa.Id_Mesa == Convert.ToInt32(cbxIdMesasDestinoCAMBIAR.SelectedItem))
                    {
                        lblIdMesaCAMBIAR.Text = mesasAsignadas[i].Id_mesa.Id_Mesa.ToString();
                        lblHoraInicioCAMBIAR.Text = mesasAsignadas[i].Tiempo_inicio.ToShortTimeString();
                        //Calculo automatico

                        tiempototal = DateTime.Now.Minute - mesasAsignadas[i].Tiempo_inicio.Minute;
                        break;
                    }
                }
                lblTipoCAMBIAR.Text = negMesa.Instancia.ListarTipoMesa(Convert.ToInt32(cbxIdMesasDestinoCAMBIAR.SelectedItem));

                txtTiempoTotalCAMBIAR.Text = tiempototal.ToString();

                //Actualizar los combos de la ventana actual CAMBIAR MESA
                cbxIdMesasOriginalCAMBIAR.Items.Clear();
                cbxIdMesasDestinoCAMBIAR.Items.Clear();

                // Poner las mesas desocupadas en el cbx Destino
                cbxIdMesasDestinoCAMBIAR.Items.AddRange(mesasDesocupadas.ToArray());
                //MessageBox.Show("Count: "+mesasAsignadas.Count());
                //Actualizar el cbx de las mesas asignadas
                cbxIdMesasOriginalCAMBIAR.Items.AddRange(mesasOcupadas.ToArray());//Actualizar las mesas ocupadas en el cbx ORIGEN

                //Text
                cbxIdMesasOriginalCAMBIAR.Text = "Seleccionar...";
                cbxIdMesasDestinoCAMBIAR.Text = "Seleccionar...";

                //Actualizar el combo de la ventana ASIGNAR MESAR
                cbxMesasASIG.Items.Clear();//borrar los datos actuales
                cbxMesasASIG.Items.AddRange(mesasDesocupadas.ToArray());//añadir lista de mesas desocupadas
                cbxMesasASIG.Text = "Seleccionar...";
            }
            else
                MessageBox.Show("COmplete los campos solicitados", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error",
            //                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void cbxIdMesaINS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            int tiempototal = 0;
            dgvMesaINS.Rows.Clear();
            foreach (entCobroMesa item in mesasAsignadas)
            {
                if (item.Id_mesa.Id_Mesa == Convert.ToInt32(cbxIdMesaINS.SelectedItem))
                {
                    tiempototal = DateTime.Now.Minute - item.Tiempo_inicio.Minute;
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvMesaINS);
                    fila.Cells[0].Value = item.Id_mesa.Id_Mesa;
                    fila.Cells[1].Value = negMesa.Instancia.ListarTipoMesa(item.Id_mesa.Id_Mesa);
                    fila.Cells[2].Value = tiempototal;
                    fila.Cells[3].Value = tiempototal * 2;//$2 el minuto
                    tiempototal = 0;
                    dgvMesaINS.Rows.Add(fila);
                }
            }
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 2)
            {
                cbxIdMesaINS.Items.Clear();
                dgvMesaINS.Rows.Clear();
                cbxIdMesaINS.Items.AddRange(mesasOcupadas.ToArray());
                int tiempototal = 0;
                
                foreach (entCobroMesa item in mesasAsignadas)
                {
                    tiempototal = DateTime.Now.Minute - item.Tiempo_inicio.Minute;
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvMesaINS);
                    fila.Cells[0].Value = item.Id_mesa.Id_Mesa;
                    fila.Cells[1].Value = negMesa.Instancia.ListarTipoMesa(item.Id_mesa.Id_Mesa);
                    fila.Cells[2].Value = tiempototal;
                    fila.Cells[3].Value = tiempototal * 2;//$2 el minuto
                    tiempototal = 0;
                    dgvMesaINS.Rows.Add(fila);
                
                }
            }
        }

    public void crearGridRegistro(DataGridView dgv)
    {
        dgv.Columns.Add("ColumnId", "ID");
        dgv.Columns.Add("ColumnTipo", "Tipo");
        dgv.Columns.Add("ColumnTiempo", "Tiempo");
        dgv.Columns.Add("ColumnTotal", "Total");

        dgv.AllowUserToAddRows = false;//Añadir filas 
        dgv.MultiSelect = false;//multiselección falsa
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//seleccionar fila completa
    }
}
}
