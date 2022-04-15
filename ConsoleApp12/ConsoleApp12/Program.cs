using System;
using System.Threading;
namespace ConsoleApp12
{
    class Program
    { public static Random r = new Random();
        static object locker = new object();
        static void Main(string[] args)
        { S s = new S();
            

            Thread myThread = new Thread(() => {
                s.c = Ch();

            });
            myThread.Start();

            Thread myThread2 = new Thread(() => {
                s.n = In();

            });
            myThread2.Start();
            myThread.Join();
            myThread2.Join();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Символьный массив[{0}] = {1}                         Числовой массив[{0}] = {2}",i, s.c[i], s.n[i]);

            }
            Thread myThread3 = new Thread(new ParameterizedThreadStart(min));
            myThread3.Start(s.n);
            Thread myThread4 = new Thread(new ParameterizedThreadStart(max));
            myThread4.Start(s.n);

        }

        class S
        {
            public int[] n = new int[5];
            public char[] c = new char[5];

        }
        static char[] Ch()
        {
            lock (locker) {
            char[] c = new char[5];
            for(int i = 0; i < 5; i++)
            {
                c[i] = Convert.ToChar(r.Next(65, 90));
                
            }
            return c; }
            
        }
        static int[] In()
        {
            lock (locker) {
                
            int[] c = new int[5];
            for (int i = 0; i < 5; i++)
            {
                c[i] = r.Next(1,10);

            }
            return c; 
            
            }
            
        }

        static void min(object x)
        {
            lock (locker)
            {
                int[] n = (int[])x;
                int m = n[0];
                for (int i = 1; i < 5; i++)
                {
                    if (n[i] < m)
                        m = n[i];

                }
                Console.WriteLine("Минимальное число: {0}", m);
            }
        }

        static void max(object x)
        {
            lock (locker)
            {
                int[] n = (int[])x;
                int m = n[0];
                for (int i = 1; i < 5; i++)
                {
                    if (n[i] > m)
                        m = n[i];

                }
                Console.WriteLine("Максимальное число: {0}", m);
            }
        }
    }
}
