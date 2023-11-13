using System;

namespace Tienda.Clases
{
    internal class Pedido
    {
        public int NumeroPedido { get; private set; }
        public int CodigoArticulo { get; set; }
        public int CantidadPedido { get; set; }
        public DateTime FechaPedido { get; set; }

        public Pedido(int codigoArticulo, int cantidadPedido)
        {
            NumeroPedido = GenerarNumeroPedidoUnico();
            CodigoArticulo = codigoArticulo;
            CantidadPedido = cantidadPedido;
            FechaPedido = DateTime.Now;
        }

        private static int numeroPedidoBase = 1;

        private static int GenerarNumeroPedidoUnico()
        {
            return numeroPedidoBase++;
        }
    }
}
