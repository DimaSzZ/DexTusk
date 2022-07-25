namespace Task_16FileStream;

internal class Program
{
    [Obsolete("Obsolete")]
    private static void Main()
    {
        while (true)
        {
            if (File.Exists(@"C:\ClientsInfo\UsercFullAccounts.dat"))
            {
                BankSystem.DictionaryCleints = FileStreamClass.DropDictionaryClients();
            }
            var fio = Console.ReadLine();
            Console.WriteLine("Доброго времени суток,1-Пополнить или создать аккаунт,2-Конвертировать деньги с одного валютного счета на другой" +
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
                    foreach (var showResult in BankSystem.DictionaryCleints?[fio!]!)
                    {
                        Console.WriteLine($"{showResult.Type} {showResult.Cash}");
                    }
                    break;
            }
        }
    }
}