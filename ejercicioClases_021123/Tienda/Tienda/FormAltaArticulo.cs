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

            // Verifica que la lista de artículos en FormAltaArticulo esté actualizada
            Console.WriteLine($"Número de artículos en FormAltaArticulo: {ControladorArticulo.ObtenerArticulos().Count}");

            dataGridViewArticulos.CellFormatting += dataGridViewArticulos_CellFormatting;

            // Configurar las columnas solo si no se han configurado previamente
            if (dataGridViewArticulos.Columns.Count == 0)
            {
                DataGridViewTextBoxColumn codigoColumn = new DataGridViewTextBoxColumn();
                codigoColumn.DataPropertyName = "CodigoArticulo";
                codigoColumn.HeaderText = "IdArtículo";
                dataGridViewArticulos.Columns.Add(codigoColumn);

                DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
                nombreColumn.DataPropertyName = "NombreArticulo";
                nombreColumn.HeaderText = "Nombre";
                dataGridViewArticulos.Columns.Add(nombreColumn);

                DataGridViewTextBoxColumn categoriaColumn = new DataGridViewTextBoxColumn();
                categoriaColumn.DataPropertyName = "Categoria";
                categoriaColumn.HeaderText = "Categoria";
                dataGridViewArticulos.Columns.Add(categoriaColumn);

                DataGridViewTextBoxColumn precioColumn = new DataGridViewTextBoxColumn();
                precioColumn.DataPropertyName = "PrecioArticulo";
                precioColumn.HeaderText = "PVP Ud./€";
                dataGridViewArticulos.Columns.Add(precioColumn);

                DataGridViewTextBoxColumn existenciasColumn = new DataGridViewTextBoxColumn();
                existenciasColumn.DataPropertyName = "ExistenciasArticulo";
                existenciasColumn.HeaderText = "Stock Disponible";
                dataGridViewArticulos.Columns.Add(existenciasColumn);

                DataGridTextBoxColumn editarColumn = new DataGridTextBoxColumn();
                editarColumn.HeaderText = "Editar";
                editarColumn.Alignment = HorizontalAlignment.Center;

                DataGridTextBoxColumn eliminarColumn = new DataGridTextBoxColumn();
                eliminarColumn.HeaderText = "Eliminar";
                eliminarColumn.Alignment = HorizontalAlignment.Center;

                // Configurar el evento CellContentClick
                dataGridViewArticulos.CellContentClick += dataGridViewArticulos_CellContentClick;

                // Establecer la fuente de datos del DataGridView
                bindingSourceArticulos.DataSource = ControladorArticulo.ObtenerArticulos();
                dataGridViewArticulos.DataSource = bindingSourceArticulos;

                dataGridViewArticulos.AutoResizeColumns();
                dataGridViewArticulos.AutoResizeRows();
            }
            // Imprimir los nombres de las columnas en la consola
            foreach (DataGridViewColumn column in dataGridViewArticulos.Columns)
            {
                Console.WriteLine($"Nombre de la columna: {column.Name}");
                Console.WriteLine($"Tipo de Celda: {column.CellType}");
                Console.WriteLine($"Tipo de Valor: {column.ValueType}");
                Console.WriteLine($"Índice de Columna: {column.Index}");
                Console.WriteLine($"Índice de Visualización: {column.DisplayIndex}");
                Console.WriteLine($"Ancho de Columna: {column.Width}");
                Console.WriteLine($"ReadOnly: {column.ReadOnly}");
                Console.WriteLine($"Visible: {column.Visible}");
                Console.WriteLine($"=====================");
            }
        }
        int Id;
        private void dataGridViewArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = "Categoria"; // La variable debe coincidir con el nombre correcto de la columna
            if (dataGridViewArticulos.Columns.Contains(columnName) && e.RowIndex >= 0)
            {
                if (dataGridViewArticulos.Rows[e.RowIndex].DataBoundItem is Articulo articulo)
                {
                    e.Value = articulo.Categoria.NombreCategoria;
                    e.FormattingApplied = true;
                }
            }
        }
        private void dataGridViewArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la celda en la que hiciste clic es una celda de botón
            if (dataGridViewArticulos.Columns[e.ColumnIndex].Name == "Editar")
            {
                // Obtener el artículo seleccionado
                Articulo articulo = (Articulo)dataGridViewArticulos.Rows[e.RowIndex].DataBoundItem;

                FormEditarArticulo formEditar = new FormEditarArticulo(articulo);
                var result = formEditar.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Actualizar la lista si es necesario
                    ActualizarListaArticulos();
                }
            }
            if (dataGridViewArticulos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                // Obtener el artículo seleccionado
                Articulo articulo = (Articulo)dataGridViewArticulos.Rows[e.RowIndex].DataBoundItem;

                MessageBox.Show("Se eliminará de forma permanente");

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un artículo antes de intentar editarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No se encontró la columna 'Acciones'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Método para actualizar la lista de artículos en FormAltaArticulo
        public void ActualizarListaArticulos()
        {
            // Actualizar la fuente de datos del DataGridView en el hilo principal
            this.BeginInvoke((MethodInvoker)delegate
            {
                bindingSourceArticulos.DataSource = ControladorArticulo.ObtenerArticulos();
                dataGridViewArticulos.Refresh();

                // Recorrer las filas del DataGridView y asignar el botón "Editar"
                foreach (DataGridViewRow row in dataGridViewArticulos.Rows)
                {
                    if (row.DataBoundItem is Articulo articulo)
                    {
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)row.Cells["Acciones"];
                        buttonCell.Value = "Editar";
                    }
                }
            });
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

            // Asegurarse de que la propiedad Categoria no sea null
            if (categoria.NombreCategoria == null)
            {
                MessageBox.Show("La categoría del artículo no está definida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Recorrer las filas del DataGridView y actualizar la cantidad de existencias en esa fila.
                foreach (DataGridViewRow row in dataGridViewArticulos.Rows)
                {
                    if (row.DataBoundItem is Articulo articulo && articulo == articuloExistente)
                    {
                        row.Cells["Existencias"].Value = articuloExistente.ExistenciasArticulo;
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

                // Agregar el nuevo artículo a la lista de artículos
                ControladorArticulo.AgregarArticulo(articulo);

                // Agregar el nuevo artículo a la fuente de datos en el hilo principal
                this.BeginInvoke((MethodInvoker)delegate
                {
                    bindingSourceArticulos.Add(articulo);
                });

                // Actualizar la vista del DataGridView en el hilo principal
                this.BeginInvoke((MethodInvoker)delegate
                {
                    ActualizarListaArticulos();
                });

                MessageBox.Show("Artículo creado con éxito.");
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


