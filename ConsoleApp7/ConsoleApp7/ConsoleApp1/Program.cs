using System;

namespace ConsoleApp1
{
    class Program
    { delegate int Del(char c, string s);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите знак");
            char c = Char.Parse(Console.ReadLine());

            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            Del del = A1;
           Console.WriteLine("Количество вхождений знака в строку - "+ del.Invoke(c, s));
             del = A2;
          Console.WriteLine("Первое вхождение знака в строке - " +del.Invoke(c, s));
           
        }
        static int A1(char c, string s)
        {
            int x = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    x++;
                }
            }
            return x;
        }
        static int A2(char c, string s)
        {
            int x = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    x= i;
                    break;
                   
                }
                
            }
            if (x==0)
                {
                    return -1;
                }
            else { return x;}
            
        }
    }
}
