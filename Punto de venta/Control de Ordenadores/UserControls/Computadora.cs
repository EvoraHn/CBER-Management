using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class Computadora : UserControl
    {
        public Computadora()
        {
            InitializeComponent();
            lblID.Parent = pictureBox1;
            lblID.BackColor = Color.Transparent;
        }

        #region Properties

        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; lblID.Text = value; }
        }

        private string ip;

        public string IP
        {
            get { return ip; }
            set { ip = value; lblIP.Text = value; }
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


        #endregion

        private void Computadora_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void Computadora_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        //public new event EventHandler Click
        //{
        //    add
        //    {
        //        base.Click += value;
        //        foreach (Control control in Controls)
        //        {
        //            control.Click += value;
        //        }
        //    }
        //    remove
        //    {
        //        base.Click -= value;
        //        foreach (Control control in Controls)
        //        {
        //            control.Click -= value;
        //        }
        //    }

        //}
    }
}
