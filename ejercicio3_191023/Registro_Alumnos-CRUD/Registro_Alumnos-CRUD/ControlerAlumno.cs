using Registro_Alumnos_CRUD.Clases;
using System.Collections.Generic;

namespace Registro_Alumnos_CRUD
{
    public class ControlerAlumno
    {

        private List<Alumno> listaAlumno;

        public ControlerAlumno()
        {
            listaAlumno = new List<Alumno>();
        }

        public void añadirAlumno(Alumno alumno)
        {
            listaAlumno.Add(alumno);
        }

        public List<Alumno> listaAlumnos()
        {
            return listaAlumno;
        }

        public void borrarAlumno(Alumno alumno)
        {
            listaAlumno.Remove(alumno);
        }

    }
}
