using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyecto.Models
{
    internal class Libro
    {
        public static List<Libro> listadoLibros = new();
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public Genero Generos { get; set; }
        public byte CantidadLibros { get; set; }

        public Libro(string titulo, string autor, string iSBN, Genero generos, byte cantidadLibros)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = iSBN;
            Generos = generos;
            CantidadLibros = cantidadLibros;
        }

        public enum Genero
        {
            Accion,
            Drama,
            Terror,
            Ciencia_Ficcion,
            Misterio,
            Crimen,
            Novela,
            Aventura,
            Romance,
            Fantasia
        }
    }
}
