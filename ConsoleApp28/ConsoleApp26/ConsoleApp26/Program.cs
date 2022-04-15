using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace ConsoleApp26
{
    
    class Program
    { public static string filename = "text.xml";
       public static List<Rose> roses = new List<Rose>();
        static void Main(string[] args)
        {
            Rose roses1 = new Rose("Роза 0", 106, 145, 50, 46);
            Rose roses2 = new Rose("Роза 1", 282, 58, 5, 46);
         
           
            
            roses.Add(roses1);
            roses.Add(roses2);
            SaveProject();
            Clear();
            OpenProject();
        }
        public static void SaveProject()
        {
        // создание потока записи и объекта создания XML-документа 
        FileStream fs = new FileStream(filename, FileMode.Create);
        XmlTextWriter xmlOut = new XmlTextWriter(fs, Encoding.Unicode);

        xmlOut.Formatting = Formatting.Indented;
            
           
            // старт начала документа 
            xmlOut.WriteStartDocument();
        xmlOut.WriteComment("Этот файл создан для примера");
        xmlOut.WriteComment("Автор: Иван Петров (www.Petrov.info)");

        // создаем корневой элемент 
        xmlOut.WriteStartElement("RosesPlant");
        xmlOut.WriteAttributeString("Version", "1");

        // цикл перебора всех роз и сохранения их 
        foreach (Rose item in roses)
            {
                item.SaveToFile(xmlOut);
            }

            // закрываем корневой тег и документ 
            xmlOut.WriteEndElement();
        xmlOut.WriteEndDocument();

        // закрываем объекты записи 
        xmlOut.Close();
        fs.Close();
        }

        public static void OpenProject()
        {
            // очистить текущий документ 


            // инициализация классов для чтения 
            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlTextReader xmlIn = new XmlTextReader(fs);
            xmlIn.WhitespaceHandling = WhitespaceHandling.None;

            // переместится в начало документа 
            xmlIn.MoveToContent();

            // проверяем первый тег документа 
            if (xmlIn.Name != "RosesPlant")
                throw new ArgumentException("Incorrect file format.");
            string version = xmlIn.GetAttribute(0);

            // цикл чтения тегов документа 
            do
            {
                // удалось ли прочитать очередной тег? 
                if (!xmlIn.Read())
                    throw new ArgumentException("Ошибочка");

                // проверяем тип текущего тега 
                if ((xmlIn.NodeType == XmlNodeType.EndElement) &&
                    (xmlIn.Name == "RosesPlant"))
                    break;

                // если это конечный элемент, то незачем проверять 
                if (xmlIn.NodeType == XmlNodeType.EndElement)
                    continue;

                // если это роза, то нужно читать ее параметры 
                if (xmlIn.Name == "Rose")
                {
                    Rose newItem = new Rose("", 0, 0,0,0);
                    roses.Add(newItem);
                    newItem.LoadFromFile(xmlIn);
                   
                }
            } while (!xmlIn.EOF);
                    foreach (Rose r in roses)
                        Console.WriteLine("{0}, X = {1}, Y = {2}, Width = {3}, Height = {4}",r.Name, r.X, r.Y, r.Width, r.Height);
            // закрываем классы 
            xmlIn.Close();
            fs.Close();



        }




        public static void Clear()
        {
            roses.Clear();
        }



    }

    class Rose
    {
        public string Name;
        public int X ;
        public int Y;
        public int Width;
        public int Height;

        public Rose(  string Name,
          int X,
          int Y,
          int Width,
          int Height)
        {
            this.Name = Name;
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
        }

        public void SaveToFile(XmlTextWriter xmlOut)
        {
            xmlOut.WriteStartElement("Rose");
            xmlOut.WriteAttributeString("Name", Name);
            xmlOut.WriteAttributeString("X", X.ToString());
            xmlOut.WriteAttributeString("Y", Y.ToString());
            xmlOut.WriteAttributeString("Width", Width.ToString());
            xmlOut.WriteAttributeString("Height", Height.ToString());
            xmlOut.WriteEndElement();
        }

        public void LoadFromFile(XmlTextReader xmlIn)
        {
            try
            {
                Name = xmlIn.GetAttribute("Name");
                X = Convert.ToInt32(xmlIn.GetAttribute("X"));
                Y = Convert.ToInt32(xmlIn.GetAttribute("Y"));
                Width = Convert.ToInt32(xmlIn.GetAttribute("Width"));
                Height = Convert.ToInt32(xmlIn.GetAttribute("Height"));
            }
            catch (Exception)
            { }
        }


    }


}
