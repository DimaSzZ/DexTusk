namespace Task_8_List__Dictionary
{
    internal class Dol : ITransactions
    {
        private double Cash { get; set; }

        public double SetMoney(double cash)
        {
            Cash = cash;
            Console.WriteLine($"Вы отрыли свой счет в долларах на сумму {Cash}");
            return Cash;
        }
    }
}
