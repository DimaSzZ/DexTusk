namespace Task_8_List__Dictionary
{
    internal class Griv:ITransactions
    {
        private double Cash { get; set; }

        public double SetMoney(double cash)
        {
            Cash = cash;
            Console.WriteLine($"Вы отрыли свой счет в гривнах на сумму {Cash}");
            return Cash;
        }
    }
}
