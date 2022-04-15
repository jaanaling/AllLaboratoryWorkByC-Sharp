using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Звезда
{
     public partial class Form1 : Form
    {
        //Инициализация bitmap и графики
        Bitmap myBitmap;
        Graphics g;
        //Создаем объекты для закрашивания фигур
        SolidBrush black = new SolidBrush(Color.Black);
        double pi = 3.14;//число Пи
        int points = 30;//количество концов звезды
        int deltangle = 0;//угол, на который происходит смещение
        int vnrad = 30;//внешний радиус звезды, который будет меняться
        int fon = 0;//переменная для изменения цвета фона
        int col = 1;//переменная для изменения цвета звезды
        //регулирование изменения размера радиуса (size) и угла (check)
        bool size = false;
        bool check = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //вызываем функцию таймера
            timer1.Start();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //функция прорисовки звезды, аргументами которой являются внешний (изменяющийся) и внутренний радиусы, центр, количество вершин звезды, цвет звезды и фона
        private void star(int R, int r, int x, int y, int amount, int angledelta, int col, int background)
        {
            //Создаем bitmap и графику из bitmap
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(myBitmap);
            //Сглаживание для графики
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //зарисовка фона, каждый раз разным оттенком
            g.FillRectangle(new SolidBrush(Color.FromArgb(background, background, background)), 0, 0, 500, 500);
            //угол между радиусами, образующими сектор (чтобы вершины звезды были равноудалены друг от друга на данный угол)
            double angle = 360 / amount + angledelta;
            //к значению угла добавляем переменную angledelta, которая способствует изменению угла, а следовательно и расположению вершин
            //запускаем цикл для прорисовки звездочки
            for (int i = 0; i < amount; i++)
            {
                //координаты вершин звезды
                double x1 = 0, y1 = 0;
                //перевод угла из градусов в радианы
                double anglerad = (angle * i * pi) / 180;
                //вычисление координат для вершин с меняющимся радиусом
                y1 = R * Math.Sin(anglerad) + y;
                x1 = R * Math.Cos(anglerad) + x;
                //координаты начала звезды
                double anglerad1 = anglerad + (angle * pi) / 360;
                double y2 = r * Math.Sin(anglerad1) + y;
                double x2 = r * Math.Cos(anglerad1) + x;
                double anglerad2 = (angle * (i - 1) * pi) / 180 + (angle * pi) / 360;
                double y3 = r * Math.Sin(anglerad2) + y;
                double x3 = r * Math.Cos(anglerad2) + x;
                //прорисовываем луч звезды определенным цветом
                switch (col)
                {
                    case 1:
                        g.DrawLine(new Pen(Color.White, 2), (int)x1, (int)y1, (int)x2, (int)y2);
                        g.DrawLine(new Pen(Color.White, 2), (int)x1, (int)y1, (int)x3, (int)y3);
                        break;

                    case 2:
                        g.DrawLine(new Pen(Color.Red, 2), (int)x1, (int)y1, (int)x2, (int)y2);
                        g.DrawLine(new Pen(Color.Red, 2), (int)x1, (int)y1, (int)x3, (int)y3);
                        break;
                    case 3:
                        g.DrawLine(new Pen(Color.Yellow, 2), (int)x1, (int)y1, (int)x2, (int)y2);
                        g.DrawLine(new Pen(Color.Yellow, 2), (int)x1, (int)y1, (int)x3, (int)y3);
                        break;
                    case 4:
                        g.DrawLine(new Pen(Color.Blue, 2), (int)x1, (int)y1, (int)x2, (int)y2);
                        g.DrawLine(new Pen(Color.Blue, 2), (int)x1, (int)y1, (int)x3, (int)y3);
                        break;
                    case 5:
                        g.DrawLine(new Pen(Color.Green, 2), (int)x1, (int)y1, (int)x2, (int)y2);
                        g.DrawLine(new Pen(Color.Green, 2), (int)x1, (int)y1, (int)x3, (int)y3);
                        break;
                    case 6:
                        g.DrawLine(new Pen(Color.Coral, 2), (int)x1, (int)y1, (int)x2, (int)y2);
                        g.DrawLine(new Pen(Color.Coral, 2), (int)x1, (int)y1, (int)x3, (int)y3);
                        break;
                    case 7:
                        g.DrawLine(new Pen(Color.Silver, 2), (int)x1, (int)y1, (int)x2, (int)y2);
                        g.DrawLine(new Pen(Color.Silver, 2), (int)x1, (int)y1, (int)x3, (int)y3);
                        break;
                    case 8:
                        g.DrawLine(new Pen(Color.Khaki, 2), (int)x1, (int)y1, (int)x2, (int)y2);
                        g.DrawLine(new Pen(Color.Khaki, 2), (int)x1, (int)y1, (int)x3, (int)y3);
                        break;
                    case 9:
                        g.DrawLine(new Pen(Color.Cyan, 2), (int)x1, (int)y1, (int)x2, (int)y2);
                        g.DrawLine(new Pen(Color.Cyan, 2), (int)x1, (int)y1, (int)x3, (int)y3);
                        break;
                    case 10:
                        g.DrawLine(new Pen(Color.Purple, 2), (int)x1, (int)y1, (int)x2, (int)y2);
                        g.DrawLine(new Pen(Color.Purple, 2), (int)x1, (int)y1, (int)x3, (int)y3);
                        break;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //если радиус не достиг максимального размера, то увеличиваем его, иначе уменьшаем
            if (size == false) vnrad++;
            if (size == true) vnrad--;
            //если угол не достиг максимального размера, то увеличиваем его, иначе уменьшаем
            if (check == false) deltangle++;
            if (check == true) deltangle--;
            //цвет звезды увеличиваем через каждые 5 шагов, т.е если deltangle делится на 5 без остатка
            if (deltangle % 5 == 0) col++;
            //если перебрали все 10 цветов, то возвращаемся к первому
            if (col > 10) col = 1;
            //фон изменяем с шагом два, при этом если звезда увеличивается, то фон светлеет, иначе темнеет
            if (size == false)
            {
                if (vnrad % 2 == 0) fon++;
            }
            if (size == true)
            {
                if (vnrad % 2 == 0) fon--;
            }
            //вызываем функцию прорисовки звезды
            star(vnrad, 30, this.Width / 2, this.Height / 2, points, deltangle, col, fon);
            //если мы дошли до максимального значения угла, то запомним это, чтобы затем уменьшать значение переменной deltangle
            if (deltangle == 100) check = true;
            //если значение deltangle минимально, то запомним это для последующего увеличения значения данной переменной 
            if (deltangle == 0) check = false;
            //если значение радиуса максимально, то переменной size присваиваем значение true, чтобы затем уменьшать радиус
            if (vnrad == 200) size = true;
            //если же значение радиуса минимально, то переменной size присваиваем значение false, чтобы затем увеличивать радиус
            if (vnrad == 30) size = false;
            //отображаем bitmap на PictureBox
            pictureBox1.Image = myBitmap;
        }
    }
}
