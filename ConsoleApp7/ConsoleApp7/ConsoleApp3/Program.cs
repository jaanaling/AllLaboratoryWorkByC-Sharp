using System;

delegate int Del (int arg);

class A1
{

    public Del this[int k]
    {
        get
        {
            return n => (int)Math.Pow(n, k);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ведите число");
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ведите Степень");
        int k = Int32.Parse(Console.ReadLine());
        A1 obj = new A1();

        Console.WriteLine(obj[k](n));

   
    }
}