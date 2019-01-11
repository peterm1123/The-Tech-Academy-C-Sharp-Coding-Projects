using System;


namespace OverloadDrill
{
    public static class Program
    {

        static void Main()
        {
            int x = 0;
            int y = 0;
            Method_Parameters method = new Method_Parameters();
            Console.WriteLine("Please enter an integer");
            x = Convert.ToInt32(Console.ReadLine());
            method.Example1(out y, x);
            Console.WriteLine("The first answer: " + x + " divided by 2 equals " + y);
            Console.WriteLine("Please hit enter to overload a function");
            Console.ReadLine();

            method.Overload(10, 20);
            Console.ReadLine();

        }
    }
}