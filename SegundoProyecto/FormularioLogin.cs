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

namespace SegundoProyecto
{
    public partial class FormularioLogin : Form
    {
        bool estadoTextBoxUser = false;
        bool estadoTextBoxPassword = false;
        bool activadorTextBoxUser = false;
        bool activadorTextBoxPassword = false;
        const string user = "josu";
        const string pass = "123";

        public FormularioLogin()
        {
            InitializeComponent();
        }
        static bool ValidarEmail(string email)
        {
            string patron = @"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
            return Regex.IsMatch(email, patron);
        }

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
            textBoxUser.KeyPress += new KeyPressEventHandler(CaracterEnterNegado!);
            textBoxPassword.KeyPress += new KeyPressEventHandler(CaracterEnterNegado!);
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            if (estadoTextBoxUser)
            { 
                DibujoRectangulo(sender, e, (116, 198, 157), textBoxUser, 3, 3);
                labelMessageUser.Text = "";
            }
            else if (textBoxUser.Text == "" && activadorTextBoxUser)
            { 
                DibujoRectangulo(sender, e, (255, 89, 94), textBoxUser, 3, 3);
                labelMessageUser.Text = "Llenar el campo es obligatorio";
            }
            else DibujoRectangulo(sender, e, (45, 106, 79), textBoxUser);

            if (estadoTextBoxPassword)
            {
                DibujoRectangulo(sender, e, (116, 198, 157), textBoxPassword, 3, 3);
                labelMessagePassword.Text = "";
            }
            else if (textBoxPassword.Text == "" && activadorTextBoxPassword)
            {
                DibujoRectangulo(sender, e, (255, 89, 94), textBoxPassword, 3, 3);
                labelMessagePassword.Text = "Llenar el campo es obligatorio";
            }
            else DibujoRectangulo(sender, e, (45, 106, 79), textBoxPassword);
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

 

        private void CaracterEnterNegado(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) e.Handled = true;
        }

        private void EnableMainButton(Button button, TextBox User, TextBox Password)
        {
            if (User.Text != "" && Password.Text != "") button.Enabled = true;
            else button.Enabled = false;
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
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void botonRedondeado1_Click(object sender, EventArgs e)
        {
            if (VerificarCredenciales())
            {
                MessageBox.Show($"Bienvenido {textBoxUser.Text}");
                new FormularioInicio().Show();
                this.Hide();
                this.Close();
            }
            else if (textBoxUser.Text == "" || textBoxPassword.Text == "") labelMessagePassword.Text = "*Debes llenar todos los campos";
            else labelMessagePassword.Text = "*Las credenciales ingresados son incorrectas";
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            EnableMainButton(botonRedondeado1, textBoxUser, textBoxPassword);

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            EnableMainButton(botonRedondeado1, textBoxUser, textBoxPassword);
        }
    }
}
