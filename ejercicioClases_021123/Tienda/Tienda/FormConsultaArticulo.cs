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
            // Lógica para realizar la consulta
            RealizarConsulta();
        }

        private void RealizarConsulta()
        {
            // Obtener el criterio de consulta y el valor desde los controles del formulario
            string criterio = radioCodigo.Checked ? "codigo" : "nombre";
            string consulta = textBoxBuscar.Text.Trim();

            // Lógica para buscar y mostrar los resultados en listViewResultado
            MostrarResultados(criterio, consulta);
        }

        private void MostrarResultados(string criterio, string consulta)
        {
            Console.WriteLine($"Criterio de consulta: {criterio}, Valor: {consulta}");
            // ... (Código existente para mostrar resultados en listViewConsulta)

            // Limpiar los resultados anteriores si los hubiera
            listViewConsultas.Items.Clear();

            // Obtener la lista de artículos desde el controlador
            List<Articulo> listaArticulos = ControladorArticulo.ObtenerArticulos();

            // Verificar el número de artículos en la lista
            Console.WriteLine("Número de artículos: " + listaArticulos.Count);

            // Realizar la consulta según el criterio seleccionado
            List<Articulo> resultados = new List<Articulo>();

            foreach (Articulo articulo in listaArticulos)
            {
                if ((criterio == "codigo" && articulo.CodigoArticulo.ToString() == consulta) ||
                    (criterio == "nombre" && articulo.NombreArticulo.ToLower() == consulta.ToLower()))
                {
                    resultados.Add(articulo);
                }
            }
            if (resultados.Count > 0)
            {
                foreach (Articulo articulo in resultados)
                {
                    ListViewItem item = new ListViewItem("Acciones");
                    item.SubItems.Add(articulo.CodigoArticulo.ToString());
                    item.SubItems.Add(articulo.NombreArticulo);
                    item.SubItems.Add(articulo.Categoria.NombreCategoria);
                    item.SubItems.Add(articulo.PrecioArticulo.ToString());
                    item.SubItems.Add(articulo.ExistenciasArticulo.ToString());
                    listViewConsultas.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para la búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e) => Close();

            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                textBoxBuscar.Text = "Escriba aquí el Nombre del Artículo ...";
            }

            private void textBoxBuscar_Enter(object sender, EventArgs e)
            {
                // Cuando el TextBox obtiene el foco (se pincha sobre él), se limpia el texto si es el texto predeterminado
                textBoxBuscar.Clear();
            }

            private void textBoxBuscar_Leave(object sender, EventArgs e)
            {
                // Cuando el TextBox pierde el foco y está vacío, se restaura el texto predeterminado
                if (string.IsNullOrWhiteSpace(textBoxBuscar.Text))
                {
                    textBoxBuscar.Text = "Escriba aquí el Nombre del Artículo ...";
                }
            }
        }
    }
