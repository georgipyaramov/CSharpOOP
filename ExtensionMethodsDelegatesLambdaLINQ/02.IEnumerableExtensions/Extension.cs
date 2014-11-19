namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(
            this IEnumerable<T> elements)
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentNullException("nqmash kakvo da bara6(lipsva 6perc)");
            }
            T sumOfElemensts = default(T);
            foreach (T element in elements)
            {
                sumOfElemensts += (dynamic)element;
            }
            return sumOfElemensts;
        }
        public static T Product<T>(
           this IEnumerable<T> elements) where T : IComparable, IComparable<T>
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentNullException("nqmash kakvo da bara6(lipsva 6perc)");
            }
            T sumOfElemensts = (dynamic)1;
            foreach (T element in elements)
            {
                sumOfElemensts *= (dynamic)element;
            }
            return sumOfElemensts;
        }
        public static T Min<T>(
            this IEnumerable<T> elements) where T : IComparable, IComparable<T>
        {

            if (elements.Count() == 0)
            {
                throw new ArgumentNullException("nqmash kakvo da bara6(lipsva 6perc)");
            }

            T elementMin = elements.First();
            foreach (T element in elements)
            {
                if (element.CompareTo(elementMin) < 0)
                {
                    elementMin = element;
                }
            }
            return elementMin;
        }
        public static T Max<T>(
            this IEnumerable<T> elements) where T : IComparable, IComparable<T>
        {

            if (elements.Count() == 0)
            {
                throw new ArgumentNullException("nqmash kakvo da bara6(lipsva 6perc)");
            }

            T elementMax = elements.First();
            foreach (T element in elements)
            {
                if (elementMax.CompareTo(element) < 0)
                {
                    elementMax = element;
                }
            }
            return elementMax;
        }
        public static T Avarage<T>(
         this IEnumerable<T> elements) where T : IComparable, IComparable<T>
        {
            if (elements.Count() == 0)
            {
                throw new ArgumentNullException("nqmash kakvo da bara6(lipsva 6perc)");
            }
            T sumOfElemensts = default(T);
            int count = 0;
            foreach (T element in elements)
            {
                count++;
                sumOfElemensts += (dynamic)element;
            }
            return sumOfElemensts / (dynamic)count;
        }
    }
}