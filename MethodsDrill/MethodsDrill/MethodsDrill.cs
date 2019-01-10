
using System;


namespace MethodsDrill
{
    public class MethodsDrill
    {
        static void Main()
        {
            Console.WriteLine("Pick a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Addition a = new Addition();
            int x = a.AddTwoValues(5, 10);
            int y = a.AddThreeValues(15, 25, 35);
            int z = a.AddFourValues(10, 20, 30, 40);

            Console.WriteLine(x + userInput);
            Console.WriteLine(y + userInput);
            Console.WriteLine(z + userInput);
            Console.ReadLine();
        }
    }
}