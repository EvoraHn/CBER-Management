using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Punto_de_venta.Control_de_Ordenadores
{
    public partial class Admin_Pcs : Form
    {

        Bases_de_datos.CyberElIngeEntities entity = new Bases_de_datos.CyberElIngeEntities();
        bool editar = false;
        bool agregar = false;
        long idPC = 0;
        public Admin_Pcs()
        {
            InitializeComponent();
        }

        private void Admin_Pcs_Load(object sender, EventArgs e)
        {

            trigger(false);
            var pcs = from p in entity.PC
                      select new
                      {
                          p.IdPC,
                          p.IP,
                          p.Fila,
                          p.Columna
                      };
            dgPCs.DataSource = pcs.CopyAnonymusToDataTable();
            dgPCs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void trigger(bool variable)
        {
            if (variable)
            {
                textIP.Enabled = true;
                textFila.Enabled = true;
                textCol.Enabled = true;
                estadoCheck.Enabled = true;
                btnNuevoGuardar.Text = "Guardar";
                btnEditarCancelar.Text = "Cancelar";

                return;
            }

            textIP.Enabled = false;
            textFila.Enabled = false;
            textCol.Enabled = false;
            estadoCheck.Enabled = false;
            btnNuevoGuardar.Text = "Nuevo";
            btnEditarCancelar.Text = "Editar";

        }

        private void populate()
        {
            var pcs = from p in entity.PC
                      select new
                      {
                          p.IdPC,
                          p.IP,
                          p.Fila,
                          p.Columna
                      };
            dgPCs.DataSource = pcs.CopyAnonymusToDataTable();
        }

        private void btnNuevoGuardar_Click(object sender, EventArgs e)
        {
            
            if (agregar && (textCol.Text != "" && textFila.Text != "" && textIP.Text != ""))
            {
                Bases_de_datos.PC pc = new Bases_de_datos.PC();
                pc.IP = textIP.Text;
                pc.Fila = textFila.Text;
                pc.Columna = textCol.Text;
                pc.Estado = estadoCheck.Checked;
                entity.PC.Add(pc);
                entity.SaveChanges();
                agregar = false;

            }
            else if (editar && (textCol.Text != "" && textFila.Text != "" && textIP.Text != ""))
            {
                var pc = entity.PC.FirstOrDefault(x => x.IdPC == idPC);
                pc.IP = textIP.Text;
                pc.Fila = textFila.Text;
                pc.Columna = textCol.Text;
                pc.Estado = estadoCheck.Checked;
                entity.SaveChanges();
                editar = false;
            }
            else if (agregar && !(textCol.Text != "" && textFila.Text != "" && textIP.Text != ""))
            {
                MessageBox.Show("Llene todos los datos.");
            }
            else if (editar && !(textCol.Text != "" && textFila.Text != "" && textIP.Text != ""))
            {
                MessageBox.Show("Llene todos los datos.");
            }

            if (btnNuevoGuardar.Text == "Nuevo" && !agregar && !editar)
            {
                
                trigger(true);
                agregar = true;
                textIP.Text = "";
                textFila.Text = "";
                textCol.Text = "";
                estadoCheck.Checked = false;

                return;
            }

            populate();
            trigger(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgPCs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPCs.RowCount > 0)
            {
                try
                {
                    idPC = Convert.ToInt64(dgPCs.SelectedCells[0].Value);
                    var pc = entity.PC.FirstOrDefault(x => x.IdPC == idPC);
                    textIP.Text = pc.IP;
                    textFila.Text = pc.Fila;
                    textCol.Text = pc.Columna;
                    estadoCheck.Checked = pc.Estado;
                    editar = true;

                }
                catch (Exception)
                {

                }
            }
        }

        private void btnEditarCancelar_Click(object sender, EventArgs e)
        {
            if (btnEditarCancelar.Text == "Editar")
            {
                trigger(true);
                editar = true;
                

                return;
            }

            editar = false;
            agregar = false;
            trigger(false);
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
