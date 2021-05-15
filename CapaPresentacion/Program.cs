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
            Application.Run(new frmInventario(2));
//>>>>>>> 3e2d525048b27929986ef45d854eb46ebdbd18ed
        }
    }
}
