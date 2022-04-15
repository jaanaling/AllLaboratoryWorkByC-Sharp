using System;
using ClassLibrary2;
namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lenght: ");
            int n = Int32.Parse(Console.ReadLine());
           Methods.getMas(Methods.Mas(n));
        }
    }
}
