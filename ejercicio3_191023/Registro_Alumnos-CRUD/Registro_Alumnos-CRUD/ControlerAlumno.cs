using Registro_Alumnos_CRUD.Clases;
using System.Collections.Generic;

namespace Registro_Alumnos_CRUD
{
    public class ControlerAlumno
    {

        private List<Alumno> listadoAlumno;

        public ControlerAlumno()
        {
            listadoAlumno = new List<Alumno>();
        }

        public void añadirAlumno(Alumno alumno)
        {
            listadoAlumno.Add(alumno);
        }

        public List<Alumno> listaAlumnos()
        {
            return listadoAlumno;
        }

        public void borrarAlumno(Alumno alumno)
        {
            listadoAlumno.Remove(alumno);
        }

    }
}
