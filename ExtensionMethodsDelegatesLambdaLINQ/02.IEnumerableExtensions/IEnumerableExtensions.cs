//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<double> numbers = new List<double> { 1.0, 2.0, 3.0, 4.0 };
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Product());
            Console.WriteLine(numbers.Avarage());
        }
    }
}