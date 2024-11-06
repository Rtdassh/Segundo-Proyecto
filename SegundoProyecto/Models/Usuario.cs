using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyecto.Models
{
    internal class Usuario
    {
        public static List<Usuario> listadoUsuarios = new();
        public string Id { get; set; }
        public string Username { get; set; }
        public string Correo { get; set; }
        public RolUsuario Rol { get; private set; }
        public string Contraseña { get; set; }

        public Usuario(string id, string username, string correo, RolUsuario rol, string contraseña)
        {
            Id = id;
            Username = username;
            Correo = correo;
            Rol = rol;
            Contraseña = contraseña;
        }

        public enum RolUsuario
        {
            Administrador,
            Bibliotecario,
            Lector
        }
    }
}
