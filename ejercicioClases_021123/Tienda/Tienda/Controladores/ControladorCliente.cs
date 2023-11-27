using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
