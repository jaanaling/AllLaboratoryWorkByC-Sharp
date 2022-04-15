using System;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.IO;

namespace Пример_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string file = "PhoneBook.xml";
                string command;

                //проверяем, существует ли файл
                if (!File.Exists(file))
                {
                    // вызываем метод который создает файл
                    // с одной стандартной записью
                    NewFile(file);
                }
                // в бесконечном цикле запрашиваем команды у пользователя
                while (true)
                {
                    Console.WriteLine("Выберете нужное действие с записью");
                    Console.WriteLine("1 (Добавить)\t|2 (Удалить)\t|3 (Поиск)\t|Все остальное - ВЫХОД");
                    Console.Write(">");
                    command = Console.ReadLine();
                    Console.Clear();
                    // если команда 1 тогда вызываем метод для добавления записи
                    if (command == "1")
                    {
                        Add(file);
                    }
                    // если команда 2 тогда вызываем метод для удаления
                    else if (command == "2")
                    {
                        Rem(file);
                    }
                    else if (command == "3")
                    {
                        Fund();
                    }
                    // остальные значения прекратят выполнение цикла
                    else
                    {
                        break;
                    }
                }
            }
        }

        static void NewFile(string file)
        {

            // создаем экземпляр класс, который представляет набор механизмов,
            // для формирования XML документа
            XmlTextWriter doc = new XmlTextWriter(file, Encoding.Unicode);
            // использовать форматирование (уровни вложенности)
            doc.Formatting = Formatting.Indented;
            // уровни будут отделятся пробелами
            doc.IndentChar = ' ';
            // один уровень отличается на 4 символа IndentChar
            doc.Indentation = 4;

            // создаем оглавление документа
            doc.WriteStartDocument();
            // добавляем элемент - корень файла      
            doc.WriteStartElement("PhoneBook");
            // добавляем атрибут
            doc.WriteAttributeString("LastId", "1");
            // добавляем элемент в корне
            doc.WriteStartElement("Account");
            // добавляем атрибут         
            doc.WriteAttributeString("ID", "1");
            // добавляем элемент
            doc.WriteStartElement("Name");
            // устанавливаем значение элемента
            doc.WriteString("Иван Семенович");
            // закрываем элемент
            doc.WriteEndElement();
            // добавляем элемент
            doc.WriteStartElement("Phone");
            // устанавливаем значение элемента
            doc.WriteString("+375291234567");
            // закрываем элемент
            doc.WriteEndElement();
            doc.WriteStartElement("Comment");
            doc.WriteString("Мой старый отключенный номер");
            doc.WriteEndElement(); // закрываем элемент
            doc.WriteEndElement(); // закрываем элемент
            doc.WriteEndElement(); // закрываем элемент
            doc.Close(); // закрываем поток (файл)
        }
        static void Add(string file)
        {
            string name, phone, comment;
            // запрашиваем необходимую информацию
            Console.WriteLine("\t\tДобавить запись");
            Console.Write("Имя >");
            name = Console.ReadLine();
            Console.Write("Телефон >");
            phone = Console.ReadLine();
            Console.Write("Комментарий (можно оставить пустым) >");
            comment = Console.ReadLine();

            // Создаем XmlDocument
            XmlDocument doc = new XmlDocument();
            // Загружаем в него файл
            doc.Load(file);
            // Создаем экземпляр класса, который позволяет выполнять XPath запросы
            // Если мы выполняем его на экземпляре класса XmlDocument,
            // то он позволяет редактировать его
            XPathNavigator navigator = doc.CreateNavigator();
            // выбираем узел с именем PhoneBook
            navigator.MoveToChild("PhoneBook", "");
            // зачитываем значение атрибута LastId
            int LastId = int.Parse(navigator.GetAttribute("LastId", ""));
            // увеличиваем его на 1
            LastId++;
            // переходим к атрибуту LastId
            navigator.MoveToAttribute("LastId", "");
            // перезаписываем значение
            navigator.SetValue($"{LastId}");
            // возвращаемся в корень
            navigator.MoveToRoot();
            // двигаемся к вложенному узлу с именем PhoneBook
            navigator.MoveToChild("PhoneBook", "");
            // добавляем вложенный узел Account с атрибутом ID
            navigator.AppendChild($"<Account ID =\"{LastId}\"></Account>");
            // переходим к первому потомку PhoneBook
            navigator.MoveToFirstChild();
            // в цикле двигаемся по узлах одного уровня
            // с тем узлом на который мы зашли в строчке выше
            while (navigator.MoveToNext())
            {
                // если атрибут ID узла равно последнему ID
                // вкладываем в него три потомка со значениями, введенными пользователем
                if (navigator.GetAttribute("ID", "") == $"{LastId}")
                {
                    navigator.AppendChild($"<Name>{name}</Name>");
                    navigator.AppendChild($"<Phone>{phone}</Phone>");
                    navigator.AppendChild($"<Comment>{comment}</Comment>");
                }
            }
            // сохраняем изменения
            doc.Save(file);
        }

        static void Rem(string file)
        {
            Console.Write("\t\tУдалить запись по ID\r\n>");
            string id = Console.ReadLine();


            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XPathNavigator navigator = doc.CreateNavigator();
            navigator.MoveToChild("PhoneBook", "");

            navigator.MoveToRoot();
            navigator.MoveToChild("PhoneBook", "");
            navigator.MoveToFirstChild();
            do
            {
                if (navigator.GetAttribute("ID", "") == id)
                {
                    navigator.MoveToFirstChild();
                    Console.WriteLine(navigator.Value);
                    navigator.MoveToNext();
                    Console.WriteLine(navigator.Value);
                    navigator.MoveToNext();
                    Console.WriteLine(navigator.Value);

                    Console.Write("Для подтверждения введите 1\r\n>");
                    if (Console.ReadLine() == "1")
                    {
                        navigator.MoveToParent();
                        navigator.DeleteSelf();
                    }

                    break;
                }
            } while (navigator.MoveToNext());

            doc.Save(file);
        }
        static void Fund()
{
            {
                string s = "";

                while (true)
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Введите номер телефона для поиска контакта (только цифры)");
                    Console.Write("> ");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (char.IsDigit(keyInfo.KeyChar))
                    {
                        if (s.Length < 12)
                        {
                            s += keyInfo.KeyChar;
                            Console.Clear();
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.Backspace)
                    {
                        if (s.Length > 0)
                        {
                            s = s.Substring(0, s.Length - 1);
                            Console.Clear();
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        break;
                    }
                    Console.SetCursorPosition(2, 1);
                    Console.WriteLine(new string(' ', 14));
                    Console.SetCursorPosition(2, 1);
                    Console.Write(s);
                    if (s.Length > 3)
                    {
                        Search(s);
                    }
                }
            }
            static void Search(string s)
            {
                int p = 0;
                Console.SetCursorPosition(0, 4);
                XmlDocument doc = new XmlDocument();
                doc.Load("PhoneBook.xml");
                XmlNodeList list = doc.LastChild.ChildNodes;// <PhoneBook>...</>
                foreach (XmlNode item in list)
                {
                    if (item.ChildNodes[1].InnerText.IndexOf(s) >= 0)
                    {
                        Console.WriteLine(item.ChildNodes[0].InnerText); // <name>
                        Console.WriteLine(item.ChildNodes[1].InnerText); // <phone>
                        Console.WriteLine(item.ChildNodes[2].InnerText); // <comment>
                        Console.WriteLine();
                        p++;
                    }


                }
                Console.WriteLine("Было найдено {0} записей",p);
            }

        }
    }
}
