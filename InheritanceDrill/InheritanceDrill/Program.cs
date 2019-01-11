using System;


namespace InheritanceDrill
{
    class Program
    {


        static void Main(string[] args)
        {

            Person person = new Person();
            person.FirstName = "Luke";
            person.LastName = "Skywalker";
            person.SayName();


            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }


}