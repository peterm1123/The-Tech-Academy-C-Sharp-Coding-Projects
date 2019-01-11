using System;

namespace EnumDrill
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter what Day of the week it is.");
            string dayValue = Console.ReadLine();

            try
            {
                Day day = (Day)Enum.Parse(typeof(Day), dayValue);
            }

            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day it is.");
            }

            Console.ReadLine();
        }
    }
}