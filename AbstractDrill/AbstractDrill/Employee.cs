using System;

namespace AbstractDrill
{
    class Employee : Person
    {

        public override void SayName()
        {
            Console.WriteLine("The employee's name is: " + firstName + " " + lastName);
        }

    }
}