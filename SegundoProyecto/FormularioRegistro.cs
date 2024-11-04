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
            Funcionalidades.AsignarEventos(this,botonRegistrarse, textBoxUsername,textBoxPassword, textBoxEmail, textBoxConfirmPass);
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

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (Funcionalidades.ValidarEmail(textBoxEmail.Text)) MessageBox.Show("True");
            else MessageBox.Show("False");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormularioLogin formularioLogin = new();
            formularioLogin.Show();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {

        }
    }
}
