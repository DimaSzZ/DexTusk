namespace Task13Delegate;
internal class Program
{
    private static void Main()
    {
        BankSystem.AddCashAccount("Гена",new List<InfoValuteAccount>());
        BankSystem.AddCashAccount("Гена", BankSystem.DictionaryCleints!["Гена"]);
        BankSystem.TransferMet(BankSystem.Convert);
        foreach (var ShowResult in BankSystem.DictionaryCleints?["Гена"]!)
        {
            Console.WriteLine($"{ShowResult.Type} {ShowResult.Cash}");
        }

    }
}