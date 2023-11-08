using System;
using System.Windows.Forms;

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

        }

        private void btnInicio_Click(object sender, EventArgs e) => Close();
    }
}
