using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public abstract class Engine
    {
        public virtual void Launch()
        {
            switchOn();
            Console.WriteLine("hou hou hou");
            InternalLaunch();
        }

        protected abstract void InternalLaunch();

        private void switchOn()
        {
            Console.WriteLine("I am ON now!");
        }
    }
}
