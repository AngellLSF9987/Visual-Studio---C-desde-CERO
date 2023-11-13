using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tienda.Controladores;

namespace Tienda
{
    public partial class FormConsultaArticulo : Form
    {

        public FormConsultaArticulo()
        {
            InitializeComponent();
            List<Articulo> articulos = ControladorArticulo.ObtenerArticulos();
        }

        private void FormConsultaArticulo_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dddd, " + "dd \\de " + "MMMM \\de " + "yyyy").ToUpperInvariant();
        }

       

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = textBoxBuscarCodigo.Text.Trim().ToLower();

            List<Articulo> articulos = ControladorArticulo.ObtenerArticulos();

            // Filtra los artículos que coincidan con el criterio de búsqueda (por ejemplo, nombre o categoría)
            List<Articulo> resultados = articulos
                .Where(articulo =>
                    articulo.NombreArticulo.ToLower().Contains(criterioBusqueda) || // Puedes agregar más criterios de búsqueda
                    articulo.CodigoArticulo.Equals(criterioBusqueda))
                .ToList();

            MostrarResultadosEnListView(resultados);
        }
        private void MostrarResultadosEnListView(List<Articulo> resultados)
        {
            listViewArticulos.Items.Clear();

            foreach (Articulo articulo in resultados)
            {
                ListViewItem item = new ListViewItem(articulo.CodigoArticulo.ToString());
                item.SubItems.Add(articulo.NombreArticulo);
                item.SubItems.Add(articulo.CategoriaArticulo);
                item.SubItems.Add(articulo.PrecioArticulo.ToString("C"));
                item.SubItems.Add(articulo.ExistenciasArticulo.ToString());
                listViewArticulos.Items.Add(item);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e) => Close();

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxBuscarCodigo.Text = string.Empty;
            textBoxBuscarNombre.Text = string.Empty;    
        }
    }
}
