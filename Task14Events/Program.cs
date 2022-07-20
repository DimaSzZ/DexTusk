using Task14Events;
class Program
{
    
    private static void Main()
    {
        var programobject = new Program();
        programobject.Notify += programobject.CheckNumObject;
        programobject.Notify += programobject.CheckEmptyObject;
        var fakePersonRepository = new FakePersonRepository();
        var persons = fakePersonRepository.GetAll().ToList();
        foreach (var personObject in persons)
        {
            Console.WriteLine($"{personObject.Name} {personObject.LastName} {personObject.Birth}");
        }
        programobject.Notify(persons);
        Console.WriteLine("Добавим 1 объект для демонстрации события");
        persons.Add(new Persona() { Name = "Имя", LastName = "Фамилия", Birth = new DateTime(2015, 7, 20) });
        programobject.Notify(persons);
        persons.Clear();
        programobject.Notify(persons);
        Console.WriteLine("А теперь введите число для сравнения");
        PotocNumAnalizator.Percentchis = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(new PotocNumAnalizator() { Num = new Random().Next(5, 10) }.Num);
        }
        var NotiTest = new ClassINotifyPropertyChanged(){NameCar = "Девятка", ColorCar = "Желтый"};
    }
    private delegate void PersonaHendler(List<Persona> persona);
    private event PersonaHendler? Notify;

    private void CheckNumObject(List<Persona> persona)
    {
        if (persona.Count() > 10)
            Console.WriteLine("Объектов больше 10");
    }
    private void CheckEmptyObject(List<Persona> persona)
    {
        if (!persona.Any())
            Console.WriteLine("Коллекция пуста");
    }
}
