namespace Tienda
{
    internal class Cliente
    {
        private int codCliente;

        public Cliente(int codCliente)
        {
            this.codCliente = codCliente;
        }

        public int CodCliente
        {
            get { return codCliente; }
            set { codCliente = value; }
        }
    }
}
