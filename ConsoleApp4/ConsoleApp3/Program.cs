
using System;
namespace Hello
{
    class Program
    {
        static double f(double x, double n) //метод f
        {
            try
            {
                if (n >= 0)
                {
                    return (Math.Pow(-1, n)) * ((Math.Pow(x, (2 * n) + 1)) / Fact((2 * n) + 1)) + f(x, n - 1);
                }
                else
                {
                    return 0;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Произошло деление на ноль");
                return 0;
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Переполнение стека");
                return 0;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переполнение стека");
                return 0;
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Переполнение памяти");
                return 0;
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Арифметическая ошибка");
                return 0;
            }
        }
        public static double Fact(double n)
        {
            if (n == 0)
            {
                return 1;
            }

            else
            {
                return n * Fact(n - 1);
            }
        }


        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int b = 1;

                Console.Write("Введите h(шаг)=");
                double h = Double.Parse(Console.ReadLine());
                if (h < a && h > b)
                {
                    throw new Exception("n вне предела");
                }
                double n = Math.Round(1 / h + 1);
                for (double i = a; i <= b; i += h)
                {
                    try
                    {
                        Console.WriteLine("Синус - {0}", Math.Sin(i));
                    }
                    catch
                    {
                        Console.WriteLine("x={0}               y=error", i);
                    }

                }







                for (double i = a; i <= b; i += h)
                {
                    try
                    {
                        Console.WriteLine("x={0}               s={1}", i, f(i, n));
                    }
                    catch
                    {
                        Console.WriteLine("x={0}               s=error", i);
                    }

                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат ввода данных");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}