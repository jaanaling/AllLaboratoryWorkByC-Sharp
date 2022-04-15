using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анимация
{
    public partial class Form1 : Form
    {
        Graphics gr;       //объявляем объект - графику, на которой будем рисовать
        Pen p;             //объявляем объект - карандаш, которым будем рисовать контур
        SolidBrush fon;    //объявляем объект - заливки, для заливки соответственно фона
        SolidBrush fig;    //и внутренности рисуемой фигуры


        int rad;          // переменная для хранения радиуса рисуемых кругов
        Random rand;      // объект, для получения случайных чисел

        public Form1()
        {
            InitializeComponent();
        }

        //опишем функцию, которая будет рисовать круг по координатам его центра
        void DrawCircle(int x, int y)
        {
            int xc, yc;
            xc = x - rad;
            yc = y - rad;
            gr.FillEllipse(fig, xc, yc, rad, rad);

            gr.DrawEllipse(p, xc, yc, rad, rad);

        }
        // для перехода к данной функции сделайте двойной щелчок по кнопке (Button)
        // добавленной на форму. См. на фото, после кода
        private void button1_Click(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();  //инициализируем объект типа графики
                                                // привязав  к PictureBox

            p = new Pen(Color.Lime);           // задали цвет для карандаша 
            fon = new SolidBrush(Color.Black); // и для заливки
            fig = new SolidBrush(Color.Purple);

            rad = 40;                          //задали радиус для круга
            rand = new Random();               //инициализируем объект для рандомных числе

            gr.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height); // закрасим черным 
                                                                                // нашу область рисования

            // вызываем написанную нами функцию, для прорисовки круга
            // случайным образом выбрав перед этим координаты центра
            int x, y;

            for (int i = 0; i < 15; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawCircle(x, y);
            }

            timer1.Enabled = true;  //включим в работу наш таймер,
                                    // то есть теперь будет происходить событие Tick и его будет обрабатывать функция //On_Tick (по умолчанию)

        }
        // для получения данной функции перейдите к конструктору формы 
        // и сделайте двойной щелчок по таймеру, добавленному на форму. См. на фото после кода
        private void timer1_Tick(object sender, EventArgs e)
        {
            //сначала будем очищать область рисования цветом фона
            gr.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height);

            // затем опять случайным образом выбираем координаты центров кругов
            // и рисуем их при помощи описанной нами функции
            int x, y;

            for (int i = 0; i < 15; i++)
            {
                x = rand.Next(pictureBox1.Width);
                y = rand.Next(pictureBox1.Height);
                DrawCircle(x, y);
            }

        }
    }
}
