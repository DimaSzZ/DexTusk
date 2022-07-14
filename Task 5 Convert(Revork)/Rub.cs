namespace Task_3
{
    internal class Rub : Currency
    {
        public double Cash { get; set; }
        public Rub()
        {
            CurDol = 53.5;
        }
        public override void GetMoney()
        {
            Console.WriteLine($"Сумма в рублях {Cash}");
        }
    }
}
