using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int y;
            call();
            Console.WriteLine("Продолжить? \n 0-нет \n 1-да");
            y = Int32.Parse(Console.ReadLine());
            while (y == 1)
            {
                call();
                Console.WriteLine("Продолжить? \n 0-нет \n 1-да");
                y = Int32.Parse(Console.ReadLine());
            }
            

            
            
        }
      
        class Friend<T, T1> 
        {
            public Dictionary<T, T1> Friends = new Dictionary<T, T1>(4);            
        }
        class Client<T, T1> 
        {
            public Dictionary<T, T1> Clients = new Dictionary<T, T1>(3);            
        }
        class Supplier<T, T1> 
        {
            public Dictionary<T, T1> Suppliers = new Dictionary<T, T1>(2);            
        }
       static public void Numbers<T, T1>(Dictionary<T, T1> dictionary)
        {
            foreach (KeyValuePair < T, T1 > keyValue in dictionary)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }
        static public Dictionary<string, string> friends<T, T1>()
        {
            Friend<string, string> friend = new Friend<string, string>();
            friend.Friends.Add("Дмитрий-9", "+72945743021");
            friend.Friends.Add("Зоя-1", "+7298434321");
            friend.Friends.Add("Дмитрий-7", "+72932434321");
            friend.Friends.Add("Петр", "+72913212321");
            return friend.Friends;
        }
        static public Dictionary<string, string> clients<T, T1>()
        {
            Client<string, string> client = new Client<string, string>();
            client.Clients.Add("Геннадий Петров", "+72945743021");
            client.Clients.Add("Михаил Горин", "+7298434321");
            client.Clients.Add("Юлий Гридин", "+72932434321");
          
            return client.Clients;
        }
        static public Dictionary<string, string> suppliers<T, T1>()
        {
            Supplier<string, string> supplier = new Supplier<string, string>();
            supplier.Suppliers.Add("КП", "+72932143021");
            supplier.Suppliers.Add("ГБ", "+729232424321");


            return supplier.Suppliers;
        }
        static public void call()
        {
            Console.WriteLine("Выберите список: \n 1-Друзья \n 2-Клиенты \n 3-Закизчики");
            int n = Int32.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Numbers(friends<string, string>());
                    break;
                case 2:
                    Numbers(clients<string, string>());
                    break;
                case 3:
                    Numbers(suppliers<string, string>());
                    break;
                default:
                    Console.WriteLine("Введено неверное значение");
                    break;
            }
        }
    }
}







