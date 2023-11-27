using System.Collections.Generic;
using System.Linq;

namespace Tienda.Controladores
{

    internal class ControladorArticulo
    {
        public static List<Articulo> Articulos { get; set; } = new List<Articulo>();

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
            List<string> categorias = Articulos.Select(a => a.Categoria.NombreCategoria).Distinct().ToList();
            return categorias;
        }

        public static List<Articulo> ObtenerArticulosPorCategoria(Categoria categoria)
        {
            return Articulos.Where(a => a.Categoria.Equals(categoria)).ToList();
        }
    }
}

