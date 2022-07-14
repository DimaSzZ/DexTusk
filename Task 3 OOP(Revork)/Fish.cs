namespace Task_1_OOP
{
    internal class Fish : Creature, ICreature
    {
        private int TailLenght { get; set; }
        private string? ScaleColor { get; set; }
        public Fish(string name, int midAge, double weight, int tailLenght, string scaleColor) : base(name, midAge, weight)
        {
            TailLenght = tailLenght;
            ScaleColor = scaleColor;
        }
        public void ShowCreature()
        {
            Console.WriteLine($"Вид этой рыбы {base.Name}, в среднем она живет {base.MidAge} лет," +
                              $" в среднем весит {base.Weight} кг. Хвост данной особи: {TailLenght} см а цвет чешуи {ScaleColor} ");
        }

        public override void MethodLogicOverride()
        {
            Console.WriteLine("Какая-то логика для рыб");
        }
    }
}
