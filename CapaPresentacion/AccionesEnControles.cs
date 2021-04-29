using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Entidades;
namespace CapaPresentacion
{
    public class AccionesEnControles
    {

        #region convertirenletras

        //public string enletras(string num)
        //{
        //    string res, dec = "";
        //    Int64 entero;
        //    int decimales;
        //    double nro;

        //    try
        //    {
        //        nro = Convert.ToDouble(num);
        //    }
        //    catch
        //    {
        //        return "";
        //    }

        //    entero = Convert.ToInt64(Math.Truncate(nro));
        //    decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
        //    if (decimales > 0)
        //    {
        //        dec = " CON " + decimales.ToString() + "/100";
        //    }
        //    if (dec == "") dec = " CON 00/100 ";
        //    res = toText(Convert.ToDouble(entero)) + dec;
        //    return res;
        //}

        //private string toText(double value)
        //{
        //    string Num2Text = "";
        //    value = Math.Truncate(value);
        //    if (value == 0) Num2Text = "CERO";
        //    else if (value == 1) Num2Text = "UNO";
        //    else if (value == 2) Num2Text = "DOS";
        //    else if (value == 3) Num2Text = "TRES";
        //    else if (value == 4) Num2Text = "CUATRO";
        //    else if (value == 5) Num2Text = "CINCO";
        //    else if (value == 6) Num2Text = "SEIS";
        //    else if (value == 7) Num2Text = "SIETE";
        //    else if (value == 8) Num2Text = "OCHO";
        //    else if (value == 9) Num2Text = "NUEVE";
        //    else if (value == 10) Num2Text = "DIEZ";
        //    else if (value == 11) Num2Text = "ONCE";
        //    else if (value == 12) Num2Text = "DOCE";
        //    else if (value == 13) Num2Text = "TRECE";
        //    else if (value == 14) Num2Text = "CATORCE";
        //    else if (value == 15) Num2Text = "QUINCE";
        //    else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
        //    else if (value == 20) Num2Text = "VEINTE";
        //    else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
        //    else if (value == 30) Num2Text = "TREINTA";
        //    else if (value == 40) Num2Text = "CUARENTA";
        //    else if (value == 50) Num2Text = "CINCUENTA";
        //    else if (value == 60) Num2Text = "SESENTA";
        //    else if (value == 70) Num2Text = "SETENTA";
        //    else if (value == 80) Num2Text = "OCHENTA";
        //    else if (value == 90) Num2Text = "NOVENTA";
        //    else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
        //    else if (value == 100) Num2Text = "CIEN";
        //    else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
        //    else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
        //    else if (value == 500) Num2Text = "QUINIENTOS";
        //    else if (value == 700) Num2Text = "SETECIENTOS";
        //    else if (value == 900) Num2Text = "NOVECIENTOS";
        //    else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
        //    else if (value == 1000) Num2Text = "MIL";
        //    else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
        //    else if (value < 1000000)
        //    {
        //        Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
        //        if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
        //    }

        //    else if (value == 1000000) Num2Text = "UN MILLON";
        //    else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
        //    else if (value < 1000000000000)
        //    {
        //        Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
        //        if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
        //    }

        //    else if (value == 1000000000000) Num2Text = "UN BILLON";
        //    else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

        //    else
        //    {
        //        Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
        //        if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
        //    }
        //    return Num2Text;

        //}

        #endregion comvertirenletras

      
        public void LlenarCboMarca(Control control)//por terminar
        {
            try
            {
                foreach (Control CboMoneda in control.Controls)
                {
                    if (CboMoneda is ComboBox)
                    {
                        if (CboMoneda.Name == "CboMoneda")
                        {
                            //List<entMarca> Lista = negVenta.Intancia.ListarMarca();
                            ((ComboBox)CboMoneda).ValueMember = "Id_Marca";
                            ((ComboBox)CboMoneda).DisplayMember = "Descripcion_Moneda";
                            ((ComboBox)CboMoneda).DataSource = Lista;
                        }
                    }
                }
            }
            catch (ApplicationException) { throw; }
            catch (Exception)
            {

                throw;
            }
        }

        
        //public Boolean EntradaSoloNumerosDgv(KeyEventArgs e)
        //{
        //    try
        //    {
        //        Boolean result;
        //        String cadena = "1234567890" + (char)15;
        //        if (cadena.Contains(e.KeyData.ToString()) || e.KeyValue == 8)
        //        {
        //            result = false;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Esta intentando ingresar un caracter no válido", "Aviso",
        //         MessageBoxButtons.OK, MessageBoxIcon.Warning); result = true;
        //        }
        //        return result;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public Boolean EntradaSoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                Boolean result;
                String cadena = "1234567890" + (char)5;
                if (cadena.Contains(e.KeyChar) || e.KeyChar == 8)
                {
                    result = false;
                }
                else
                {
                    MessageBox.Show("Esta intentando ingresar un caracter no válido", "Aviso",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning); result = true;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Boolean EntradaDecimales(KeyPressEventArgs e)
        {
            try
            {
                Boolean result;
                String cadena = "1234567890," + (char)5;
                if (cadena.Contains(e.KeyChar) || e.KeyChar==8)
                {
                    result = false;
                }
                else
                {
                    MessageBox.Show("Esta intentando ingresar un caracter no válido", "Aviso",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning); result = true;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LimpiarText(Control control)
        {
            try
            {
                foreach (Control txt in control.Controls)
                {
                    if (txt is TextBox)
                    {
                        if (txt.Name != "txtCodUsuario")//Cuidar no borrar al usuario
                        {
                            ((TextBox)txt).Clear();
                        }
                    }
                    else if (txt is GroupBox)
                    {
                        foreach (Control txtgb in txt.Controls)//para la barra de busqueda
                        {
                            if (txtgb is TextBox)
                            {
                                ((TextBox)txtgb).Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        public void BloquearText(Control control, Boolean estado)//(des)bloquear cajas de texto
        {
            try
            {
                foreach (Control txt in control.Controls)
                {
                    if (txt is TextBox)
                    {
                        ((TextBox)txt).Enabled = estado;
                        if (txt.Name == "txtCodigoC" || txt.Name == "txtCodigoP" || txt.Name == "txtCodigoUM" || txt.Name == "txtCodigoPR") 
                               {
                                   ((TextBox)txt).Enabled = false;
                               }
                    }
                    else if (txt is GroupBox)
                    {
                        foreach (Control txtgb in txt.Controls)
                        {

                            if (txtgb is TextBox && txtgb.Name != "txtBuscar")
                            {
                                ((TextBox)txtgb).Enabled = estado;
                                if (txtgb.Name == "txtCodUsuario" || txtgb.Name == "txtCodSucursal" || txtgb.Name == "txtDescNivelAcceso")
                                {
                                    ((TextBox)txtgb).Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}
