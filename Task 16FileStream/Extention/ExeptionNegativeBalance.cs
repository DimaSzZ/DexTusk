namespace Task_16FileStream.Extention
{
    internal class ExeptionNegativeBalance : Exception
    {
        public double Cash;

        public ExeptionNegativeBalance(string message, double cash) :base(message)
        {
            Cash = cash;
        }
    }
}
