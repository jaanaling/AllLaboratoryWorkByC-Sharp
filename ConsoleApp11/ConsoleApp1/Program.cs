using System;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = Int32.Parse(Console.ReadLine());
            Thread myThread = new Thread(new ParameterizedThreadStart(Factorial));
            myThread.Start(n);
            
            Thread myThread2 = new Thread(new ParameterizedThreadStart(Sum));
            myThread2.Start(n);
            
        }

        public static void Factorial(object x)
        {
            int n = (int)x;
            int f = 1;
            for (int i = 1; i <= n; ++i)
            {
                f *= i;
                Console.WriteLine("Считаю факториал: "+f);
                Thread.Sleep(400);
            }

            
        }

        public static void Sum(object x)
        {
            int n = (int)x;
            int f = 1;
            for (int i = 1; i <= n; ++i)
            {
                f += i;
                Console.WriteLine("Считаю сумму: "+f);
              Thread.Sleep(500);
            }
            

        }

    }
}
