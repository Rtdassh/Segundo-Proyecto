using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SegundoProyecto.Models
{

    internal class Test : UserControl
    {
        Color bc = Color.AliceBlue;
        int bh = 1;
        public Test()
        {
            DoubleBuffered = true;
            BackColor = Color.Transparent;
        }
        public Color BorderColor { get { return bc; } set { bc = value; Invalidate(); } }
        public int BorderHeight { get { return bh; } set { bh = value; Invalidate(); } }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            Pen p = new Pen(bc, Height - 4) { EndCap = LineCap.Round, StartCap = LineCap.Round };
            e.Graphics.DrawLine(p, new Point(Height / 2, Height / 2), new Point(Width-Height / 2, Height / 2));
            p.Width -=2 * bh; p.Color= Parent!.BackColor;

            e.Graphics.DrawLine(p, new Point(Height / 2, Height / 2), new Point(Width -Height / 2, Height / 2));
        }
    } 
}


