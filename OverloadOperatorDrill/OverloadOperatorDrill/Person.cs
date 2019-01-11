using System;


namespace OverloadOperatorDrill
{
    class Person : Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int ID { get; set; }

        public void SayName()
        {
            Console.WriteLine("Employee Name: " + FirstName + " " + LastName + " " + "ID: " + ID);
        }
        public static bool operator ==(Person person1, Person person2)
        {
            bool status = false;
            if (person1.ID == person2.ID)
            {
                status = true;
            }
            return status;
        }
        public static bool operator !=(Person person1, Person person2)
        {
            bool status = false;
            if (person1.ID != person2.ID)
            {
                status = true;
            }
            return status;
        }
    }
}