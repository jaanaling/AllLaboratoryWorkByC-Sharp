using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        { List<string> names = new List<string>();    
            Console.WriteLine("Name in file:");
            string[] name = File.ReadAllLines("text.txt");
            var str = from line in name
                    select line;
            foreach (string s in str) {
                Console.Write("{0}, ",s);
                names.Add(s);
            }
         
            Console.WriteLine("\n\nRequest through a filter for a deferred request:");

            var str2 = from l in names
                       where l.StartsWith("A")
                      select l;
            foreach (string s in str2)
            {
                Console.Write("{0}, ", s);
            }

            Console.WriteLine("\n\nNumber of names per A:");

            var str3 = (from l in names
                        where l.StartsWith("A")
                        select l).Count();
            Console.WriteLine(str3);
        }
    }
}
