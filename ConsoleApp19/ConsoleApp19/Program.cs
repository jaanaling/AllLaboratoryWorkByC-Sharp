using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Sum<int> sum = new Sum<int>(2, 3);
           
            Sum<string> sum2 = new Sum<string>("2", "3");
            Sum<string> sum3 = new Sum<string>("One", "Two");
            sum.IntSum(sum.a, sum.b);
            sum2.StringSum(sum2.a, sum2.b);
            sum2.StringSum(sum3.a, sum3.b);
        }
    }
    class Sum<T>
    {
        public T a;
        public T b;
        public Sum(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public void IntSum(int a, int b)
        {
            Console.WriteLine("Сумма значений Int - {0}+{1} = {2}",a,b,a+b);
        }
        public void StringSum(string a, string b)
        {
            try 
            {
            int a1 = int.Parse(a);
            int a2 = int.Parse(b);
            Console.WriteLine("Сумма значений String - {0}+{1} = {2}",a,b, a1 + a2);
            }
            catch
            {
            Console.WriteLine("Сумма значений String - {0}+{1} = невозможно преобразовать слово в числа", a, b);
            }

            
        }
       
    }

}
