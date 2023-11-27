using System;
using System.Windows.Forms;
namespace Tienda.Clases
{
    internal class TipoPago
    {
        private int codTipoPago;
        private string nombreTipoPago;
        private decimal porcentajeDescuentoRecargo;

        public TipoPago(int codTipoPago, string nombreTipoPago, decimal porcentajeDescuentoRecargo)
        {
            this.codTipoPago = codTipoPago;
            this.nombreTipoPago = nombreTipoPago;
            this.PorcentajeDescuentoRecargo = porcentajeDescuentoRecargo;
        }

        public int CodTipoPago { get => codTipoPago; set => codTipoPago = value; }
        public string NombreTipoPago { get => nombreTipoPago; set => nombreTipoPago = value; }
        public decimal PorcentajeDescuentoRecargo { get => porcentajeDescuentoRecargo; set => porcentajeDescuentoRecargo = value; }

        public override bool Equals(object obj)
        {
            return obj is TipoPago pago &&
                   codTipoPago == pago.codTipoPago &&
                   nombreTipoPago == pago.nombreTipoPago;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CodTipoPago, NombreTipoPago);
        }

        public override string ToString()
        {
            return $"{NombreTipoPago} - Descuento o Recargo según Tipo de Pago: {PorcentajeDescuentoRecargo}";
        }

        internal void Add(TipoPago tipoPago)
        {
            throw new NotImplementedException();
        }
    }
}

