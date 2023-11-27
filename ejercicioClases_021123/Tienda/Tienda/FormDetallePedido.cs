using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tienda.Clases;
using Tienda.Controladores;
using Tienda.Utilidades_Extensiones;

namespace Tienda
{
    public partial class FormDetallePedido : Form
    {

        double precio = 0;
        int cantidad = 0;
        private int codigoPedidoActual = 0;

        private List<Articulo> articulos = new List<Articulo>();
        private List<Pedido> pedidos = new List<Pedido>();

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

            // Deshabilitar el modo virtual
            listViewPedidos.VirtualMode = false;

            // Configurar el evento RetrieveVirtualItem
            listViewPedidos.VirtualMode = true;
            listViewPedidos.RetrieveVirtualItem += listViewPedidos_RetrieveVirtualItem;

            // Actualizar el ListView con la nueva información
            ActualizarListViewPedidos();

            //
            /** Añadir las columnas necesarias
            listViewPedidos.Columns.Add("Acciones", 105);
            listViewPedidos.Columns.Add("Cod. Pedido", 105);
            listViewPedidos.Columns.Add("Uds./Pedido", 120);
            listViewPedidos.Columns.Add("Cod. Cliente", 105);
            listViewPedidos.Columns.Add("Tipo de Pago", 280);
            listViewPedidos.Columns.Add("Descuento o Recargo Aplicable - Tipo de Pago", 310);
            listViewPedidos.Columns.Add("Precio Final / PVP .€", 142);
            */
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
        private void CalcularPrecioTotal()
        {
            // Verificar si hay artículos en el pedido
            if (articulosPedido.Count > 0)
            {
                // Calcular el precio total sin aplicar descuento o recargo
                decimal precioTotalSinDescuentoRecargo = CalcularPrecioTotalSinDescuentoRecargo(articulosPedido);

                // Mostrar el precio total sin descuento o recargo en el label
                labelTotal.Text = precioTotalSinDescuentoRecargo.ToString("C");
            }
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
                        decimal precioFinal = CalcularPrecioFinal(articulosPedido, tipoPagoSeleccionado);

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
        private decimal CalcularPrecioTotalSinDescuentoRecargo(List<Articulo> articulos)
        {
            decimal precioTotal = 0;

            foreach (Articulo articulo in articulos)
            {
                precioTotal += articulo.Categoria.PrecioPorDefecto;
            }

            return precioTotal;
        }
        private decimal CalcularPrecioFinal(List<Articulo> articulos, TipoPago tipoPago)
        {
            decimal precioTotal = 0;

            foreach (Articulo articulo in articulos)
            {
                precioTotal += articulo.Categoria.PrecioPorDefecto;
            }
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
                        ActualizarListViewPedidos();

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
        private void listViewPedidos_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            // Verificar si el índice está dentro del rango
            if (e.ItemIndex >= 0 && e.ItemIndex < ControladorPedido.ObtenerPedidos().Count)
            {
                // Obtener el pedido correspondiente al índice
                Pedido nuevoPedido = ControladorPedido.ObtenerPedidos()[e.ItemIndex];

                // Crear el ListViewItem con los detalles del pedido
                ListViewItem pedidoItem = new ListViewItem("Acciones");
                pedidoItem.SubItems.Add(nuevoPedido.CodigoPedido.ToString());
                pedidoItem.SubItems.Add(nuevoPedido.CantidadArticulos.ToString()); // Número de artículos en el pedido
                pedidoItem.SubItems.Add("CodigoCliente"); // Reemplaza "CódigoCliente" con el código real
                pedidoItem.SubItems.Add(nuevoPedido.TipoPago.NombreTipoPago); // Tipo de pago  
                pedidoItem.SubItems.Add(nuevoPedido.TipoPago?.PorcentajeDescuentoRecargo.ToString() ?? "0"); // Obtén el descuento según tu lógica
                pedidoItem.SubItems.Add(nuevoPedido.PrecioFinal.ToString("C")); // Precio final del pedido en formato de moneda


                e.Item = pedidoItem; // Asignar el ListViewItem al ítem virtual
            }
        }
        private void FormDetallePedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Guardar los pedidos en un archivo al cerrar el formulario
            Console.WriteLine("Guardando pedidos en archivo...");
            ControladorPedido.GuardarPedidosEnArchivo();
            Console.WriteLine("Pedidos guardados en archivo.");
        }
        private void ActualizarListViewPedidos()
        {
            // Desactivar el modo virtual
            listViewPedidos.VirtualMode = false;

            // Limpiar la lista
            listViewPedidos.Items.Clear();

            // Verifica si hay datos en la lista de pedidos
            Console.WriteLine($"Número total de pedidos: {ControladorPedido.ObtenerPedidos().Count}");

            /** Agregar elementos al ListView
            foreach (Pedido pedido in ControladorPedido.ObtenerPedidos())
            {
                ListViewItem pedidoItem = new ListViewItem("Acciones");
                pedidoItem.SubItems.Add(pedido.CodigoPedido.ToString());
                pedidoItem.SubItems.Add(pedido.CantidadArticulos.ToString());
                pedidoItem.SubItems.Add("CódigoCliente"); // Reemplaza con el código real si es necesario
                pedidoItem.SubItems.Add(pedido.TipoPago.NombreTipoPago);
                pedidoItem.SubItems.Add(pedido.TipoPago?.PorcentajeDescuentoRecargo.ToString() ?? "0");
                pedidoItem.SubItems.Add(pedido.PrecioFinal.ToString("C"));

                listViewPedidos.Items.Add(pedidoItem);
            }
            */
            // Actualizar el tamaño virtual
            listViewPedidos.VirtualListSize = ControladorPedido.ObtenerPedidos().Count;

            // Volver a habilitar el modo virtual si es necesario
            listViewPedidos.VirtualMode = true;

            // Redibujar los elementos del ListView
            // listViewPedidos.RedrawItems(0, listViewPedidos.Items.Count - 1, true);

            // Forzar un repintado del ListView
            listViewPedidos.Refresh();

        }
        private void AbrirFormularioConsulta(int codigoPedido)
        {
            // Obtener el código de pedido desde la fila seleccionada
            //int codigoPedido = int.Parse(item.SubItems[1].Text);  // Suponiendo que el código de pedido está en la segunda columna

            // Abrir el formulario de consulta con el código de pedido
            FormConsultaPedidoRegistrado formConsulta = new FormConsultaPedidoRegistrado(codigoPedido);

            formConsulta.ShowDialog();
        }
        private void BorrarPedido(int codigoPedido)
        {
            // Lógica para borrar el pedido según el código de pedido
            // Puedes implementar la lógica para borrar el pedido o simplemente marcarlo como borrado
            MessageBox.Show($"Borrar pedido {codigoPedido}");
            // También puedes actualizar tu lista interna de pedidos o base de datos según sea necesario
            // ControladorPedido.BorrarPedido(codigoPedido);
            // Actualizar la interfaz
            // ActualizarListViewPedidos();
        }
        private void btnInicio_Click(object sender, EventArgs e) => Close();
    }
}