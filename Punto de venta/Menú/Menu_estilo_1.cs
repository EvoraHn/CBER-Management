using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.Menú
{
    public partial class Menu_estilo_1 : Form
    {
        string modulo = "";
        int userID = Clases.Usuario.idUsuario;
        Punto_de_venta.Bases_de_datos.CyberElIngeEntities entity = new Punto_de_venta.Bases_de_datos.CyberElIngeEntities();
        public Menu_estilo_1()
        {

            InitializeComponent();  
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
       
            abrirFormularioHijo(new Punto_de_venta.Mantenimientos.Mantenimiento_Productos(modulo,userID));//Manda a llamar el formulario de inventario y lo abre

        }
        public void abrirFormularioHijo(object formHijo)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
                Form fh = formHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelPrincipal.Controls.Add(fh);
                this.panelPrincipal.Tag = fh;
                fh.Show(); 
        }
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void logo_Click(object sender, EventArgs e)
        {
            //abrirFormularioHijo(new Punto_de_venta.Inicio.Inicio(userID));
            //if (panelBotones.Width == 273)
            //{
            //    panelBotones.Width = 100;
            //    panelPrincipal.Width = 1173;
            //    panelMenu.Width = 1173;

            //}
            //else
            //    panelBotones.Width = 273;
            //    panelPrincipal.Width = 1000;
            //    panelMenu.Width = 1000;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Punto_de_venta.Ventas.Formulario_Ventas(userID));
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Punto_de_venta.Compras.Formulario_Compras(userID));
        }

        private void Menu_estilo_1_Load(object sender, EventArgs e)
        {
            var usuario = from u in entity.Usuario
                          where u.IdUsuario == Clases.Usuario.idUsuario
                          select new
                          {
                              u.FKPerfil
                          };
            DataTable usr = usuario.CopyAnonymusToDataTable();
            if (usr.Rows.Count > 0)
            {
                if (usr.Rows[0].ItemArray[0].ToString() != "1")
                {
                    btnUsuarios.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Bitacora.Formulario_Bitacora());
            
        }

        private void Menu_estilo_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.NumPad1)
            {
                btnInventario.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad3)
            {
                btnVentas.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad2)
            {
                btnComprar.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.NumPad5)
            {
                //abrirFormularioHijo(new Punto_de_venta.Inicio.Inicio(userID));
            }
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Punto_de_venta.Control_de_Ordenadores.Form1 form = new Punto_de_venta.Control_de_Ordenadores.Form1();
            form.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Mantenimientos.Mantenimiento_Usuarios_2_0());
        }
    }
}
