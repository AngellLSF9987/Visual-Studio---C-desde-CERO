using System;

namespace Tienda
{
    public class Categoria
    {
        private int codCategoria;
        private string nombreCategoria;
        private decimal precioPorDefecto;

        public Categoria(int codCategoria, string nombreCategoria, decimal precioPorDefecto)
        {
            this.codCategoria = codCategoria;
            this.nombreCategoria = nombreCategoria;
            this.precioPorDefecto = precioPorDefecto;
        }

        public int CodCategoria
        {
            get { return codCategoria; }
            set { codCategoria = value; }
        }
        public string NombreCategoria
        {
            get { return nombreCategoria; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentException("El nombre es demasiado corto");
                }
                else
                {
                    nombreCategoria = value;
                }
            }
        }

        public decimal PrecioPorDefecto
        {
            get { return precioPorDefecto; }
            set { precioPorDefecto = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Categoria otraCategoria = (Categoria)obj;

            return CodCategoria == otraCategoria.CodCategoria &&
                   NombreCategoria == otraCategoria.NombreCategoria &&
                   PrecioPorDefecto == otraCategoria.PrecioPorDefecto;
        }

        // Garantizar la coherencia en el uso de la clase en colecciones basadas en hash.
        public override int GetHashCode()
        {
            return HashCode.Combine(CodCategoria, NombreCategoria, PrecioPorDefecto);
        }

        public override string ToString()
        {
            // Devolver el nombre de la categoría
            return NombreCategoria;

        }
    }
}
