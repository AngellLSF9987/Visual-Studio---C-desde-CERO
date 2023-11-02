using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Articulos_Clases_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private List<Articulo> listaArticulos = new List<Articulo>();
        private List<Pedido> listaPedidos = new List<Pedido>();

        // Agregar un nuevo artículo
        private void AgregarArticulo(Articulo articulo)
        {
            articulo.CodigoArticulo = listaArticulos.Count + 1;
            listaArticulos.Add(articulo);
        }

        // Actualizar un artículo existente
        private void ActualizarArticulo(Articulo articulo)
        {
            var articuloExistente = listaArticulos.FirstOrDefault(a => a.CodigoArticulo == articulo.CodigoArticulo);
            if (articuloExistente != null)
            {
                articuloExistente.NombreArticulo = articulo.NombreArticulo;
                articuloExistente.PrecioArticulo = articulo.PrecioArticulo;
            }
        }

        // Eliminar un artículo
        private void EliminarArticulo(int codigoArticulo)
        {
            listaArticulos.RemoveAll(a => a.CodigoArticulo == codigoArticulo);
        }

        // Agregar un nuevo pedido
        private void AgregarPedido(Pedido pedido)
        {
            pedido.ID = listaPedidos.Count + 1;
            listaPedidos.Add(pedido);
        }

        // Actualizar un pedido existente
        private void ActualizarPedido(Pedido pedido)
        {
            var pedidoExistente = listaPedidos.FirstOrDefault(p => p.ID == pedido.ID);
            if (pedidoExistente != null)
            {
                pedidoExistente.Cliente = pedido.Cliente;
                pedidoExistente.Articulos = pedido.Articulos;
            }
        }

        // Eliminar un pedido
        private void EliminarPedido(int id)
        {
            listaPedidos.RemoveAll(p => p.ID == id);
        }
    }
}
