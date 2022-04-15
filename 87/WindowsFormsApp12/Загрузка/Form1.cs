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

namespace Загрузка
{
    public partial class Form1 : Form
    {

        Graphics g;
        SolidBrush fon;
        int R = 2;//Радиус по умолчанию маленьких эллипсов
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void func(int z)
        {


            fon = new SolidBrush(Color.White);

            g.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height);
            double a = 0;
            double[] x = new double[1000];
            double[] y = new double[1000];
            for (int i = 0; i < 17; i++)//создание массива большого круга с радиусом 150px, центром в точке 200:200, и 17 точек для создания маленьких кругов
            {
                x[i] = 200 + 150 * Math.Cos(a);
                y[i] = 200 + 150 * Math.Sin(a);
                a += (Math.PI * 150 / 17) * 5;
            }

            if (z < 9)
            {
                for (int i = z; i < 9 + z; i++)
                {
                    g.FillEllipse(new SolidBrush(Color.Black), (int)x[i] + R, (int)y[i] + R, R * 2, R * 2);
                    //цикл отрисовки маленьких кругов до начала нового круга
                    R++;
                }

            }
            if (z > 8)
            {
                R = 2;
                for (int i = z; i < 17; i++)//цикл отрисовки ухода круга
                {
                    g.FillEllipse(new SolidBrush(Color.Black), (int)x[i] + R, (int)y[i] + R, R * 2, R * 2);
                    R++;
                }

                for (int j = 0; j < z - 8; j++)//цикл отрисовки нового круга
                {
                    g.FillEllipse(new SolidBrush(Color.Black), (int)x[j] + R, (int)y[j] + R, R * 2, R * 2);
                    R++;

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            fon = new SolidBrush(Color.White);
            g.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height);
            timer1.Enabled = true;//включение таймера


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.FillRectangle(fon, 0, 0, pictureBox1.Width, pictureBox1.Height);
            for (int x = 0; x < 18; x++)
            {
                R = 2;
                func(x);
                Thread.Sleep(50);//задержка таймера
            }


        }
    }
}
