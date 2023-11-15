using System;
using System.Windows.Forms;

namespace Tienda
{
    internal class Articulo
    {
        private static int codigoBase = 1; // Para llevar un seguimiento del código automáticamente generado
        private const int StockMinimo = 1; // Cantidad mínima en existencias para considerar en mínimos

        public int CodigoArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public string CategoriaArticulo { get; set; }
        public decimal PrecioArticulo { get; set; }
        public int ExistenciasArticulo { get; set; }

        public Articulo()
        {
            CodigoArticulo = codigoBase++;
        }

        public Articulo(string nombreArticulo, string categoriaArticulo, decimal precioArticulo, int existenciasArticulo)
        {
            CodigoArticulo = codigoBase++;
            NombreArticulo = nombreArticulo;
            CategoriaArticulo = categoriaArticulo;
            PrecioArticulo = precioArticulo;
            ExistenciasArticulo = existenciasArticulo;         
        }

        // Sobrescribir el método ToString para mostrar todos los datos del objeto
        public override string ToString()
        {
            return $"Código: {CodigoArticulo}, Nombre: {NombreArticulo}, Categoría: {CategoriaArticulo}, Precio: {PrecioArticulo:C}, Existencias: {ExistenciasArticulo}";
        }

        // Verifica si las existencias del artículo están por debajo del valor mínimo establecido (StockMinimo) y devuelve un valor booleano
        public bool EstaEnMinimos()
        {
            return ExistenciasArticulo < StockMinimo;
        }
        // Verifica si la categoría del artículo es una de las categorías válidas ("Colección PCs Sobremesa", "Colección PCs Portátiles", "Colección Smartpohnes").
        // Lo utilizaremos para validar las categorías durante la entrada de datos.
        public static bool CategoriaValida(string categoria)
        {
            return categoria.Equals("Colección PCs Sobremesa", StringComparison.OrdinalIgnoreCase) ||
                   categoria.Equals("Colección PCs Portátiles", StringComparison.OrdinalIgnoreCase) ||
                   categoria.Equals("Colección Smartpohnes", StringComparison.OrdinalIgnoreCase);
        }
    }
}
