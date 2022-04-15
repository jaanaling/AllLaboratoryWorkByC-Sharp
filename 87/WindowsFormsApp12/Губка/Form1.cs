using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Губка
{
    public partial class Form1 : Form
    {
        // объявляем объект типа Bitmap, который будет буфером для хранения
        // и прорисовки изображений
        Bitmap myBitmap;

        // объявляем "средства" рисования - графику, перо и заливку
        Graphics gr;
        Pen pen;
        SolidBrush brush;
    
        // объявляем переменные для хранения центра рисуемого изображения
        // и смещения его относительно заданного центра
        int centerX;
        int centerY;
        int offsetX;
        int offsetY;

        // переменные для движения в анимации
        int movX;
        int movY;

        // объявляем объекты - части тела, рисуемого изображения
        // писание соответствующих классов будет ниже
        Circles circ;
        Chest ch;
        Shirt sh;
        Pants pa;
        Legs le;
        Cuffs cu;
        LHand lha;
        RHand rha;
        Eye bEye;
        Eye fEye;
        Mouth mo;

        // описание функции, для задания смещения изображения
        // при анимации, которая использует функции-методы определенных классов
        void setOffset(int x, int y)
        {
            ch.setOffset(x, y);
            bEye.setOffset(x, y);
            fEye.setOffset(x, y);
            mo.setOffset(x, y);
            lha.setOffset(x, y);
            rha.setOffset(x, y);
        }

        //класс - туловище изображения
        // так как само содержимое классов не сильно отличается, то 
        // только данный класс будет описан подробно
        // остальным будет дано лишь описание рисуемой части "тела"
        public class Chest
        {
            // переменные для хранения центра и смещения изображения
            int cenX;
            int cenY;
            int offsX;
            int offsY;
            // заливка туловища
            SolidBrush BrChest = new SolidBrush(Color.Yellow);

            // конструктор класса, который определеяем центр и смещение
            public Chest(int Cx, int Cy, int offX, int offY)
            {
                cenX = Cx;
                cenY = Cy;
                offsX = offX;
                offsY = offY;
            }

            // функция, для задания смещения при анимации
            public void setOffset(int x, int y)
            {
                offsX += x;
                offsY += y;
            }

            // функция для прорисовка данной части "тела"
            // принимает графику, которой рисует и перо
            public void Draw(Graphics b, Pen p)
            {
                // рисуем переднюю часть туловища
                Rectangle Chest1 = new Rectangle(cenX - 150 + offsX, cenY - 175 + offsY, 220, 175);
                b.FillRectangle(BrChest, Chest1);
                b.DrawRectangle(p, Chest1);

                // определяем многоугольник для того, чтобы придать
                // ощущение объемного тела изображения
                Point[] Chest2 = new Point[]{
                new Point(cenX - 150 + offsX, cenY - 175 + offsY),
                new Point(cenX - 175 + offsX, cenY - 160 + offsY),

                new Point(cenX - 175 + offsX, cenY + 15 + offsY),
                new Point(cenX - 150 + offsX, cenY + offsY)
            };
                // заливаем полученную фигуру
                b.FillPolygon(BrChest, Chest2);
                b.DrawPolygon(p, Chest2);

            }
        }

        //класс для рисования рубашки (слой между телом и штанами)
        //никуда не сдвигается при анимации
        public class Shirt
        {
            int cenX;
            int cenY;
            int offsX;
            int offsY;
            SolidBrush BrShirt = new SolidBrush(Color.LightSteelBlue);

            public Shirt(int Cx, int Cy, int offX, int offY)
            {
                cenX = Cx;
                cenY = Cy;
                offsX = offX;
                offsY = offY;
            }
            public void Draw(Graphics b, Pen p)
            {
                Rectangle Shirt1 = new Rectangle(cenX - 150 + offsX, cenY + offsY, 220, 50);
                b.FillRectangle(BrShirt, Shirt1);
                b.DrawRectangle(p, Shirt1);

                Point[] Shirt2 = new Point[]{
                    new Point(cenX - 150 + offsX, cenY + offsY),
                    new Point(cenX - 175 + offsX, cenY  + 15 + offsY),

                    new Point(cenX - 175 + offsX, cenY + 65 + offsY),
                    new Point(cenX - 150 + offsX, cenY + 50 + offsY)
            };
                b.FillPolygon(BrShirt, Shirt2);
                b.DrawPolygon(p, Shirt2);
            }
        }

        //класс для рисования штанов
        //никуда не сдвигается при анимации
        public class Pants
        {
            int cenX;
            int cenY;
            int offsX;
            int offsY;
            SolidBrush BrPants = new SolidBrush(Color.SaddleBrown);

            public Pants(int Cx, int Cy, int offX, int offY)
            {
                cenX = Cx;
                cenY = Cy;
                offsX = offX;
                offsY = offY;
            }

            public void Draw(Graphics b, Pen p)
            {
                Rectangle Pants1 = new Rectangle(cenX - 150 + offsX, cenY + 50 + offsY, 220, 50);
                b.FillRectangle(BrPants, Pants1);
                b.DrawRectangle(p, Pants1);

                Point[] Pants2 = new Point[]{
                    new Point(cenX - 150 + offsX, cenY  + 50 + offsY),
                    new Point(cenX - 175 + offsX, cenY  + 65 + offsY),

                    new Point(cenX - 175 + offsX, cenY   + 115 + offsY),
                    new Point(cenX - 150 + offsX, cenY  + 100 + offsY)
            };
                b.FillPolygon(BrPants, Pants2);
                b.DrawPolygon(p, Pants2);

                Point[] Pants3 = new Point[]{
                    new Point(cenX - 175  + offsX, cenY   + 115 + offsY),
                    new Point(cenX - 150 + offsX, cenY  + 100 + offsY),

                    new Point(cenX + 70 + offsX, cenY  + 100 + offsY),
                    new Point(cenX + 45 + offsX, cenY  + 115 + offsY),
                    new Point(cenX - 175 + offsX, cenY   + 115 + offsY)
            };
                b.FillPolygon(BrPants, Pants3);
                b.DrawPolygon(p, Pants3);

            }

        }

        //класс для рисования ног
        //никуда не сдвигается при анимации
        public class Legs
        {
            int cenX;
            int cenY;
            int offsX;
            int offsY;
            SolidBrush BrLegs = new SolidBrush(Color.SaddleBrown);
            SolidBrush BrFoot = new SolidBrush(Color.Black);
            public Legs(int Cx, int Cy, int offX, int offY)
            {
                cenX = Cx;
                cenY = Cy;
                offsX = offX;
                offsY = offY;
            }

            public void Draw(Graphics b, Pen p)
            {
                Rectangle Leg1 = new Rectangle(cenX - 130 + offsX, cenY + 110 + offsY, 40, 40);
                Rectangle Leg2 = new Rectangle(cenX - 10 + offsX, cenY + 110 + offsY, 40, 40);
                b.FillRectangle(BrLegs, Leg1);
                b.FillRectangle(BrLegs, Leg2);
                b.DrawRectangle(p, Leg1);
                b.DrawRectangle(p, Leg2);

                Point leg1_1 = new Point(cenX - 110 + offsX, cenY + 150 + offsY);
                Point leg1_2 = new Point(cenX - 110 + offsX, cenY + 210 + offsY);

                Point leg2_1 = new Point(cenX + 10 + offsX, cenY + 150 + offsY);
                Point leg2_2 = new Point(cenX + 10 + offsX, cenY + 210 + offsY);

                b.DrawLine(p, leg1_1, leg1_2);
                b.DrawLine(p, leg2_1, leg2_2);

                Rectangle leg1_3 = new Rectangle(cenX - 160 + offsX, cenY + 190 + offsY, 70, 30);
                b.FillEllipse(BrFoot, leg1_3);
                b.DrawEllipse(p, leg1_3);

                Rectangle leg2_3 = new Rectangle(cenX - +10 + offsX, cenY + 190 + offsY, 70, 30);
                b.FillEllipse(BrFoot, leg2_3);
                b.DrawEllipse(p, leg2_3);
            }

        }

        //класс для рисования манжетов и галстука
        //никуда не сдвигается при анимации
        public class Cuffs
        {
            int cenX;
            int cenY;
            int offsX;
            int offsY;
            SolidBrush BrCuffs = new SolidBrush(Color.White);

            public Cuffs(int Cx, int Cy, int offX, int offY)
            {
                cenX = Cx;
                cenY = Cy;
                offsX = offX;
                offsY = offY;
            }

            public void Draw(Graphics b, Pen p)
            {
                Point[] Cuffs1 = new Point[]{
                new Point(cenX + offsX - 90, cenY + offsY ),
                new Point(cenX + offsX - 70, cenY + offsY  + 25),

                new Point(cenX + offsX - 50, cenY + offsY  ),
                //new Point(cenX + offsX - 150, cenY + offsY  + 50)
 
            };
                b.FillPolygon(BrCuffs, Cuffs1);
                b.DrawPolygon(p, Cuffs1);

                Point[] Cuffs2 = new Point[]{
                new Point(cenX + offsX + 10, cenY + offsY ),
                new Point(cenX + offsX - 10, cenY + offsY  + 25),

                new Point(cenX + offsX - 30, cenY + offsY  ),
                //new Point(cenX + offsX - 150, cenY + offsY  + 50)
 
            };
                b.FillPolygon(BrCuffs, Cuffs2);
                b.DrawPolygon(p, Cuffs2);

                SolidBrush BrCuffs3 = new SolidBrush(Color.Red);
                Point[] Cuffs3_1 = new Point[]{
                new Point(cenX + offsX - 50, cenY + offsY ),
                new Point(cenX + offsX - 40, cenY + offsY  + 15),

                new Point(cenX + offsX - 30, cenY + offsY  ),
                //new Point(cenX + offsX - 150, cenY + offsY  + 50)
            };

                b.FillPolygon(BrCuffs3, Cuffs3_1);
                b.DrawPolygon(p, Cuffs3_1);

                Point[] Cuffs3_2 = new Point[]{
                new Point(cenX + offsX - 40, cenY + offsY  + 15),
                new Point(cenX + offsX - 50, cenY + offsY + 60),
                new Point(cenX + offsX - 40, cenY + offsY  + 75),
                new Point(cenX + offsX - 30, cenY + offsY + 60 )
            };

                b.FillPolygon(BrCuffs3, Cuffs3_2);
                b.DrawPolygon(p, Cuffs3_2);
            }
        }

        //классы для рисования левой и правой руки
        //задействованы в анимации
        public class LHand
        {
            int cenX;
            int cenY;

            SolidBrush BrHand = new SolidBrush(Color.Yellow);

            public LHand(int Cx, int Cy, int offX, int offY)
            {
                cenX = Cx + offX - 155;
                cenY = Cy + offY - 20;
            }
            public void setOffset(int x, int y)
            {
                cenX += x;
                cenY += y;
            }
            public void Draw(Graphics b, Pen p)
            {
                Point[] shoulder = new Point[]{
                    new Point(cenX, cenY),
                    new Point(cenX - 15, cenY - 5),
                    new Point(cenX - 40, cenY + 40),
                    new Point(cenX, cenY + 50)
                };
                b.FillPolygon(BrHand, shoulder);
                b.DrawPolygon(p, shoulder);

                Point Hand1 = new Point(cenX - 20, cenY + 45);
                Point Hand2 = new Point(cenX - 35, cenY + 100);

                Point Palm1 = new Point(cenX - 50, cenY + 110);
                Point Palm2 = new Point(cenX - 30, cenY + 115);
                Point Palm3 = new Point(cenX - 45, cenY + 120);
                b.DrawLine(p, Hand1, Hand2);
                b.DrawLine(p, Hand2, Palm1);
                b.DrawLine(p, Hand2, Palm2);
                b.DrawLine(p, Hand2, Palm3);
            }
        }

        public class RHand
        {
            int cenX;
            int cenY;

            SolidBrush BrHand = new SolidBrush(Color.Yellow);

            public RHand(int Cx, int Cy, int offX, int offY)
            {
                cenX = Cx + offX + 70;
                cenY = Cy + offY - 30;
            }
            public void setOffset(int x, int y)
            {
                cenX += x;
                cenY += y;
            }
            public void Draw(Graphics b, Pen p)
            {
                Point[] shoulder = new Point[]{
                    new Point(cenX, cenY),
                    new Point(cenX, cenY - 15),
                    new Point(cenX + 40, cenY - 40),
                    new Point(cenX + 45, cenY - 5)
                };
                b.FillPolygon(BrHand, shoulder);
                b.DrawPolygon(p, shoulder);

                Point Hand1 = new Point(cenX + 43, cenY - 20);
                Point Hand2 = new Point(cenX + 93, cenY - 50);

                Point Palm1 = new Point(cenX + 105, cenY - 65);
                Point Palm2 = new Point(cenX + 110, cenY - 35);
                Point Palm3 = new Point(cenX + 110, cenY - 50);
                b.DrawLine(p, Hand1, Hand2);
                b.DrawLine(p, Hand2, Palm1);
                b.DrawLine(p, Hand2, Palm2);
                b.DrawLine(p, Hand2, Palm3);
            }
        }

        //класс для рисования глаз
        //двигается вместе с туловищем
        public class Eye
        {
            int cenX;
            int cenY;
            int r1, r2, r3;

            SolidBrush e1 = new SolidBrush(Color.Black);
            SolidBrush e2 = new SolidBrush(Color.Cyan);
            SolidBrush e3 = new SolidBrush(Color.White);

            public Eye(int Cx, int Cy, int offX, int offY, int ra1, int ra2, int ra3)
            {
                cenX = Cx + offX - 40;
                cenY = Cy + offY - 150;
                r1 = ra1;
                r2 = ra2;
                r3 = ra3;
            }
            public void setOffset(int x, int y)
            {
                cenX += x;
                cenY += y;
            }

            public void Draw(Graphics b, Pen p)
            {
                b.FillEllipse(e3, cenX, cenY, r3, r3);
                b.DrawEllipse(p, cenX, cenY, r3, r3);

                b.FillEllipse(e2, cenX + r3 / 4 - 1, cenY + r3 / 4 - 1, r2, r2);
                b.DrawEllipse(p, cenX + r3 / 4 - 1, cenY + r3 / 4 - 1, r2, r2);

                b.FillEllipse(e1, cenX + r3 / 3 + 4, cenY + r3 / 3 + 4, r1, r1);
                b.DrawEllipse(p, cenX + r3 / 3 + 4, cenY + r3 / 3 + 4, r1, r1);

                Point b1 = new Point(cenX, cenY - 5);
                Point b2 = new Point(cenX + 10, cenY + 10);
                Point b3 = new Point(cenX + 20, cenY - 5);
                Point b4 = new Point(cenX + 30, cenY - 5);

                b.DrawBezier(p, b1, b2, b3, b4);
            }

        }

        //класс дли рисования рта
        //двигается вместе с туловищем
        public class Mouth
        {
            int cenX;
            int cenY;
            SolidBrush BrTongue = new SolidBrush(Color.Salmon);
            SolidBrush BrTooth = new SolidBrush(Color.White);
            SolidBrush BrNose = new SolidBrush(Color.Gold);
            public Mouth(int Cx, int Cy, int offX, int offY)
            {
                cenX = Cx + offX - 20;
                cenY = Cy + offY - 50;

            }

            public void setOffset(int x, int y)
            {
                cenX += x;
                cenY += y;
            }
            public void Draw(Graphics b, Pen p)
            {
                Point p1 = new Point(cenX - 50, cenY - 20);
                Point p2 = new Point(cenX - 10, cenY + 20);
                Point p3 = new Point(cenX + 20, cenY + 5);
                Point p4 = new Point(cenX + 40, cenY - 10);

                Point p5 = new Point(cenX - 50, cenY - 20);
                Point p6 = new Point(cenX - 20, cenY + 60);
                Point p7 = new Point(cenX + 40, cenY + 70);
                Point p8 = new Point(cenX + 40, cenY - 10);


                b.DrawBezier(p, p1, p2, p3, p4);
                b.DrawBezier(p, p5, p6, p7, p8);

                b.FillPie(BrTongue, cenX - 30, cenY + 20, 40, 40, 15, -150);
                b.DrawPie(p, cenX - 30, cenY + 20, 40, 40, 15, -150);

                Point[] tooth = new Point[]{
                 new Point(cenX - 10, cenY +5),
                 new Point(cenX - 10, cenY + 15),
                 new Point(cenX + 5, cenY + 15),
                 new Point(cenX + 5, cenY + 5)
             };

                b.FillPolygon(BrTooth, tooth);
                b.DrawPolygon(p, tooth);

                Rectangle nose = new Rectangle(cenX - 20, cenY - 35, 50, 30);
                b.FillEllipse(BrNose, nose);
                b.DrawEllipse(p, nose);


            }

        }

        //класс для обрамления рисуемой области
        //хранит центры и радиус кругов
        //функция рисования реализуется при помощи двух циклов,
        //которые рисуют кружки на противоположных сторонах PictureBox
        public class Circles
        {

            public int radius;
            public int x;
            public int y;


            SolidBrush crlB = new SolidBrush(Color.Green);

            public Circles()
            {
                radius = 20;
                x = 5;
                y = 5;
            }
            public void Draw(Pen p, Graphics b, PictureBox pBox)
            {
                while (x <= pBox.Width - radius)
                {
                    b.FillEllipse(crlB, x, y, radius, radius);
                    b.DrawEllipse(p, x, y, radius, radius);
                    b.FillEllipse(crlB, x, pBox.Height - radius, radius, radius);
                    b.DrawEllipse(p, x, pBox.Height - radius, radius, radius);
                    x += radius;
                }

                x -= radius;
                while (y <= pBox.Height - radius)
                {
                    b.FillEllipse(crlB, x, y, radius, radius);
                    b.DrawEllipse(p, x, y, radius, radius);
                    b.FillEllipse(crlB, 5, y, radius, radius);
                    b.DrawEllipse(p, 5, y, radius, radius);
                    y += radius;
                }
                x = 5;
                y = 5;
            }





        }

        public Form1()
        {
            InitializeComponent();
           
        }

        //функция обработки нажатия клавиши
        private void button1_Click(object sender, EventArgs e)
        {
            //инициализируем Bitmap, задав его размеры, на которых будем рисовать
            myBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //привязываем графику к нашему Bitmap
            gr = Graphics.FromImage(myBitmap);
            // gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //инициализируем перо и фоновую заливку
            pen = new Pen(Color.Black);
            brush = new SolidBrush(Color.Aqua);

            // задаем центр рисуемого изображения и смещение
            centerX = pictureBox1.Width / 2;
            centerY = pictureBox1.Height / 2;
            offsetX = 0;
            offsetY = 0;


            //закрашиваем фон
            gr.FillRectangle(brush, 0, 0, pictureBox1.Width, pictureBox1.Height);

            //инициализируем объекты, в соответствии с описанными конструкторами
            //передав центр и смещение относительно центра
            circ = new Circles();
            ch = new Chest(centerX, centerY, offsetX, offsetY);
            sh = new Shirt(centerX, centerY, offsetX, offsetY);
            pa = new Pants(centerX, centerY, offsetX, offsetY);
            le = new Legs(centerX, centerY, offsetX, offsetY);
            cu = new Cuffs(centerX, centerY, offsetX, offsetY);
            lha = new LHand(centerX, centerY, offsetX, offsetY);
            rha = new RHand(centerX, centerY, offsetX, offsetY);
            bEye = new Eye(centerX, centerY, offsetX, offsetY, 20, 40, 70);
            fEye = new Eye(centerX - 50, centerY, offsetX, offsetY, 20, 40, 70);
            mo = new Mouth(centerX, centerY, offsetX, offsetY);

            //рисуем НА БУФЕРЕ!:

            // кружочки
            circ.Draw(pen, gr, pictureBox1);

            // тело
            ch.Draw(gr, pen);

            // Рубашка
            sh.Draw(gr, pen);

            //Штаны
            pa.Draw(gr, pen);

            // Ноги
            le.Draw(gr, pen);

            // манжеты
            cu.Draw(gr, pen);

            // руки
            lha.Draw(gr, pen);
            rha.Draw(gr, pen);

            // глаза
            bEye.Draw(gr, pen);
            fEye.Draw(gr, pen);

            //рот
            mo.Draw(gr, pen);

            //переносим изображение с буфера на PictureBox
            pictureBox1.Image = myBitmap;

            // обнуляем переменные для анимации
            movX = 0;
            movY = 0;

            //запускаем таймер (тик опять указан на 150мс)
            timer1.Enabled = true;

        }

        //обработка тика таймера (анимация)
        private void timer1_Tick(object sender, EventArgs e)
        {
            //присваиваем значение смещения  анимации
            movX += 5;
            movY -= 2;
            if (movX > 40) // контролируем перемещение
            {
                movX = -40;
                movY = 16;
            }

            //задаем смещение для анимации
            setOffset(movX, movY);

            // опять закрашиваем фон
            gr.FillRectangle(brush, 0, 0, pictureBox1.Width, pictureBox1.Height);

            // аналогично рисуем картинку по частям
            // и в конце "переносим" изображение с Bitmap на PictureBox
            // кружочки
            circ.Draw(pen, gr, pictureBox1);

            // тело
            ch.Draw(gr, pen);

            // Рубашка
            sh.Draw(gr, pen);

            //Штаны
            pa.Draw(gr, pen);

            // Ноги
            le.Draw(gr, pen);

            // манжеты
            cu.Draw(gr, pen);

            // руки
            lha.Draw(gr, pen);
            rha.Draw(gr, pen);

            // глаза
            bEye.Draw(gr, pen);
            fEye.Draw(gr, pen);

            //рот
            mo.Draw(gr, pen);


            pictureBox1.Image = myBitmap;

        }
       
    }
}
