using System;
using System.Collections.Generic;
using System.IO;

namespace Hello
{
    class Program
    {

        static void Main(string[] args)
        {
            foreach (var drive in DriveInfo.GetDrives())
            {

                Console.WriteLine("Имя диска: " + drive.Name);
                Console.WriteLine("Файловая система: " + drive.DriveFormat);
                Console.WriteLine("Тип диска: " + drive.DriveType);
                Console.WriteLine("Объем доступного свободного места (в байтах): " + drive.AvailableFreeSpace);
                Console.WriteLine("Готов ли диск: " + drive.IsReady);
                Console.WriteLine("Корневой каталог диска: " + drive.RootDirectory);
                Console.WriteLine("Общий объем свободного места, доступного на диске (в байтах): " + drive.TotalFreeSpace);
                Console.WriteLine("Размер диска (в байтах): " + drive.TotalSize);




                Console.WriteLine();
            }


        }
    }
}