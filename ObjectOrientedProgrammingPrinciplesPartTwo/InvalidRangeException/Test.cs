using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidRangeException
{
    class Test
    {
        static void Main()
        {
        int startInt = 1, endInt = 100;
            DateTime startDate = new DateTime(1980, 1, 1), endDate = new DateTime(2013, 12, 31);

            try
            {
                int number = ReadNumberInRange(startInt, endInt);
                DateTime date = ReadDateInRange(startDate, endDate);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine("{0}.Valid range is [{1}..{2}].", e.Message, e.MinValue, e.MaxValue);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine("{0}.Valid range is [{1}..{2}].",
                    e.Message, e.MinValue.ToShortDateString(), e.MaxValue.ToShortDateString());
            }
        }

        private static int ReadNumberInRange(int startInt, int endInt)
        {
            Console.Write("Enter int [{0}..{1}]: ", startInt, endInt);
            int number = int.Parse(Console.ReadLine());
            if (number < startInt || number > endInt)
            {
                throw new InvalidRangeException<int>("Invalid range", startInt, endInt);
            }
            return number;
        }

        private static DateTime ReadDateInRange(DateTime startDate, DateTime endDate)
        {
            Console.Write("Enter date in range [{0}..{1}]: ", startDate.ToShortDateString(), endDate.ToShortDateString());
            DateTime number = DateTime.Parse(Console.ReadLine());
            if (number < startDate || number > endDate)
            {
                throw new InvalidRangeException<DateTime>("Invalid range", startDate, endDate);
            }
            return number;
        }
    }
}
