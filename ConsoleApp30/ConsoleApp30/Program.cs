using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe {


                int[,] A = new int[3,4];
               
                fixed (int* p = A)
                { 
                    *(p + 4) = 3;
                }

                fixed (int* p2 = &A[2, 3])
                {
                    *p2 = 3;
                }

                fixed (int* p3 = A)
                {
                   *(p3) = p3[4];
                }

                for (int i = 0; i < 3; ++i)
                {
                    Console.WriteLine();
                    for (int g = 0; g < 4; ++g)
                    {
                        Console.Write(A[i,g]);
                    }
                }

            }
        }
           
    }
}

