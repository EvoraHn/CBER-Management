using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.Bitacora
{
    public partial class Formulario_Bitacora : Form
    {
        Punto_de_venta.Bases_de_datos.CyberElIngeEntities entity = new Bases_de_datos.CyberElIngeEntities();
        DataView mifiltro;
        public Formulario_Bitacora()
        {
            InitializeComponent();
        }

        private void Formulario_Bitacora_Load(object sender, EventArgs e)
        {
           var tBitacora = from b in entity.Bitacora
                             select new
                             {
                                b.Formulario,
                                b.Fecha,
                                b.Descripcion,
                                b.Usuario
                             };
            this.mifiltro = (tBitacora.CopyAnonymusToDataTable()).DefaultView;
            this.dgBitacora.DataSource = mifiltro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnNuevaFactura1_Click(object sender, EventArgs e)
        {

        }
    }
}
