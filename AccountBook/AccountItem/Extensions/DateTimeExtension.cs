using System;
using System.Collections.Generic;
using System.Text;

namespace AccountItem.Extensions
{
    public static class DateTimeExtension
    {
        public static bool IsSameMonthOfSameYear(this DateTime dateTime, DateTime targetDateTime)
        {
            return dateTime.Year == targetDateTime.Year && dateTime.Month == targetDateTime.Month;
        }
    }
}
