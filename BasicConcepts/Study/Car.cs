using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    public delegate void OnLauncherHandler();

    public class Car
    {
        //private Engine engine;

        //// Dependency Injection
        //public Car(Engine engine)
        //{
        //    this.engine = engine;
        //}

        public void run(OnLauncherHandler handler)
        {
            //engine.Launch();
            handler(); //handler.Invoke();
            Console.WriteLine("And I can run.");
        }
    }
}
