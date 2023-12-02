using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tienda.Controladores;

namespace Tienda
{
    public partial class FormEditarArticulo : Form
    {
        private List<Categoria> Categorias = new List<Categoria>();

        public string NuevoNombre { get; set; }

        public Categoria NuevaCategoria
        {
            get { return (Categoria)ComboBoxNuevaCategoria.SelectedItem; }
            set { ComboBoxNuevaCategoria.SelectedItem = value; }
        }

        public decimal NuevoPrecio
        {
            get { return ((Categoria)ComboBoxNuevaCategoria.SelectedItem).PrecioPorDefecto; }
            set { /** Puedes establecer el precio por defecto si es necesario */ }
        }

        public int NuevasExistencias
        {
            get
            {
                if (int.TryParse(TextBoxCantidad.Text, out int existencias))
                {
                    return existencias;
                }
                return 0; // Otra opción podría ser lanzar una excepción aquí si lo prefieres
            }
            set { TextBoxCantidad.Text = value.ToString(); }
        }

        private Articulo articuloOriginal;

       

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