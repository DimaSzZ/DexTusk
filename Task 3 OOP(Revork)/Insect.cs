namespace Task_1_OOP
{
    internal class Insect : Creature, ICreature
    {
        private MindTypes MindType { get; set; }
        private bool Danger { set { if (value == true) Danger2 = "представляет опасность для человека"; else Danger2 = "не представляет опасности для человека"; } }
        private string? Danger2 { get; set; }
        public Insect(string name, int midAge, double weight, MindTypes mindType, bool danger) : base(name, midAge, weight)
        {
            MindType = mindType;
            Danger = danger;
        }
        public void ShowCreature()
        {
            Console.Write($"Вид нашего насекомого  {base.Name}, в среднем он живет {base.MidAge} дней, в среднем весит {base.Weight} гр. {MindType}, {Danger2} ");
        }
        public override void MethodLogicOverride()
        {
            Console.WriteLine("Какая-то логика для насекомых");
        }
    }
}
