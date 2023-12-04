using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tienda.Controladores;

namespace Tienda
{
    public partial class FormAltaArticulo : Form
    {
        private List<Categoria> Categorias = new List<Categoria>();
        private BindingSource bindingSourceArticulos = new BindingSource();
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

        private void dataGridViewArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que se hizo clic en una fila válida
            {
                DataGridViewRow row = DataGridViewArticulos.Rows[e.RowIndex];
                // Obtener el código del artículo seleccionado
                int codigoArticulo = ControladorArticulo.ObtenerCodigoArticuloSeleccionado(DataGridViewArticulos);

                // Llamar al método de obtener artículo por código con el código obtenido
                Articulo articulo = ControladorArticulo.ObtenerArticuloPorCodigo(codigoArticulo);

                // Declarar variables fuera del bloque if
                string nuevoNombre = string.Empty;
                Categoria nuevaCategoria = null;
                decimal nuevoPrecio = 0;
                int nuevasExistencias = 0;

                if (e.ColumnIndex == DataGridViewArticulos.Columns["Editar"].Index)
                {
                    FormEditarArticulo formEditar = new FormEditarArticulo(articulo);
                    var result = formEditar.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // Obtener los nuevos datos del formulario de edición
                        nuevoNombre = formEditar.NuevoNombre;
                        nuevaCategoria = formEditar.NuevaCategoria;
                        nuevoPrecio = formEditar.NuevoPrecio;
                        nuevasExistencias = formEditar.NuevasExistencias;

                        // Llamar al método de edición en el controlador
                        ControladorArticulo.EditarArticulo(articulo, nuevoNombre, nuevaCategoria, nuevoPrecio, nuevasExistencias);

                        // Actualizar la lista si es necesario
                        ActualizarListaArticulos();
                    }
                }
                else if (e.ColumnIndex == DataGridViewArticulos.Columns["Eliminar"].Index)
                {
                    // Obtener el artículo seleccionado
                    Articulo articuloSeleccionado = (Articulo)row.DataBoundItem;

                    MsgBoxEliminar msgBoxEliminar = new MsgBoxEliminar("question",
                        "Desea eliminar?\nSe eliminará de forma permanente");
                    msgBoxEliminar.ShowDialog();

                    if (msgBoxEliminar.DialogResult == DialogResult.OK)
                    {
                        // Eliminar el artículo
                        ControladorArticulo.EliminarArticulo(articuloSeleccionado);

                        // Actualizar la lista si es necesario
                        ActualizarListaArticulos();
                    }
                }
            }
        }
        private void DataGridViewResultados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Establecer el formato de las celdas de imagen (Editar y Eliminar)
            if (e.ColumnIndex == DataGridViewArticulos.Columns["Editar"].Index ||
                e.ColumnIndex == DataGridViewArticulos.Columns["Eliminar"].Index)
            {
                e.Value = new Bitmap((Image)e.Value, new Size(24, 24));
            }
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

            // Inicializar la lista de artículos
            List<Articulo> articulos = ControladorArticulo.ObtenerArticulos();

            // Verifica que la lista de artículos en FormAltaArticulo esté actualizada
            Console.WriteLine($"Número de artículos en FormAltaArticulo: {ControladorArticulo.ObtenerArticulos().Count}");

            // Configurar el evento CellContentClick
            DataGridViewArticulos.CellContentClick += dataGridViewArticulos_CellContentClick;
            DataGridViewArticulos.CellFormatting += DataGridViewResultados_CellFormatting;
            // Establecer la fuente de datos del DataGridView
            bindingSourceArticulos.DataSource = articulos;
            DataGridViewArticulos.DataSource = bindingSourceArticulos;
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
            try
            {
                // Obtener la categoría seleccionada del comboBoxSelectCategoria
                Categoria categoria = comboBoxSelectCategoria.SelectedItem as Categoria;

                // Validar la categoría
                if (categoria == null || categoria.NombreCategoria == null || !Articulo.CategoriaValida(categoria))
                {
                    MessageBox.Show("Categoría no válida. Las categorías válidas son: Colección Smartphones, Colección PCs Sobremesa, Colección PCs Portátiles.");
                    return;
                }

                // Asegurarse de que la propiedad Categoria no sea null
                if (categoria.NombreCategoria == null)
                {
                    MessageBox.Show("La categoría del artículo no está definida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar la conversión de la cantidad a int
                if (!int.TryParse(textBoxCantidad.Text, out int existenciasArticulo))
                {
                    MessageBox.Show("La cantidad ingresada no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                existenciasArticulo = int.Parse(textBoxCantidad.Text);

                // Obtener el precio por defecto de la categoría
                decimal precioPorDefecto = categoria.PrecioPorDefecto;
                // Obtener los datos ingresados en el formulario

                string nombreArticulo = textBoxNombreArticulo.Text;

                // Validar el nombre del artículo
                if (string.IsNullOrWhiteSpace(nombreArticulo) || nombreArticulo == "Escriba aquí el Nombre del Nuevo Artículo ...")
                {
                    MessageBox.Show("Por favor, ingrese un nombre de artículo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Buscar un artículo existente con el mismo nombreArticulo
                Articulo articuloExistente = ControladorArticulo.ObtenerArticulos().FirstOrDefault(a => a.NombreArticulo == nombreArticulo && a.Categoria.Equals(categoria));

                /** Verificaciones InvokeRequired para asegurarme de que las operaciones que interactúan 
                 * con la interfaz de usuario se realicen en el hilo principal. 
                 */

                if (articuloExistente != null)
                {
                    // Si se encuentra un artículo con el mismo nombre, aumentar las existencias
                    articuloExistente.ActualizarExistencias(existenciasArticulo);
                    MessageBox.Show("Se han añadido nuevas existencias para el artículo existente.");

                    ActualizarListaArticulos();
                }
                else
                {
                    // Crear un nuevo artículo con los datos ingresados
                    Articulo articulo = new Articulo(nombreArticulo, categoria, precioPorDefecto, existenciasArticulo);

                    // Mostrar el precio por defecto en el labelTotal
                    labelTotal.Text = $"{precioPorDefecto}€";

                    // Agregar el nuevo artículo a la lista de artículos
                    ControladorArticulo.AgregarArticulo(articulo);

                    // bindingSourceArticulos.Add(articulo);
                    ActualizarListaArticulos();

                    MessageBox.Show("Artículo creado con éxito.");
                }
                btnLimpiar_Click(sender, e);
            }
            catch
            {
                // Manejo de excepciones
                MessageBox.Show($"Se ha producido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para actualizar la lista de artículos en FormAltaArticulo
        public void ActualizarListaArticulos()
        {
            if (DataGridViewArticulos.InvokeRequired)
            {
                // Utilizar Invoke para actualizar la interfaz de usuario desde el hilo principal
                DataGridViewArticulos.Invoke((MethodInvoker)delegate
                {
                    bindingSourceArticulos.ResetBindings(false);
                });
            }
            else
            {
                // Si ya estamos en el hilo principal, actualizar directamente
                bindingSourceArticulos.ResetBindings(false);
            }
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


