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
    public partial class Libros : UserControl
    {
        public Libros()
        {
            InitializeComponent();
        }

        private void Libros_Resize(object sender, EventArgs e)
        {
            textBoxSearch.Location = new(barraBusqueda.Location.X+9, barraBusqueda.Location.Y+5);
            textBoxSearch.Size = new(barraBusqueda.Width-18, barraBusqueda.Height-8);
            buttonSearch.Location = new(barraBusqueda.Location.X + barraBusqueda.Width, barraBusqueda.Location.Y-2);
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            LoadBooks(Book.books);
            textBoxSearch.KeyPress += new KeyPressEventHandler(Funcionalidades.CaracterEnterNegado!);
        }

        private void LoadBooks(List<Book> books)
        {
            flowLayoutPanelBooks.Controls.Clear(); // Limpiar cualquier tarjeta previa

            foreach (var book in books)
            {
                BookCard bookCard = new BookCard();
                bookCard.SetBookData(book);
                flowLayoutPanelBooks.Controls.Add(bookCard);
            }
        }

    }
}
