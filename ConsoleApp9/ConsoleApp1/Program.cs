using System;

namespace Consolefirstpplication1
{
    public delegate void MyDelegate(string str); 
    class First
    {
        protected string str;
        public First( string str)
        {
            this.str = str;
        }
        public event MyDelegate My_event; 
        public void GenEv() 
        {
            Console.WriteLine("Событие создано!!!"); 

            if (My_event != null) My_event(str);
           
        }
    }
    class Second
    {
        public void Do_Event_1(string str) 
        { Console.WriteLine(str); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            First first = new First("first");
            First first1 = new First("first1");
            Second С = new Second();
         
            
            first.My_event += new MyDelegate(С.Do_Event_1);
        
            first.GenEv();

            first1.My_event += new MyDelegate(С.Do_Event_1);

            first1.GenEv();

        }
    }
}
