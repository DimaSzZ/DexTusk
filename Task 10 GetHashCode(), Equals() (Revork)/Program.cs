namespace Task_7_GetHashCode____Equals__;

internal class Program
{
    private static void Main()
    {
        var fakePersonRepository = new FakePersonRepository();
        var persons = fakePersonRepository.GetAll();
        var personObjectList = persons as Person[] ?? persons.ToArray();
        foreach (var personObject in personObjectList) { personObject.IdPassport = personObject.GetHashCode(); }
        foreach (var personObject in personObjectList) { Console.WriteLine(personObject); }
        Console.WriteLine();
        var personObjectClone = new Person
        {
            Name = personObjectList[0].Name,LastName = personObjectList[0].LastName,
            Birth = personObjectList[0].Birth = personObjectList[0].Birth,IdPassport = personObjectList[0].IdPassport
        };
        Console.WriteLine(personObjectList[0].Equals(personObjectList[1]));
        Console.WriteLine(personObjectList[0].Equals(personObjectClone));
    }
}