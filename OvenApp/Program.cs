using System;

namespace OvenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Oven oven = new Oven(45);
            //oven.OverHeatEventRaiser += new DoSomething(() => { Console.WriteLine("Alarm!"); });
            //oven.OverHeatEventRaiser += new DoSomething(() => { oven.SetOff(); });

            User user = new User(oven);
            user.OvenSettingsWhenOverHeat(oven.Alarm);
            user.OvenSettingsWhenOverHeat(oven.SetOff);

            oven.Run();

        }
    }
}
