using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{

    public delegate int TransformHandler(int i);
    public delegate bool FilterHandler(int i);

    public class MyList
    {
        private List<int> numbers = new List<int>();

        public void Add(int i)
        {
            numbers.Add(i);
        }

        public List<int> Transform(TransformHandler th)
        {
            List<int> result = new List<int>();

            foreach (var i in numbers)
            {
                result.Add(th(i));
            }

            return result;
        }

        public List<int> Filter(FilterHandler fh)
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
