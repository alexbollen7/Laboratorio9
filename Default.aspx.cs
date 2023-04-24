using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio9
{
    public partial class _Default : Page
    {
        static List<Curso> cursos = new List<Curso>();
        static List<Registro> registros = new List<Registro>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.Nombre = TextBoxCurso.Text;
            curso.Nota = int.Parse(TextBoxNota.Text);
            cursos.Add(curso);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();

            registro.Nombre = TextBoxNombre.Text;
            registro.Cursos = cursos.ToList();

            registros.Add(registro);
            cursos.Clear();

            Grabar();
        }

        private void Grabar()
        {
            //Suponiendo que la List llamada lista ya contiene datos

            //Se serializa (convierte) la lista en formato Json y se guarda en una variable de tipo string
            string json = JsonConvert.SerializeObject(registros);

            //El nombre del archivo
            string archivo = Server.MapPath("Datos.json");

            //Se escribe la variable que contiene el json al archivo en un solo paso
            //con WriteAllText se escribe todo de un solo
            System.IO.File.WriteAllText(archivo, json);
        }

    }
}