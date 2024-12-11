using System;

namespace SalesPro.Helpers
{
    public static class DateFormatHelper
    {
        public static string FormatDate(DateTime date, string format = "MMMM dd, yyyy")
        {
            return date.ToString(format);
        }

        public static string FormatDateWithTime(DateTime date, string format = "MMMM dd, yyyy | hh:ss tt")
        {
            return date.ToString(format);
        }
    }

}
