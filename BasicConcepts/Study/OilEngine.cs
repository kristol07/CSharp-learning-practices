using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class OilEngine: Engine
    {
        protected override void InternalLaunch()
        {
            Console.WriteLine("Well, I am oil-driven.");
        }

        public override void Launch()
        {
            Console.WriteLine("??? ... Launched~");
        }
    }
}
