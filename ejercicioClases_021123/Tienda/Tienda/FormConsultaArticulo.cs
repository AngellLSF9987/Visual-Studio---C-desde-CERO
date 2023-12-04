using System;
using System.Collections.Generic;
using System.Drawing;
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

        // En FormConsultaArticulo.cs

        private void DataGridViewResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridViewResultados.Columns["Editar"].Index)
            {
                // Obtener el código del artículo seleccionado
                int codigoArticulo = ControladorArticulo.ObtenerCodigoArticuloSeleccionado(DataGridViewResultados);

                // Lógica para editar el artículo con el código obtenido
                // Llama a ObtenerArticuloPorCodigo en ControladorArticulo proporcionando el código
                Articulo articuloEncontrado = ControladorArticulo.ObtenerArticuloPorCodigo(codigoArticulo);

                // Abrir un nuevo formulario para la edición, por ejemplo:
                FormEditarArticulo formEdicion = new FormEditarArticulo(articuloEncontrado);
                formEdicion.ShowDialog();
            }
            else if (e.ColumnIndex == DataGridViewResultados.Columns["Eliminar"].Index)
            {
                // Obtener el código del artículo seleccionado
                int codigoArticulo = ControladorArticulo.ObtenerCodigoArticuloSeleccionado(DataGridViewResultados);

                // Lógica para eliminar el artículo con el código obtenido
                // ControladorArticulo.EliminarArticulo(codigoArticulo);

                // Vuelve a realizar la consulta después de eliminar el artículo
                RealizarConsulta();
            }
        }


        private void DataGridViewResultados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Establecer el formato de las celdas de imagen (Editar y Eliminar)
            if (e.ColumnIndex == DataGridViewResultados.Columns["Editar"].Index ||
                e.ColumnIndex == DataGridViewResultados.Columns["Eliminar"].Index)
            {
                e.Value = new Bitmap((Image)e.Value, new Size(24, 24));
            }
        }

        private void FormConsultaArticulo_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Now.ToString("dddd, " + "dd \\de " + "MMMM \\de " + "yyyy").ToUpperInvariant();

            // Agregar eventos para las celdas de "Editar" y "Eliminar"
            DataGridViewResultados.CellContentClick += DataGridViewResultados_CellContentClick;
            DataGridViewResultados.CellFormatting += DataGridViewResultados_CellFormatting;
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

        private void ActualizarDataGridView(List<Articulo> resultados)
        {
            // Limpiar los resultados anteriores si los hubiera
            DataGridViewResultados.Rows.Clear();

            foreach (Articulo articulo in resultados)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DataGridViewResultados);

                // Establecer los valores de las celdas
                row.Cells[0].Value = articulo.CodigoArticulo.ToString();
                row.Cells[1].Value = articulo.NombreArticulo;
                row.Cells[2].Value = articulo.Categoria.NombreCategoria;
                row.Cells[3].Value = articulo.PrecioArticulo.ToString();
                row.Cells[4].Value = articulo.ExistenciasArticulo.ToString();
                row.Cells[5].Value = Properties.Resources.editVer;
                row.Cells[6].Value = Properties.Resources.deleRoj;

                // Agregar la fila al DataGridView
                DataGridViewResultados.Rows.Add(row);
            }
        }

        private void MostrarResultados(string criterio, string consulta)
        {
            Console.WriteLine($"Criterio de consulta: {criterio}, Valor: {consulta}");

            // Obtener la lista de artículos desde el controlador
            List<Articulo> listaArticulos = ControladorArticulo.ObtenerArticulos();

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
                // Actualizar el DataGridView de resultados
                ActualizarDataGridView(resultados);

                // Notificar a FormAltaArticulo para que también actualice su DataGridView
                FormAltaArticulo formAltaArticulo = Application.OpenForms["FormAltaArticulo"] as FormAltaArticulo;
                formAltaArticulo?.ActualizarListaArticulos();
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
