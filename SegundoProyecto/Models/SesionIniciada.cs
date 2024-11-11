using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyecto.Models
{
    internal class SesionIniciada
    {
        public static string User { get; set; } = string.Empty;
        public static string Nombre { get; set; } = string.Empty;
        public static Usuario.RolUsuario Rol { get; set; }
       
        public static void LimpiarSesion()
        {
            User = string.Empty;
            Nombre = string.Empty;
            Rol = default;
        }

        public static void IniciarSesion(string user, string nombre)
        {
            User = user;
            Nombre = nombre;
            Rol = HallarRol(user);
        }

        public static Usuario.RolUsuario HallarRol(string username)
        {
            Usuario? usuario = Usuario.listadoUsuarios.Find(n=>n.Username == username || n.Correo == username);
            return usuario!.Rol;
        }
    }
}
