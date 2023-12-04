using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tienda.Clases;
using Tienda.Controladores;


namespace Tienda
{
    public partial class FormDetallePedido : Form
    {

        double precio = 0;
        int cantidad = 0;
        private int codigoPedidoActual = 0;

        private List<Articulo> articulos = new List<Articulo>();
        private BindingSource bindingSourcePedidos = new BindingSource();
        
        //Lista interna donde irán almacenándose artículos añadidos en un mismo pedido
        private List<Articulo> articulosPedido = new List<Articulo>();

        private FormTipoPago formTipoPago;

        public FormDetallePedido()
        {
            InitializeComponent();
            timerHoraActual.Enabled = true;
            formTipoPago = new FormTipoPago();

            // Manejo de Errores de carga lista Categorías, Tipos de Pago y Articulos en comboBox al inicio.
            try
            {
                ControladorCategoria.InicializarCategorias();
                ControladorArticulo.ObtenerArticulos();
                ControladorTipoPago.ObtenerTipoPago();

                //CargarTiposPagoEnComboBox();
                CargarCategoriasEnComboBox();
                CargarComboBoxArticulos(articulos);
                //MessageBox.Show($"Número de categorías: {ControladorCategoria.ObtenerCategorias().Count}");
                var tiposDePago = ControladorTipoPago.ObtenerTipoPago();
                foreach (var tipo in tiposDePago)
                {
                    Console.WriteLine($"DEBUG: Tipo de pago: {tipo.NombreTipoPago}");
                }
            }
            catch (Exception ex)
            {
                // MessageBox aquí con el mensaje de error.
                // Console.WriteLine($"Error al inicializar categorías: {ex.Message}"); -- Salida Error por consola.

                MessageBox.Show($"Error al inicializar categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDetallePedido_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dddd, " + "dd \\de " + "MMMM \\de " + "yyyy").ToUpperInvariant();
            labelTotal.Text = Convert.ToString(precio + "€");

            List<Pedido> pedidos = ControladorPedido.ObtenerPedidos();

            // Configurar el evento CellContentClick
            DataGridViewPedidos.CellContentClick += dataGridViewPedidos_CellContentClick;
            // Establecer la fuente de datos del DataGridView
            bindingSourcePedidos.DataSource = pedidos;
            DataGridViewPedidos.DataSource = bindingSourcePedidos;
        }

        private void dataGridViewPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewPedidos.Rows[e.RowIndex];
                // Verificar si la celda en la que hiciste clic es una celda de botón
                if (e.ColumnIndex == DataGridViewPedidos.Columns["Consultar"].Index)
                {
                    // Obtener el artículo seleccionado
                    Pedido pedido = (Pedido)row.DataBoundItem;

                    FormConsultaPedidoRegistrado formConsultar = new FormConsultaPedidoRegistrado(pedido.CodigoPedido);
                    var result = formConsultar.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // Obtener los datos del formulario de consulta
                       // string nuevoNombre = formConsultar.NuevoNombre;
                       // Categoria nuevaCategoria = formConsultar.NuevaCategoria;
                       // decimal nuevoPrecio = formConsultar.NuevoPrecio;
                       // int nuevasExistencias = formConsultar.NuevasExistencias;

                        // Llamar al método de edición en el controlador
                        ControladorPedido.ObtenerPedidoPorCodigo(pedido.CodigoPedido);

                        // Actualizar la lista si es necesario
                        ActualizarListaPedidos();
                    }
                }
                else if (e.ColumnIndex == DataGridViewPedidos.Columns["Eliminar"].Index)
                {
                    // Obtener el artículo seleccionado
                    Articulo articulo = (Articulo)row.DataBoundItem;

                    MsgBoxEliminar msgBoxEliminar = new MsgBoxEliminar("question",
                        "Desea eliminar?\nSe eliminará de forma permanente");
                    msgBoxEliminar.ShowDialog();

                    if (msgBoxEliminar.DialogResult == DialogResult.OK)
                    {
                        // Eliminar el artículo
                        ControladorArticulo.EliminarArticulo(articulo);

                        // Actualizar la lista si es necesario
                        ActualizarListaPedidos();
                    }
                }
            }
        }

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // Método para obtener categorías únicas de la lista de artículos
        private void CargarCategoriasEnComboBox()
        {
            // Agrega un elemento por defecto
            comboBoxCategorias.Text = "Seleccione Categoría...";
            comboBoxArticulos.Text = "Seleccione Articulo...";

            List<Categoria> categorias = ControladorCategoria.ObtenerCategorias();

            if (categorias.Count > 0)
            {
                comboBoxCategorias.Items.AddRange(categorias.ToArray());

                // Selecciona el elemento por defecto
                // comboBoxCategorias.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No hay categorías disponibles.");
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxCategorias.Text = "Seleccione Categoría...";
            comboBoxArticulos.Text = "Seleccione Articulo...";
            //comboBoxSelecPago.Text = "Seleccione Tipo de Pago...";
            textBoxCantidad.Text = "...";
            labelTotal.Text = Convert.ToString(precio + "€");
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            textBoxCantidad.Clear();
        }
        private void CargarComboBoxArticulos(List<Articulo> articulos)
        {
            // Limpiar el ComboBox antes de cargar nuevos artículos
            comboBoxArticulos.Items.Clear();
            comboBoxArticulos.Text = "Seleccione Articulo...";
            comboBoxArticulos.Items.AddRange(articulos.ToArray());
            comboBoxArticulos.Refresh();
        }

        private void ComboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la categoría seleccionada del ComboBox
            Categoria categoriaSeleccionada = (Categoria)comboBoxCategorias.SelectedItem;

            /** Mensaje de depuración
            MessageBox.Show($"Categoría seleccionada: {categoriaSeleccionada.NombreCategoria}");*/
            Console.WriteLine($"Categoría seleccionada: {categoriaSeleccionada.NombreCategoria}");


            // Obtener la lista completa de artículos desde el controlador
            List<Articulo> listaArticulos = ControladorArticulo.ObtenerArticulosPorCategoria(categoriaSeleccionada);

            //Mensaje de depuración
            //MessageBox.Show($"Número total de artículos: {listaArticulos.Count}");
            Console.WriteLine($"Número total de artículos: {listaArticulos.Count}");


            if (listaArticulos.Count > 0)
            {
                // Limpiar y cargar el ComboBox de artículos con los artículos de la categoría seleccionada
                comboBoxArticulos.Items.Clear();
                CargarComboBoxArticulos(listaArticulos);
                comboBoxArticulos.Refresh();
            }
            else
            {
                MessageBox.Show("No existen artículos disponibles.");
            }

            // Refrescar el ComboBox de Artículos
            comboBoxArticulos.Refresh();
        }

        private void comboBoxSelecArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxArticulos.Text = "Seleccione Articulo...";
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado al menos un artículo y si se ha ingresado una cantidad
            if (comboBoxArticulos.SelectedIndex != -1 && !string.IsNullOrEmpty(textBoxCantidad.Text))
            {
                // Obtener el artículo seleccionado
                Articulo articuloSeleccionado = (Articulo)comboBoxArticulos.SelectedItem;

                // Obtener la cantidad especificada
                int cantidad = int.Parse(textBoxCantidad.Text);

                // Agregar el artículo seleccionado a la lista del pedido actual, multiplicando por la cantidad
                for (int i = 0; i < cantidad; i++)
                {
                    // articulosPedido.Add(articuloSeleccionado);
                    articulosPedido.Add(new Articulo(articuloSeleccionado));
                }

                // Calcular y mostrar el precio total provisional del pedido
                CalcularPrecioTotal();
                MessageBox.Show("Artículo añadido al pedido");
                // Limpiar los controles de entrada en el formulario
                // btnLimpiar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Seleccione al menos un artículo y especifique la cantidad para añadir al pedido.");
            }
        }
        private decimal CalcularPrecioTotal()
        {
            decimal precioTotal = 0;

            foreach (Articulo articulo in articulosPedido)
            {
                precioTotal += articulo.Categoria.PrecioPorDefecto;
            }

            // Mostrar el precio total provisional del pedido
            labelTotal.Text = precioTotal.ToString("C");

            return precioTotal;
        }
        private Pedido CrearPedido()
        {
            string tipoPagoSeleccionadoNombre;
            // Verificar si formTipoPago es null
            if (formTipoPago != null && formTipoPago.TipoPagoSeleccionado != null)
            {
                // Asegurarse de que TipoPagoSeleccionado no sea null antes de acceder a sus propiedades
                tipoPagoSeleccionadoNombre = formTipoPago.TipoPagoSeleccionado.Split('-')[0].Trim();

                if (!string.IsNullOrEmpty(tipoPagoSeleccionadoNombre))
                {
                    TipoPago tipoPagoSeleccionado = ControladorTipoPago.ObtenerTipoPago()
                    .FirstOrDefault(t => t.NombreTipoPago.Equals(tipoPagoSeleccionadoNombre, StringComparison.OrdinalIgnoreCase));


                    if (tipoPagoSeleccionado != null)
                    {
                        // Calcular el precio final del pedido según el tipo de pago
                        decimal precioFinal = CalcularPrecioFinal(tipoPagoSeleccionado);

                        Pedido nuevoPedido = new Pedido
                        {
                            CantidadArticulos = articulosPedido.Count,
                            //CodigoCliente = codigoCliente,
                            TipoPago = tipoPagoSeleccionado,
                            PrecioFinal = precioFinal
                        };

                        return nuevoPedido;
                    }
                    else
                    {
                        // Manejar el caso cuando tipoPagoSeleccionado es null
                        // Mostrar un mensaje de error o tomar alguna otra acción
                        Console.WriteLine("Error: tipoPagoSeleccionado es null.");
                        return null; // o retorna un objeto Pedido por defecto o manejarlo según la lógica
                    }
                }
                else
                {
                    // Manejar el caso cuando TipoPagoSeleccionado está vacío o es null
                    Console.WriteLine("Error: TipoPagoSeleccionado está vacío o es null.");
                    return null; // o manejar según la lógica
                }
            }
            else
            {
                // Manejar el caso cuando formTipoPago es null
                Console.WriteLine("Error: formTipoPago es null.");
                return null; // o manejar según la lógica
            }
        }
        private decimal CalcularPrecioFinal(TipoPago tipoPago)
        {
            // Calcular el precio final sumando los precios de todos los artículos en la lista
            decimal precioTotal = CalcularPrecioTotal();

            // Verificar si tipoPago no es null antes de acceder a la propiedad
            if (tipoPago != null)
            {
                // Aplicar el descuento o recargo según el tipo de pago
                precioTotal *= (1 + tipoPago.PorcentajeDescuentoRecargo);
            }
            else
            {
                // Manejar el caso en el que tipoPago es null
                MessageBox.Show("Error: tipoPago es null.");
            }
            return precioTotal;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos un artículo en el pedido
            if (articulosPedido.Count > 0)
            {
                // Declarar la variable del manejador del evento fuera del bloque para poder desconectarla
                EventHandler confirmarClickHandler = null;

                // Conectar el evento
                confirmarClickHandler = (s, _args) =>
                {
                    string tipoPagoSeleccionadoNombre = formTipoPago.TipoPagoSeleccionado.Split('-')[0].Trim();

                    Console.WriteLine($"DEBUG: Nombre seleccionado antes de la obtención: '{tipoPagoSeleccionadoNombre}'");

                    TipoPago tipoPagoSeleccionado = ControladorTipoPago.ObtenerTipoPago()
                        .FirstOrDefault(t => t.NombreTipoPago.Equals(tipoPagoSeleccionadoNombre, StringComparison.OrdinalIgnoreCase));

                    Console.WriteLine($"DEBUG: Tipo de pago seleccionado: '{tipoPagoSeleccionado?.NombreTipoPago ?? "null"}'");

                    if (tipoPagoSeleccionado != null)
                    {
                        // Crear el pedido
                        Pedido nuevoPedido = CrearPedido();

                        // Agregar el pedido a la lista interna de pedidos
                        ControladorPedido.AgregarPedido(nuevoPedido);

                        // Limpiar la lista interna de artículos después de registrar el pedido
                        //articulosPedido.Clear();
                        articulosPedido = new List<Articulo>();

                        // Mostrar el ListView con la nueva información
                        ActualizarListaPedidos();

                        // Limpiar los controles de entrada en el formulario
                        btnLimpiar_Click(sender, e);
                    }
                    else
                    {
                        var tiposDePago = ControladorTipoPago.ObtenerTipoPago();
                        foreach (var tipo in tiposDePago)
                        {
                            Console.WriteLine($"DEBUG: Tipo de pago: {tipo.NombreTipoPago}");
                        }

                        MessageBox.Show("Error: El tipo de pago seleccionado es null.");
                    }
                    // Desconectar el evento después de ejecutarse una vez
                    formTipoPago.ConfirmarClick -= confirmarClickHandler;
                };
                // Conectar el evento
                formTipoPago.ConfirmarClick += confirmarClickHandler;

                // Mostrar el formulario de tipo de pago
                formTipoPago.ShowDialog();
            }
            else
            {
                MessageBox.Show("Añada al menos un artículo al pedido antes de registrar.");
            }
        }
        private void FormDetallePedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Guardar los pedidos en un archivo al cerrar el formulario
            Console.WriteLine("Guardando pedidos en archivo...");
            ControladorPedido.GuardarPedidosEnArchivo();
            Console.WriteLine("Pedidos guardados en archivo.");
        }
        private void ActualizarListaPedidos()
        {
            if (DataGridViewPedidos.InvokeRequired)
            {
                // Utilizar Invoke para actualizar la interfaz de usuario desde el hilo principal
                DataGridViewPedidos.Invoke((MethodInvoker)delegate
                {
                    bindingSourcePedidos.ResetBindings(false);
                });
            }
            else
            {
                // Si ya estamos en el hilo principal, actualizar directamente
                bindingSourcePedidos.ResetBindings(false);
            }
        }
        private void btnInicio_Click(object sender, EventArgs e) => Close();
    }
}