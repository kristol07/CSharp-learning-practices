using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class MyEnumerator
    {
        private int seed;

        public MyEnumerator(int seed)
        {
            this.seed = seed;
        } 

        public IEnumerable<int> NextNumber()
        {
            for (int i = 0; i <= this.seed; i = i + 2)
            {
                yield return i;
            }
            for (int i = 1; i <= this.seed; i = i + 2)
            {
                yield return i;
            }
        }
    }
}
