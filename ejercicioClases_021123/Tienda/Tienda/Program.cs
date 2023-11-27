using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Tienda.Controladores;

namespace Tienda
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /**
            // Crear un directorio específico para almacenar datos de la aplicación y manejar adecuadamente la creación del directorio si no existe:
            
            // 1. Obtén la ruta del directorio de datos
            string directorioDatos = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tienda");

            // 2. Verifica si el directorio existe, si no, créalo
            if (!Directory.Exists(directorioDatos))
            {
                Directory.CreateDirectory(directorioDatos);
            }

            // 3. Combina la ruta del archivo pedidos.dat con el directorio de datos
            string rutaArchivo = Path.Combine(directorioDatos, "pedidos.dat");
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Antes de iniciar la aplicación, carga la lista de tipos de pago
            try
            {
                ControladorTipoPago.InicializarTipoPago();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la carga
                Console.WriteLine($"Error al cargar tipos de pago: {ex.Message}");
            }
            // Inicializar datos en un punto central
            InicializadorDatos.Inicializar();
            Application.Run(new FormPrincipal());
        }

        // Clase de inicialización centralizada
        public static class InicializadorDatos
        {
            public static void Inicializar()
            {
                // Inicializar categorías
                ControladorCategoria.InicializarCategorias();

                // Crear algunos artículos de ejemplo
                List<Articulo> articulosIniciales = new List<Articulo>
            {
                new Articulo("Asus",  ControladorCategoria.ObtenerCategorias()[0], 500, 25),
                new Articulo("Omen",  ControladorCategoria.ObtenerCategorias()[1], 700, 50),
                new Articulo("Samsung",  ControladorCategoria.ObtenerCategorias()[2], 900, 200),
                new Articulo("HP",  ControladorCategoria.ObtenerCategorias()[0], 500, 1500),
                new Articulo("Lenovo",  ControladorCategoria.ObtenerCategorias()[1], 700, 1255),
                new Articulo("OPPO",  ControladorCategoria.ObtenerCategorias()[2], 900, 1350)

            };

                // Agregar artículos a ControladorArticulo
                foreach (Articulo articulo in articulosIniciales)
                {
                    ControladorArticulo.AgregarArticulo(articulo);
                }
                // Actualizar la lista de artículos en FormAltaArticulo
                FormAltaArticulo formAltaArticulo = new FormAltaArticulo();
                //formAltaArticulo.ActualizarListaArticulos();
            }
        }
    }
}
