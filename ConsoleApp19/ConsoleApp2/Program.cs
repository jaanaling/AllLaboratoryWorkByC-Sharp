using System;

delegate char Del();

class MyClass
{
    public readonly string text;
    private Del del;

    public Del DelProperty => del;

    public MyClass(string text, bool b)
    {
        this.text = text;

        if (b == true)
        {
            del = () => text[0];

        }
        else
        {
            del = () => text[text.Length - 1];
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        MyClass A = new MyClass(str, true);
        MyClass B = new MyClass(str, false);

        Console.WriteLine(A.DelProperty());
        Console.WriteLine(B.DelProperty());



    }
}