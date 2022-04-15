using System;
using System.Threading;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread1 = new Thread(new ThreadStart(First));
            myThread1.Start(); // запускаем поток
            Thread myThread2 = new Thread(new ThreadStart(Second));
            myThread2.Start(); // запускаем поток
            Thread myThread3 = new Thread(new ThreadStart(Theard));
            myThread3.Start(); // запускаем поток


        }
        static void First()
        {
            string f = "first";
            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine("Поток один " + f[i].GetHashCode());
                Thread.Sleep(1);
            }
        }
        static void Second()
        {
            string f = "second";
            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine("Поток два " + f[i].GetHashCode());
                Thread.Sleep(10);
            }
        }
        static void Theard()
        {
            string f = "theard";
            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine("Поток три " + f[i].GetHashCode());
                Thread.Sleep(0);
            }
        }
    }
}
