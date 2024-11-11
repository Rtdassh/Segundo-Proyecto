using SegundoProyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProyecto.Interfaces
{
    internal partial class BookCard : UserControl
    {
        public BookCard()
        {
            InitializeComponent();
        }
        private Book book1 = new Book();
        public async void SetBookData(Book book)
        {
            labelTitle.Text = book.Title;
            book1 = book;
            // Si tienes una URL para la portada, podrías cargarla con PictureBox
            if (!string.IsNullOrEmpty(book.Cover))
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = await client.GetAsync(book.Cover);
                        response.EnsureSuccessStatusCode();
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            pbCover.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception)
                {
                    pbCover.Image = Properties.Resources.not_found; // Una imagen predeterminada
                }
            }
            else
                pbCover.Image = Properties.Resources.not_found; // Una imagen predeterminada
        }

        private void pbCover_Click(object sender, EventArgs e)
        {
            Form Background = new Form();
            BookCardMaximized bookCardMax = new BookCardMaximized();
            using (bookCardMax)
            {
                Background.StartPosition = FormStartPosition.CenterScreen;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.7d;
                Background.BackColor = Color.Black;
                Background.Size = Funcionalidades.tamanoFormulario;
                Background.Location = this.Location;
                Background.ShowInTaskbar = false;
                Background.Show(this);
                bookCardMax.Owner = Background;
                bookCardMax.SetBookFullData(book1);
                bookCardMax.ShowDialog(Background);
                Background.Dispose();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

