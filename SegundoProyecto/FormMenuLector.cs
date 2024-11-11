using SegundoProyecto.Interfaces;
using SegundoProyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProyecto
{
    public partial class FormMenuLector : Form
    {
        //Variables 
        private Button botonSeleccionado = new();
        private UserControl activeUserControl = new();
        private UserControl activeUserControlMenu = new();
        (byte, byte, byte) tuplaColores = (88, 129, 87);
        public FormMenuLector()
        {
            InitializeComponent();
        }

        private void SelectedButton(object btnSender, (byte, byte, byte) colorButton)
        {
            if (btnSender != null)
            {
                if (botonSeleccionado != (Button)btnSender)
                {
                    DisableButton();
                    botonSeleccionado = (Button)btnSender;
                    Color nuevoColor = Color.FromArgb(colorButton.Item1, colorButton.Item2, colorButton.Item3);
                    botonSeleccionado.BackColor = nuevoColor;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control botonAnterior in panelMenuLateral.Controls)
            {
                if (botonAnterior.GetType() == typeof(Button))
                {
                    botonAnterior.BackColor = Color.FromArgb(45, 106, 79);
                }
            }
        }
        public void AbrirUserControl(UserControl userControl)
        {
            if (activeUserControl != null) activeUserControl.Hide();
            if (activeUserControlMenu != null) activeUserControlMenu.Hide();
            activeUserControl = userControl;
            userControl.Dock = DockStyle.Fill;
            this.panelSubMenu.Controls.Add(userControl);
            this.panelSubMenu.Tag = userControl;
            userControl.BringToFront();
            userControl.Show();
            userControl.MouseDown += FormMenuLector_MouseDown!;
        }

        private void FormMenuLector_Load(object sender, EventArgs e)
        {
            RedibujarRegion();
            buttonMenu_Click(buttonMenu, EventArgs.Empty);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult exit_confirmation = MensajePersonalizado.Show("¿Está seguro de salir? Seleccione una opción para continuar", "Confirmación de Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit_confirmation == DialogResult.Yes) Application.Exit();
        }
        private void RedibujarRegion()
        {
            if (activeUserControlMenu != null)
                activeUserControlMenu.Hide();
            if (this.Region != null)
                this.Region.Dispose();
            IntPtr region = Librerias.CreateRoundRectRgn(0, 0, this.Width, this.Height, 16, 24);
            this.Region = System.Drawing.Region.FromHrgn(region);

            Librerias.DeleteObject(region);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                buttonMax.Image = Properties.Resources.lucide__minimize;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                buttonMax.Image = Properties.Resources.humbleicons__maximize__4_;
            }
        }

        private void FormMenuLector_SizeChanged(object sender, EventArgs e)
        {
            RedibujarRegion();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelOptionsBar_MouseDown(object sender, MouseEventArgs e)
        {
            Librerias.ReleaseCapture();
            Librerias.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, tuplaColores);
            AbrirUserControl(new Libros());
        }

        private void buttonConfigUsers_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, tuplaColores);
            AbrirUserControl(new MiCuenta());
        }

        private void buttonPrestamos_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, tuplaColores);
            AbrirUserControl(new Prestamos());
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, tuplaColores);
            AbrirUserControl(new Reportes());
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            SelectedButton(sender, tuplaColores);
            AbrirUserControl(new Menu());
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            MenuDesplegableCuenta desplegableCuenta = new();
            if (activeUserControlMenu != null)
                activeUserControlMenu.Hide();
            activeUserControlMenu = desplegableCuenta;
            this.Controls.Add(desplegableCuenta);
            desplegableCuenta.Location = new Point(buttonProfile.Location.X + panelMenuLateral.Width, buttonProfile.Location.Y + buttonProfile.Height);
            desplegableCuenta.BringToFront();
            desplegableCuenta.Show();
            this.MouseDown += FormMenuLector_MouseDown!;

        }

        private void buttonNotifications_Click(object sender, EventArgs e)
        {
            MenuDesplegableNotificaciones desplegableCuenta = new();
            if (activeUserControlMenu != null)
                activeUserControlMenu.Hide();
            activeUserControlMenu = desplegableCuenta;
            this.Controls.Add(desplegableCuenta);
            desplegableCuenta.Location = new Point(buttonNotifications.Location.X + panelMenuLateral.Width, buttonNotifications.Location.Y + buttonNotifications.Height);
            desplegableCuenta.BringToFront();
            desplegableCuenta.Show();
            this.MouseDown += FormMenuLector_MouseDown!;

        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            MenuDesplegableAjustes desplegableCuenta = new();
            if (activeUserControlMenu != null)
                activeUserControlMenu.Hide();
            activeUserControlMenu = desplegableCuenta;
            this.Controls.Add(desplegableCuenta);
            desplegableCuenta.Location = new Point(buttonConfig.Location.X + panelMenuLateral.Width, buttonConfig.Location.Y + buttonConfig.Height);
            desplegableCuenta.BringToFront();
            desplegableCuenta.Show();

            this.MouseDown += FormMenuLector_MouseDown!;
        }
        

        private void FormMenuLector_MouseDown(object sender, MouseEventArgs e)
        {
                if (activeUserControlMenu != null&&!activeUserControlMenu.Bounds.Contains(e.Location) &&
                    !buttonConfig.Bounds.Contains(e.Location))
                {
                    activeUserControlMenu.Hide();
                    this.MouseDown -= FormMenuLector_MouseDown!; // Desuscribe el evento después de ocultar
                }           
        }

    }
}
