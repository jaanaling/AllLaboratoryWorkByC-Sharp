using System;
using System.Threading;
namespace ConsoleApp6
{
  
        class Program
        {
           
            static object locker = new object();
            static void Main(string[] args)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread myThread = new Thread(Count);
                    myThread.Name = "Поток " + i.ToString();
                    myThread.Start();
                }

               
            }
            public static void Count()
        {
            lock (locker) { 
                Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Сумму, которую хотите снять");
            int s = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Имя: {0} Снято: {1}", name, s);
            }
           
            }
        }
    }
