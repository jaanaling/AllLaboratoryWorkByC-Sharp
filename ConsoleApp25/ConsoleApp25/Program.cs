using System;
using System.Xml;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("text.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
               
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                    {
                        Console.WriteLine("Group name: {0}", childnode.InnerText);
                    }
                    if (childnode.Name == "genre")
                    {
                        Console.WriteLine("Genre: {0}", childnode.InnerText);
                    }
                    // если узел age
                    if (childnode.Name == "country")
                    {
                        Console.WriteLine("Country: {0}", childnode.InnerText);
                    }
                }
                Console.WriteLine();
            }
           
        }

    }
}
    