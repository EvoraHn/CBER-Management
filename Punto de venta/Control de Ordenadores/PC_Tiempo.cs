using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto_de_venta
{
    class PC_Tiempo
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string ip;

        public string IP
        {
            get { return ip; }
            set { ip = value; }
        }

        private DateTime horaInicio;

        public DateTime HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        private DateTime horaLimite;

        public DateTime HoraLimite
        {
            get { return horaLimite; }
            set { horaLimite = value; }
        }


    }
}
