using System;

namespace Tienda
{
    internal class Cliente
    {
        private int codCliente;
        private string NombreCliente;

        public Cliente(int codCliente, string nombreCliente)
        {
            this.codCliente = codCliente;
            NombreCliente = nombreCliente;
        }

        public int CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   codCliente == cliente.codCliente &&
                   NombreCliente == cliente.NombreCliente;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(codCliente, NombreCliente);
        }

        public override string ToString()
        {
            return $"{NombreCliente}";
        }
    }
}
