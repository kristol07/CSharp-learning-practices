using System;
using System.Collections.Generic;
using System.Text;

namespace OvenApp
{

    public delegate void DoSomething();

    public class User
    {

        private Oven oven { get; }

        public User(Oven oven)
        {
            this.oven = oven;
        }

        public void OvenSettingsWhenOverHeat(DoSomething doSomething)
        {
            oven.OverHeatEventRaiser += doSomething;
        }

    }
}
