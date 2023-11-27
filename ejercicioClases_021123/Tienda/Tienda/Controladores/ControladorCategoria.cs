using System.Collections.Generic;
using System.Linq;

namespace Tienda.Controladores
{
    internal class ControladorCategoria
    {
        private static List<Categoria> Categorias { get; set; } = new List<Categoria>();

        public static void AgregarCategoria(Categoria categoria)
        {
            Categorias.Add(categoria);
        }

        public static List<Categoria> ObtenerCategorias()
        {
            return Categorias;
        }

        public static List<string> ObtenerNombresCategorias()
        {
            return Categorias.Select(c => c.NombreCategoria).ToList();
        }

        public static void InicializarCategorias()
        {
            Categorias = new List<Categoria>
        {
                new Categoria(1, "Colección PCs Sobremesa", 500),
                new Categoria(2, "Colección PCs Portátiles", 700),
                new Categoria(3, "Colección Smartphones", 250)
            };
        }
    }
}


