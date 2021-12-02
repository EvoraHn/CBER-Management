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
        Punto_de_venta.Bases_de_datos.CyberElIngeEntities entity = new Bases_de_datos.CyberElIngeEntities();
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
                var thUser = entity.UsuarioDetalles.FirstOrDefault(x => x.PKUsuario == id);

                thUser.userNombre = txtNombre.Text;
                thUser.userApellido = txtApellido.Text;
                thUser.userTelefono = txtTelefono.Text;

                entity.SaveChanges();

                editar = false;
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtTelefono.Enabled = false;
                MessageBox.Show("Detalles del Usuario Actualizados");
            }
            else
            {
                if (txtNombre.Enabled)
                {
                    Punto_de_venta.Bases_de_datos.UsuarioDetalles tUD = new Punto_de_venta.Bases_de_datos.UsuarioDetalles();

                    tUD.PKUsuario = (short)Convert.ToInt32(id);
                    tUD.userNombre = txtNombre.Text;
                    tUD.userApellido = txtApellido.Text;
                    tUD.userTelefono = txtTelefono.Text;


                    entity.UsuarioDetalles.Add(tUD);

                    entity.SaveChanges();
                    MessageBox.Show("Detalles del Usuario Actualizados");

                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtTelefono.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEditar.BackColor = btnGuardar.BackColor;
                }
                else
                {
                    MessageBox.Show("Si desea modificar/guardar los datos de este usuario ya existente presione editar y luego guardar");
                }
            }
        }

        private void Mantenimiento_Usuarios_Detalles_Load(object sender, EventArgs e)
        {
            var texists = entity.UsuarioDetalles.FirstOrDefault(x => x.PKUsuario == id);

            if (texists != null)
            {
                txtNombre.Text = texists.userNombre;
                txtApellido.Text = texists.userApellido;
                txtTelefono.Text = texists.userTelefono;
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtTelefono.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = false;
                btnEditar.BackColor = Color.White;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
        }
    }
}
