namespace Task_9_Generic_Type__Generic_Member;

internal class Program
{
    private static void Main()
    {
        var collectionObject = new Bank();
        collectionObject.Registarion_Logic(new Client{Id = 1, Name = "ClientMisha", Age = 24});
        collectionObject.Registarion_Logic(new Employee { Id = 1, Name = "EmployeeEgor", Age = 24 });
        foreach (var zxc in collectionObject._clients)
        {
            Console.WriteLine($"{zxc.Id} {zxc.Name} {zxc.Age}");
        }
        foreach (var zxc in collectionObject._employes)
        {
            Console.WriteLine($"{zxc.Id} {zxc.Name} {zxc.Age}");
        }

        collectionObject.Search_Logic(new Employee { Id = 1 });
    }

}