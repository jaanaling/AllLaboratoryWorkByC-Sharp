using System;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        static Mutex mutexObj = new Mutex();
        public static Random r = new Random();

        static void Main(string[] args)
        {
            string[] h = new string[10] { "Мастер и Маргарита", "Двенадцать стульев", "Золотой теленок", "Палата № 6", "Рудин", "Анна Каренина", "Воскресение", "Робинзон Крузо", "Тихий Дон", "Белая гвардия" };
                string[] b = new string[10] { "Война и мир","Отцы и дети","Повести Белкина","Руслан и Людмила","Два капитана","Тарас Бульба","Бедные люди","Чайка","1984","Хаджи-Мурат" };
                Thread myThread = new Thread(new ParameterizedThreadStart(Hand));
                myThread.Start(h);
            Thread myThread2 = new Thread(new ParameterizedThreadStart(Bioble));
            myThread2.Start(b);


        }
        public static void Hand(object obj )
        {
        try
        {
        mutexObj.WaitOne();

            string[] s = (string[])obj;
            Console.Write("Введите число книг, сколько надо взять на руки(не больше трёх): ");
            int a = Int32.Parse(Console.ReadLine());
            if (a > 3)
            {
                throw new Exception("Слишком много книг");
            }
            for (int i=0;i<a; i++)
            {
                Console.WriteLine("Взял с собой :{0}", s[r.Next(0,9)]);
            }

            mutexObj.ReleaseMutex();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Bioble(object obj)
        {
            try
            {
                mutexObj.WaitOne();

                string[] s = (string[])obj;
                Console.Write("Введите число книг, сколько надо взять в зал(не больше трёх): ");
                int q = Int32.Parse(Console.ReadLine());
                if (q > 3)
                {
                    throw new Exception("Слишком много книг");
                }
                for (int i = 0; i < q; i++)
                {
                    Console.WriteLine("Взял в зал :{0}", s[r.Next(0, 9)]);
                }

                mutexObj.ReleaseMutex();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
