using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Controladores
{
   
    internal class ControladorArticulo
    {
        public static List<Articulo> Articulos { get; } = new List<Articulo>();

        public static void AgregarArticulo(Articulo articulo)
        {
            Articulos.Add(articulo);
        }

        public static List<Articulo> ObtenerArticulos()
        {
            return Articulos;
        }
    }
}
