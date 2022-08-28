using Task24_1_;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 - 1 задание, 2 - 2 задание");
        switch (Console.ReadLine())
        {
            case "1":
                new Thread(() => ClientClass.clients.Add(new ClientClass("Марк",963))).Start();
                new Thread(Foreach).Start();
                break;
            case "2":
                new Thread(Donation).Start();
                new Thread(Donation).Start();
                Thread.Sleep(1000);
                foreach (var objClient in ClientClass.clients)
                {
                    Console.WriteLine($"{objClient.Fio} {objClient.Cash}");
                }
                break;
            default:
                Console.WriteLine("Либо 1 либо 2");
                break;
        }
    }

    public static void Foreach()
    {
        foreach (var client in ClientClass.clients)
        {
            Console.WriteLine($"{client.Fio}");
        }
    }
    public static void Donation()
    {
        for (int i = 0; i < 10; i++)
        {
            ClientClass.clients.First(x => x.Fio == "Dima").Cash += 200;
        }
    }
}
