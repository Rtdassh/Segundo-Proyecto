using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyecto.Models
{
    internal class Prestamo
    {
        public static List<Prestamo> listadoPrestamos = new();
        public Lector Lector { get; set; }
        public Book Libro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }

        public Prestamo(Lector lector, Book libro)
        {
            this.Lector = lector;
            Libro = libro;
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = null;
        }
    }
}
