using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OvenApp
{

    public class Oven
    {

        public event DoSomething OverHeatEventRaiser;

        private int Temperature;
        public bool IsOn = false;

        public int ThresholdTemperature
        {
            get; set;
        }
        public string AlarmMessage { get; set; }

        public Oven() : this(37, 100, "OverHeat!") { }
        public Oven(int thresholdTemperature): this(37, thresholdTemperature, "OverHeat!") { }
        public Oven(int temperature, int thresholdTemperature, string alarmMessage)
        {
            Temperature = temperature;
            ThresholdTemperature = thresholdTemperature;
            AlarmMessage = alarmMessage;
        }

        public void Run()
        {
            SetOn();

            while (IsOn)
            {
                Heat();
                if (OverHeatEventRaiser != null && Temperature >= ThresholdTemperature)
                {
                    OverHeatEventRaiser();
                }
                Thread.Sleep(1000);
            }
        }

        public void SetOff()
        {
            IsOn = false;
            Console.WriteLine("Oven is turned off.");
        }

        public void SetOn()
        {
            IsOn = true;
            Console.WriteLine("Oven is turned on. Begin heat.");
        }

        private void Heat()
        {
            Temperature += 1;
            Console.WriteLine("The temperature is: {0}°C", Temperature);
        }

        public void Alarm()
        {
            Console.WriteLine(AlarmMessage);
        }

    }
}
