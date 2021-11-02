using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.Mantenimientos
{
    public partial class Mantenimiento_Usuarios_Detalles : Form
    {
        Punto_de_venta.Bases_de_datos.BPBEntities1 entity = new Bases_de_datos.BPBEntities1();
        int id = 0;
        bool editar = false;
        public Mantenimiento_Usuarios_Detalles(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtTelefono.Text.Equals(""))
            {
                MessageBox.Show("Por favor ingresar toda la información requerida.");
                return;
            }

            if (editar)
            {
                var thUser = entity.UsuarioDetalle.FirstOrDefault(x => x.PKUsuario == id);

                thUser.userNombre = txtNombre.Text;
                thUser.userApellido = txtApellido.Text;
                thUser.userTelefono = txtTelefono.Text;

                entity.SaveChanges();
            }
            else
            {
                Punto_de_venta.Bases_de_datos.UsuarioDetalles tUD = new Punto_de_venta.Bases_de_datos.UsuarioDetalles();

                tUD.userNombre = txtNombre.Text;
                tUD.userApellido = txtApellido.Text;
                tUD.userTelefono = txtTelefono.Text;

                entity.Productos.Add(tUD);

                entity.SaveChanges();
            }
        }

        private void Mantenimiento_Usuarios_Detalles_Load(object sender, EventArgs e)
        {
            var texists = entity.UsuarioDetalles.FirstOrDefault(x => x.PKUsuario == id);

            if (texists)
            {
                txtNombre.Text = texists.userNombre;
                txtApellido.Text = texists.userApellido;
                txtTelefono.Text = texists.userTelefono;
            }
        }
    }
}
