using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass1 = new int[] {1,2,3,4,5,6,7,8,9,10 };
            string[] mass2 = new string[] {"aaa","bbb","ccc" };
            char[] mass3 = new char[] { 'a', 'b','c' };
            Massiv<int> massiv = new Massiv<int>(mass1);
            Massiv<string> massiv1 = new Massiv<string>(mass2);
            Massiv<char> massiv2 = new Massiv<char>(mass3);
            Console.WriteLine("Массив Int");
            for(int i=0; i<massiv.mass.Length; i++) { Console.Write(" "+massiv.mass[i]); }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Массив String");
            for (int i = 0; i < massiv1.mass.Length; i++) { Console.Write(" " + massiv1.mass[i]); }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Массив Char");
            for (int i = 0; i < massiv2.mass.Length; i++) { Console.Write(" " + massiv2.mass[i]); }
            Console.WriteLine();
            Console.WriteLine();

        }
        class Massiv<T>
        {
           public T[] mass = new T[] {};
            public Massiv(T[] mass)
            {
                this.mass = mass;
            }
        }

    }
}
