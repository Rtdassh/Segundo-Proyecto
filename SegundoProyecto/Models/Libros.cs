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
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string TituloOriginal { get; set; }
        public DateTime FechaPublicacion{ get; set; }
        public string Autor { get; set; }
        public Genero Generos { get; set; }
        public string Portada { get; set; }

        public byte CantidadLibros { get; set; }

        public Libro(string iSBN, string titulo, string tituloOriginal, DateTime fechaPublicacion, string autor, Genero generos, string portada, byte cantidadLibros)
        {
            ISBN = iSBN;
            Titulo = titulo;
            TituloOriginal = tituloOriginal;
            FechaPublicacion = fechaPublicacion;
            Autor = autor;
            Generos = generos;
            Portada = portada;
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
