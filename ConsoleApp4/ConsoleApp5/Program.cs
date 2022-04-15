using System;
using System.Collections.Generic;
using System.IO;

namespace Hello
{
    class Program
    {

        static void Main(string[] args)
        {
            string path1 = "E:\\TEMP1";
            string subpath1 = "TEMP1";
            string path2 = "E:\\TEMP2";
            string path3 = "E:\\Tekst";
            string txt = "E:\\Tekst\\block.txt";
            string newtxt = "E:\\TEMP2\\TEMP1\\block.txt";
            DirectoryInfo dirInfo1 = new DirectoryInfo(path1);
            DirectoryInfo dirInfo2 = new DirectoryInfo(path2);
            DirectoryInfo dirInfo3 = new DirectoryInfo(path3);
            FileInfo fileInf = new FileInfo(txt);
            if (!dirInfo1.Exists)
            {
                Console.WriteLine("Создана папка TEMP1");
                dirInfo1.Create();

            }
            if (!dirInfo3.Exists)
            {
                dirInfo3.Create();

            }
            dirInfo1.CreateSubdirectory(subpath1);
          
          
            if (dirInfo1.Exists && Directory.Exists(path2) == false)
            {
                Console.WriteLine(" папка TEMP1 перемещена в TEMP2");
                dirInfo1.MoveTo(path2);
            }

            
            if (!fileInf.Exists)
            {
                Console.WriteLine(" Создан файл формата txt");
                fileInf.Create();
            }

            

            if (fileInf.Exists)
            {
                Console.WriteLine("  файл формата txt перемещён в TEMP1 ");
                fileInf.MoveTo(newtxt);

            }
            Console.ReadKey();
            if (dirInfo2.Exists)
            {
                Console.WriteLine("Удалена  папка TEMP2");
                dirInfo2.Delete(true);
                
            }

        }
    }
}