namespace Task_3
{
    internal class Lei : Currency
    {
        public double Cash { get; set; }
        public Lei()
        {
            CurDol = 19.22;
        }
        public override void GetMoney()
        {
            Console.WriteLine($"Сумма в леях {Cash}");
        }
    }
}
