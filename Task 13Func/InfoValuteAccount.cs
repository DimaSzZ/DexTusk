namespace Task_13Func
{
    internal class InfoValuteAccount
    {
        public InfoValuteAccount(Type type, double cash)
        {
            Type = type;
            Cash = cash;
        }
        public Type Type { get; set; }
        public double Cash { get; set; }
    }
}
