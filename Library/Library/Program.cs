using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// 
        /// Diego A. Jaramillo Jaramillo
        /// Herramientas de programacion 2 2018 *
        /// Aplicacion para llevar inventario en una libreria
        /// MODELO MVC 
        /// LIBRERIA MATERIAL DESING ***** BUNIFU IU 
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
