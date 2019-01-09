using System;
using System.Collections.Generic;

class ArrayDrill
{
    static void Main()
    {

        Console.WriteLine("Please enter a number: (1-7)");
        string[] colorArray = new string[] { "red", "blue", "green", "black", "purple", "yellow", "white" };
        try
        {
            Console.WriteLine(colorArray[Convert.ToByte(Console.ReadLine()) - 1]);
        }

        catch (System.IndexOutOfRangeException)
        {
            System.Console.WriteLine("That number does not exist. Please try again.");

        }
        Console.WriteLine("Please enter a number: (1-7)");
        Console.WriteLine(colorArray[Convert.ToByte(Console.ReadLine()) - 1]);
        Console.ReadLine();



        Console.WriteLine("Please enter another number number: (1-7)");
        int[] numArray = new int[] { 7, 6, 5, 4, 3, 2, 1 };
        try
        {
            Console.WriteLine(numArray[Convert.ToByte(Console.ReadLine()) - 1]);
        }

        catch
        {
            System.Console.WriteLine("That index does not exist.");
        }
        Console.WriteLine("Please enter another number value: (1-7)");
        Console.WriteLine(numArray[Convert.ToByte(Console.ReadLine()) - 1]);
        Console.ReadLine();


        Console.WriteLine("Please enter a final index value: (1-7)");
        List<string> comic = new List<string>();
        comic.Add("Deadpool");
        comic.Add("Thor");
        comic.Add("Wolverine");
        comic.Add("Hulk");
        comic.Add("X-men");
        comic.Add("Fantastic Four");
        comic.Add("Avengers");

        try
        {
            Console.WriteLine(comic[Convert.ToByte(Console.ReadLine()) - 1]);
        }

        catch
        {
            System.Console.WriteLine("That comic does not exist.");
        }

        Console.WriteLine("Please enter a final number value: (1-7)");
        Console.WriteLine(comic[Convert.ToByte(Console.ReadLine()) - 1]);
        Console.ReadLine();
    }
}