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
    public partial class Libros : UserControl
    {
        public Libros()
        {
            InitializeComponent();
        }

        private void Libros_Resize(object sender, EventArgs e)
        {
            textBoxSearch.Location = new(barraBusqueda.Location.X, barraBusqueda.Location.Y);
            textBoxSearch.Size = new(barraBusqueda.Width, barraBusqueda.Height);
            buttonSearch.Location = new(barraBusqueda.Location.X + barraBusqueda.Width, barraBusqueda.Location.Y);
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            textBoxSearch.KeyPress += new KeyPressEventHandler(Funcionalidades.CaracterEnterNegado!);
        }
    }
}
