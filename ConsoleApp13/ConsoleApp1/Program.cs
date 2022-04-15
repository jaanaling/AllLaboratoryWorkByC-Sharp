using System;
using System.Threading;

namespace AsyncApp
{
    class Program
    {
        static public Random r = new Random();
        public delegate bool Del(int n, int f);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите искомое число");
            int f = Int32.Parse(Console.ReadLine());
            Del del = new Del(Display);

            IAsyncResult res = del.BeginInvoke(n, f, null, null);

            Console.WriteLine("Продолжается работа метода Main");
            bool result = del.EndInvoke(res);
            Console.WriteLine("Результат равен {0}", result);

            Console.ReadLine();
        }

        static bool Display(int n, int f)
        {
            Console.WriteLine("Начинается работа метода Display....");
            int[] m = new int[n];
            bool result = false;
            for (int i = 0; i < n; i++)
            {
                m[i] = r.Next(1, 10);
                Console.WriteLine(m[i]);
                Thread.Sleep(300);
            }

            for (int i = 0; i < n; i++)
            {
                if (m[i] == f)
                {
                    result = true;
                }
            }

            Console.WriteLine("Завершается работа метода Display....");
            return result;
        }
    }
}