using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulos_Clases_
{
    public class Articulo
    {
            // Propiedades de la clase
            public int CodigoArticulo { get; set; }
            public string NombreArticulo { get; set; }
            public string CategoriaArticulo { get; set; }
            public decimal PrecioArticulo { get; set; }
            public int ExistenciasArticulo { get; set; }

            // Constructor vacío
            public Articulo()
            {
                // Inicializa las propiedades con valores predeterminados
                CodigoArticulo = 0;
                NombreArticulo = "";
                CategoriaArticulo = "";
                PrecioArticulo = 0.0m;
                ExistenciasArticulo = 0;
            }

            // Constructor con argumentos para inicializar las propiedades
            public Articulo(int codigo, string nombre, string categoria, decimal precio, int existencias)
            {
                CodigoArticulo = codigo;
                NombreArticulo = nombre;
                CategoriaArticulo = categoria;
                PrecioArticulo = precio;
                ExistenciasArticulo = existencias;
            }
        }
    }

