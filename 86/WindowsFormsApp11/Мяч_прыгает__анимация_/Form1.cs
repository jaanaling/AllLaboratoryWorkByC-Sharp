using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Мяч_прыгает__анимация_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Задаем ширину и высоту прямоугольника, внутри которого будет летать мяч: 
        int width_of_rectangle = 1000;
        int height_of_rectangle = 500;

        //Верхняя горизонтальная линия пpямоугольник
        //от оси ‘х’ на расстоянии boundai, rectangle_y: 
        int boundary_of_rectangle_y = 15;
        //Левая вертикальная линия прямоугольника отстоит от оси ‘у’ на расстоянии boundary of_rectangle_x:	
        int boundary_of_rectangle_x = 15;
        //Размер мяча size_of_ball, как часть (доля) от размеров прямоугольника:	
        int size_of_ball = 20;
        //Величина перемещения мяча size_of_move как часть (доля) от размеров мяча:
        int size_of_move_of_ball = 5;
        //Создаем объект myBitmap класса Bitmap: 
        private Bitmap myBitmap;
        //Объявляем целочисленные переменные: 
        int position_of_ball_x, position_of_ball_y, radius_of_ball_x, radius_of_ball_y, move_of_ball_x,
            move_of_ball_y, width_of_bitmap_of_ball, height_of_bitmap_of_ball, width_of_margin_of_bitmap,
            height_of_margin_of_bitmap;
        //--------------------------------------------------------------------------------------
        bool OffOn = false;
        private void button1_Click(object sender, EventArgs e)
        {
            //Задаем чередование остановки и возобновления анимации после каждого щелчка кнопки button2: 
            if (OffOn == false)
            {
                //Приостанавливаем анимацию:
                timer1.Enabled = false;
                //Изменяем значение OffOn на противоположное: 
                OffOn = true;
            }
            else
                //Возобновляем анимацию: 
                timer1.Enabled = true;
            //Изменяем значение OffOn на противоположное: 
            OffOn = false;

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = trackBar1.Value;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Создаем объект myGraphics класса Graphics:
            Graphics myGraphics = CreateGraphics();
            //Рисуем четыре граничные линии прямоугольника, от которых будет отскакивать летающий мяч: 

            myGraphics.DrawLine(new Pen(Color.Red, 3), boundary_of_rectangle_x, boundary_of_rectangle_y,
                width_of_rectangle, boundary_of_rectangle_y);
            myGraphics.DrawLine(new Pen(Color.Red, 3), boundary_of_rectangle_x, boundary_of_rectangle_y,
                boundary_of_rectangle_x, height_of_rectangle);
            myGraphics.DrawLine(new Pen(Color.Red, 3), boundary_of_rectangle_x, height_of_rectangle,
                width_of_rectangle, height_of_rectangle);
            myGraphics.DrawLine(new Pen(Color.Red, 3), width_of_rectangle, boundary_of_rectangle_y,
width_of_rectangle, height_of_rectangle);
            //------------------------------------------------------------------------- 
            //Рисуем изображение мяча на диалоговой панели Form1 при помощи метода DrawImage:
            myGraphics.DrawImage(myBitmap, Convert.ToInt32(position_of_ball_x - width_of_bitmap_of_ball / 2),
                Convert.ToInt32(position_of_ball_y - height_of_bitmap_of_ball / 2),
            width_of_bitmap_of_ball, height_of_bitmap_of_ball);

            //Высвобождаем ресурсы, выделенные объекту myGraphics: 
            myGraphics.Dispose();
            //После изображения мяча с текущими координатами увеличиваем координаты мяча
            //на шаг перемещения в направлении осей 'x’ и ‘ у’: 
            position_of_ball_x = position_of_ball_x - move_of_ball_x;
            position_of_ball_y = position_of_ball_y + move_of_ball_y;

            //Изменяем направление перемещения мяча по оси 'х’, когда мяч ударяется о какую-либо из двух 
            //граничных вертикальных линий прямоугольника: 
            if (position_of_ball_x + radius_of_ball_x >= width_of_rectangle)
            {
                move_of_ball_x = -move_of_ball_x;
                //В момент удара подаем звуковой сигнал Веер: 
                //Microsoft.VisualBasic.Interaction.Веер();
            }
            if (position_of_ball_x - radius_of_ball_x <= boundary_of_rectangle_x)
            {
                move_of_ball_x = -move_of_ball_x;
                //  Microsoft.VisualBasic.Interaction.Beep();

            }   //Изменяем направление перемещения мяча по оси ’у',
                //когда мяч ударяется о какую-либо из двух граничных горизонтальных линий прямоугольника:
            if (position_of_ball_y + radius_of_ball_y >= height_of_rectangle)
            {
                move_of_ball_y = -move_of_ball_y;
                // Microsoft.VisualBasic.Interaction.Beep();
            }
            if (position_of_ball_y - radius_of_ball_y <= boundary_of_rectangle_y)
            {
                move_of_ball_y = -move_of_ball_y;
                //    Microsoft.VisualBasic.Interaction.Beep();	
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Создаем объект myGraphics класса Graphics и стираем другие изображения:
            Graphics myGraphics = CreateGraphics(); myGraphics.Clear(BackColor);
            //Задаем радиус мяча как дробь (часть) от ширины или высоты прямоугольника,
            //в зависимости от того, какая дробь меньше: 
            double radius_of_ball = Math.Min(width_of_rectangle / myGraphics.DpiX,
                height_of_rectangle / myGraphics.DpiY) / size_of_ball;

            //Задаем ширину и высоту мяча в dpi (точки на дюйм) для единиц разрешения изображения
            //по горизонтали и вертикали, что идентично значениям в направлении осей ‘х’ и ‘у’:

            radius_of_ball_x = Convert.ToInt32(radius_of_ball * myGraphics.DpiX);
            radius_of_ball_y = Convert.ToInt32(radius_of_ball * myGraphics.DpiY);

            //Высвобождаем ресурсы, выделенные объекту myGraphics 
            myGraphics.Dispose();
            //Задаем шаг перемещения мяча в 1 пиксель, или как часть (дробь, доля) от размера шара,
            //в зависимости от того, какая величина больше.
            //Это означает, что на каждом шаге перемещение мяча пропорционально его размеру,
            //а размер мяча, в свою очередь, пропорционален размеру прямоугольника.
            //Таким образом, при прочих равных условиях,	когда размеры прямоугольника уменьшаются,	
            //перемещение мяча замедляется, а когда размеры увеличиваются, перемещение мяча ускоряется: 
            move_of_ball_x = Convert.ToInt32(Math.Max(1, radius_of_ball_x / size_of_move_of_ball));
            move_of_ball_y = Convert.ToInt32(Math.Max(1, radius_of_ball_y / size_of_move_of_ball));

            //Значение перемещения мяча также определяет поле изображения вокруг мяча.	
            //На каждом шаге перемещение мяча равно перемещению поля изображения,	
            //что позволяет стирать предыдущее изображение перед каждым последующим изображением мяча 
            //без мерцания:
            width_of_margin_of_bitmap = move_of_ball_x;
            height_of_margin_of_bitmap = move_of_ball_y;

            //Определяем фактический размер изображения, где нарисован мяч,
            //прибавляя поля к размерам мяча:
            width_of_bitmap_of_ball = 2 * (radius_of_ball_x + width_of_margin_of_bitmap);
            height_of_bitmap_of_ball = 2 * (radius_of_ball_y + height_of_margin_of_bitmap);

            // Создаем новый рисунок мяча соответствующей ширины и высоты:
            myBitmap = new Bitmap(width_of_bitmap_of_ball, height_of_bitmap_of_ball);

            //Получаем объект класса Graphics для изображения мяча,
            //удаляем существующий мяч и рисуем новый мяч. 
            //Задаем черный цвет Black для мяча, чтобы он был лучше виден в прямоугольнике: 
            myGraphics = Graphics.FromImage(myBitmap); myGraphics.Clear(BackColor);
            myGraphics.FillEllipse(Brushes.Black,
               new Rectangle(move_of_ball_x, move_of_ball_y, radius_of_ball_x, radius_of_ball_y));
            //Высвобождаем ресурсы, выделенные объекту myGraphics: 
            myGraphics.Dispose();
            position_of_ball_x = Convert.ToInt32(width_of_rectangle / 2);
            position_of_ball_y = Convert.ToInt32(height_of_rectangle / 2);
        }

    }
}
