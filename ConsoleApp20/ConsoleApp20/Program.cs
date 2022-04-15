using System;
using System.Collections;
namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
                ArrayList SNP = new ArrayList();
                Console.Write("Введите фамилию: ");
                string second_name = Console.ReadLine();
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите отчество: ");
                string patronymic = Console.ReadLine();
               
                SNP.Add(second_name);
                SNP.Add(name);
                SNP.Add(patronymic);

                Console.Write("Введите ФИО: ");
                foreach (string i in SNP)
                {
                    Console.Write("{0}",i);
                }
        }    
    }
}
