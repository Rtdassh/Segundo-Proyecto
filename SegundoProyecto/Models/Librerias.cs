using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyecto.Models
{
    internal class Librerias
    {
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        public extern static void SendMessage(nint hWnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);

        // Constantes para los diferentes tipos de animaciones
        public const int AW_HIDE = 0x10000;      // Oculta la ventana
        public const int AW_ACTIVATE = 0x20000;  // Muestra la ventana
        public const int AW_BLEND = 0x80000;     // Desvanecer la ventana
        public const int AW_SLIDE = 0x40000;     // Deslizar la ventana
        public const int AW_HOR_POSITIVE = 0x1;  // Deslizar desde la izquierda a la derecha
        public const int AW_HOR_NEGATIVE = 0x2;  // Deslizar desde la derecha a la izquierda
        public const int AW_VER_POSITIVE = 0x4;  // Deslizar desde arriba hacia abajo
        public const int AW_VER_NEGATIVE = 0x8;  // Deslizar desde abajo hacia arriba
    }
}
