namespace Task14Events
{
    internal class PotocNumAnalizator
    {
        private delegate void PotocHendler(int chis);
        private static event PotocHendler? Notify = CheckPercent;
        public static int Percentchis { get; set; }

        public static void CheckPercent(int chis)
        {
            if(Percentchis * 0.40 + Percentchis < chis | Percentchis * 0.40 - Percentchis > chis)
            {
                Console.WriteLine("Число отличается более чем на 40 процентов ");
            }
        }
        private int _num;
        public int Num
        {
            get => _num;
            set
            {
                PotocNumAnalizator.Notify?.Invoke(value);
                _num = value;
            }
        }
    }
}
