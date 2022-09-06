using Task14Events;
class Program
{
    
    private static void Main()
    {
        var classTest = new ClassTest();
        classTest.Event += scanList_Event;
        var fakePersonRepository = new FakePersonRepository();
        var temporaryСollection = fakePersonRepository.GetAll().ToList();
        foreach (var personObject in temporaryСollection)
        {
            classTest.Add(personObject);
        }
        Console.WriteLine("Добавим 1 объект для демонстрации события");
        classTest.Add(new Person() { Name = "Имя", LastName = "Фамилия", Birth = new DateTime(2015, 7, 20) });
        classTest.Clear();
        Console.WriteLine("А теперь введите число для сравнения");
        StreamNumAnalizator.Percentchis = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(new StreamNumAnalizator() { Num = new Random().Next(5, 10) }.Num);
        }
        var notiTest = new NPCTest(){NameCar = "Девятка", ColorCar = "Желтый"};
        notiTest.ColorCar = "Пурпурный";
    }
    static void scanList_Event(object sender, ScanListEventArgs e)
    {
        var listPersons = sender as List<Person>;
        switch (e.Message)
        {
            case "Add":
                if(listPersons?.Count > 10)
                Console.WriteLine("Больше 10");
                break;
            case "Clear":
                Console.WriteLine("коллекция пуста");
                break;
        }
    }
}
