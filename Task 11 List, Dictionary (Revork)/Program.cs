using System.Diagnostics;
using Task_8_List__Dictionary;

class Program
{
    static void Main()
    {
        var random = new Random();
        var list = new List<Client>();
        var dictionary = new Dictionary<string, Client>();
        var sw = new Stopwatch();
        var testRandomClient= new Client(Convert.ToString(random.Next(1, 7)), random.Next(1, 99999));
        list.Add(new Client(Convert.ToString(random.Next(1, 7)), random.Next(1, 99999)));
        dictionary.Add(testRandomClient.IdPassport, testRandomClient);
        {
            list.Add(new Client(Convert.ToString(random.Next(1, 7)), random.Next(1, 99999)));
        }
        for (var i = 0; i < 1001; i++)
        {
            var a = new Client(Convert.ToString(random.Next(1, 7)), random.Next(1, 99999));
            dictionary.Add(a.IdPassport, a);
            Console.WriteLine(a.IdPassport);
        }
        sw.Start();
        list.Selector_IdPassport($"{list[0].IdPassport}");
        foreach (var listClient in list)
        {
            Console.WriteLine($"Сумма на счету:{listClient.Cash} ID паспорта:{listClient.IdPassport} ФИО:{listClient.Fio}");
        }
        Console.WriteLine($"Время {sw.Elapsed.TotalMilliseconds}");
        sw.Stop();
        sw.Reset();
        sw.Start();
        var searchRandomClient = dictionary[testRandomClient.IdPassport];
        Console.WriteLine($"Сумма на счету:{searchRandomClient.Cash} ID паспорта:{searchRandomClient.IdPassport} ФИО:{searchRandomClient.Fio}");
        Console.WriteLine($"Время {sw.Elapsed.TotalMilliseconds}");
        sw.Stop();
    }
}
