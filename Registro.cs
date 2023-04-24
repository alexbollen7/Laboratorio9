using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio9
{
    public class Registro
    {
        string nombre;
        List<Curso> cursos;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Curso> Cursos { get => cursos; set => cursos = value; }

        //Constructor de la clase
        //Ejecuta codigo al crearse un objeto de esta clase

        public Registro(){
            //Crear la lista de cursos
            cursos = new List<Curso>();
        }
    }
}