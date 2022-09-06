namespace Task15MoneyTransfer
{
    internal class NegativeBalanceException : Exception
    {
        public double Cash;

        public NegativeBalanceException(string message, double cash) :base(message)
        {
            Cash = cash;
        }
    }
}
