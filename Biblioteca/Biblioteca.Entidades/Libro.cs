
namespace Biblioteca.Entidades
{
    public class Libro
    {
        //setters and getters
        public int CodigoLibro { get; set; }
        public int nEjemplares { get; set; }
        public string isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Anio { get; set; }
        public int nEdicion { get; set; }
        public string Pais { get; set; }
        public string Idioma { get; set; }
        public string Materia { get; set; }
    }
}
