using System.Drawing;
using System.Windows.Forms;

namespace Tienda.Utilidades_Extensiones
{
    // Clase estática de nivel superior para el manejo de eventos sobre botones añadidos automáticamente y el empleo de su lógica.
    public static class ListViewExtensions
    {
        public static void AddEmbeddedControl(this ListView listView, Control control, int columnIndex, int rowIndex)
        {
            // Observar que el índice de la fila sea válido
            if (rowIndex >= 0 && rowIndex < listView.Items.Count)
            {
                // Observar que el índice de la columna sea válido
                if (columnIndex >= 0 && columnIndex < listView.Columns.Count)
                {
                    Rectangle cellBounds = listView.Items[rowIndex].GetBounds(ItemBoundsPortion.Entire);
                    cellBounds = new Rectangle(cellBounds.Left + listView.Columns[columnIndex].Width, cellBounds.Top, control.Width, cellBounds.Height);
                    control.Bounds = cellBounds;

                    listView.Controls.Add(control);
                }
            }
        }
    }
}