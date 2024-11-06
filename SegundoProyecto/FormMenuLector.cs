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
        public FormMenuLector()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMenuLector_Load(object sender, EventArgs e)
        {
            RedibujarRegion();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult exit_confirmation = MensajePersonalizado.Show("¿Está seguro de salir? Seleccione una opción para continuar", "Confirmación de Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit_confirmation == DialogResult.Yes) Application.Exit();
        }
        private void RedibujarRegion()
        {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
