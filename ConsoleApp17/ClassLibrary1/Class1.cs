
#define student
using System;

namespace ClassLibrary1
{
    #region Class
    public abstract class People
    {
        #region Poly
        protected string name;
        protected int age;
        protected string status;
        #endregion
        #region Constuct
        public People(string name, int age, string status)
        {
            this.name = name;
            this.age = age;
            this.status = status;
        }
        #endregion
        #region Methods
        public abstract void Info();
        public abstract void Status();
        #endregion
    }
    #region PClass
    #region Worker
    public class Worker : People
    {
        #region Construct
        public Worker(string name, int age, string status) : base(name, age, status) { }
        #endregion
        #region Methods
        public override void Info()
        {
            Console.WriteLine("Name - {0}, Age - {1}, Status - {2}", name, age, status);
        }
        public override void Status()
        {
#if student
            Console.WriteLine("Too old to study");

#endif

#if worker
            Console.WriteLine("Go in work");

#endif
        }
        #endregion
    }
    #endregion
    #region Student
    public class Student : People
        {
            #region Constuct
            public Student(string name, int age, string status) : base(name, age, status) { }
            #endregion
            #region Methods
            public override void Info()
            {
                Console.WriteLine("Name - {0}, Age - {1}, Status - {2}", name, age, status);
            }
            public override void Status()
            {
#if student
                Console.WriteLine("Go stady");

#endif

#if worker
            Console.WriteLine("too young for work");

#endif
        }
        #endregion
    }
    #endregion
    #endregion
    #endregion
}

