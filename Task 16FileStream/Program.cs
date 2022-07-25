namespace Task_16FileStream;

internal class Program
{
    [Obsolete("Obsolete")]
    private static void Main()
    {
        while (true)
        {
            BankSystem.DictionaryCleints = FileStreamClass.DropDictionaryClients();
            Console.WriteLine("Ввдетие фио клиента");
            var fio = Console.ReadLine();
            FileStreamClass.AddClientFile(fio!);
            Console.WriteLine($"Доброго времени суток {fio},1-Пополнить или создать аккаунт,2-Конвертировать деньги с одного валютного счета на другой" +
                              ", 3-Что бы посмотреть информацию о ваших счетах");
            switch (Console.ReadLine())
            {
                case "1":
                    BankSystem.AddCashAccount(fio, new List<InfoValuteAccount>());
                    break;
                case "2":
                    BankSystem.TransferMet();
                    break;
                case "3":
                    try
                    {
                        foreach (var showResult in BankSystem.DictionaryCleints?[fio!]!)
                        {
                            Console.WriteLine($"{showResult.Type} {showResult.Cash}");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Такой клиент не найден");
                    }
                    break;
            }
        }
    }
}