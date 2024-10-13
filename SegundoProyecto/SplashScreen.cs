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
    public partial class SplashScreen : Form
    {
        int contador = 0;
        public SplashScreen()
        {
            InitializeComponent();
            timerSplashScreen.Start();
        }

        private void timerSplashScreen_Tick(object sender, EventArgs e)
        {
            contador += 100;
            if(label3.Text.Contains("...")) label3.Text = "Cargando";
            label3.Text += "."; 
            if (contador == 1000)
            {
                new FormularioLogin().Show();
                this.Hide();
                this.Close();
                timerSplashScreen.Stop();
            }
        }

    }
}
