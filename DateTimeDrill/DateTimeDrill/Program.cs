using System;


namespace DateTimeDrill
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("The current Date and Time is: ");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Please enter a number.");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In {0} hours, it will be ", X);
            double[] hours = { X };
            DateTime dateValue = DateTime.Now;

            foreach (double hour in hours)
                Console.WriteLine("{0} + {1} hour(s) = {2}", dateValue, hour, dateValue.AddHours(hour));
            Console.ReadLine();
        }
    }
}