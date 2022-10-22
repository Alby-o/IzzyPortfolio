namespace Portfolio.Client.Util
{
    public static class DateOnlyExtensions
    {
        public static string ToMonthYearString(this DateOnly date)
        {
            return date.ToString("MMM yyyy");
        }

        public static string ToYearString(this DateOnly date)
        {
            return date.ToString("yyyy");
        }
    }
}
