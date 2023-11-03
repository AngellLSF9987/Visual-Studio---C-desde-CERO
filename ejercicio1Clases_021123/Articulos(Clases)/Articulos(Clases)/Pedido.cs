using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulos_Clases_
{
    public class Pedido
    {
        public int CodPedido { get; set; }
        public string Cliente { get; set; }
        public int CantidadPedido { get; set; }
        public List<Articulo> Articulos { get; set; }

    }
}
