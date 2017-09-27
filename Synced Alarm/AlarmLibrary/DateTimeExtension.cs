using System;
using System.Globalization;

namespace AlarmLibrary
{
    public static class DateTimeExtension
    {
        public static string To24HourDateTimeString(this DateTime dateTime)
        {
            return dateTime.ToString("MM/dd/yyyy HH:mm");
        }

        public static DateTime ToDateTimeFrom24HourString(this string dateString)
        {
            return DateTime.ParseExact(dateString, "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
        }
    }
}