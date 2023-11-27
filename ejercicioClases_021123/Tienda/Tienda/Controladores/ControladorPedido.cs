using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Tienda.Clases;

namespace Tienda.Controladores
{
    internal class ControladorPedido
    {
        private static List<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public static void AgregarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }

        public static List<Pedido> ObtenerPedidos()
        {
            return Pedidos;
        }

        public static Pedido ObtenerPedidoPorCodigo(int codigoPedido)
        {
            return Pedidos.FirstOrDefault(p => p.CodigoPedido == codigoPedido);
        }

        // Obtener el TipoPago de un pedido
        public static TipoPago ObtenerTipoPagoParaPedido(int codigoPedido)
        {
            Pedido pedido = ObtenerPedidoPorCodigo(codigoPedido);
            if (pedido != null)
            {
                // Aquí puedes ajustar cómo obtienes el TipoPago según la relación entre Pedido y TipoPago
                // Puedes asumir que cada Pedido tiene un TipoPago, o puedes hacer una búsqueda más compleja
                // según tu modelo de datos
                return pedido.TipoPago;
            }
            return null; // o manejar el escenario donde el pedido no existe
        }

        private static string ObtenerRutaArchivoPedidos()
        {
            // Obtener la ruta al directorio de datos de la aplicación en la carpeta AppData
            string directorioDatos = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tienda/Tienda");

            // Combinar la ruta con el nombre del archivo de pedidos
            string archivoPedidos = Path.Combine(directorioDatos, "pedidos.dat");

            // Asegurarse de que el directorio exista
            if (!Directory.Exists(directorioDatos))
            {
                Directory.CreateDirectory(directorioDatos);
            }

            return archivoPedidos;
        }
        public static void CargarPedidosDesdeArchivo()
        {
            // Obtener la ruta del archivo de pedidos
            string pedidosDat = ObtenerRutaArchivoPedidos();

            // Cargar la lista de pedidos desde un archivo
            if (File.Exists(pedidosDat))
            {
                string jsonPedidos = File.ReadAllText(pedidosDat);
                Pedidos = JsonConvert.DeserializeObject<List<Pedido>>(jsonPedidos);
            }
            else
            {
                Pedidos = new List<Pedido>();
            }
        }
        public static void GuardarPedidosEnArchivo()
        {
            // Serializar y guardar la lista de pedidos en un archivo
            string jsonPedidos = JsonConvert.SerializeObject(Pedidos);

            // Obtener la ruta del archivo de pedidos
            string nombreArchivo = ObtenerRutaArchivoPedidos();

            File.WriteAllText(nombreArchivo, jsonPedidos);
        }       
    }
}




