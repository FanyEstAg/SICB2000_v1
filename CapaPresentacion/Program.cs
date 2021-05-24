using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //<<<<<<< HEAD
            //Application.Run(new frmInicioSesion());
            //=======
           // entUsuario u = new entUsuario();//En calidad de mientras
            //u.Id_Usuario = 1;
            //u.Nombre_Usuario = "Admin";
            Application.Run(new frmInicioSesion());
            //>>>>>>> 3e2d525048b27929986ef45d854eb46ebdbd18ed
        }
    }
}
