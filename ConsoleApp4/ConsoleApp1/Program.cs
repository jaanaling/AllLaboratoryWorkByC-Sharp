using System;
namespace Hello
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите n: ");
                int n = Int32.Parse(Console.ReadLine());

                int s = 0;
                Console.Write("Числа, которые делятся на 5 в пределе n:");
                checked
                {
                    if (n > 0)
                    {
                        for (int i = 0; i <= n; i++)
                        {
                            if (i % 5 == 0 && i != 0)
                            {
                                Console.Write("  " + i);
                                s += i;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i >= n; i--)
                        {
                            if (i % 5 == 0 && i != 0)
                            {
                                Console.Write("  " + i);
                                s += i;
                            }
                        }
                    }
                }


                Console.WriteLine();
                Console.WriteLine("Сумма чисел, которые делятся на 5 в пределе n = {0}", s);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено значение не верного формата");
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Переполнение стека");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переполнение стека");
            }
        }
    }
}
