using MySql.Data.MySqlClient;
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
    public partial class FormularioInicio : Form
    {
        MySqlConnection connection;
        public FormularioInicio()
        {
            InitializeComponent();
            string connectionString = "server=localhost;port=3307;user=root;password=#TimeForceWildest24;database=world";
            connection = new MySqlConnection(connectionString);
        }

        private void FormularioInicio_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                MessageBox.Show("Conexión exitosa a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            Librerias.ReleaseCapture();
            Librerias.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
