using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

             int[,] massive;
            int n = Int32.Parse(Console.ReadLine());
           
            int[] sumCol = new int[n];
          
                massive = new int[n, n];
                Random rnd = new Random();
                int c, l, d;
                while (true)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            massive[i, k] = rnd.Next(1, 10);
                        }
                    }
                    c = Column(sumCol,massive,n);
                    l = Line(massive, n);
                    d = Diagonal(massive, n);
                    if (c == l && l == d && c != 0)
                        break;
                }
                for (int i = 0; i < n; i++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write(massive[i, k]);
                    }
                    Console.WriteLine();
                }
               
            }
            static int Column(int[] sumCol, int [,]massive, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        sumCol[i] += massive[i, k];
                    }
                }
            Console.WriteLine(1);
                return Sum(sumCol);
            }
            static int Line(int[,] massive, int n)
            {
                int[] sum = new int[n];
                for (int i = 0; i < n; i++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        sum[i] += massive[k, i];
                    }
                }
            Console.WriteLine(2);
            return Sum(sum);
            }
            static int Sum(params int[] sum)
            {
                if (sum[0] == sum[1] && sum[1] == sum[2] && sum[0] != 0)
                {
                    int allsum = sum[0] + sum[1] + sum[2];
                Console.WriteLine(3);
                return allsum;
                }
                else
                Console.WriteLine(3);
            return 0;
            }
            static int Diagonal(int[,] massive, int n)
            {
                int[] s = new int[2];
                for (int i = 0; i < n; i++)
                {
                    s[0] += massive[i, i];
                }
                for (int k = 2, i = 0; i < 3; i++, k--)
                {
                    s[1] += massive[i, k];
                }
                if (s[0] == s[1] && s[0] != 0)
                {
                    int allsum = s[0] + s[1];
                Console.WriteLine(4);
                return allsum;
                }
                else
                Console.WriteLine(4);
            return 0;
            }
        }
    }

