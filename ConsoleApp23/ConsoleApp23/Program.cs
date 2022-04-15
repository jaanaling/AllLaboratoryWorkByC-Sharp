using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 15, 2, 3, 10,5, 1 };

            var selectedNum = from t in num 
                                where t%5==0 
                                orderby t  
                                select t; 

            foreach (int s in selectedNum)
                Console.WriteLine(s);
        }
    }
}
