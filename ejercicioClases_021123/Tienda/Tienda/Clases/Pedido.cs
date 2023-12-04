using System;
using System.Collections.Generic;

namespace Tienda.Clases
{
    internal class Pedido
    {
        private static int codigoPedidoBase = 1;
        public int CodigoPedido { get; set; }
        public int CantidadArticulos { get; set; }
        public Cliente Cliente { get; set; }
        public TipoPago TipoPago { get; set; }
        public decimal PrecioFinal { get; set; }


        public Pedido()
        {
            CodigoPedido = codigoPedidoBase++;
        }

        public override bool Equals(object obj)
        {
            return obj is Pedido pedido &&
                   CodigoPedido == pedido.CodigoPedido &&
                   CantidadArticulos == pedido.CantidadArticulos &&
                   EqualityComparer<Cliente>.Default.Equals(Cliente, pedido.Cliente);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CodigoPedido, CantidadArticulos, Cliente);
        }
    }
}

