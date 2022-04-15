using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Выбираем перо "myPen" черного цвета Black
            //толщиной в 1 пиксель:
            Pen myWind = new Pen(Color.Black, 2);
            //Объявляем объект "g" класса Graphics и предоставляем
            //ему возможность рисования на pictureBox1:
            Graphics g = pictureBox1.CreateGraphics();
            // Создаем объекты для закрашивания фигур
            SolidBrush myCorp = new SolidBrush(Color.Black);
            SolidBrush myTrum = new SolidBrush(Color.Green);
            SolidBrush myTrub = new SolidBrush(Color.Gray);
            SolidBrush mySe = new SolidBrush(Color.Blue);
            // Закрашиваем фигуры
            g.FillRectangle(myTrub, 300, 125, 75, 75);
            g.FillRectangle(myTrub, 480, 125, 75, 75);
            g.FillPolygon(myCorp, new Point[] {
                new Point(100,300),new Point(700,300),
                new Point(700,300),new Point(600,400),
                new Point(600,400),new Point(200,400),
                new Point(200,400),new Point(100,300)
            });
            g.FillRectangle(myTrum, 250, 200, 350, 100);
            int x = 50;
            int Radius = 50;
            // Море
            while (x <= pictureBox1.Width - Radius)
            {
                g.FillPie(mySe, 0 + x, 375, 50, 50, 0, -180);
                x += 50;
            }
            // Окошки
            for (int y = 300; y <= 550; y += 50)
            {
                g.DrawEllipse(myWind, y, 240, 20, 20);
            }

        }
    }
}
