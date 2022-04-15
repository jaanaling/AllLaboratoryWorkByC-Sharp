using System;

namespace ConsoleApp2
{
    class Program
    { delegate void GetC(char x);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите знак");
            char c = Char.Parse(Console.ReadLine());
            Ch ch = new Ch();
            GetC get= ch.setC;
            get(c);
        }
        
    }
        class Ch
        {
            char c;
            
            public void setC(char x)
            {
                this.c = x;
                Console.WriteLine("Введёный знак  = "+this.c);
            }
        }
}