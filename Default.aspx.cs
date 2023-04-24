using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            Leer();
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
        
        private void Leer()
        {
            //Se crea una lista con la misma estructura que tienen los datos en el archivo
            List<Registro> lista = new List<Registro>();

            //El nombre del archivo a utilizar
            string archivo = Server.MapPath("Datos.json");

            //Se abre el archivo
            StreamReader jsonStream = File.OpenText(archivo);

            //Se Lee todo el contenido del archivo y el contenido leído se guarda en una variable cualquiera de tipo string.
            //aquí no se necesitan ciclos pues el método ReadToEnd() lee todo el contenido de una sola vez.
            string json = jsonStream.ReadToEnd();

            //Se cierra el archivo
            jsonStream.Close();

            //Se deserializa (convierte) la cadena json guardada en la variable, a la estructura que tiene la lista a donde se van a cargar los datos
            lista = JsonConvert.DeserializeObject<List<Registro>>(json);
            registros = lista.ToList();
        }
    }
}