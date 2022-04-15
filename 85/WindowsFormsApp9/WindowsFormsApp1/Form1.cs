using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            OnPaint(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 2);
            Font verdanaFont = new Font("Verdana", 60, FontStyle.Bold);

            Point[] curvePoints1 = { new Point(200, 15),
    new Point(200, 200), new Point(375, 250) };
            Point[] curvePoints2 = { new Point(0, 250),
    new Point(200, 200), new Point(375, 250) };
            Point[] curvePoints3 = { new Point(200, 15),
    new Point(200, 200), new Point(0, 250) };

            Point pt1 = new Point(10, 10);
            Point pt2 = new Point(30, 30);
            LinearGradientBrush lgBrush1 = new LinearGradientBrush(pt1, pt2, Color.Red, Color.Blue);

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.FillPolygon(new SolidBrush(Color.PowderBlue), curvePoints1);
            e.Graphics.FillPolygon(new SolidBrush(Color.Purple), curvePoints2);
            e.Graphics.FillPolygon(new SolidBrush(Color.Navy), curvePoints3);

            g.DrawString("C#", verdanaFont, lgBrush1, new PointF(125, 120));

            g.Dispose();
        }






    }
}
