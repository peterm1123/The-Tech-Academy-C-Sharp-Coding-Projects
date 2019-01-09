using System;
using System.Collections.Generic;


class Program
{

    static void Main(string[] args)
    { /*String array section*/

        string[] numArray1 = new string[7] { "red", "green", "yellow", "blue", "purple", "black", " " };

        for (int i = 0; i < numArray1.Length; i++)
        {

            Console.WriteLine(numArray1[i]);

        }
        Console.WriteLine("\n");
        Console.WriteLine("Please enter a color to add to the array:");
        numArray1[6] = Console.ReadLine();
        Console.WriteLine("\n");
        Console.WriteLine("Here is the new array:");

        for (int i = 0; i <= numArray1.Length - 1; i++)
        {

            Console.WriteLine(numArray1[i]);

        }

        while (true)
        {

            break;

        }
        /*First List*/

        Console.WriteLine("\n");
        Console.WriteLine("Next Question");
        Console.WriteLine("Please type the text of the movie index you want");
        Console.WriteLine("\n");
        List<string> Movie = new List<string>();
        Movie.Add("John Wick");
        Movie.Add("Star Wars");
        Movie.Add("Ant-Man");
        Movie.Add("Deadpool");
        Movie.Add("Logan");
        Movie.Add("Pacific Rim");
        Movie.Add("Lord of the Rings");

        for (int i = 0; i < Movie.Count; i++)
        {

            Console.WriteLine(Movie[i]);

        }

        string Movieread = Console.ReadLine();


        int count = 0;
        foreach (string Item in Movie)
        {
            if (Item.Contains(Movieread))
            {
                Console.WriteLine(count);
                break;
            }
            else if (count == Movie.Count - 1)
            {
                Console.WriteLine("I'm sorry that movie is not in the list!");
                break;
            }
            else
            {
                count = count + 1;
            }
        }
        /*Second List*/

        Console.WriteLine("\n");
        Console.WriteLine("Next Question");
        Console.WriteLine("Please type the text of the car index you want");
        Console.WriteLine("\n");
        List<string> cars = new List<string>();
        cars.Add("Dodge Durango");
        cars.Add("Ford F-150");
        cars.Add("Chrysler 300");
        cars.Add("Ford Raptor");
        cars.Add("Jeep Renegade");
        cars.Add("Dodge Charger");

        for (int i = 0; i < cars.Count; i++)
        {

            Console.WriteLine(cars[i]);

        }

        string carinput = Console.ReadLine();
        count = 0;
        bool goodanswer = false;
        foreach (string Item in cars)
        {

            if (Item.Contains(carinput))
            {
                Console.WriteLine(count);
                goodanswer = true;

            }
            else if ((count == cars.Count - 1) & (goodanswer == false))
            {

                Console.WriteLine("I'm sorry this car is not in the list!");
                break;
            }

            count = count + 1;


        }
        /*Third List*/

        Console.WriteLine("\n");
        Console.WriteLine("Next Question");
        Console.WriteLine("\n");
        List<string> Comics = new List<string>();
        Comics.Add("Hulk");
        Comics.Add("Deadpool");
        Comics.Add("Thor");
        Comics.Add("Deadpool");
        Comics.Add("X-men");
        Dictionary<string, string> occurrences = new Dictionary<string, string>();

        var testset = new HashSet<string>();

        foreach (var Item in Comics)
        {
            if (!testset.Add(Item))
            {
                Console.WriteLine("List contains duplicate of: " + Item);
                break;
            }
        }


        Console.ReadLine();
    }
}
