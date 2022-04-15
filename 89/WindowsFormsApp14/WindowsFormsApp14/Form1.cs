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

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        
            // делегат для манипулирования лейбом  
            public delegate void DelegateForTime(Label label);

            // поле типа делегата  
            DelegateForTime DelTime;

            // поток  
            Thread t1;

            public Form1()
            {
                InitializeComponent();
                DelTime = new DelegateForTime(StartTime);// указываем метод делегату  
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                t1 = new Thread(LabelTime); // создаем поток  
                t1.IsBackground = true; // задаем фоновый режим  
                t1.Priority = ThreadPriority.Lowest; // указываем свмый низкий приоритет  
                t1.Start(); // стартуем  
            }

            // устанавливает время  
            void StartTime(Label label)
            {
                // выводим всегда две цифры   
                // (00:00)  
                string s = DateTime.Now.Hour.ToString("00");
                s += " : ";
                s += DateTime.Now.Minute.ToString("00");

                s += " : " + DateTime.Now.Second.ToString("00");
                label.Text = s;
            }


            void LabelTime()
            {
                // бесконечный цикл  
                while (true)
                {
                    Invoke(DelTime, label1);// запускаем метод с главного потока             
                }
            }
        }
    }

