using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class ElectricEngine: Engine
    {
        protected override void InternalLaunch()
        {
            Console.WriteLine("Well, I am electricity-driven.");
        }
    }
}
