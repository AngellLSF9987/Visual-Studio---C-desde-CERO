using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormEditarArticulo : Form
    {
        private List<Categoria> Categorias = new List<Categoria>();
        private Articulo articuloOriginal;

        public int CodigoArticulo { get; set; }
        public string NuevoNombre { get; set; }
        public Categoria NuevaCategoria { get; set; }
        public decimal NuevoPrecio { get; set; }
        public int NuevasExistencias { get; set; }

        public FormEditarArticulo(Articulo articulo)
        {
            InitializeComponent();

            // Verificar si el objeto articulo es null
            if (articulo == null)
            {
                MessageBox.Show("El artículo proporcionado es nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Puedes decidir cerrar el formulario en este punto si el artículo es nulo
                Close();
                return;
            }

            // Almacenar el artículo para su posterior edición
            articuloOriginal = articulo;

            // Llenar los campos del formulario con los datos del artículo
            TextBoxNuevoNombre.Text = articulo.NombreArticulo;
            ComboBoxNuevaCategoria.SelectedItem = articulo.Categoria;
            TextBoxCantidad.Text = articulo.ExistenciasArticulo.ToString();
            LabelTotal.Text = $"{articulo.Categoria.PrecioPorDefecto}€";
        }
        private void FormEditarArticulo_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dddd, " + "dd \\de " + "MMMM \\de " + "yyyy").ToUpperInvariant();
        }

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ComboBoxNuevaCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Actualizar el precio por defecto al seleccionar una nueva categoría
            if (ComboBoxNuevaCategoria.SelectedItem is Categoria nuevaCategoria)
            {
                LabelTotal.Text = $"{nuevaCategoria.PrecioPorDefecto}€";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Validar los datos antes de cerrar el formulario
            if (ValidarDatos())
            {
                // Actualizar el artículo original con los nuevos valores
                articuloOriginal.NombreArticulo = TextBoxNuevoNombre.Text;
                articuloOriginal.Categoria = (Categoria)ComboBoxNuevaCategoria.SelectedItem;
                articuloOriginal.PrecioArticulo = ((Categoria)ComboBoxNuevaCategoria.SelectedItem).PrecioPorDefecto;
                articuloOriginal.ExistenciasArticulo = int.Parse(TextBoxCantidad.Text);

                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private bool ValidarDatos()
        {
            // Aquí puedes agregar lógica de validación adicional si es necesario
            if (string.IsNullOrWhiteSpace(TextBoxNuevoNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(TextBoxCantidad.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Puedes agregar más validaciones según tus requisitos

            return true;
        }
    }
}