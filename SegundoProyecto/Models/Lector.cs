using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyecto.Models
{
    internal class Lector : Usuario
    {
        public List<Prestamo> Prestamos { get; set; }
        public Lector(string id, string username, string correo, RolUsuario rol, string contraseña, List<Prestamo> prestamos) : base(id, username, correo, rol, contraseña)
        {
            Prestamos = prestamos;
        }
    }
}
