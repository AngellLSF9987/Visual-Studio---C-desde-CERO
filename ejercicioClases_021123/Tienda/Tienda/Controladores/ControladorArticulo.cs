using System.Collections.Generic;

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

        public static List<string> ObtenerCategorias()
        {
            return Articulos.Select(a => a.CategoriaArticulo).Distinct().ToList();
        }
    }
}
