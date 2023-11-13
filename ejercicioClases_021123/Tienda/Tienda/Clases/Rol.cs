namespace Tienda.Clases
{
    internal class Rol
    {
        private int codRol;
        private string nombreRol;

        public Rol(int codRol, string nombreRol)
        {
            this.codRol = codRol;
            this.nombreRol = nombreRol;
        }

        public int CodRol {  get { return codRol; } set {  codRol = value; } }
        public string NombreRol { get { return nombreRol; } set {nombreRol = value; } }
    }
}
