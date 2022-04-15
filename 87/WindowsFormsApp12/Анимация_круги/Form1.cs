using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Анимация_круги
{
    public partial class Form1 : Form
    {
        Bitmap myBitmap; //объявляем bitmap
        Graphics g; //объявляем графику

        SolidBrush bgcol = new SolidBrush(Color.Black); //цвет фона
        SolidBrush col1 = new SolidBrush(Color.White); //белый и черный цвета кругов
        SolidBrush col2 = new SolidBrush(Color.Black);

        float x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6, x7, y7, x8, y8, x9, y9, x10, y10; //объявляем координаты каждого круга

        float shag = 0; //переменная для движения
        int cnt = 0; //счетчик для анимации

        public Form1()
        {
            InitializeComponent(); //инициализация компонентов на форме
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); //при загрузке формы начинается анимация
        }

        private void Circles()//функция изменения фигуры
        {
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);//создаем битмап
            g = Graphics.FromImage(myBitmap);//создаем графику                       
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//добавляем сглаживание
            g.FillRectangle(bgcol, 0, 0, 500, 500);//заливаем фон

            g.TranslateTransform((float)pictureBox1.Width / 2, (float)pictureBox1.Height / 2);//смещаем начало координат в центр

            x10 = -23 + shag;//задаем начальные координаты кругов с переменной shag, которая будет меняться в процессе анимации
            y10 = -23;

            x9 = -46 - shag;
            y9 = -46;

            x8 = -69 + shag;
            y8 = -69;

            x7 = -92 - shag;
            y7 = -92;

            x6 = -115 + shag;
            y6 = -115;

            x5 = -138 - shag;
            y5 = -138;

            x4 = -161 + shag;
            y4 = -161;

            x3 = -184 - shag;
            y3 = -184;

            x2 = -207 + shag;
            y2 = -207;

            x1 = -230 - shag;
            y1 = -230;

            g.FillEllipse(col1, x1, y1, 460, 460);//рисуем круги с заданными координатами
            g.FillEllipse(col2, x2, y2, 414, 414);
            g.FillEllipse(col1, x3, y3, 368, 368);
            g.FillEllipse(col2, x4, y4, 322, 322);
            g.FillEllipse(col1, x5, y5, 276, 276);
            g.FillEllipse(col2, x6, y6, 230, 230);
            g.FillEllipse(col1, x7, y7, 184, 184);
            g.FillEllipse(col2, x8, y8, 138, 138);
            g.FillEllipse(col1, x9, y9, 92, 92);
            g.FillEllipse(col2, x10, y10, 46, 46);

            pictureBox1.BackgroundImage = myBitmap;//отображаем битмап на pictureBox

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            cnt++; // с каждым шагов увеличиваем счетчик на 1
            if (cnt <= 20) //если значение cnt меньше либо равно 20,...
            {
                shag += (float)0.5; //...то движемся вправо(белые кружки)/влево(черные кружки)
            }
            if (cnt >= 20) //если cnt превысило 20...(1)
            {
                if (cnt >= 60) //если cnt превысило 60...(2)
                {
                    if (cnt == 80) //если cnt дошло до 80 (конец анимации), то
                    {
                        shag = 0; //обнуляем все значения и начинаем сначала
                        cnt = 0;
                    }
                    shag += (float)1; //...(2), то движемся вправо(белые кружки)/влево(черные кружки) к начальной позиции
                }
                shag += (float)-0.5; //...(1), то движемся в обратную сторону
            }

            Circles();//прорисовываем круги
        }
    }
}

