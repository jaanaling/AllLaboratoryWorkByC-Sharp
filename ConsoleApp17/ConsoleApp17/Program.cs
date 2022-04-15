#define student
using ClassLibrary1;
using System;

namespace ConsoleApp17
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Class
            #region Worker
            Worker worker = new Worker("Bob", 48, "Enginer");
            #endregion
            #region Methods
            worker.Info();
            worker.Status();
            #endregion
            #region Student
            Student student = new Student("Francesco", 15, "Student");
            #endregion
            #region Methods
            student.Info();
            student.Status();
            #endregion
            #endregion
        }

    }
}