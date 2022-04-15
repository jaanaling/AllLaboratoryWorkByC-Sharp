using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const Single DALPHA = (Single)Math.PI / 10;
        private static double theta = 0;

        private void tmrAtom_Tick(object sender, EventArgs e)//имя таймера tmrAtom, Interval = 100
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            const double DTHETA = Math.PI / 5;

            e.Graphics.Clear(this.BackColor);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            theta += DTHETA;

            const int E_RADIUS = 3;
            int cx = 50;
            int cy = 50;
            int rx = 45;
            int ry = 15;

            Rectangle rect = new Rectangle(-rx, -ry, 2 * rx, 2 * ry);
            double x, y;

            e.Graphics.RotateTransform(60, System.Drawing.Drawing2D.MatrixOrder.Append);
            e.Graphics.TranslateTransform(cx, cy, System.Drawing.Drawing2D.MatrixOrder.Append);
            // Рисуем красный эллипс-орбиту
            e.Graphics.DrawEllipse(Pens.Red, rect);

            // Рисуем красный атом
            x = rx * Math.Cos(theta);
            y = ry * Math.Sin(theta);
            e.Graphics.FillEllipse(Brushes.Red, (int)(x - E_RADIUS), (int)(y - E_RADIUS),
                2 * E_RADIUS, 2 * E_RADIUS);

            e.Graphics.ResetTransform();
            e.Graphics.RotateTransform(-60, System.Drawing.Drawing2D.MatrixOrder.Append);

            // Рисуем второй эллипс-орбиту
            e.Graphics.TranslateTransform(cx, cy, System.Drawing.Drawing2D.MatrixOrder.Append);
            e.Graphics.DrawEllipse(Pens.Red, rect);

            // Рисуем зеленый электрон
            x = rx * Math.Cos(-theta * 0.9);
            y = ry * Math.Sin(-theta * 0.9);
            e.Graphics.FillEllipse(Brushes.Green, (int)(x - E_RADIUS), (int)(y - E_RADIUS), 2 * E_RADIUS, 2 * E_RADIUS);

            e.Graphics.ResetTransform();
            e.Graphics.TranslateTransform(cx, cy, System.Drawing.Drawing2D.MatrixOrder.Append);
            // Рисуем третий эллипс орбиту электрона
            e.Graphics.DrawEllipse(Pens.Red, rect);
            x = rx * Math.Cos(theta * 0.8);
            y = ry * Math.Sin(theta * 0.8);
            // Рисуем синий электрон
            e.Graphics.FillEllipse(Brushes.Blue, (int)(x - E_RADIUS), (int)(y - E_RADIUS), 2 * E_RADIUS, 2 * E_RADIUS);

            e.Graphics.ResetTransform();

            // Рисуем атом в центре
            const int N_RADIUS = 4;
            e.Graphics.FillEllipse(Brushes.Black, cx - N_RADIUS, cy - N_RADIUS, 2 * N_RADIUS, 2 * N_RADIUS);
        }
    }
}
