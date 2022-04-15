using System;

using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите n: ");
        int n = Int32.Parse(Console.ReadLine());
        Thread myThread = new Thread(new ParameterizedThreadStart(Count));
        myThread.Start(n);

        Thread.Sleep(1400);
        myThread.Name = "Count";
        Console.WriteLine("Имя потока: {0}", myThread.Name);
        Console.WriteLine("Запущен ли поток: {0}", myThread.IsAlive);
        Console.WriteLine("Приоритет потока: {0}", myThread.Priority);
        Console.WriteLine("Статус потока: {0}", myThread.ThreadState);
        // получаем домен приложения
        Console.WriteLine("Домен приложения: {0}", Thread.GetDomain().FriendlyName);


    }

    public static void Count(object x)
    {int s = 0;
        int n = (int)x;
        for (int i = 1; i < n; i++)
        {
            s += n;
            Console.WriteLine("Поток:"+(s));
          
            Thread.Sleep(400);
        }
    }
}