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
        bool estadoUser, estadoPass, estadoEmail, estadoConfirmPass = false;
        bool activadorUser, activadorPass, activadorEmail, activadorConfirmPass = false;

        public FormularioRegistro()
        {
            InitializeComponent();
            Funcionalidades.AsignarEventoButton(this, botonRegistrarse, textBoxUsername, textBoxPassword, textBoxEmail, textBoxConfirmPass);
            Funcionalidades.AsignarEventoEnter(this, textBoxUsername, textBoxPassword, textBoxEmail, textBoxConfirmPass);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormularioLogin formularioLogin = new();
            formularioLogin.Show();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult exit_confirmation = MensajePersonalizado.Show("¿Está seguro de salir? Seleccione una opción para continuar", "Confirmación de Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit_confirmation == DialogResult.Yes) Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            MensajePersonalizado.Show("prueba del funcionamiento", "Información de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            estadoUser = true;
            activadorUser = false;
            this.Invalidate();
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            estadoUser = false;
            activadorUser = true;
            this.Invalidate();
        }
        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            estadoEmail = true;
            activadorEmail = false;
            this.Invalidate();
        }
        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            estadoEmail = false;
            activadorEmail = true;
            this.Invalidate();
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            estadoPass = true;
            activadorPass = false;
            this.Invalidate();
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            estadoPass = false;
            activadorPass = true;
            this.Invalidate();
        }

        private void textBoxConfirmPass_Enter(object sender, EventArgs e)
        {
            estadoConfirmPass = true;
            activadorConfirmPass = false;
            this.Invalidate();
        }

        private void textBoxConfirmPass_Leave(object sender, EventArgs e)
        {
            estadoConfirmPass = false;
            activadorConfirmPass = true;
            this.Invalidate();
        }

        private void FormularioRegistro_Paint(object sender, PaintEventArgs e)
        {
            Funcionalidades.FasesBoton(sender, e, estadoUser, activadorUser, textBoxUsername, labelMessageUser,0);
            Funcionalidades.FasesBoton(sender, e, estadoEmail, activadorEmail, textBoxEmail, labelMessageEmail,1);
            Funcionalidades.FasesBoton(sender, e, estadoPass, activadorPass, textBoxPassword, labelMessagePass,2);
            Funcionalidades.FasesBoton(sender, e, estadoConfirmPass, activadorConfirmPass, textBoxConfirmPass, labelMessageConfirmPass, (Funcionalidades.EvaluarIgualdad(textBoxPassword, textBoxConfirmPass)) ? (byte)100 : (byte)3);
        }

        private void buttonEyeWatcherPass_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
        }

        private void buttonEyeWatcherPass_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Invalidate();
        }
        private void buttonEyeWatcherConfirmPass_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxConfirmPass.PasswordChar = '\0';
        }

        private void buttonEyeWatcherConfirmPass_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxConfirmPass.PasswordChar = '*';
            textBoxConfirmPass.Invalidate();
        }
    }
}
