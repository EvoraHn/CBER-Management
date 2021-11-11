using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
       
        [STAThread]
        static void Main()
        {
            long userid = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Punto_de_venta.Menú.Menu_estilo_1());
            Application.Run(new Punto_de_venta.Inicio.Login());
            //Application.Run(new Punto_de_venta.Inicio.Inicio(userid));
            //Application.Run(new Punto_de_venta.Informes.Form1());
            //Application.Run(new Punto_de_venta.Mantenimientos.Mantenimiento_Usuarios_2_0());

            //Application.Run(new Punto_de_venta.Ventas.Formulario_Ventas(userid));
            //Application.Run(new Punto_de_venta.Compras.Formulario_Compras(userid));
            //Application.Run(new Punto_de_venta.Bitacora.Formulario_Bitacora());
            //Application.Run(new Control_de_Ordenadores.Form1());

        }
    }
}
