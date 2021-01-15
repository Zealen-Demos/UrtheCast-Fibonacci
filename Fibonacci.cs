using System;
using System.Collections.Generic;
using System.Text;

namespace UrtheCast
{
    public class Fibonacci
    {
        public static int CalculatePosition(int position, int sum, int a, int b)
        {

            Console.WriteLine("Position: " + a);
            if (position == 0)
            {
                return a;
            }

            return CalculatePosition(position - 1, a + b, b, a + b);
        }
    }
}
