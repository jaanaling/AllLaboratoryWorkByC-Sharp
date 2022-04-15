using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace что_то
{
    public partial class Form1 : Form
    {
        Bitmap buf; //Буфер для прорисовки промежуточных кадров
        Graphics _graphic; //Графика
        Color background = Color.Blue; //Кисть для заливки фона
        Color mainColor = Color.White; // Основной цвет
        public SolidBrush SquareBrush;
        public SolidBrush CircleBrush;

        int stage = 1;
        int fps = 50;//Количество кадров в 1й стадии

        Point Center;//Центр экрана
        Point[] Squere;//Точки квадрата
        float SqureRadius;
        circle lt, rt, rd, ld;//Круги

        int Angle;//Угол

        public Form1()
        {
            InitializeComponent();

            Center = new Point(MainBox.Width / 2, MainBox.Height / 2);
            buf = new Bitmap(MainBox.Width, MainBox.Height);//Определение буфера
            _graphic = Graphics.FromImage(buf);//Определение графики из буфера
            _graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Режим размытия граффики
            MainBox.BackColor = background;//Цвет фона
            timer1.Enabled = true;//Включение таймера


            lt = new circle(Center.X - 50, Center.Y - 50, 45);
            rt = new circle(Center.X + 50, Center.Y - 50, 45);
            rd = new circle(Center.X + 50, Center.Y + 50, 45);
            ld = new circle(Center.X - 50, Center.Y + 50, 45);

            Squere = new Point[4];

            SqureRadius = (float)Math.Sqrt(20000) / 2;

            CircleBrush = new SolidBrush(mainColor);
            SquareBrush = new SolidBrush(background);

        }

        //Кнопка выхода
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Функция таймера выполняется каждые 5 мс
        private void timer1_Tick(object sender, EventArgs e)
        {

            _graphic.Clear(background);

            lt.stage = stage;
            rd.stage = stage;
            ld.stage = stage;
            rt.stage = stage;

            //Вычисление угала поворота
            Angle = (Angle + 90 / fps) % 360;

            if (stage == 1)
            {

                //вычисление новых координат для кругов через угол поворота
                lt.center.X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * ((-Angle + 135) % 360))) + Center.X;
                lt.center.Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * ((-Angle + 135) % 360))) + Center.Y;
                rt.center.X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * ((-Angle + 45) % 360))) + Center.X;
                rt.center.Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * ((-Angle + 45) % 360))) + Center.Y;
                rd.center.X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * ((-Angle + 315) % 360))) + Center.X;
                rd.center.Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * ((-Angle + 315) % 360))) + Center.Y;
                ld.center.X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * ((-Angle + 225) % 360))) + Center.X;
                ld.center.Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * ((-Angle + 225) % 360))) + Center.Y;
                //Вычисление новых кординат для квадрата
                Squere[0].X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * ((Angle + 225) % 360))) + Center.X;
                Squere[0].Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * ((Angle + 225) % 360))) + Center.Y;
                Squere[1].X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * ((Angle + 315) % 360))) + Center.X;
                Squere[1].Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * ((Angle + 315) % 360))) + Center.Y;
                Squere[2].X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * ((Angle + 45) % 360))) + Center.X;
                Squere[2].Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * ((Angle + 45) % 360))) + Center.Y;
                Squere[3].X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * ((Angle + 135) % 360))) + Center.X;
                Squere[3].Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * ((Angle + 135) % 360))) + Center.Y;

                //Отрисовка
                lt.Draw(_graphic, CircleBrush);
                rt.Draw(_graphic, CircleBrush);
                rd.Draw(_graphic, CircleBrush);
                ld.Draw(_graphic, CircleBrush);
                _graphic.FillPolygon(SquareBrush, Squere);//Отрисовка квадрата

                //Условие смены стадии
                if (lt.center.X >= 300 && lt.center.Y >= 200)
                {
                    Angle = 0;
                    stage = 2;
                    lt.angleOfRotate = 0;
                    rt.angleOfRotate = 270;
                    rd.angleOfRotate = 180;
                    ld.angleOfRotate = 90;
                    Thread.Sleep(100);// Задежка

                }
            }
            else if (stage == 2)
            {

                lt.center.X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * (Angle + 135))) + Center.X;
                lt.center.Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * (Angle + 135))) + Center.Y;
                rt.center.X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * (Angle + 45))) + Center.X;
                rt.center.Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * (Angle + 45))) + Center.Y;
                rd.center.X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * (Angle + 315))) + Center.X;
                rd.center.Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * (Angle + 315))) + Center.Y;
                ld.center.X = (int)(SqureRadius * Math.Cos((Math.PI / 180) * (Angle + 225))) + Center.X;
                ld.center.Y = (int)(SqureRadius * Math.Sin((Math.PI / 180) * (Angle + 225))) + Center.Y;
                lt.angleOfRotate = -Angle * 3;
                rt.angleOfRotate = 270 - Angle * 3;
                rd.angleOfRotate = 180 - Angle * 3;
                ld.angleOfRotate = 90 - Angle * 3;


                lt.Draw(_graphic, CircleBrush);
                rt.Draw(_graphic, CircleBrush);
                rd.Draw(_graphic, CircleBrush);
                ld.Draw(_graphic, CircleBrush);

                if (lt.center.X >= 200 && lt.center.Y <= 200)
                {

                    Angle = 0;
                    stage = 1;
                    Thread.Sleep(100);// Задержка
                }

            }

            MainBox.Image = buf;

        }

        // Класс кругов

        public class circle
        {
            public int stage = 1;
            public Point center;
            public int radius;
            public int angleOfRotate = 0;// Угол поворота круга

            public void Draw(Graphics g, Brush b)
            {
                if (stage == 1)
                {
                    g.FillEllipse(b, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
                }
                else if (stage == 2)
                {
                    g.FillPie(b, center.X - radius, center.Y - radius, 2 * radius, 2 * radius, angleOfRotate, 270);
                }
            }

            //конструктор
            public circle(int x, int y, int r)
            {
                center.X = x;
                center.Y = y;
                radius = r;
            }
        }
    }
}

