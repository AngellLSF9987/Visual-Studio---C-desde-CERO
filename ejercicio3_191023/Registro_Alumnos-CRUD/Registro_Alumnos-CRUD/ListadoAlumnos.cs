using Registro_Alumnos_CRUD.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Registro_Alumnos_CRUD
{
    public partial class ListadoAlumnos : Form
    {
        private List<Alumno> listadoAlumno;
        public ListadoAlumnos()
        {
            InitializeComponent();
            listadoAlumno = new List<Alumno>();
        }

        public List<Alumno> ListadoAlumno
        {
            get 
            {
                return listadoAlumno;
            }
            set
            { 
                listadoAlumno = value;
            }
        }

       
        private void ListadoAlumnos_Load(object sender, EventArgs e)
        {
            foreach (Alumno alumno in listadoAlumno)
            {
                int n = dataAlumnos.Rows.Add();             
                for (alumno.CodAlum = 1; alumno.CodAlum < dataAlumnos.Rows.Count; alumno.CodAlum++)
                {
                    dataAlumnos.Rows[n].Cells[0].Value = alumno.CodAlum;
                }
                dataAlumnos.Rows[n].Cells[1].Value = alumno.CursoAlum;
                dataAlumnos.Rows[n].Cells[2].Value = alumno.NomAlum;
                dataAlumnos.Rows[n].Cells[3].Value = alumno.ApellAlum;
                dataAlumnos.Rows[n].Cells[4].Value = alumno.GeneroAlum;
                dataAlumnos.Rows[n].Cells[5].Value = alumno.FecNacAlum;
                dataAlumnos.Rows[n].Cells[6].Value = alumno.TelfAlum;
                dataAlumnos.Rows[n].Cells[7].Value = alumno.MailAlum;
            }
        }

        private void dataAlumnos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
