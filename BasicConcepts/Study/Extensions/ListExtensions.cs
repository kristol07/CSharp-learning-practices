using System;
using System.Collections.Generic;
using System.Text;

namespace Study.Extensions
{
    public static class ListExtensions
    {
        public static List<int> Transform(this List<int> myList, Func<int, int> function)
        {
            List<int> result = new List<int>();

            foreach (var i in myList)
            {
                result.Add(function(i));
            }

            return result;
        }

        public static List<int> Filter(this List<int> myList, Predicate<int> function)
        {
            List<int> result = new List<int>();

            foreach (var i in myList)
            {
                if (function(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
