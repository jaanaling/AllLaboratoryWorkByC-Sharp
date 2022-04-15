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

namespace Кольца
{
    public partial class Form1 : Form
    {
        Bitmap buf; //Буфер для прорисовки промежуточных кадров
        Graphics _graphic; //Графика
        SolidBrush background = new SolidBrush(Color.Black); //Кисть для заливки фона

        //Объявление кругов
        //Класс описан в конце
        Circle c1 = new Circle();
        Circle c2 = new Circle();
        Circle c3 = new Circle();
        Circle c4 = new Circle();
        Circle c5 = new Circle();
        Circle c6 = new Circle();
        Circle c7 = new Circle();
        Circle c8 = new Circle();

        bool _in = false;  // если true круги движутся внутрь
        int XStart = 250;  //Начальная X координата
        int YStart = 250;  //Начальная Y координата
        double RStart = 280;  //Начальный радиус
        double DStart = 15;  //Начальная толщина круга
        int sec = 0;  //Счетчик кадров
        int time = 20;  //Количество кадров в одном цикле анимации
        int interval = 1000;  //Интервал между повторениями
        static int way = 80;  //Длина пути который проходит каждая окружность
        double dChenge = 8;  //Коэффициент изменения толщины окружности
        double rChenge = 40;  //Коэффициент изменения радиуса
        double xChenge = way * Math.Cos(0.3926991);  //Коэффициент изменения пути по X (длина пути * косинус 22.5 градусов)
        double yChenge = way * Math.Sin(0.3926991);  //Коэффициент изменения пути по Y (длина пути * синус 22.5 градусов)

        public Form1()
        {
            InitializeComponent();

            buf = new Bitmap(MainBox.Width, MainBox.Height);  //Определение буфера
            _graphic = Graphics.FromImage(buf);  //Определение графики из буфера
            _graphic.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Режим размытия графики
            MainBox.BackColor = background.Color;  //Цвет фона
            timer1.Enabled = true;  //Включение таймера

            //Стартовые координаты кругов
            c1.x = XStart; c1.y = YStart;
            c1.r = RStart; c1.d = DStart;
            c2.x = XStart; c2.y = YStart;
            c2.r = RStart; c2.d = DStart;
            c3.x = XStart; c3.y = YStart;
            c3.r = RStart; c3.d = DStart;
            c4.x = XStart; c4.y = YStart;
            c4.r = RStart; c4.d = DStart;
            c5.x = XStart; c5.y = YStart;
            c5.r = RStart; c5.d = DStart;
            c6.x = XStart; c6.y = YStart;
            c6.r = RStart; c6.d = DStart;
            c7.x = XStart; c7.y = YStart;
            c7.r = RStart; c7.d = DStart;
            c8.x = XStart; c8.y = YStart;
            c8.r = RStart; c8.d = DStart;
        }

        //Кнопка выхода
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Функция таймера выполняется каждые 5 мс
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_in)  //Если круги движутся наружу
            {
                //Изменение параметров всех кругов
                c1.d -= dChenge / time;  //Изменение толщины
                c1.r -= rChenge / time;  //Изменении радиуса
                c1.x -= xChenge / time;  //Изменение Х координаты
                c1.y -= yChenge / time;  //Изменение Y координаты

                c2.d -= dChenge / time;
                c2.r -= rChenge / time;
                c2.x += xChenge / time;
                c2.y -= yChenge / time;

                c3.d -= dChenge / time;
                c3.r -= rChenge / time;
                c3.x -= xChenge / time;
                c3.y += yChenge / time;

                c4.d -= dChenge / time;
                c4.r -= rChenge / time;
                c4.x += xChenge / time;
                c4.y += yChenge / time;

                c5.d -= dChenge / time;
                c5.r -= rChenge / time;
                c5.x -= yChenge / time;
                c5.y -= xChenge / time;

                c6.d -= dChenge / time;
                c6.r -= rChenge / time;
                c6.x += yChenge / time;
                c6.y -= xChenge / time;

                c7.d -= dChenge / time;
                c7.r -= rChenge / time;
                c7.x -= yChenge / time;
                c7.y += xChenge / time;

                c8.d -= dChenge / time;
                c8.r -= rChenge / time;
                c8.x += yChenge / time;
                c8.y += xChenge / time;
            }
            else //Если круги движутся внутрь, то изменение параметров обратно
            {
                c1.d += dChenge / time;
                c1.r += rChenge / time;
                c1.x += xChenge / time;
                c1.y += yChenge / time;

                c2.d += dChenge / time;
                c2.r += rChenge / time;
                c2.x -= xChenge / time;
                c2.y += yChenge / time;

                c3.d += dChenge / time;
                c3.r += rChenge / time;
                c3.x += xChenge / time;
                c3.y -= yChenge / time;

                c4.d += dChenge / time;
                c4.r += rChenge / time;
                c4.x -= xChenge / time;
                c4.y -= yChenge / time;

                c5.d += dChenge / time;
                c5.r += rChenge / time;
                c5.x += yChenge / time;
                c5.y += xChenge / time;

                c6.d += dChenge / time;
                c6.r += rChenge / time;
                c6.x -= yChenge / time;
                c6.y += xChenge / time;

                c7.d += dChenge / time;
                c7.r += rChenge / time;
                c7.x += yChenge / time;
                c7.y -= xChenge / time;

                c8.d += dChenge / time;
                c8.r += rChenge / time;
                c8.x -= yChenge / time;
                c8.y -= xChenge / time;
            }

            //Заливка фона и отрисовка всех кругов
            _graphic.Clear(background.Color);
            c1.Draw(_graphic);
            c2.Draw(_graphic);
            c3.Draw(_graphic);
            c4.Draw(_graphic);
            c5.Draw(_graphic);
            c6.Draw(_graphic);
            c7.Draw(_graphic);
            c8.Draw(_graphic);

            MainBox.Image = buf;

            if (sec >= time) { _in = !_in; Thread.Sleep(interval); sec = -1; }
            sec++;
        }
    }

    //Класс кругов
    class Circle
    {
        public double x, y;  //координаты центра
        public double r, d;  //Радиус и толщина

        public void Draw(Graphics g)//Метод отрисовки круга
        {
            g.DrawEllipse(new Pen(Color.Yellow, (int)d), (int)(x - r / 2), (int)(y - r / 2), (int)r, (int)r);
        }
    };
}
