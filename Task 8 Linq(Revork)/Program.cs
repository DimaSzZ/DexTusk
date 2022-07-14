using Task_5_Linq;
class Program
{
    static void Main()
    {
        List<Persona> list = new List<Persona>();
        for (int i = 0; i < 100; i++)
        {
            list.Add(new Persona(Convert.ToString(new Random().Next(1, 4)),
                new Random().Next(18, 81), Convert.ToString(new Random().Next(1, 3))));
        }
        var List = list.Where(x => x.Name == "Женя" && x.Age < 50).OrderBy(x => x.Age);
        var List2 = list.GroupBy(x => x.Name);
        var List3 = list.Where(x => x.Gender == "Мужской").Any();
        var List4 = list.All(x => x.Gender == "Женский");
        var List5 = list.Where(x => x.Gender == "Женский" && x.Age > 50).Sum(x => x.Age);
        foreach (Persona persona in List)
        {
            Console.WriteLine(persona);
        }
        Console.WriteLine();
        foreach (var Group in List2)
        {
            Console.WriteLine(Group.Key);

            foreach (var person in Group)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine(List3);
        Console.WriteLine();
        Console.WriteLine(List4);
        Console.WriteLine();
        Console.WriteLine(List5);
    }
}