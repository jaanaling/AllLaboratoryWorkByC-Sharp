using System;  
namespace ConsoleApp3
{
    class Program
    {
        delegate void Del<T, T1>(T a, T1 a1);
        static void Main(string[] args)
        {
            Del<int, int> delInt = conc;
            delInt += cont;
            delInt += Ind;
            Console.WriteLine("Выполнение делегата с типами int int:");
            delInt(7, 25);
            Console.WriteLine();
            Del<int, string> delInSt = conc;
            delInSt += cont;
            delInSt += Ind;
            Console.WriteLine("Выполнение делегата с типами int string:");
            delInSt(7, "ff");
            Console.WriteLine();
            Del<string, string> delStr = conc;
            delStr += cont;
            delStr += Ind;
            Console.WriteLine("Выполнение делегата с типами string string:");
            delStr("gg", "ff");
        }
        static void conc<T, T1>(T a, T1 a1)
        {
            string b1 = Convert.ToString(a);
            string b2 = Convert.ToString(a1);
            Console.WriteLine("Конкатенация строк - {0}",String.Concat(b1,b2));
        }
        static void cont<T, T1>(T a, T1 a1)
        {
            string b1 = Convert.ToString(a);
            string b2 = Convert.ToString(a1);
            Console.WriteLine("Содержит ли строка введённую подстроку - {0}", b1.Contains(b2));
        }
        static void Ind<T, T1>(T a, T1 a1)
        {
            string b1 = Convert.ToString(a);
            string b2 = Convert.ToString(a1);
            Console.WriteLine("Первое вхождение подстроки в строку - {0}", b1.IndexOf(b2));
        }
    }
}
