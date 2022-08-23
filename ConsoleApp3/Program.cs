namespace TipsAndTricks
{
    class Program
    {
        public static void Main(string[] args)
        {
            var date = 29.February(2020);
            var date2 = 13.December(2019);

            Console.WriteLine(date);
            Console.WriteLine(date2);
            Console.ReadKey();
        }
    }  

    static class Extesnions
    {
        private static readonly int[] DaysOfMonthsNonLeap =
        { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private static readonly int[] DaysOfMonthLeap =
        { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private static bool TryValidate
            (int year, int month, int day, out DateTime dateTime)
        {
            if (year < Constants.MinYear || year > Constants.MaxYear)
                throw new ArgumentOutOfRangeException("year");

            if (Constants.MinMonth < 1 || Constants.MaxMonth > 12)
                throw new ArgumentOutOfRangeException("month");

            int[] days = DateTime.IsLeapYear(year)
                            ? DaysOfMonthLeap
                            : DaysOfMonthsNonLeap;

            if (day < Constants.MinDay || day > days[month])
                throw new ArgumentOutOfRangeException("day");

            dateTime = new DateTime(year, month, day);
            
            return true;

        }


        // 29.February(2020);

        public static DateTime? January(this int day, int year)
        {
            if (TryValidate(year, Constants.JANUARY, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
        public static DateTime? February(this int day, int year)
        {
            if(TryValidate(year, Constants.FEBRUARY, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
        public static DateTime? March(this int day, int year)
        {
            if (TryValidate(year, Constants.MARCH, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
        public static DateTime? April (this int day, int year)
        {
            if (TryValidate(year, Constants.APRIL, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
        public static DateTime? May(this int day, int year)
        {
            if (TryValidate(year, Constants.MAY, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
        public static DateTime? June(this int day, int year)
        {
            if (TryValidate(year, Constants.JUNE, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
        public static DateTime? July(this int day, int year)
        {
            if (TryValidate(year, Constants.JULY, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
        public static DateTime? August(this int day, int year)
        {
            if (TryValidate(year, Constants.AUGUST, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
        public static DateTime? September(this int day, int year)
        {
            if (TryValidate(year, Constants.SEPTEMBER, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
        public static DateTime? October(this int day, int year)
        {
            if (TryValidate(year, Constants.OCTOBER, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
        public static DateTime? November(this int day, int year)
        {
            if (TryValidate(year, Constants.NOVEMBER, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }
        public static DateTime? December(this int day, int year)
        {
            if (TryValidate(year, Constants.DECEMBER, day, out DateTime dateTime))
            {
                return dateTime;
            }
            return null;
        }

        public static string ToTime(this DateTime datetime)
        { 
            return datetime.ToString("t");
        }
    }
}









