using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tienda.Controladores;

namespace Tienda
{
    public partial class FormAltaArticulo : Form
    {
        private List<Categoria> Categorias = new List<Categoria>();
        public FormAltaArticulo()
        {
            InitializeComponent();
            timerHoraActual.Enabled = true;
            // Método para inicializar la lista de categorías con ejemplos
            ControladorCategoria.InicializarCategorias();
            Categorias = ControladorCategoria.ObtenerCategorias();
            // Método para inicializar la lista de articulos y obtenerlos por Categorias
            ControladorArticulo.ObtenerArticulos();
            comboBoxSelectCategoria.SelectedIndexChanged += new EventHandler(comboBoxSelectCategoria_SelectedIndexChanged);
        }
        
        private void FormAltaArticulo_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dddd, " + "dd \\de " + "MMMM \\de " + "yyyy").ToUpperInvariant();

            // Asignar las categorías al comboBox
            comboBoxSelectCategoria.DataSource = Categorias;
            comboBoxSelectCategoria.DisplayMember = "NombreCategoria";
            comboBoxSelectCategoria.ValueMember = "PrecioPorDefecto";

            // Establecer el texto predeterminado que deseas mostrar
            comboBoxSelectCategoria.Text = "Asocie una Categoria al Articulo...";

            // Establecer el texto predeterminado que deseas mostrar en labelTotal
            labelTotal.Text = "Elija categoría para ver el precio...";

            // Agregar artículos a la lista y al ListView
            foreach (Articulo articulo in ControladorArticulo.ObtenerArticulos())
            {
                /**{--ControladorArticulo.AgregarArticulo(articulo);--}*/

                ListViewItem item = new ListViewItem(articulo.CodigoArticulo.ToString());
                item.SubItems.Add(articulo.NombreArticulo);
                item.SubItems.Add(articulo.Categoria.NombreCategoria);
                item.SubItems.Add(articulo.Categoria.PrecioPorDefecto.ToString());
                item.SubItems.Add(articulo.ExistenciasArticulo.ToString());

                listViewArticulos.Items.Add(item);
            }
            // Verifica que la lista de artículos en FormAltaArticulo esté actualizada
            Console.WriteLine($"Número de artículos en FormAltaArticulo: {ControladorArticulo.ObtenerArticulos().Count}");
        }
        // Método para actualizar la lista de artículos en FormAltaArticulo
        public void ActualizarListaArticulos()
        {
            // Limpiar la lista actual
            listViewArticulos.Items.Clear();

            // Volver a cargar la lista de artículos
            foreach (Articulo articulo in ControladorArticulo.ObtenerArticulos())
            {
                ListViewItem item = new ListViewItem(articulo.CodigoArticulo.ToString());
                item.SubItems.Add(articulo.NombreArticulo);
                item.SubItems.Add(articulo.Categoria.NombreCategoria);
                item.SubItems.Add(articulo.Categoria.PrecioPorDefecto.ToString());
                item.SubItems.Add(articulo.ExistenciasArticulo.ToString());

                listViewArticulos.Items.Add(item);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e) => Close();

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        protected void comboBoxSelectCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectCategoria.SelectedItem is Categoria categoria)
            {
                labelTotal.Text = $"{categoria.PrecioPorDefecto}€";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {         
            // Obtener la categoría seleccionada del comboBoxSelectCategoria
            Categoria categoria = comboBoxSelectCategoria.SelectedItem as Categoria;
            
            // Validar la categoría
            if (categoria == null || !Articulo.CategoriaValida(categoria))
            {
                MessageBox.Show("Categoría no válida. Las categorías válidas son: Colección Smartphones, Colección PCs Sobremesa, Colección PCs Portátiles.");
                return;
            }
            // Obtener el precio por defecto de la categoría
            decimal precioPorDefecto = categoria.PrecioPorDefecto;
            // Obtener los datos ingresados en el formulario

            string nombreArticulo = textBoxNombreArticulo.Text;         
            int existenciasArticulo = int.Parse(textBoxCantidad.Text);
           
            // Buscar un artículo existente con el mismo nombreArticulo
            Articulo articuloExistente = ControladorArticulo.ObtenerArticulos().FirstOrDefault(a => a.NombreArticulo == nombreArticulo && a.Categoria.Equals(categoria));

            if (articuloExistente != null)
            {
                // Si se encuentra un artículo con el mismo nombre, aumentar las existencias
                articuloExistente.ActualizarExistencias(existenciasArticulo);
                MessageBox.Show("Se han añadido nuevas existencias para el artículo existente.");

                //Recorre el ListView para encontrar la fila correspondiente al artículo y se actualiza la cantidad de existencias en esa fila.
                foreach (ListViewItem item in listViewArticulos.Items)
                {
                    if (item.SubItems[1].Text == nombreArticulo && item.SubItems[2].Text == categoria.NombreCategoria)
                    {
                        item.SubItems[4].Text = articuloExistente.ExistenciasArticulo.ToString();
                        break;
                    }
                }
            }
            else
            {
                // Crear un nuevo artículo con los datos ingresados
                Articulo articulo = new Articulo(nombreArticulo, categoria, precioPorDefecto, existenciasArticulo);

                // Mostrar el precio por defecto en el labelTotal
                labelTotal.Text = $"{precioPorDefecto}€";
                // Agregar una nueva fila al ListView para mostrar los detalles del nuevo artículo
                ListViewItem item = new ListViewItem(articulo.CodigoArticulo.ToString());
                item.SubItems.Add(articulo.NombreArticulo);
                item.SubItems.Add(articulo.Categoria.NombreCategoria);
                item.SubItems.Add(articulo.Categoria.PrecioPorDefecto.ToString());
                item.SubItems.Add(articulo.ExistenciasArticulo.ToString());

                listViewArticulos.Items.Add(item);
                ControladorArticulo.AgregarArticulo(articulo);

                MessageBox.Show("Artículo creado con éxito.");
                listViewArticulos.Refresh();
            }
            btnLimpiar_Click(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombreArticulo.Text = "Escriba aquí el Nombre del Nuevo Artículo ...";
            comboBoxSelectCategoria.Text = "Seleccione Articulo...";
            textBoxCantidad.Text = "Define la Nueva Cantidad Disponible ...";
            labelTotal.Text = "...";
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


