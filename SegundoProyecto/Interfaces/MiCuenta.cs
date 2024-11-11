using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProyecto.Interfaces
{
    public partial class MiCuenta : UserControl
    {
        public MiCuenta()
        {
            InitializeComponent();
        }

        private void btnCropImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cargar la imagen en el PictureBox
                    string filePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(filePath);
                }
            }
        }
       
        private void MiCuenta_Load(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) buttonChangeProfilePicture.Text = "Cambiar Foto de Perfil";
            else buttonChangeProfilePicture.Text = "Subir Foto de Perfil";
        }
    }
}
