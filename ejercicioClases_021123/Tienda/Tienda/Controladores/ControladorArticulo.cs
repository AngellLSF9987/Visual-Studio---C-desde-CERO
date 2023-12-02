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

        public static void EditarArticulo(Articulo articuloExistente, string nuevoNombre, Categoria nuevaCategoria, decimal nuevoPrecio, int nuevasExistencias)
        {
            // Verificar si el artículo existe en la lista
            if (Articulos.Contains(articuloExistente))
            {
                // Actualizar las propiedades del artículo
                articuloExistente.NombreArticulo = nuevoNombre;
                articuloExistente.Categoria = nuevaCategoria;
                articuloExistente.PrecioArticulo = nuevoPrecio;
                articuloExistente.ExistenciasArticulo = nuevasExistencias;
            }
        }

        public static void EliminarArticulo(Articulo articulo)
        {
            Articulos.Remove(articulo);
        }
    }
}

