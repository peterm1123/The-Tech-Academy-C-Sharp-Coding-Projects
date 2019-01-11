using System;

namespace MethodDrill2
{
    public class Calculator
    {
        public Calculator()
        {

        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Subtract(double num1, double num2)
        {
            return Convert.ToInt32(num1 - num2);
        }

        public int Add(string one, string two)
        {
            int x = 0;
            int y = 0;
            if (!Int32.TryParse(one, out x))
            {
                x = -1;
            }
            if (!Int32.TryParse(two, out y))
            {
                y = -1;
            }
            return x + y;
        }
    }
}