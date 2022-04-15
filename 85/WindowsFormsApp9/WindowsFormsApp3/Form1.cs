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

namespace WindowsFormsApp3
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
        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            g.FillRectangle(new SolidBrush(Color.White), ClientRectangle);
            GraphicsPath path = new GraphicsPath(new Point[] {
    new Point(40, 40), new Point(275, 100),
    new Point(105, 125), new Point(190, 200),
    new Point(50, 250), new Point(20, 80), }, new byte[] {
    (byte)PathPointType.Start,
    (byte)PathPointType.Bezier,
    (byte)PathPointType.Bezier,
    (byte)PathPointType.Bezier,
    (byte)PathPointType.Line,
    (byte)PathPointType.Line,
    });
            PathGradientBrush pgb = new PathGradientBrush(path);
            pgb.SurroundColors = new Color[] { Color.Green,Color.Yellow,Color.Red, Color.Blue,
    Color.Orange, Color.White, };
            g.FillPath(pgb, path);
        }

    }
}
