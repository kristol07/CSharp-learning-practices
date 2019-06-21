using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public class Developer: Employee
    {
        public Developer():base("dev123") { }

        public void m()
        {
            base.m2();
        }
    }
}
