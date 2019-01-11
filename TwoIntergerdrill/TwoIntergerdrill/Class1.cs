using System;
using System.Runtime.InteropServices;

namespace TwoIntergerdrill

    {
        public class Example
        {

            public void AddNumbers(int a, [Optional] int[] b)
            {
                int total = a + 10;
                if (b != null)
                {
                    foreach (int i in b)
                    {
                        total += i;
                    }
                }
                Console.WriteLine("10 + integer one + integer two:");
                Console.WriteLine(total);

            }

        }
    }