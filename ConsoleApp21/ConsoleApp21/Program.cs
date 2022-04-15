using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> month = new Dictionary<int, string>(4);
          
            month.Add(1, "Spring");
            month.Add(2, "Summer");
            month.Add(3, "Autumn");
            month.Add(4, "Winter");
            foreach (KeyValuePair<int, string> keyValue in month)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }

    }

}

