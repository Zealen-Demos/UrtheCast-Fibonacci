using System;
using System.Collections.Generic;

namespace UrtheCast
{
    class UrtheCast
    {
        static void Main(string[] args)
        {
            List<String> original = new List<String>{ "one", "two", "three", "thxxx", "thaaa" };
            List<String> add = new List<String> { "one", "two", "five", "six" };
            List<String> remove = new List<String> { "two", "five" };

            Console.WriteLine(Fibonacci.CalculatePosition(5, 0, 0, 1));

            ListManipulation.Merge(original, add, remove).ForEach(Console.WriteLine);
        }
    }
}
