using System;
using System.Collections.Generic;

namespace GenericsDrill
{
    class GenericsDrilll
    {

        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            List<string> Items = new List<string>();
            Items.Add("Book");
            Items.Add("Pencil");
            Items.Add("Watch");
            Items.Add("Phone");
            Items.Add("Glasses");

            Employee<int> employee2 = new Employee<int>();
            List<int> Numbers = new List<int>();
            Numbers.Add(2);
            Numbers.Add(7);
            Numbers.Add(5);
            Numbers.Add(1);
            Numbers.Add(3);

            foreach (string item in Items)
            {
                Console.WriteLine(item);
            }
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}