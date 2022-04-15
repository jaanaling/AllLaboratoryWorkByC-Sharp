using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                const int size = 7;
                int* A = stackalloc int[size]; // выделяем память в стеке под семь объектов int
                int* p = A;

                *(p+3) = 4; // присваиваем первой ячейке значение 1 и
                            // увеличиваем указатель на 1
             
                for (int i = 0; i < size; ++i)
                {
                    Console.WriteLine(A[i ]);
                }
            }

        }
    }
}
