using System.Windows.Forms;

namespace Tienda.Utilidades_Extensiones
{
    internal class ListViewEmbeddedControl : ListViewItem
    {
        public Button EditButton { get; set; }

        public ListViewEmbeddedControl(Button editButton)
        {
            this.EditButton = editButton;
            this.Tag = editButton;  // Almacenamos el botón en el Tag del ListViewItem
        }

        public void AddEmbeddedControlToListView(ListView listView)
        {
            if (this.EditButton != null && listView != null)
            {
                // Asegurarse de que el control está desanclado y sin padre antes de agregarlo
                this.EditButton.Dock = DockStyle.None;
                this.EditButton.Parent = listView;
                //this.EditButton.PointToScreen(this.EditButton.Location);

                // Agregar el ListViewItem al ListView
                listView.Items.Add(this);
            }
        }
    }
}
