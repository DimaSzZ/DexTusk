namespace Task15MoneyTransfer
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
