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
    internal partial class BookCardMaximized : Form
    {
        public BookCardMaximized()
        {
            InitializeComponent();
        }
        Book libro = new();
        public async void SetBookFullData(Book book)
        {
            libro = book;
            labelTitle.Text = book.Title;
            labelDescription.Text = book.Description;
            labelPages.Text = $"Páginas: {book.Pages}";
            labelReleaseDate.Text = $"Fecha de Lanzamiento: {book.ReleaseDate}";
            labelOriginalTitle.Text = book.OriginalTitle;

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

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonPrestar_Click(object sender, EventArgs e)
        {
            DialogResult borrowing_confirmation = MensajePersonalizado.Show("¿Está seguro de prestar este libro? ", "Confirmación de Préstamos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (borrowing_confirmation == DialogResult.Yes)
            {
                Lector? lector = (Lector)Usuario.listadoUsuarios.Find(n => n.Username == SesionIniciada.User)!;
                Prestamo nuevoPrestamo = new(lector, libro);
                lector.Prestamos.Add(nuevoPrestamo);
                MensajePersonalizado.Show("Has prestado éxitosamente el libro " + libro.Title, "Información de Registro", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }
        private bool ValidarPrestamoRealizado()
        {
            if (SesionIniciada.Rol == Usuario.RolUsuario.Lector)
            {
                Lector? lector = (Lector)Usuario.listadoUsuarios.Find(n => n.Username == SesionIniciada.User)!;
            }
                return false;
        }
        private void BookCardMaximized_Load(object sender, EventArgs e)
        {
            IntPtr region = Librerias.CreateRoundRectRgn(0, 0, this.Width, this.Height, 16, 24);
            this.Region = System.Drawing.Region.FromHrgn(region);
        }
    }
}
