using System;
using System.Threading;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread1 = new Thread(new ThreadStart(First));
            
            Thread myThread2 = new Thread(new ThreadStart(Second));
            
            Thread myThread3 = new Thread(new ThreadStart(Third));
            myThread1.Priority = ThreadPriority.BelowNormal;
            myThread2.Priority = ThreadPriority.Highest;
            myThread3.Priority = ThreadPriority.Lowest;
            myThread3.Start(); // запускаем поток
            myThread2.Start(); // запускаем поток
            myThread1.Start(); // запускаем поток
        }
        static void First()
        {
            string f = "first";
            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine("Поток один " + f[i].GetHashCode());

            }
        }
        static void Second()
        {
            string f = "second";
            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine("Поток два " + f[i].GetHashCode());

            }
        }
        static void Third()
        {
            string f = "third";
            for (int i = 0; i < f.Length; i++)
            {
                Console.WriteLine("Поток три " + f[i].GetHashCode());

            }
        }
    }
}
