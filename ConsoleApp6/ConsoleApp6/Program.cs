using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mc = new int[4, 4] { { 8, 11, 14, 1 }, { 13, 2, 7, 12 }, { 3, 16, 9, 6 }, { 10, 5, 4, 15 } };
            string[,] ch = new string[4, 4] { {"8", "11", "14", "1" }, { "13", "2", "7", "12" }, { "3", "16", "9", "6" }, { "10", "5", "4", "15" } };
            Console.WriteLine("Введите строку(максимально 16 символов)");
            string str = Console.ReadLine();
            char[,] str2 = new char[4,4];
            int f = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int g = 0; g < 4; g++) { 
                    if (f < str.Length) {str2[i, g] = str[f]; f++;}
                else { str2[i,g] = ' '; }

                    Console.Write("." + str2[i, g] + ".");

                }
                   
            }
            Console.WriteLine();
            int z = 0;
            int l = 1;
            for (int o = 0; o < 4; o++) 
            { 

                for (int j = 0; j < 4; j++) 
                {
                bool suc = int.TryParse(ch[o,j], out z);
                    //Console.WriteLine("|" + z + "|");
                    
                    for (int i = 0; i < 4; i++) 
                    {  
                        if (i == 0)
                        {
                            l = 1;
                        }
                                if (l == -1) 
                                {
                            //Console.WriteLine("<dddddd>" + l + "<ddddd>");
                            //Console.WriteLine("<//>" + z + "<//>");
                            //Console.WriteLine("<>" + 4 + "<>");
                           
                                break;
                                }
                       
                        for (int g= 0; g < 4; g++)
                        {
                            if (z != l)
                            {
                                l++;
                                //Console.WriteLine("<>" + 1 + "<>");
                            }
                            else if (z==l)
                            {
                                ch[o, j] = Convert.ToString(str2[i, g]);
                                //Console.WriteLine("<>" + 2 + "<>");
                                Console.Write("<" + ch[o, j] + ">");
                                l=-1;
                                break;

                            }
                             else if (l > z)
                             {
                                //Console.WriteLine("<>" + 3 + "<>");
                                break;

                             }
                        }
                    }        
                } 
            }

            Console.WriteLine();        
        }
    }
}
