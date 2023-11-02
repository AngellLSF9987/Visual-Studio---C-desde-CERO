using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulos_Clases_
{
    public class ControladorArticulos
    {
        private List<Articulo> listadoArticulo;

        public void ControladorArticulo()
        {
            listadoArticulo = new List<Articulo>();
        }
        public void añadirArticulo(Articulo articulo)
        {
            listadoArticulo.Add(articulo);
        }
        public List<Articulo> listaArticulos()
        {
            return listadoArticulo;
        }
        public void borrarArticulo(Articulo articulo)
        {
            listadoArticulo.Remove(articulo);
        }
    }
}
