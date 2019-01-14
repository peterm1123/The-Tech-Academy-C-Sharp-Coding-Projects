using System;

namespace ConstantVarDrill
{
    public class Student
    {
        public Student() : this("", "")
        {
        }

        public Student(string name, string city)
        {
            const string studentName = "Wade Wilson";
            var City = "Spokane";
            Console.WriteLine("Student name = {0}, City = {1}", studentName, City);
        }
    }
}