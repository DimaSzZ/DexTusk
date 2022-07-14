using Task_1_OOP;

class Program
{
    static void Main()
    {
        var organisms = new List<ICreature> { new Fish("Карась", 20, 3, 10, "Серый"),
            new Bird("Горный орел", 15, 5, 15, "Brown"),
            new Insect("Тарантул", 15, 40, MindTypes.RoysType, true) };
        foreach (var item in organisms)
        {
            item.ShowCreature();
            Console.WriteLine();
            var a = item as Creature;
            a.MethodLogicOverride();
            Console.WriteLine();
        }
    }
}