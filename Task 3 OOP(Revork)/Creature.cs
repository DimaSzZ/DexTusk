namespace Task_1_OOP
{
    internal abstract class Creature
    {
            protected string? Name { get; set; }
            protected int MidAge { get; set; }
            protected double Weight { get; set; }
            public Creature(string name, int midAge, double weight)
            {
                Name = name;
                MidAge = midAge;
                Weight = weight;
            }

        public virtual void MethodLogicOverride()
        {
            Console.WriteLine("Какая то логика для базового класса");
        }
    }
}
