using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProyecto
{
    public partial class FormularioLogin : Form
    {
        bool estadoTextBoxUser = false;
        bool estadoTextBoxPassword = false;
        const string user = "josu";
        const string pass = "123";
        public FormularioLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(nint hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormularioLogin_Load(object sender, EventArgs e)
        {
            textBoxUser.Height = 24;
            textBoxUser.KeyPress += new KeyPressEventHandler(CaracterEnterNegado!);
            textBoxPassword.KeyPress += new KeyPressEventHandler(CaracterEnterNegado!);
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
            if (estadoTextBoxUser) DibujoRectangulo(sender, e, (116, 198, 157), textBoxUser, 3, 3);

            else DibujoRectangulo(sender, e, (45, 106, 79), textBoxUser);

            if (estadoTextBoxPassword) DibujoRectangulo(sender, e, (116, 198, 157), textBoxPassword, 3, 3);

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
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            estadoTextBoxUser = true;
            panelTop.Invalidate();
        }
        private void textBoxUser_Leave(object sender, EventArgs e)
        {
            estadoTextBoxUser = false;
            panelTop.Invalidate();

        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            estadoTextBoxPassword = true;
            panelTop.Invalidate();

        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            estadoTextBoxPassword = false;
            panelTop.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarCredenciales())
            {
                MessageBox.Show($"Bienvenido {textBoxUser.Text}");
            }
            else if (textBoxUser.Text == "" || textBoxPassword.Text == "") labelErrorMessage.Text = "*Debes llenar todos los campos";
            else labelErrorMessage.Text = "*Las credenciales ingresadas son incorrectas";
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
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
