namespace Task_1_OOP
{
    internal class Bird : Creature, ICreature
    {
        private int BeakLength { get; set; }
        private string? FeatherColor { get; set; }
        public Bird(string name, int midAge, double weight, int beakLength, string featherColor) : base(name, midAge, weight)
        {
            BeakLength = beakLength;
            FeatherColor = featherColor;
        }
        public void ShowCreature()
        {
            Console.WriteLine($"Вид нашей птички  {base.Name}, в среднем она живет {base.MidAge} лет," +
                              $" в среднем весит {base.Weight} кг. Длина клюва нашей птицы: {BeakLength} см, а цвет перьев {FeatherColor} ");
        }
        public override void MethodLogicOverride()
        {
            Console.WriteLine("Какая-то логика для птичек");
        }
    }
}
