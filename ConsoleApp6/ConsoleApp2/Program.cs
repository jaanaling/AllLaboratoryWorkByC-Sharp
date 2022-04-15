using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку(максимально 16 символов)");
            int[,] square = new int[4, 4] { { 16, 3, 2, 13 }, { 9, 6, 7, 12 }, { 5, 10, 11, 8 }, { 4, 15, 14, 1 } };
            try { 
            string text = Console.ReadLine();
                if (text.Length > 16)
                {
                    throw new Exception("Строка больше допустимого предела");
                }
            char[,] eText = ESquare(text, square);
            string dText = DSquare(eText, square);
            Console.WriteLine();
            for(int i = 0; i< 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("|"+eText[i, j]+"|");
                }
            }
            Console.WriteLine();
            Console.WriteLine(dText);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static char[,] ESquare(string text, int[,] square)
        {
            int z = 0;
            char[,] eText = new char[4, 4] { { ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ' }, { ' ', ' ', ' ', ' ' } };
            while (z != text.Length)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if ((square[i, j] == z + 1) && (z != text.Length))
                        {
                            eText[i, j] = text[z];
                            z++;
                        }
                    }
                }

            }

            return eText;
        }
       static string DSquare(char[,] text, int[,] square)
        {
            int z = 0;
            string dText = "";
            while (z != text.Length)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if ((square[i, j] == z + 1) && (z != text.Length))
                        {
                            dText += Convert.ToString(text[i, j]);
                            z++;
                        }
                    }
                }
            }
            return dText;
        }
    }
}