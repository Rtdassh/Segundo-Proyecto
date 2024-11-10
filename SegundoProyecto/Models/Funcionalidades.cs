using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static SegundoProyecto.FormularioLogin;

namespace SegundoProyecto.Models
{
    internal class Funcionalidades
    {
        public static bool ValidarEmail(string email)
        {
            string patron = @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
            return Regex.IsMatch(email, patron);
        }
        public static bool ValidarUsuario(string nombreUsuario)
        {
            string patron = @"^(?!.*\.\.)(?!.*\.$)(?!.*__)[a-zA-Z0-9](?!.*\W)(?!.*_{2,})(?!.*\s)(?!.*[_]$)(?!^[_])[A-Za-z0-9_]{2,14}$";

            return Regex.IsMatch(nombreUsuario, patron);
        }

        public static bool ValidarPassword(string password)
        {
            string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&#]{8,}$";
            return Regex.IsMatch(password, patron);
        }

        public static string HallarFallaPassword(string password)
        {
            if (password.Length < 8) return "Debe contener mínimo 8 caracteres.";
            if (!Regex.IsMatch(password, @"[A-Z]")) return "Debe contener mínimo una letra mayúscula.";
            if (!Regex.IsMatch(password, @"[a-z]")) return "Debe contener mínimo una letra minúscula.";
            if (!Regex.IsMatch(password, @"\d")) return "Debe contener mínimo un número.";
            if (!Regex.IsMatch(password, @"[@$!%*?&#]")) return "Debe contener mínimo un carácter especial (@, $, !, %, *, ?, &, #).";

            return "Falló?";
        }

        public static string HallarFallaUsuario(string nombreUsuario)
        {
            if (nombreUsuario.Length < 3) return "Debe tener mínimo 3 caracteres.";
            if (nombreUsuario.Length > 15) return "No puede tener más de 15 caracteres.";
            if (!Regex.IsMatch(nombreUsuario, @"^[a-zA-Z0-9_]+$")) return "Solo puede contener letras, números y guiones bajos.";
            if (nombreUsuario.StartsWith("_") || nombreUsuario.EndsWith("_")) return "No puede comenzar ni terminar con un guion bajo.";
            if (ManejoDatos.EvaluarUsuarioRepetido(nombreUsuario)) return "Ya existe ese nombre de usuario";
            return "Falló?";
        }


        public static void DibujoRectangulo(Graphics graphics, (byte, byte, byte) coloresRGB, Control control, int variacionY = 0,int grosorPen = 2, int grosor = 2)
        {
            using (Pen pen = new Pen(Color.FromArgb(coloresRGB.Item1, coloresRGB.Item2, coloresRGB.Item3), grosorPen))
            {
                graphics.DrawRectangle(pen, new Rectangle(control.Location.X, control.Location.Y + variacionY, control.Width, grosor));
            }
        }
        public static void CaracterEnterNegado(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) e.Handled = true;
        }
        public static void GetSpecialTextBoxes(TextBox email, TextBox pass, TextBox confirmPass)
        {

        }
        public static bool EvaluateMail(TextBox textBox, params TextBox[] textBoxes)
        {
            return textBox.Enabled = textBoxes.All(textBox => !string.IsNullOrEmpty(textBox.Text));
        }
        public static void EnableMainButton(Button button, params TextBox[] textBoxes)
        {
            button.Enabled = textBoxes.All(textBox => !string.IsNullOrEmpty(textBox.Text));
        }
        public static void EnableMainButton(Form formulario,Button button, TextBox textBoxUsername, TextBox textBoxEmail, TextBox textBoxPassword, TextBox textBoxConfirmPass)
        {
            bool emailValido = !string.IsNullOrEmpty(textBoxEmail.Text) && ValidarEmail(textBoxEmail.Text);
            bool usuarioValido = !string.IsNullOrEmpty(textBoxUsername.Text) && ValidarUsuario(textBoxUsername.Text);
            bool passwordValido = !string.IsNullOrEmpty(textBoxPassword.Text) && ValidarPassword(textBoxPassword.Text);
            bool contraseñasCoinciden = EvaluarIgualdad(textBoxPassword, textBoxConfirmPass);
            
            button.Enabled = emailValido && usuarioValido && passwordValido && contraseñasCoinciden && !ManejoDatos.EvaluarUsuarioRepetido(textBoxUsername) && !ManejoDatos.EvaluarCorreoRepetido(textBoxEmail);
            formulario.Invalidate();
        }

        public static void FasesBoton(object sender, PaintEventArgs e, bool estado, bool activador, TextBox textBox, Label label, byte casoTextBox = 100)
        {
            if (estado)
            {
                DibujoRectangulo(e.Graphics, (116, 198, 157), textBox, 28, 3,3);
                label.Text = "";
                return;
            }
            

            if (string.IsNullOrEmpty(textBox.Text) && activador)
            {
                DibujoRectangulo(e.Graphics, (255, 89, 94), textBox, 28, 3, 3);
                label.Text = "Llenar el campo es obligatorio";
                return;
            }

            bool esValido = true;
            string mensajeError = "";
            switch (casoTextBox)
            {
                case 0:
                    esValido = ValidarUsuario(textBox.Text) && !ManejoDatos.EvaluarUsuarioRepetido(textBox);
                    if (!esValido) mensajeError = HallarFallaUsuario(textBox.Text);
                    break;
                case 1 when activador == false && estado == false:
                    DibujoRectangulo(e.Graphics, (45, 106, 79), textBox,28); // Color de borde válido
                    label.Text = "";
                    return;
                case 1:
                    esValido = ValidarEmail(textBox.Text) && !ManejoDatos.EvaluarCorreoRepetido(textBox);
                    if (!esValido) mensajeError = "Debe ingresar un correo válido";
                    if (!esValido && ManejoDatos.EvaluarCorreoRepetido(textBox)) mensajeError = "Ese correo ya está registrado";
                    break;
                case 2 when activador == false && estado == false:
                    DibujoRectangulo(e.Graphics, (45, 106, 79), textBox, 28); // Color de borde válido
                    label.Text = "";
                    return;
                case 2:
                    esValido = ValidarPassword(textBox.Text);
                    if (!esValido) mensajeError = HallarFallaPassword(textBox.Text);
                    break;
                case 3 when activador == false && estado == false:
                    DibujoRectangulo(e.Graphics, (45, 106, 79), textBox, 28); // Color de borde válido
                    label.Text = "";
                    return;
                case 3:
                    esValido = false; 
                    mensajeError = "La contraseña ingresada no coincide";
                    break;
                case 100:
                    DibujoRectangulo(e.Graphics, (45, 106, 79), textBox, 28); 
                    label.Text = "";
                    return; 
            }

            if (esValido)
            {
                DibujoRectangulo(e.Graphics, (45, 106, 79), textBox, 28);
                label.Text = "";
            }
            else if (activador)
            {
                DibujoRectangulo(e.Graphics,(255, 89, 94), textBox, 28, 3, 3); 
                label.Text = mensajeError;
            }
        }

        public static bool EvaluarIgualdad(TextBox textBoxPass, TextBox textBoxConfirmPass)
        {
            if (textBoxPass.Text == textBoxConfirmPass.Text) return true;
                return false;
        }
        
        public static void AsignarEventoButton(Form form,Button mainButton, TextBox textBoxUsername, TextBox textBoxEmail, TextBox textBoxPassword, TextBox textBoxConfirmPass)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox) textBox.TextChanged += (sender, e) => EnableMainButton(form,mainButton, textBoxUsername, textBoxEmail, textBoxPassword, textBoxConfirmPass);
            }
        }
        public static void AsignarEventoEnter(Form form, params TextBox[] textBoxes)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox) control.KeyPress += new KeyPressEventHandler(CaracterEnterNegado!);
            }
        }

        public static Color CambiarBrillo(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
