using SegundoProyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProyecto
{
    public partial class FormularioRegistro : Form
    {
        public FormularioRegistro()
        {
            InitializeComponent();
        }

        private void FormularioRegistro_Load(object sender, EventArgs e)
        {
            IntPtr region = Librerias.CreateRoundRectRgn(0, 0, this.Width, this.Height, 16, 24);
            this.Region = System.Drawing.Region.FromHrgn(region);
        }

        private void FormularioRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            Librerias.ReleaseCapture();
            Librerias.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        static bool ValidarEmail(string email)
        {
            string patron = @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
            return Regex.IsMatch(email, patron);
        }
        private void DibujoRectangulo(object sender, PaintEventArgs e, (byte, byte, byte) coloresRGB, TextBox textBox, int grosorPen = 2, int grosor = 2)
        {
            Panel? panel = sender as Panel;
            if (panel != null)
            {
                Pen pen = new Pen(Color.FromArgb(coloresRGB.Item1, coloresRGB.Item2, coloresRGB.Item3), grosorPen);
                e.Graphics.DrawRectangle(pen, new Rectangle(textBox.Location.X, textBox.Location.Y + 30, textBox.Width + 1, grosor));
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (ValidarEmail(textBoxEmail.Text)) MessageBox.Show("True");
            else MessageBox.Show("False");
        }
    }
}
