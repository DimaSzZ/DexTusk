namespace Task_3
{
    internal class Griv : Currency
    {
        public  double Cash { get; set; }
        public Griv()
        {
            CurDol = 29.8;
        }
        public override void GetMoney()
        {
            Console.WriteLine($"Сумма в гривнах:{Cash}");
        }

    }
}
