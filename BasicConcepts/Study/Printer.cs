using System;

namespace Study
{
    public class Printer
    {
        public string Output()
        {
            return "kristol";
        }

        public static string Output(string msg)
        {
            return "kristol, " + msg;
        }

        public string PrintWeek(int dayOfWeek)
        {
            switch(dayOfWeek)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return "Workday";
                case 6:
                case 7:
                    return "Weekend";
                default:
                    return "Error: Wrong Input!";
            }
        }
    }
}
