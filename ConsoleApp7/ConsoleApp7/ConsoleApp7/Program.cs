using System;

namespace ConsoleApp7
{
    class Program
    {
        delegate string GetStr();
        static void Main(string[] args)
        { Console.WriteLine("Введите переменную(string)");

            GetStr get;
            get = Str;
            Console.WriteLine("Вызванный делегат - "+get.Invoke());
            
           
        }
       
        static string Str()
        {
            string a = Console.ReadLine();
            return a;
        }

    }
}
