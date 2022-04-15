using System;
using System.Collections.Generic;
using System.IO;

namespace Hello
{
    class Program
    {

        static void Main(string[] args)
        {
            {

                string str1 = "";
                Console.WriteLine("Введите значение N: ");
                int N = Int32.Parse(Console.ReadLine());
                if (N > 26)
                {
                    Console.WriteLine("N задан не верно, значение измененно на 26: ");
                    N = 26;
                }
                else if (N < 1)
                {
                    Console.WriteLine("N задан не верно, значение измененно на 1: ");
                    N = 1;
                }
                for (int i = 1; i <= N; i++)
                {
                    str1 = str1 + Convert.ToChar(i + 64);
                    string str2 = "";
                    for (int j = i; j < N; j++)
                    {
                        str2 = str2 + '*';
                    }
                    string str3 = str1 + str2;
                    Console.WriteLine("<<" + str3 + ">>");

                    string txt = "E:\\Tekst\\test.txt";
                    StreamWriter sw = new StreamWriter(txt, true);
                    sw.WriteLine("<<" + str3 + ">>");
                    sw.Close();

                }
            }

        }
    }
}