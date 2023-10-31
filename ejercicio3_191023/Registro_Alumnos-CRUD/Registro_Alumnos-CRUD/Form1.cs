using Registro_Alumnos_CRUD.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Registro_Alumnos_CRUD
{
    public partial class Registro_Alumnos : Form
    {

        private ControlerAlumno controlerAlumno;
        private Alumno al;
        private List<Alumno> listaALumno;

       
        public Registro_Alumnos()
        {
            InitializeComponent();

            controlerAlumno = new ControlerAlumno();
            al = new Alumno();
            listaALumno = new List<Alumno>();
        }

       
        private void Registro_Alumnos_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Alumno alumno = new Alumno();
            alumno.CodAlum += 1;
            alumno.CursoAlum = textCurso.Text;
            alumno.NomAlum = textNombre.Text;
            alumno.ApellAlum = textApellido.Text;
            alumno.GeneroAlum = Convert.ToString(cmbGenAlum.Items[cmbGenAlum.SelectedIndex]);
            alumno.TelfAlum = long.Parse(textTelefono.Text);
            alumno.MailAlum = textEmail.Text;
            alumno.FecNacAlum = dateFecNac.Value;

            al = alumno;
            controlerAlumno.añadirAlumno(alumno);
            listaALumno = controlerAlumno.listaAlumnos();
            MessageBox.Show("Bienvenido/a al Sistema" + textNombre.Text + " " +textApellido.Text);
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
            this.Close();
        }

        private void dataAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(Alumno alumno in listaALumno) 
            {
                int n = dataAlumnos.Rows.Add();
                dataAlumnos.Rows[n].Cells[0].Value = alumno.CodAlum;
                dataAlumnos.Rows[n].Cells[1].Value = alumno.CursoAlum;
                dataAlumnos.Rows[n].Cells[2].Value = alumno.NomAlum;
                dataAlumnos.Rows[n].Cells[3].Value = alumno.ApellAlum;
                dataAlumnos.Rows[n].Cells[4].Value = alumno.GeneroAlum;
                dataAlumnos.Rows[n].Cells[5].Value = alumno.FecNacAlum;
                dataAlumnos.Rows[n].Cells[6].Value = alumno.TelfAlum;
                dataAlumnos.Rows[n].Cells[7].Value = alumno.MailAlum;

            }
        }
    }
}
