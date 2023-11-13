using System;
using System.Globalization;
using System.Windows.Forms;

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
        }

        private void FormDetallePedido_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dddd, " + "dd \\de " + "MMMM \\de " + "YYYY");
            labelTotal.Text = Convert.ToString(precio + "€");
            
        }

        private void btnInicio_Click(object sender, EventArgs e) => Close();

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void comboBoxSelecArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            articulo = comboBoxSelecArticulos.Text;

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
            comboBoxSelecArticulos.Text = "Seleccione Articulo...";
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
            if (comboBoxSelecArticulos.SelectedIndex == -1)
                MessageBox.Show("Seleccione Articulo...");
            else if (textBoxCantidad.Text == " ")
                MessageBox.Show("Defina cantidad...");
            else if (comboBoxSelecPago.SelectedIndex == -1)
                MessageBox.Show("Seleccione Tipo de Pago...");
            else
            {
                articulo = comboBoxSelecArticulos.Text;
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

                    ListViewItem registro = new ListViewItem(articulo);
                   /**registro.SubItems.Add(codArticulo.ToString());
                    registro.SubItems.Add(nombreArticulo.ToString());
                    registro.SubItems.Add(categoria.ToString());*/
                    registro.SubItems.Add(precio.ToString());
                    registro.SubItems.Add(cantidad.ToString());
                    registro.SubItems.Add(pago);
                    registro.SubItems.Add(descuento.ToString());
                    registro.SubItems.Add(recargo.ToString());
                    registro.SubItems.Add(total.ToString());
                    /**registro.SubItems.Add(categoria.ToString()); */


                    btnLimpiar_Click(sender, e);

                    MessageBox.Show("Pedido realizado con éxito! Muchas gracias por elegirnos!");
                }
            }
        }
    }
}
