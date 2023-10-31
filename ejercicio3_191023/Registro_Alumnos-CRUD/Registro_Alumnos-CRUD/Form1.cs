using Registro_Alumnos_CRUD.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Registro_Alumnos_CRUD
{
    public partial class Registro_Alumnos : Form
    {

        private ControlerAlumno ca;
        private Alumno alum;
        private List<Alumno> listadoAlumno;

       
        public Registro_Alumnos()
        {
            InitializeComponent();

            ca = new ControlerAlumno();
            alum = new Alumno();
            listadoAlumno = new List<Alumno>();
        }

       
        private void Registro_Alumnos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Alumno alumno = new Alumno();
            alumno.CursoAlum = textCurso.Text;
            alumno.NomAlum = textNombre.Text;
            alumno.ApellAlum = textApellido.Text;
            alumno.GeneroAlum = Convert.ToString(cmbGenAlum.Items[cmbGenAlum.SelectedIndex]);
            alumno.TelfAlum = long.Parse(textTelefono.Text);
            alumno.MailAlum = textEmail.Text;
            alumno.FecNacAlum = dateFecNac.Value;

            alum = alumno;
            ca.añadirAlumno(alumno);
            listadoAlumno = ca.listaAlumnos();
            MessageBox.Show("Registro creado: " + textNombre.Text + " " +textApellido.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textCurso.Text = string.Empty;   //  == textCurso.Text = " ";
            textNombre.Text = string.Empty;
            textApellido.Text = string.Empty;
            textEmail.Text = string.Empty;
            cmbGenAlum.Text = string.Empty;
            textTelefono.Text = string.Empty;
            dateFecNac.Text = string.Empty;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Visualizar visualizar = new Visualizar();
            visualizar.Alum = alum;
            visualizar.ShowDialog();
        }

        private void btnListadoAlumnos_Click(object sender, EventArgs e)
        {
            ListadoAlumnos listadoAlum = new ListadoAlumnos();
            listadoAlum.ListadoAlumno = this.listadoAlumno;
            listadoAlum.ShowDialog();
        }
    }
}
