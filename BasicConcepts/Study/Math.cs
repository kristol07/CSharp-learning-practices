using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class Math
    {
        public static int Add(int x, int y) => x + y;

        public static int Substract(int x, int y) => x - y;

    }

    public delegate int Cal(int x, int y);

    public class Calculator
    {
        private Math math = new Math();

        public int calculate(int x, int y, Cal cal)
        {
            return cal(x, y); // cal.Invoke(x, y);
        }

        //public int calculateAdd(int x, int y)
        //{
        //    return math.Add(x, y);
        //}

        //public int calculateSubstract(int x, int y)
        //{
        //    return math.Substract(x, y);
        //}


    }
}
