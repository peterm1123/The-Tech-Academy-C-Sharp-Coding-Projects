using System;

namespace InterfaceDrill
{
    class Employee : Person, IQuittable
    {

        public override void SayName()
        {
            Console.WriteLine("The employee's name is: " + firstName + " " + lastName);
        }

        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }

        public override void Quit()
        {
            Console.WriteLine("The employee " + firstName + " " + lastName + " " + "has quit");
        }
    }
}