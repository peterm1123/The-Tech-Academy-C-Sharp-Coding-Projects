using System;
using System.Text;


namespace StringDrill
{
    class StringDrill
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Good Afternoon. ");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Okay " + name + ", Nice to meet you. What is your best strength?");
            string userStrength = Console.ReadLine();
            string strength = userStrength.ToUpper();

            StringBuilder sb = new StringBuilder();
            sb.Append(". My best strength is " + strength + ". ");

            Console.WriteLine("How will that help us out? ");

            string fit = Console.ReadLine();
            sb.Append("I think it will help you out because " + fit);

            Console.WriteLine("Hello, my name is " + name + sb + ". Thank you for talking to me");
            Console.ReadKey();


        }
    }
}