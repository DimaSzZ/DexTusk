using Task24_25_26_1_;

class Program
{
    public static int Amount { get; set; }

    static void Main()
    {
        Console.WriteLine("1 - 1 задание, 2 - 2 задание");
        switch (Console.ReadLine())
        {
            case "1":
                Task1Efficiency.Taks1Met();
                break;
            case "2":
                JobExecutor executor = new JobExecutor();

                Task.Run(() =>
                {
                    for (int i = 0; i < 100; i++)
                    {
                        executor.Add(() =>
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("Поток # 1");
                        });
                    }

                    executor.Start(2);
                });

                Task.Run(() =>
                {
                    for (int i = 0; i < 100; i++)
                    {
                        executor.Add(() =>
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("Поток # 2");
                        });
                    }
                    executor.Start(100);
                });
                executor.Stop();
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("1 или 2");
                break;
        }

    }
}