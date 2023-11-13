using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tienda.Clases;
using Tienda.Controladores;

namespace Tienda
{
    public partial class FormDetallePedido : Form
    {
        double precio = 0;
        string articulo, pago = " ";
        int cantidad = 0;
        
       
        public FormDetallePedido()
        {
            InitializeComponent();  
            timerHoraActual.Enabled = true;
            List<Articulo> articulos = ControladorArticulo.ObtenerArticulos();
        }

        private void FormDetallePedido_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dddd, " + "dd \\de " + "MMMM \\de " + "yyyy").ToUpperInvariant();
            labelTotal.Text = Convert.ToString(precio + "€");
            
        }

        private void btnInicio_Click(object sender, EventArgs e) => Close();

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void comboBoxSelecArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            articulo = comboBoxSelectArticulos.Text;

            if (articulo.Equals("Colección Smartphones"))
            {
                precio = 250;
                labelTotal.Text = Convert.ToString(precio + "€");
            }
            if (articulo.Equals("Colección PCs Sobremesa"))
            {
                precio = 450;
                labelTotal.Text = Convert.ToString(precio + "€");
            }
            if (articulo.Equals("Colección PCs Portátiles"))
            {
                precio = 700;
                labelTotal.Text = Convert.ToString(precio + "€");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxSelectArticulos.Text = "Seleccione Articulo...";
            comboBoxSelecPago.Text = "Seleccione Tipo de Pago...";
            textBoxCantidad.Text = Convert.ToString(textBoxCantidad.Text);
            labelTotal.Text = Convert.ToString(precio + "€");
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            textBoxCantidad.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectArticulos.SelectedIndex == -1)
                MessageBox.Show("Seleccione Articulo...");
            else if (textBoxCantidad.Text == " ")
                MessageBox.Show("Defina cantidad...");
            else if (comboBoxSelecPago.SelectedIndex == -1)
                MessageBox.Show("Seleccione Tipo de Pago...");
            else
            {
                articulo = comboBoxSelectArticulos.Text;
                cantidad = Convert.ToInt32(textBoxCantidad.Text);
                pago = comboBoxSelecPago.Text;

                double subTotal = cantidad * precio;
                double recargo = 0.1, descuento = 0.05;

                if (pago.Equals("Efectivo"))
                {
                   double efectivo = descuento * subTotal;
                }
                else
                {
                    double parcial = recargo * subTotal;
                    double total = subTotal - descuento * recargo;

                    /**foreach (Pedido pedido in listadoPedido)
                    {
                       int n = dataGridViewPedidos.Rows.Add();
                        for (pedido.CodPedido = 1; pedido.CodPedido < dataGridViewPedidos.Rows.Count; pedido.CodPedido++)
                        {
                            dataGridViewPedidos.Rows[n].Cells[0].Value = pedido.CodPedido;
                        }
                        for (pedido.CodArticulo = 1; pedido.CodArticulo < ; pedido.CodArticulo++)
                        {
                                dataGridViewPedidos.Rows[n].Cells[1].Value = pedido.CodArticulo;
                        }

                        dataGridViewPedidos.Rows[n].Cells[2].Value = pedido.PrecioArticulo;
                        dataGridViewPedidos.Rows[n].Cells[3].Value = pedido.ExistenciasArticulo;
                        pedido.CategoriaArticulo = Convert.ToString(comboBoxSelectCategoria.Items[comboBoxSelectCategoria.SelectedIndex]);
                        dataGridViewPedidos.Rows[n].Cells[4].Value = pedido.CategoriaArticulo;*/

                    //MessageBox.Show("Pedido registrado: " + comboBoxSelectArticulos.Text);
                }
                /**ListViewItem registro = new ListViewItem(articulo);
               registro.SubItems.Add(codArticulo.ToString());
                registro.SubItems.Add(nombreArticulo.ToString());
                registro.SubItems.Add(categoria.ToString());
                registro.SubItems.Add(precio.ToString());
                registro.SubItems.Add(cantidad.ToString());
                registro.SubItems.Add(pago);
                registro.SubItems.Add(descuento.ToString());
                registro.SubItems.Add(recargo.ToString());
                registro.SubItems.Add(total.ToString());
                /**registro.SubItems.Add(categoria.ToString());
                ListViewItem articulo = new ListViewItem(articulo);
                articulo.SubItems.Add(articulo.ToString());
                articulo.SubItems.Add(nombreArticulo.ToString());
                articulo.SubItems.Add(categoria.ToString());
                articulo.SubItems.Add(precio.ToString());
                articulo.SubItems.Add(cantidad.ToString());
                articulo.SubItems.Add(pago);
                articulo.SubItems.Add(descuento.ToString());
                articulo.SubItems.Add(recargo.ToString());
                articulo.SubItems.Add(total.ToString());
                articulo.SubItems.Add(categoria.ToString()); */

                btnLimpiar_Click(sender, e);

                    MessageBox.Show("Pedido realizado con éxito! Muchas gracias por elegirnos!");
                
            }
        }
    }
}
