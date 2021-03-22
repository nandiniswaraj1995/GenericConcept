using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConcept
{
    public class GenericClass<T> where T : IComparable
    {
        public static T maximum(params T[] elements)
        {
            T max = elements[0];
            foreach(T element in elements)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }
            printMax(max);
            return max;
           }
        public static void printMax(T element)
        {
            Console.WriteLine("Max Value: "+element);
        }



    }
}
