using System;


namespace ExceptionHandlingDrill2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter your age.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                int birthYear = 2018 - userInput;
                if (userInput < 1)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine(birthYear);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a real age.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}