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
    public partial class MenuDesplegableAjustes : UserControl
    {
        public MenuDesplegableAjustes()
        {
            InitializeComponent();
        }

        private void MenuDesplegable_Load(object sender, EventArgs e)
        {

        }

        private void MenuDesplegable_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            SesionIniciada.LimpiarSesion();
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                MessageBox.Show(form + " formulario");
                if (form.Name != "PrincipalForm") form.Close();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();

            new FormularioLogin().Show();
        }
    }
}
