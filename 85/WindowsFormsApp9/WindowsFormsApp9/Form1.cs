using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            e.Graphics.FillEllipse(Brushes.DarkBlue, new Rectangle(300, 100, 60, 60));
            e.Graphics.FillRectangle(Brushes.Black, new Rectangle(200, 200, 110, 110));
            e.Graphics.CopyFromScreen(new Point(10, 10), new Point(100, 300), new Size(70, 70));


                        Point[] points = {
               new Point(75, 0),
               new Point(100, 50),
               new Point(150, 50),
               new Point(112, 75),
               new Point(150, 150),
               new Point(75, 100),
               new Point(0, 150),
               new Point(37, 75),
               new Point(0, 50),
               new Point(50, 50)};

                        Color[] colors = {
               Color.FromArgb(255, 0, 0, 0),
               Color.FromArgb(255, 0, 255, 0),
               Color.FromArgb(255, 0, 0, 255),
               Color.FromArgb(255, 255, 255, 255),
               Color.FromArgb(255, 0, 0, 0),
               Color.FromArgb(255, 0, 255, 0),
               Color.FromArgb(255, 0, 0, 255),
               Color.FromArgb(255, 255, 255, 255),
               Color.FromArgb(255, 0, 0, 0),
               Color.FromArgb(255, 0, 255, 0)};

            GraphicsPath path = new GraphicsPath();
            path.AddLines(points);
            // Используйте путь для построения градиентной кисти пути.
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            // Установите цвет в центре пути на красный.
            pthGrBrush.CenterColor = Color.FromArgb(255, 255, 0, 0);
            pthGrBrush.SurroundColors = colors;
            // Заполните контур градиентной кистью path.
            e.Graphics.FillPath(pthGrBrush, path);


            DrawEllipse();
            DrawRectangle();
            DrawString();

           
        }
        private void DrawEllipse()
        {
            Pen myPen = new Pen(Color.Red);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawEllipse(myPen, new Rectangle(400, 0, 100, 200));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void DrawRectangle()
        {
           Pen myPen = new Pen(Color.Red);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(400, 0, 100, 200));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        public void DrawString()
        {
           Graphics formGraphics = this.CreateGraphics();
            string drawString = "Sample Text";
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = 150.0F;
            float y = 50.0F;
            StringFormat drawFormat = new StringFormat();
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}
