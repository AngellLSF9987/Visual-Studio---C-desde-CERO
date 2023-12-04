using System;
using System.Windows.Forms;

namespace Tienda
{
    public class Articulo
    {
        private static int codigoBase = 1; // Para llevar un seguimiento del código automáticamente generado
        private const int StockMinimo = 10; // Cantidad mínima en existencias para considerar en mínimos

        public int CodigoArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public Categoria Categoria { get; set; }
        public decimal PrecioArticulo { get; set; }
        public int ExistenciasArticulo { get; set; }

        public Articulo()
        {
            CodigoArticulo = codigoBase++;
        }

        public Articulo(string nombreArticulo, Categoria categoria, decimal precioArticulo, int existenciasArticulo)
        {
            CodigoArticulo = codigoBase++;
            NombreArticulo = nombreArticulo;
            Categoria = categoria;
            PrecioArticulo = precioArticulo;
            ExistenciasArticulo = 20;
        }

        // Constructor de copia
        public Articulo(Articulo original)
        {
            // Copiar propiedades
            this.CodigoArticulo = original.CodigoArticulo;
            this.NombreArticulo = original.NombreArticulo;
            this.Categoria = original.Categoria;
            this.PrecioArticulo = original.PrecioArticulo;
            this.ExistenciasArticulo = original.ExistenciasArticulo;
        }

        public void ActualizarExistencias(int incremento)
        {
            if (incremento > 0)
            {
                this.ExistenciasArticulo += incremento;
            }
            else
            {
                throw new ArgumentException("La cantidad no ha sido indicada");
            }
        }

        public void ControlExistencias(int cantidadPedido)
        {
            if (cantidadPedido <= ExistenciasArticulo)
            {
                ExistenciasArticulo -= cantidadPedido;
                decimal importePedido = cantidadPedido * PrecioArticulo;
                MessageBox.Show($"Pedido realizado: {cantidadPedido} unidades, Importe: {importePedido:C}, Existencias restantes: {ExistenciasArticulo}");
            }
            else
            {
                MessageBox.Show($"No hay suficientes existencias. Existencias actuales: {ExistenciasArticulo}");
            }

        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Articulo otroArticulo = (Articulo)obj;

            return CodigoArticulo == otroArticulo.CodigoArticulo &&
                    NombreArticulo == otroArticulo.NombreArticulo &&
                    Categoria.Equals(otroArticulo.Categoria) &&
                    PrecioArticulo == otroArticulo.PrecioArticulo &&
                    ExistenciasArticulo == otroArticulo.ExistenciasArticulo;
        }

        // Garantizar la coherencia en el uso de la clase en colecciones basadas en hash.
        public override int GetHashCode()
        {
            return CodigoArticulo.GetHashCode() ^ Categoria.GetHashCode();
        }

        // Sobrescribir el método ToString para mostrar todos los datos del objeto
        public override string ToString()
        {
            return $"{NombreArticulo}, Existencias: {ExistenciasArticulo}";
        }

        // Verifica si las existencias del artículo están por debajo del valor mínimo establecido (StockMinimo) y devuelve un valor booleano
        public bool EstaEnMinimos()
        {
            return ExistenciasArticulo < StockMinimo;
        }
        // Verifica si la categoría del artículo es una de las categorías válidas ("Colección PCs Sobremesa", "Colección PCs Portátiles", "Colección Smartpohnes").
        // Lo utilizaremos para validar las categorías durante la entrada de datos.
        public static bool CategoriaValida(Categoria categoria)
        {
            // Validar si el nombre de la categoría es válido
            return categoria != null &&
                (categoria.NombreCategoria.Equals("Colección PCs Sobremesa", StringComparison.OrdinalIgnoreCase) ||
                 categoria.NombreCategoria.Equals("Colección PCs Portátiles", StringComparison.OrdinalIgnoreCase) ||
                 categoria.NombreCategoria.Equals("Colección Smartphones", StringComparison.OrdinalIgnoreCase));
        }
    }
}
