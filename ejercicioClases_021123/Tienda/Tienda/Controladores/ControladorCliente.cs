using System.Collections.Generic;

namespace Tienda.Controladores
{
    internal class ControladorCliente
    {
        public static List<Cliente> Clientes { get; set; } = new List<Cliente>();

        public static void AgregarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public static List<Cliente> ObtenerClientes()
        {
            return Clientes;
        }
    }
}
