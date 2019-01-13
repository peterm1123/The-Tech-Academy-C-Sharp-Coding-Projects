using System;


namespace IODrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Test text\nMore text";
            Console.WriteLine("Please enter a number to save to file");
            string num = Console.ReadLine();
            string filePath = @"C:\Users\Nashi\log.txt";
            File.WriteAllText(filePath, text + "\n" + num);

            string readText = File.ReadAllText(filePath);
            Console.WriteLine("\n\n");
            Console.WriteLine("Contents of text file:\n");
            Console.WriteLine(readText);
        }
    }
}