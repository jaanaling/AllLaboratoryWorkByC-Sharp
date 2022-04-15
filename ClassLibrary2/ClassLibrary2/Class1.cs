using System;

namespace ClassLibrary2
{
    public class Methods
    {
        static public Random r = new Random();
        static public int[] Mas(int n)
        {
            int[] m = new int[n];
            for (int i = 0; i < n; i++)
            {
                m[i] = r.Next(1, 20);
            }
            return m;
        }
        static public void getMas(int[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i]);
            }
        }
    }
}
