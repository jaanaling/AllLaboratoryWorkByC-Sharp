using System;
namespace Hello
{
    class Program
    {
        static double f(double x, double n) //метод f
        {
            try
            {

                return (Math.Pow(-1, n) * (Math.Pow(x, 2 * n) / Fact(2 * n)));

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
                

                Console.Write(f(0.8f,3));
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