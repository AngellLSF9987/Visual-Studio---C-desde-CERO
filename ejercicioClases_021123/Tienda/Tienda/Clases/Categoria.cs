using System;

namespace Tienda
{
    internal class Categoria
    {
        private int codCategoria;
        private string nombreCategoria;

        public Categoria(int codCategoria, string nombreCategoria)
        {
            this.codCategoria = codCategoria;
            this.nombreCategoria = nombreCategoria;
        }

        public int CodCategoria
        {
            get { return codCategoria; }
            set { codCategoria = value;}
        }
        public string NombreCategoria
        {
            get { return nombreCategoria;}
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
    }
}
