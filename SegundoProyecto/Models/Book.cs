using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyecto.Models
{
    internal class Book
    {
        public static List<Book> books = new();
        public int Number { get; set; }            
        public string? Title { get; set; }           
        public string? OriginalTitle { get; set; }   
        public string? ReleaseDate { get; set; }     
        public string? Description { get; set; }     
        public int Pages { get; set; }              
        public string? Cover { get; set; }
        public int CantidadLibros { get; set; }
    }
}
