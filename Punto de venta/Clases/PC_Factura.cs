using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_de_venta.Clases
{
    class PC_Factura
    {

        private static int _PCactual;

        public static int PCactual
        {
            get { return _PCactual; }
            set { _PCactual = value; }
        }

        private static DateTime _HoraInicio;

        public static DateTime HoraInicio
        {
            get { return _HoraInicio; }
            set { _HoraInicio = value; }
        }

        private static DateTime _HoraFin;

        public static DateTime HoraFin
        {
            get { return _HoraFin; }
            set { _HoraFin = value; }
        }

        private static string _HorasAcumuladas;

        public static string HorasAcumuladas
        {
            get { return _HorasAcumuladas; }
            set { _HorasAcumuladas = value; }
        }


    }
}
