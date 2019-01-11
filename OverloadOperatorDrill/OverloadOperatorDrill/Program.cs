using System;

namespace OverloadOperatorDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Wade";
            person1.LastName = "Wilson";
            person1.ID = 22;
            person1.SayName();
            Console.ReadLine();

            Person person2 = new Person();
            person2.FirstName = "Scott";
            person2.LastName = "Summer";
            person2.ID = 11;
            person2.SayName();
            Console.ReadLine();

            if (person1 == person2)
                Console.WriteLine("Wade Wilson and Scott Summer have the same Employee IDs.");
            else
                Console.WriteLine("Wade Wilson and Scott Summer do not have the same Employee IDs.");
            Console.ReadLine();
        }
    }
}