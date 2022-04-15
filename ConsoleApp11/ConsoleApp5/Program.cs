using System;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 0;
            int sum = 0;
            Console.Write("Введите n: ");
            int n = Int32.Parse(Console.ReadLine());
            Thread myThread = new Thread(() => {
                factorial = Factorial(n);
              
            });
            myThread.Start();

            Thread myThread2 = new Thread(() => {
                sum = Sum(n);
               
            });
            myThread2.Start();
            myThread.Join();
            myThread2.Join(); 
            Console.WriteLine("Сумма факториала и предела суммы: {0}", factorial+sum);

        }

        public static int Factorial(object x)
        {
            int n = (int)x;
            if (n == 0)
            { return 1; }
            else
            {
               
                return n * Factorial(n - 1); }
        }


    

        public static int Sum(object x)
        {
            int n = (int)x;

            if (n == 0)
            { return 0; }
            else
            {
                return n + Sum(n-1);

            }

        }

    }
}
