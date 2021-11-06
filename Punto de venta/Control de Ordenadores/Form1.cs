using System;
using System.Net;
using System.Net.Sockets;
using static System.Text.Encoding;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace Punto_de_venta.Control_de_Ordenadores
{
    public partial class Form1
    {
        
        Punto_de_venta.Bases_de_datos.CyberElIngeEntities entity = new Punto_de_venta.Bases_de_datos.CyberElIngeEntities();
        private DateTime HORAINICIO;
        private DateTime HORALIMITE;
        private UdpClient ADMINISTRADOR = new UdpClient();
        private IPAddress ORDENADOR;
        private bool refill = false;
        List<PC_Tiempo> arreglopcs = new List<PC_Tiempo>();

        public Form1()
        {
            InitializeComponent();
            _ButtonBLOQUEO.Name = "ButtonBLOQUEO";
            _ButtonAPAGAR.Name = "ButtonAPAGAR";
            _ButtonINICIAR.Name = "ButtonINICIAR";
            _TextBoxMENSAJES1.Name = "TextBoxMENSAJES1";
            _ButtonAÑADIR.Name = "ButtonAÑADIR";
            _ButtonCERRAR.Name = "ButtonCERRAR";
            _ButtonREINICIAR.Name = "ButtonREINICIAR";
            _ComboBox1.Name = "ComboBox1";
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            ComboBox1.Focus();
            populate();
        }

        public void populate()
        {
            var computadoras = from c in entity.PC
                               select new
                               {
                                   c.IdPC,
                                   c.IP
                               };
            DataTable newcomputers = computadoras.CopyAnonymusToDataTable();
            if (newcomputers.Rows.Count > 0)
            {
                Computadora[] pc = new Computadora[newcomputers.Rows.Count];
                PC_Tiempo[] tiempo_pcs = new PC_Tiempo[newcomputers.Rows.Count];
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                for (int i = 0; i < newcomputers.Rows.Count; i++)
                {
                    pc[i] = new Computadora();
                    pc[i].ID = newcomputers.Rows[i].ItemArray[0].ToString();
                    pc[i].IP = newcomputers.Rows[i].ItemArray[1].ToString();
                    pc[i].Click += new EventHandler(pc_click);
                    pc[i].HoraInicio = HORAINICIO;
                    pc[i].HoraLimite = HORALIMITE;

                    //Agregar los controles al panel
                    flowLayoutPanel1.Controls.Add(pc[i]);

                    tiempo_pcs[i] = new PC_Tiempo();
                    tiempo_pcs[i].ID = newcomputers.Rows[i].ItemArray[0].ToString();
                    tiempo_pcs[i].IP = newcomputers.Rows[i].ItemArray[1].ToString();
                    tiempo_pcs[i].HoraInicio = HORAINICIO;
                    tiempo_pcs[i].HoraLimite = HORALIMITE;


                    arreglopcs.Add(tiempo_pcs[i]);
                }

             
            }

        }


        public void pc_click(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            Computadora pc = (Computadora)sender;
            ORDENADOR = IPAddress.Parse(pc.IP);
            textIP.Text = pc.IP;
            var _pc = arreglopcs.FirstOrDefault(x => x.IP == pc.IP);
            txtLimite.Text = _pc.HoraLimite.ToLongTimeString();
        }

        private ArrayList searchInArray(string ip, List<PC_Tiempo> array)
        {
            var err = "";
            var address = "";
            var nuevo = array;
            DateTime horaInicio;
            DateTime horaLimite;
            ArrayList datos = new ArrayList();
            for (int i = 0; i < array.Count; i++)
            {
                //System.Diagnostics.Debug.WriteLine(array[i]);
                if (array[i].IP.ToString() == ip )
                {
                   
                    address = array[i].IP.ToString();
                    horaInicio = array[i].HoraInicio;
                    horaLimite = array[i].HoraLimite;
                    datos.Add(array[i].IP);
                    datos.Add(array[i].HoraInicio);
                    datos.Add(array[i].HoraLimite);
                }
            }

            return datos;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBox1.SelectedItem.ToString() ?? "")
            {
                case "W7":
                    {
                        ORDENADOR = IPAddress.Parse("192.168.182.170");
                        break;
                    }

                case "XP":
                    {
                        ORDENADOR = IPAddress.Parse("192.168.1.35");
                        break;
                    }
            }
        }

        private void ButtonINICIAR_Click(object sender, EventArgs e)
        {
            try
            {
                int totalmins = (System.Convert.ToInt32(NumH1.Value.ToString()) * 60) + System.Convert.ToInt32(NumM1.Value.ToString());
                var IP = new IPEndPoint(ORDENADOR, System.Convert.ToInt32(TextBoxPUERTO1.Text));
                string FRASE = "INICIAR:" + NumH1.Value + ":" + NumM1.Value;
                var MENSAJE = UTF7.GetBytes(FRASE);
                ADMINISTRADOR.Connect(IP);
                ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                HORAINICIO = DateTime.Now;
                HORALIMITE = HORAINICIO.AddMinutes(totalmins);
                var pc = arreglopcs.FirstOrDefault(x => x.IP == ORDENADOR.ToString());
                pc.HoraInicio = HORAINICIO;
                pc.HoraLimite = HORALIMITE;
                txtLimite.Text = pc.HoraLimite.ToLongTimeString();
                NumH1.Value = 0m;
                NumM1.Value = 0m;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonAÑADIR_Click(object sender, EventArgs e)
        {
            try
            {
                int totalmins = (System.Convert.ToInt32(NumH1.Value.ToString()) * 60) + System.Convert.ToInt32(NumM1.Value.ToString());
                var IP = new IPEndPoint(ORDENADOR, System.Convert.ToInt32(TextBoxPUERTO1.Text));
                string FRASE = "AÑADIR:" + NumH1.Value + ":" + NumM1.Value;
                var MENSAJE = UTF7.GetBytes(FRASE);
                ADMINISTRADOR.Connect(IP);
                ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                var pc = arreglopcs.FirstOrDefault(x => x.IP == ORDENADOR.ToString());
                pc.HoraLimite = pc.HoraLimite.AddMinutes(totalmins);
                txtLimite.Text = pc.HoraLimite.ToLongTimeString();
                NumH1.Value = 0m;
                NumM1.Value = 0m;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBoxMENSAJES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(TextBoxMENSAJES1.Text))
                {
                    try
                    {
                        var IP = new IPEndPoint(ORDENADOR, System.Convert.ToInt32(TextBoxPUERTO1.Text));
                        string FRASE = "MENSAJE:" + TextBoxMENSAJES1.Text + ":0";
                        var MENSAJE = UTF7.GetBytes(FRASE);
                        ADMINISTRADOR.Connect(IP);
                        ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                        TextBoxMENSAJES1.Clear();
                        e.SuppressKeyPress = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ButtonBLOQUEO_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere bloquear el escritorio remoto?", "Bloquear escritorio remoto",  MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var IP = new IPEndPoint(ORDENADOR, System.Convert.ToInt32(TextBoxPUERTO1.Text));
                    string FRASE = "BLOQUEO:0:0";
                    var MENSAJE = UTF7.GetBytes(FRASE);
                    ADMINISTRADOR.Connect(IP);
                    ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonCERRAR_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere cerrar la aplicacion del escritorio remoto?", "Cerrar aplicacion",  MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var IP = new IPEndPoint(ORDENADOR, System.Convert.ToInt32(TextBoxPUERTO1.Text));
                    string FRASE = "CERRAR:0:0";
                    var MENSAJE = UTF7.GetBytes(FRASE);
                    ADMINISTRADOR.Connect(IP);
                    ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonREINICIAR_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere reiniciar el escritorio remoto?", "Reiniciar ordenador remoto",  MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var IP = new IPEndPoint(ORDENADOR, System.Convert.ToInt32(TextBoxPUERTO1.Text));
                    string FRASE = "REINICIAR:0:0";
                    var MENSAJE = UTF7.GetBytes(FRASE);
                    ADMINISTRADOR.Connect(IP);
                    ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ButtonAPAGAR_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere apagar el escritorio remoto?", "Apagar ordenador remoto",  MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var IP = new IPEndPoint(ORDENADOR, System.Convert.ToInt32(TextBoxPUERTO1.Text));
                    string FRASE = "APAGAR:0:0";
                    var MENSAJE = UTF7.GetBytes(FRASE);
                    ADMINISTRADOR.Connect(IP);
                    ADMINISTRADOR.Send(MENSAJE, MENSAJE.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Ingrese # o ID de Computadora");
                e.Handled = true;
            }
            if (textBox1.Text != "" && e.KeyChar == (char)13)
            {
                var id = System.Convert.ToInt64(textBox1.Text);
                var entityPC = entity.PC.FirstOrDefault(x => x.IdPC == id);
                if (entityPC != null)
                {
                    refill = true;
                    Computadora PC = new Computadora();
                    PC.ID = entityPC.IdPC.ToString();
                    PC.IP = entityPC.IP;
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(PC);
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && refill)
            {
                populate();
                refill = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Pcs form = new Admin_Pcs();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ORDENADOR == null)
            {
                MessageBox.Show("Seleccione un ordenador.");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quiere facturar para el ordenador " + ORDENADOR.ToString() + "?", "Facturar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var pc = arreglopcs.FirstOrDefault(x => x.IP == ORDENADOR.ToString());
                var ttotal = pc.HoraLimite - pc.HoraInicio;
                var hrs = ttotal.TotalHours;
                var mins = ttotal.TotalMinutes;
                var secs = ttotal.TotalSeconds;
                //Pendiente enviar al grid de ventas
            }
        }
    }
}