using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pick a number that isn't an even number between 1 and 10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            while (!isGuessed)

            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("1 is an odd number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("2 is an even number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("3 is an odd number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("4 is a even number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("5 is a odd number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("6 is a even number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("7 is a odd number!");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("8 is an even number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("9 is a odd number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("10 is a even number.");
                        Console.WriteLine("Try another number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Good work!");
                        Console.WriteLine("That is not an odd number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }


                Console.Read();
            }
        }

    }
}