using System;

namespace ClassLibrary3
{
    public class Data
    {
        static public void Datta()
        {
            Console.WriteLine("Введите год");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите Месяц");
            int month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите день");
            int day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите час");
            int hour = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите минуту");
            int minute = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите секунду");
            int second = Int32.Parse(Console.ReadLine());
            DateTime date1 = new DateTime( year,  month,  day,  hour,  minute,  second);
            Console.WriteLine(date1);

        }
    }
}
