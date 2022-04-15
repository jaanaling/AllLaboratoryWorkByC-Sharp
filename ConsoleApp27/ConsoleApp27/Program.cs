using System;
using System.Xml.Linq;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
			string fileName = "base.xml";
			//читаем данные из файла

			//счетчик для номера композиции
			int trackId = 1;
			//Создание вложенными конструкторами.
			XDocument doc1 = new XDocument(
				new XElement("library",
					new XElement("track",
						new XAttribute("id", trackId++),
						new XAttribute("genre", "Rap"),
						new XAttribute("time", "3:24"),
						new XElement("name", "Who We Be RMX (feat. 2Pac)"),
						new XElement("artist", "DMX"),
						new XElement("album", "The Dogz Mixtape: Who's Next?!")),
					new XElement("track",
						new XAttribute("id", trackId++),
						new XAttribute("genre", "Rap"),
						new XAttribute("time", "5:06"),
						new XElement("name", "Angel (ft. Regina Bell)"),
						new XElement("artist", "DMX"),
						new XElement("album", "...And Then There Was X")),
					new XElement("track",
						new XAttribute("id", trackId++),
						new XAttribute("genre", "Break Beat"),
						new XAttribute("time", "6:16"),
						new XElement("name", "Dreaming Your Dreams"),
						new XElement("artist", "Hybrid"),
						new XElement("album", "Wide Angle")),
					new XElement("track",
						new XAttribute("id", trackId++),
						new XAttribute("genre", "Break Beat"),
						new XAttribute("time", "9:38"),
						new XElement("name", "Finished Symphony"),
						new XElement("artist", "Hybrid"),
						new XElement("album", "Wide Angle"))));
			doc1.Save(fileName);

			XDocument doc = XDocument.Load(fileName);
			//проходим по каждому элементу в найшей library
			//(этот элемент сразу доступен через свойство doc.Root)
			foreach (XElement el in doc.Root.Elements())
			{
				//Выводим имя элемента и значение аттрибута id
				Console.WriteLine("{0} {1}", el.Name, el.Attribute("id").Value);
				Console.WriteLine("  Attributes:");
				//выводим в цикле все аттрибуты, заодно смотрим как они себя преобразуют в строку
				foreach (XAttribute attr in el.Attributes())
					Console.WriteLine(" {0}", attr);
				Console.WriteLine("  Elements:");
				//выводим в цикле названия всех дочерних элементов и их значения
				foreach (XElement element in el.Elements())
					Console.WriteLine(" {0}: {1}", element.Name, element.Value);
			}

		}
	}
}
