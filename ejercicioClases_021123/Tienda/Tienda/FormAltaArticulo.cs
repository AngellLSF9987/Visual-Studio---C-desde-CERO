using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using Tienda.Controladores;

namespace Tienda
{
    public partial class FormAltaArticulo : Form
    {

        List<Articulo> articulos = new List<Articulo>();
        // Mostrar el precio incluido al seleccionar una categoría del ComboBox (comboBoxSelectCategoria), utilizar un diccionario para almacenar los precios de las categorías.
        private Dictionary<string, decimal> preciosCategorias = new Dictionary<string, decimal>
        {
            { "Colección PCs Sobremesa", 500 },
            { "Colección PCs Portátiles", 700 },
            { "Colección Smartphones", 250 }
        };

        decimal precio = 0;
        public FormAltaArticulo()
        {
            InitializeComponent();
            timerHoraActual.Enabled = true;
            comboBoxSelectCategoria.SelectedIndexChanged += new EventHandler(comboBoxSelectCategoria_SelectedIndexChanged);
        }

        private void FormAltaArticulo_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dddd, " + "dd \\de " + "MMMM \\de " + "yyyy").ToUpperInvariant();
        }

        private void btnInicio_Click(object sender, EventArgs e) => Close();

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void comboBoxSelectCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoriaSeleccionada = comboBoxSelectCategoria.SelectedItem.ToString();
            if (preciosCategorias.ContainsKey(categoriaSeleccionada))
            {
                labelTotal.Text = preciosCategorias[categoriaSeleccionada].ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtener los datos ingresados en el formulario
            string nombreArticulo = textBoxNombreArticulo.Text;
            decimal precioArticulo = decimal.Parse(labelTotal.Text);
            string categoriaArticulo = comboBoxSelectCategoria.SelectedItem.ToString();

            int existenciasArticulo = int.Parse(textBoxCantidad.Text);

            // Validar la categoría
            if (!Articulo.CategoriaValida(categoriaArticulo))
            {
                MessageBox.Show("Categoría no válida. Las categorías válidas son: Colección PCs Sobremesa, Colección PCs Portátiles, Colección PCs Smartphones.");
                return;
            }

           

            // Buscar un artículo existente con el mismo nombreArticulo
            Articulo articuloExistente = articulos.FirstOrDefault(a => a.NombreArticulo == nombreArticulo);

            if (articuloExistente != null)
            {
                // Si se encuentra un artículo con el mismo nombre, aumentar las existencias
                articuloExistente.ExistenciasArticulo += existenciasArticulo;
                MessageBox.Show("Existencias aumentadas para el artículo existente.");
            }
            // Crear un nuevo artículo con los datos ingresados
            Articulo articulo = new Articulo(nombreArticulo, categoriaArticulo, precioArticulo, existenciasArticulo);
            // Agregar una nueva fila al ListView para mostrar los detalles del nuevo artículo
            ListViewItem item = new ListViewItem(articulo.CodigoArticulo.ToString());
            item.SubItems.Add(articulo.NombreArticulo);
            item.SubItems.Add(articulo.CategoriaArticulo);
            item.SubItems.Add(articulo.PrecioArticulo.ToString());
            item.SubItems.Add(articulo.ExistenciasArticulo.ToString());

            listViewArticulos.Items.Add(item);
            ControladorArticulo.AgregarArticulo(articulo);

            MessageBox.Show("Artículo creado con éxito.");
            btnLimpiar_Click(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombreArticulo.Text = "Escriba aquí el Nombre del Nuevo Artículo ...";
            comboBoxSelectCategoria.Text = "Seleccione Articulo...";
            textBoxCantidad.Text = "Define la Nueva Cantidad Disponible ...";
            labelTotal.Text = Convert.ToString(precio + "€");
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            textBoxCantidad.Clear();
        }

        private void textBoxNombreArticulo_TextChanged(object sender, EventArgs e)
        {
            textBoxNombreArticulo.Clear();
        }
    }
}


