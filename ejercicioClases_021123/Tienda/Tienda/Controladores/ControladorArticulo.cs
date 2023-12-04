using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

        public static Articulo ObtenerArticuloPorCodigo(int codigo)
        {
            return Articulos.FirstOrDefault(a => a.CodigoArticulo == codigo);
        }

        public static int ObtenerCodigoArticuloSeleccionado(DataGridView dataGridView)
        {
            // Obtener la fila seleccionada en el DataGridView
            DataGridViewRow selectedRow = dataGridView.SelectedRows.Count > 0 ? dataGridView.SelectedRows[0] : null;

            if (selectedRow != null && selectedRow.DataBoundItem is Articulo articuloSeleccionado)
            {
                // Retorna el código del artículo seleccionado
                return articuloSeleccionado.CodigoArticulo;
            }

            // Retorna 0 si no se pudo obtener el código
            return 0;
        }
/**
        public static int ObtenerCodigoArticuloSeleccionado(DataGridView dataGridView)
        {
            // Verificar si se ha seleccionado alguna fila en el DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obtener el valor de la celda correspondiente al código del artículo (columna 0)
                string codigoStr = dataGridView.SelectedRows[0].Cells[0].Value.ToString();

                // Intentar convertir el valor a entero
                if (int.TryParse(codigoStr, out int codigo))
                {
                    return codigo;
                }
            }

            // Devolver un valor predeterminado (puedes ajustarlo según tus necesidades)
            return -1;
        }
*/
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

