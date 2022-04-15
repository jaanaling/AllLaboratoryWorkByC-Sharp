using System;
using System.IO;
namespace ConsoleApp16
{
    class Program
    {
        static int IndexOf(string str, int Si, out char space) //находит разделитель (str - предложение)(Si-начало слова )(sword -   само слово)(space - разделитель) (out - чтоб передовать по ссылке)
        {
            space = '.';//сам разделитель
            for (int i = Si; i < str.Length; i++)//присваиваем i наше начало слова 
            {

                if (str[i] == space) // ищем разделитель 
                {
                    return i;//возвращаем индекс разделителя
                }

            }

            //если разделитель не найден
            return -1;
        }

        static string WordsReverse(string str)
        {

            int sl = str.Length; //(sl - длина предложения)
            char[] str2 = new char[sl];//(str2 - результат)
            int word = 0; //(начальный индекс у слова)

            while (word < sl)//через фор не получилось
            {
                int spaceI = IndexOf(str, word, out char space); //spaceI - индекс пробела
                if (spaceI == -1) // если разделителя нет, то мы присваиваем индексу пробела длину строки, чтоб выйти из цикла
                {
                    spaceI = str.Length;
                }
                else
                {
                    str2[spaceI] = space;
                }

                int Ind = word;// ind - текущий индекс
                for (int i = spaceI - 1; i >= word; i--)//тут переворачиваем
                {
                    str2[Ind] = str[i];
                    Ind++;
                }

                word = spaceI + 1;//чтобы снова зайти в цикл
            }

            return new string(str2);//new string - чтобы конвертировать str2 из Чара в Строку
        }

        static void Main(string[] args)
        {
            try { 
                
            string txt = "E:\\Tekst\\test1.txt";
                FileInfo fileInfo = new FileInfo("E:\\Tekst\\test1.txt");
                StreamReader sw = new StreamReader(txt, true);
            string str = sw.ReadLine();
            Console.WriteLine(WordsReverse(str));
            str = WordsReverse(str);
            sw.Close();
            StreamWriter ws = new StreamWriter(txt);
            ws.WriteLine(str);
            ws.Close();
            if (!fileInfo.Exists)
            {
                throw new Exception("Файла не существует");
            }
            if (str == null)
            {
                throw new Exception("Файл пустой");
            }
        }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}
    }
}