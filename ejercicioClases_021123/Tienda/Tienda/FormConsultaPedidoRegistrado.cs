using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormConsultaPedidoRegistrado : Form
    {
        // Propiedad para almacenar el código de pedido
        public int CodigoPedido { get; set; }
        public FormConsultaPedidoRegistrado(int codigoPedido)
        {
            InitializeComponent();
            timerHoraActual.Enabled = true;
        }

        private void FormConsultaPedidoRegistrado_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dddd, " + "dd \\de " + "MMMM \\de " + "yyyy").ToUpperInvariant();

            // Lógica para mostrar detalles del pedido según el código de pedido
            MostrarDetallesPedido(CodigoPedido);
        }

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void MostrarDetallesPedido(int codigoPedido)
        {
            // Lógica para mostrar detalles del pedido según el código de pedido
            // Puedes abrir un nuevo formulario o ventana emergente aquí
            MessageBox.Show($"Mostrar detalles del pedido {codigoPedido}");
        }
    }
}
