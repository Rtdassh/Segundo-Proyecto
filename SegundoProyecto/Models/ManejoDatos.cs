using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyecto.Models
{
    internal class ManejoDatos
    {
        public static int contadorID = 0;
        public static int ContadorID()
        {
            contadorID += 1;
            return contadorID;
        }
        public static bool EvaluarUsuarioRepetido(TextBox textBox)
        {
           Usuario? user =  Usuario.listadoUsuarios.Find(n=>n.Username == textBox.Text);
            return user != null;
        }

        public static bool EvaluarUsuarioRepetido(string username)
        {
            Usuario? user = Usuario.listadoUsuarios.Find(n => n.Username == username);
            return user != null;

        }
        public static bool EvaluarCorreoRepetido(TextBox textBox)
        {
            Usuario? user = Usuario.listadoUsuarios.Find(n => n.Correo == textBox.Text);
            return user != null;
        }

        public static void AgregarLector(string username, string correo, string password)
        {
            Lector nuevoLector = new("C" + ContadorID(), username, correo, Usuario.RolUsuario.Lector, password);
            Usuario.listadoUsuarios.Add(nuevoLector);
        }

        public static bool VerificarCredenciales(string user, string password)
        {
            bool pass = false;
            Usuario? usuario = Usuario.listadoUsuarios.Find(n=>n.Username == user || n.Correo == user);
            if(usuario!=null) pass = usuario!.Contraseña.Equals(password);
            return pass;
        }
    }
}
