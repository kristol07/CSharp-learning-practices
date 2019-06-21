using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{

    //public delegate int TransformHandler(int i);
    //public delegate bool FilterHandler(int i);

    //public delegate R Function<T, R>(T x); // System.Func
    //public delegate bool Predicate<T>(T x);  // System.Predicate

    public class MyList
    {
        private List<int> numbers = new List<int>();

        public void Add(int i)
        {
            numbers.Add(i);
        }

        public List<int> Transform(Func<int, int> th)
        {
            List<int> result = new List<int>();

            foreach (var i in numbers)
            {
                result.Add(th(i));
            }

            return result;
        }

        public List<int> Filter(Predicate<int> fh)
        {
            List<int> result = new List<int>();

            foreach (var i in numbers)
            {
                if (fh(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }

    }
}
