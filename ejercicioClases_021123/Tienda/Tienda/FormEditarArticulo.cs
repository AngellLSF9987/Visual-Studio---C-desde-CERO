using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormEditarArticulo : Form
    {
        private Articulo articulo; // Nueva variable miembro para almacenar el artículo

        internal FormEditarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo; // Almacenar el artículo pasado como parámetro
        }

        private void FormEditarArticulo_Load(object sender, EventArgs e)
        {
            // Puedes acceder a las propiedades del artículo aquí, por ejemplo:
            string nombreArticulo = articulo.NombreArticulo;
            // Haz lo que necesites con el nombre del artículo...
        }
    }
}