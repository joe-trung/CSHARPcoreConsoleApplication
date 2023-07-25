using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApplication
{
    internal class Student
    {
        int studentId;
        string studentName;

        public void acceptDetails()
        {
            Console.Write("Enter Student Id: ");
            studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();
        }

        //public Student()
        //{
        //    studentId = 101;
        //    studentName = "Annonymous";
        //}

        //public Student(int sId, string sName)
        //{
        //    studentId = sId;
        //    studentName = sName;
        //}

            public void displayDetails()
        {
            Console.WriteLine("Student Id: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
        }


    }
}
