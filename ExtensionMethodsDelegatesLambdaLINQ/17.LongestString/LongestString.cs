//Write a program to return the string with maximum length from an array of strings. Use LINQ.

namespace LongestStringNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestString
    {
        public static int StringLength(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count++;
            }
            return count;
        }

        public static List<T> EnumerableToList<T>(IOrderedEnumerable<T> current)
        {
            List<T> listed = new List<T>();

            foreach (var item in current)
            {
                listed.Add(item);
            }

            return listed;
        }
        static void Main()
        {
            List<string> listOfStrings = new List<string>() {"This is sample text", "My name is Georgi Ivanov",
            "I'm 20 years old"};

            var longestString = listOfStrings.OrderBy(st => StringLength(st));

            var sortedList = EnumerableToList(longestString);

            Console.WriteLine("The longest string is: {0}", sortedList[sortedList.Count - 1]);

            Console.WriteLine();
        }
    }
}