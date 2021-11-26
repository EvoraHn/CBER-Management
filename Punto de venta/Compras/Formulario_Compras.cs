using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Printing;

namespace Punto_de_venta.Compras
{
    public partial class Formulario_Compras : Form
    {
        //conexión a la base de datos
        Punto_de_venta.Bases_de_datos.CyberElIngeEntities entity = new Bases_de_datos.CyberElIngeEntities();
        //filtro para el botón buscar
        DataView mifiltro;
        long userID = 0;
        //inicializar las variables
        long id = 0;

        public Formulario_Compras(long _userID)
        {
            InitializeComponent();
            userID = _userID;
        }

        private void Formulario_Compras_Load(object sender, EventArgs e)
        {
            Mostrar_datos();
        }

        private void Mostrar_datos()
        {
            var tProductos = from p in entity.Vista1
                             select new
                             {
                                 p.Codigo,
                                 p.Producto,
                                 p.Precio
                             };
            this.mifiltro = (tProductos.CopyAnonymusToDataTable()).DefaultView;
            this.dgDatos.DataSource = mifiltro;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void AgregarProducto()
        {
            int indice = dgDatos.CurrentCell.RowIndex;
            int indiceF = dgFactura.RowCount == 0 ? 0 : dgFactura.CurrentCell.RowIndex;

            string codigo = dgDatos.Rows[indice].Cells[0].Value.ToString();
            string producto = dgDatos.Rows[indice].Cells[1].Value.ToString();
            //string precio = dgProductos.Rows[indice].Cells[2].Value.ToString();
            string precio = txtPrecio.Text;
            string cantidad = dgFactura.RowCount == 0 ? "1" : dgFactura.Rows[indiceF].Cells[3].Value.ToString();

            foreach (DataGridViewRow dr in dgFactura.Rows)
            {
                string id = (dr.Cells[1].Value).ToString();

                if (id == producto)
                {

                    int quantity = Convert.ToInt32(dr.Cells[3].Value);
                    cantidad = (Convert.ToInt32(txtCantidad.Text) + quantity).ToString();
                    dgFactura.Rows.RemoveAt(dr.Index);
                    break;
                }
                else
                {
                    cantidad = txtCantidad.Text;
                }

            }
            dgFactura.Rows.Add(codigo, producto, precio, cantidad);
            //HacerCuentas();
            actualizarTotales();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgFactura.SelectedRows.Count > 0)
                {
                    int indice = dgFactura.CurrentCell.RowIndex;
                    int indiceF = dgFactura.RowCount == 0 ? 0 : dgFactura.CurrentCell.RowIndex;
                    int cantidadf = dgFactura.RowCount == 0 ? 0 : Convert.ToInt32(dgFactura.Rows[indice].Cells[3].Value);

                    if (cantidadf <= 1)
                    {
                        dgFactura.Rows.RemoveAt(indice);
                    }
                    else
                    {
                        string codigo = dgFactura.Rows[indice].Cells[0].Value.ToString();
                        string producto = dgFactura.Rows[indice].Cells[1].Value.ToString();
                        string precio = dgFactura.Rows[indice].Cells[2].Value.ToString();
                        string cantidad = dgFactura.RowCount == 0 ? "0" : dgFactura.Rows[indiceF].Cells[3].Value.ToString();

                        //HacerCuentas();
                        foreach (DataGridViewRow dr in dgFactura.Rows)
                        {
                            string id = (dr.Cells[1].Value).ToString();

                            if (id == producto)
                            {

                                int quantity = 1;
                                cantidad = (Convert.ToInt32(cantidad) - quantity).ToString();
                                dgFactura.Rows.RemoveAt(dr.Index);
                                break;
                            }
                            else
                            {
                                //cantidad = txtCantidad.Text;
                            }

                        }
                        dgFactura.Rows.Add(codigo, producto, precio, cantidad);
                        //HacerCuentas();
                        dgFactura.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un producto de la factura para eliminarlo",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona un producto de la factura para eliminarlo",
                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            actualizarTotales();
        }

        private void btnQuitarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgFactura.SelectedRows.Count > 0)
                {
                    int indice = dgFactura.CurrentCell.RowIndex;
                    dgFactura.Rows.RemoveAt(indice);
                }
                else
                {
                    MessageBox.Show("Selecciona un producto de la factura para eliminarlo",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona un producto de la factura para eliminarlo",
                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            actualizarTotales();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != string.Empty || dgDatos.ColumnCount > 0)
            {
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                if (cantidad > 0)
                {

                    //Punto_de_venta.Bases_de_datos.Producto tabla = new Punto_de_venta.Bases_de_datos.Producto();
                    var tabla = entity.Producto.FirstOrDefault(x => x.IdProducto == Convert.ToInt64(id));
                    tabla.Cantidad += cantidad;
                    entity.SaveChanges();
                    Guardar_Compra();
                    Mostrar_datos();
                    Limpiar();
                    MessageBox.Show("Se agregó más producto al inventario",
                   "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                else
                {
                    MessageBox.Show("no puedes comprar cantidades negativas",
                   "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ingresa la cantidad que deseas comprar",
                   "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void actualizarTotales()
        {
            double subtotal = 0.00;

            foreach (DataGridViewRow dr in dgFactura.Rows)
            {
                double precio = Convert.ToDouble(dr.Cells[2].Value);
                int cantidad = Convert.ToInt32(dr.Cells[3].Value);
                double total2 = precio * cantidad;
                subtotal += total2;
            }

            txtSubtotal.Text = subtotal.ToString("0.00");
            double descuentos = txtDescuentos.Text == "" ? 0.00 : Convert.ToDouble(txtDescuentos.Text);
            double impuestos = txtImporteExonerado.Text == "" ? 0.00 : Convert.ToDouble(txtImporteExonerado.Text);
            subtotal = subtotal - descuentos;
            double total = subtotal + impuestos;
            txtTotal.Text = total.ToString("0.00");
        }
        
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.txtBuscar.Text.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(Codigo LIKE '%" + palabra + "%' OR Producto LIKE '%" + palabra + "%' )";
                }
                else
                {
                    salida_datos = "(Codigo LIKE '%" + palabra + "%' OR Producto LIKE '%" + palabra + "%' )";
                }
            }
            this.mifiltro.RowFilter = salida_datos;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor ingresa solo numeros enteros en este campo",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void Limpiar()
        {
            txtBuscar.Text = txtCantidad.Text = txtId.Text = txtDescuentos.Text = txtImporteExonerado.Text = string.Empty;
            txtId.Text = txtProducto.Text = txtDescuentos.Text = txtImporteExonerado.Text = txtTotal.Text =
            txtSubtotal.Text = txtBuscar.Text = txtTotal.Text = string.Empty;
            txtDescuentos.Text = "0";
            txtImporteExonerado.Text = "0";
            dgFactura.Rows.Clear();
            dgFactura.RowCount = 0;
            txtCantidad.Text = "1";
            lblFactura.Text = "00000";
            txtPrecio.Text = "";
            txtBuscar.Focus();
            actualizarTotales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            
        }

        private void Guardar_Compra()
        {
            Punto_de_venta.Bases_de_datos.Compra tabla = new Punto_de_venta.Bases_de_datos.Compra();
            tabla.idUsuario = 6;
            tabla.Total = Convert.ToDouble(txtTotal.Text);
            tabla.Fecha = DateTime.Now;
            entity.Compra.Add(tabla);
            entity.SaveChanges();

            AgregarDetalleDeCompra(tabla.IdCompra);
            Limpiar();
        }

        private void dgDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgDatos.RowCount > 0)
            {
                try
                {
                    id = Convert.ToInt64(dgDatos.SelectedCells[0].Value);
                    var tabla = entity.Producto.FirstOrDefault(x => x.IdProducto == id);
                    txtId.Text = (tabla.IdProducto).ToString();
                    txtProducto.Text = tabla.Nombre;
                    txtPrecio.Text = (tabla.PrecioVenta).ToString();
                }
                catch (Exception)
                { }
            }
        }

        private void btnSoloGuardar1_Click(object sender, EventArgs e)
        {
            Guardar_Compra();
        }

        private void txtDescuentos_TextChanged(object sender, EventArgs e)
        {
            actualizarTotales();
        }

        private void txtImporteExonerado_TextChanged(object sender, EventArgs e)
        {
            actualizarTotales();
        }

        private void AgregarDetalleDeCompra(int id)
        {
            foreach (DataGridViewRow dr in dgFactura.Rows)
            {
                Punto_de_venta.Bases_de_datos.CompraDetalle tabla = new Punto_de_venta.Bases_de_datos.CompraDetalle();
                tabla.IdCompra = id;
                long idprod = Convert.ToInt64(dr.Cells[0].Value);
                
                tabla.IdProducto = idprod;
                tabla.PrecioUnidad = Convert.ToString(dr.Cells[2].Value);
                int cantidad = Convert.ToInt32(dr.Cells[3].Value);
                tabla.Cantidad = cantidad.ToString();
                tabla.Total = "0";
                entity.CompraDetalle.Add(tabla);
                entity.SaveChanges();

                var tProd = entity.Producto.FirstOrDefault(x => x.IdProducto == idprod);
                int total = tProd.Cantidad += cantidad;
                tProd.Cantidad = total;
                entity.SaveChanges();
            }
        }

        private void BtnNuevaFactura1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor ingresa solo numeros enteros positivos en este campo",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtDescuentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor ingresa solo numeros enteros positivos en este campo",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtImporteExonerado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor ingresa solo numeros enteros positivos en este campo",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
