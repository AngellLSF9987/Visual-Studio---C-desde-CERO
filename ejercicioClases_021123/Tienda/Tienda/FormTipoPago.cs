using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tienda.Clases;
using Tienda.Controladores;

namespace Tienda
{
    public partial class FormTipoPago : Form
    {
        public event EventHandler ConfirmarClick;
        public string TipoPagoSeleccionado { get; private set; }

        public FormTipoPago()
        {
            InitializeComponent();
            timerHoraActual.Enabled = true;
            CargarTiposPagoEnComboBox();

            // Establecer la posición inicial del formulario
            this.StartPosition = FormStartPosition.CenterScreen; // Puedes ajustar esto según tus necesidades
                                                                 // Asegúrate de que el formulario no esté configurado como "TopMost" si no es necesario
                                                                 // this.TopMost = true; 
        }

        private void FormTipoPago_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dddd, " + "dd \\de " + "MMMM \\de " + "yyyy").ToUpperInvariant();
        }

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void CargarTiposPagoEnComboBox()
        {
            // Obtener la lista de tipos de pago desde el controlador
            List<TipoPago> tiposPago = ControladorTipoPago.ObtenerTipoPago();

            if (tiposPago.Count > 0)
            {
                // Agregar tipos de pago al ComboBox
                comboBoxSelecPago.Items.AddRange(tiposPago.ToArray());

                // Establecer el primer elemento como seleccionado (opcional)
                comboBoxSelecPago.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No hay tipos de pago disponibles.");
            }
        }

        public string ObtenerTipoPagoSeleccionado()
        {
            return comboBoxSelecPago.SelectedItem?.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Obtener el tipo de pago seleccionado
            TipoPago tipoPagoSeleccionado = (TipoPago)comboBoxSelecPago.SelectedItem;

            // Verificar si ya hay un pedido existente con el mismo tipo de pago
            // bool existePedido = ControladorPedido.ExistePedidoConTipoPago(TipoPagoSeleccionado);

            // Cerrar el formulario emergente
            // this.Close();

            // Guardar el tipo de pago seleccionado y cerrar el formulario
            TipoPagoSeleccionado = comboBoxSelecPago.SelectedItem?.ToString();
            ConfirmarClick?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
