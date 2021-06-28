using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocio
{
    public class NLibro
    {
        //Crea un nuevo libro
        public static string Insertar(int nejemplares, string ISBN, string titulo, string autor, string editorial, int anio, int nedicion, string pais, string idioma, string materia)
        {
            DLibro Datos = new DLibro();

            Libro Obj = new Libro();
            Obj.nEjemplares = nejemplares;
            Obj.isbn = ISBN;
            Obj.Titulo = titulo;
            Obj.Autor = autor;
            Obj.Editorial = editorial;
            Obj.Anio = anio;
            Obj.nEdicion = nedicion;
            Obj.Pais = pais;
            Obj.Idioma = idioma;
            Obj.Materia = materia;
            return Datos.Insertar(Obj);

        }
    }
}
