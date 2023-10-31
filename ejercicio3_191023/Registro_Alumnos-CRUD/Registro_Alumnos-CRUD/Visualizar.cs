using Registro_Alumnos_CRUD.Clases;
using System;
using System.Windows.Forms;

namespace Registro_Alumnos_CRUD
{
    public partial class Visualizar : Form
    {
        private Alumno alum;
        public Visualizar()
        {
            InitializeComponent();
            alum = new Alumno();
        }

        public Alumno Alum 
        {
            get 
            {
                return alum;
            }
            set 
            {
                alum = value;
            }
        }
        private void Visualizar_Load(object sender, EventArgs e)
        {
            
            labelCursoNombre.Text = alum.CursoAlum;
            labelNombre.Text = alum.NomAlum;
            labelApellido.Text = alum.ApellAlum;
            labelGenero.Text = alum.GeneroAlum;
            labelFechaNacimiento.Text = Convert.ToString(alum.FecNacAlum);
            labelTelefono.Text = Convert.ToString(alum.TelfAlum);
            labelEmail.Text = alum.MailAlum;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
