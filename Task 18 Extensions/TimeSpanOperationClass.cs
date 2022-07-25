namespace Task_18_Extensions
{
    public static class TimeSpanOperationClass
    {
        public static TimeSpan HourNow(this int time, DateTime ts)
        {
            return ts-ts.Date ;
        }
    }
}
