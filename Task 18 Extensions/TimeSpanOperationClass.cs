namespace Task_18_Extensions
{
    public static class TimeSpanOperationClass
    {
        public static DateTime HourNow(this int time, DateTime ts)
        {
            return ts.AddHours(-(time)) ;
        }
    }
}
