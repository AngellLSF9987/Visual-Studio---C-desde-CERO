using System;

namespace Tienda
{
    internal class Usuario
    {
        private int codUsuario;
        private string nombreUsuario;
        private string apellidoUsuario;
        private string direccionUsuario;
        private long telefonoUsuario;
        private bool rolUsuario;

        public Usuario(int codUsuario, string nombreUsuario, string apellidoUsuario, string direccionUsuario, long telefonoUsuario, bool rolUsuario)
        {
            this.codUsuario = codUsuario;
            this.nombreUsuario = nombreUsuario;
            this.apellidoUsuario = apellidoUsuario;
            this.direccionUsuario = direccionUsuario;
            this.telefonoUsuario = telefonoUsuario;
            this.rolUsuario = rolUsuario;
        }

        public int CodUsuario
        {
            get { return codUsuario; }
            set { codUsuario = value; }
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("El nombre es demasiado corto");
                }
                else
                {
                    nombreUsuario = value;
                }
            }
        }
        public string ApellidoUsuario
        {
            get { return apellidoUsuario;}
            set
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("El apellido es demasiado corto");
                }
                else
                {
                    apellidoUsuario = value;
                }
            }
        }
        public string DireccionUsuario
        {
            get { return direccionUsuario; }
            set 
            {
                if (value.Length < 0)
                {
                    throw new ArgumentException("La dirección es demasiado corto");
                }
                else
                {
                    direccionUsuario = value;
                }
            }
        }
        public int TelefonoUsuario
        {
            get { return (int)telefonoUsuario; }
            set 
            {
                if (value < 9)
                {
                    throw new ArgumentException("El telefono es demasiado corto");
                }
                else
                {
                    telefonoUsuario = value;
                }
            }
        }
        public bool RolUsuario 
        {
            get { return rolUsuario; }
            set
            {
               
            }
        }
    }
}
