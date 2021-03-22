using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConcept
{
    public class GenericClass<T> where T : IComparable
    {
        public static T maximum(T x, T y, T z)
        {
            T max = x;
            if (y.CompareTo(max) > 0)
                max = y;
            if (z.CompareTo(max) > 0)
                max = z;
            return max;
        }



    }
}
