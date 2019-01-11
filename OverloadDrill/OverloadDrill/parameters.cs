using System;


namespace OverloadDrill

{
    public class Method_Parameters
    {

        public void Example1(out int y, int x)
        {
            y = x / 2;
        }

        public void Overload(int x, int y)
        {
            Console.WriteLine("Overload(int x, int y)");
        }

        public void Overload(int x, double y)
        {
            Console.WriteLine("Overload(int x, double y)");
        }

        public void Overload(double x, int y)
        {
            Console.WriteLine("Overload(double x, int y)");
        }

    }
}