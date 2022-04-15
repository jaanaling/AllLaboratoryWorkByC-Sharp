using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = Input();
            double s;
            if (a < 0)
            {
                s = Neg();
                Console.WriteLine(s);
            }
            else if (a >= 0)
            {
                s = Pos(a);
                Console.WriteLine(s);
            }


        }
        static double Input()
        {
            try
            {
                double a = Double.Parse(Console.ReadLine());
                return a;
            }
            catch (FormatException)
            {
                Console.WriteLine("Число введено неверно");
                return 0;
            }
        }
        static double Pos(double a)
        {
            checked
            {
                try
                {
                    double s = 1;
                    for (int i = 2; i <= 8; i += 2)
                    {
                        s *= (Math.Pow(i, 2) - a);
                        Console.WriteLine(s);
                    }
                    return s;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка переполнения");
                    return 0;
                }
            }
        }
        static double Neg()
        {
            try
            {
                double s = 0;
                for (int i = 3; i <= 9; i += 3)
                {
                    s += (i - 2);
                }
                return s;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка переполнения");
                return 0;
            }
        }

    }
}
