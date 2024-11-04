using Microsoft.VisualBasic.ApplicationServices;
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

        public static void DibujoRectangulo(object sender, PaintEventArgs e, (byte, byte, byte) coloresRGB, TextBox textBox, int grosorPen = 2, int grosor = 2)
        {
            Panel? panel = sender as Panel;
            if (panel != null)
            {
                Pen pen = new Pen(Color.FromArgb(coloresRGB.Item1, coloresRGB.Item2, coloresRGB.Item3), grosorPen);
                e.Graphics.DrawRectangle(pen, new Rectangle(textBox.Location.X, textBox.Location.Y + 30, textBox.Width + 1, grosor));
            }
        }
        public static void CaracterEnterNegado(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) e.Handled = true;
        }

        public static void EnableMainButton(Button button, params TextBox[] textBoxes)
        {
            button.Enabled = textBoxes.All(textBox => !string.IsNullOrEmpty(textBox.Text));
        }

        public static void FasesBoton(object sender, PaintEventArgs e, bool estado, bool activador, TextBox textBox, Label label)
        {
            if (estado)
            {
                DibujoRectangulo(sender, e, (116, 198, 157), textBox, 3, 3);
                label.Text = "";
            }
            else if (string.IsNullOrEmpty(textBox.Text)&& activador)
            {
                DibujoRectangulo(sender, e, (255, 89, 94), textBox, 3, 3);
                label.Text = "Llenar el campo es obligatorio";
            }
            else DibujoRectangulo(sender, e, (45, 106, 79), textBox);
        }

        public static void AsignarEventos(Form form, Button mainButton, params TextBox[] textBoxes)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox) textBox.TextChanged += (sender, e) => EnableMainButton(mainButton, textBoxes);
            }
        }

    }
}
