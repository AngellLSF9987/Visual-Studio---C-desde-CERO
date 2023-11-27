using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Clases;

namespace Tienda.Controladores
{
    internal class ControladorTipoPago
    {
        private static List<TipoPago> tipoPagos = new List<TipoPago>();

        public static void AgregarTipoPago(TipoPago tipoPago)
        {
            tipoPagos.Add(tipoPago);
        }

        public static List<TipoPago> ObtenerTipoPago()
        {
            return tipoPagos;
        }

       /** public static List<string> ObtenerNombresTipoPagos()
        {
            return tipoPagos.Select(t => t.NombreTipoPago).ToList();
        }
       */
        public static void InicializarTipoPago()
        {
            tipoPagos = new List<TipoPago>
            {
                new TipoPago(1, "Efectivo", -0.05m), // Descuento del 5%
                new TipoPago(2, "Tarjeta débito o crédito", +0.1m), // Recargo del 10%
                new TipoPago(3, "Transferencia Bancaria", 0), // Sin cambios en el precio
                new TipoPago(4, "PayPal", +      0.1m) // Descuento del 5%
            };
        }
    }
}

