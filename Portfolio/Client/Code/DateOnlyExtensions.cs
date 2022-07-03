namespace Portfolio.Client.Code
{
    public static class DateOnlyExtensions
    {
        public static string ToMonthYearString(this DateOnly date)
        {
            return date.ToString("MMM yyyy");
        }
    }
}
