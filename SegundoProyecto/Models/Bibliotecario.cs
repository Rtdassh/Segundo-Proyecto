using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyecto.Models
{
    internal class Bibliotecario : Usuario
    {
        public Bibliotecario(string id, string username, string correo, RolUsuario rol, string contraseña) : base(id, username, correo, rol, contraseña)
        {
        }
    }
}
