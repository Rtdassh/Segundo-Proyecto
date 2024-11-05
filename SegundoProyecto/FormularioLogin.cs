using Microsoft.Win32;
using SegundoProyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SegundoProyecto
{
    public partial class FormularioLogin : Form
    {
        
        bool estadoTextBoxUser, estadoTextBoxPassword, activadorTextBoxUser, activadorTextBoxPassword = false;
        const string user = "josu";
        const string pass = "123";

        public FormularioLogin()
        {
            InitializeComponent();
        }
        /*
        private void AsignarEventos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    textBox.Enter += Funcionalidades.TextBox_Enter!;
                }
            }
        }
        */
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            Librerias.ReleaseCapture();
            Librerias.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            Librerias.ReleaseCapture();
            Librerias.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormularioLogin_Load(object sender, EventArgs e)
        {
            IntPtr region = Librerias.CreateRoundRectRgn(0, 0, this.Width, this.Height, 16, 24);
            this.Region = System.Drawing.Region.FromHrgn(region);
            textBoxUser.KeyPress += new KeyPressEventHandler(Funcionalidades.CaracterEnterNegado!);
            textBoxPassword.KeyPress += new KeyPressEventHandler(Funcionalidades.CaracterEnterNegado!);
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            Funcionalidades.FasesBoton(sender, e, estadoTextBoxUser, activadorTextBoxUser, textBoxUser,labelMessageUser);
            Funcionalidades.FasesBoton(sender, e, estadoTextBoxPassword, activadorTextBoxPassword, textBoxPassword, labelMessagePassword);
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            estadoTextBoxUser = true;
            activadorTextBoxUser = false;
            panelTop.Invalidate();
        }

        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            estadoTextBoxUser = false;
            activadorTextBoxUser = true;
            panelTop.Invalidate();
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            estadoTextBoxPassword = true;
            activadorTextBoxPassword = false;
            panelTop.Invalidate();

        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            estadoTextBoxPassword = false;
            activadorTextBoxPassword = true;
            panelTop.Invalidate();
        }

        private bool VerificarCredenciales()
        {
            if (textBoxUser.Text == user && textBoxPassword.Text == pass) return true;
            else return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormularioRegistro formularioRegistro = new();
            formularioRegistro.Show();
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

        private void botonRedondeado1_Click(object sender, EventArgs e)
        {
            if (VerificarCredenciales())
            {
                MensajePersonalizado.Show($"Has ingresado con éxito {textBoxUser.Text}", "Ingreso", MessageBoxButtons.OK,MessageBoxIcon.None);
                new FormularioInicio().Show();
                this.Hide();
                this.Close();
            }
            else labelMessagePassword.Text = "*Las credenciales ingresadas son incorrectas";
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            Funcionalidades.EnableMainButton(botonRedondeado1, textBoxUser, textBoxPassword);
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            Funcionalidades.EnableMainButton(botonRedondeado1, textBoxUser, textBoxPassword);
        }

        public void TextBox_Enter(object sender, EventArgs e)
        {
            var estado = e as PaintEventArgs;
            Funcionalidades.FasesBoton(sender, estado!, true, false, textBoxUser, labelMessageUser);
            this.Invalidate();
        }
    }
}
