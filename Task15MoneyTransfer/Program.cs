using Task15MoneyTransfer;
class Program
{
    private static void Main()
    {
        BankSystem.TransferMet();
        foreach (var ShowResult in BankSystem.DictionaryCleints?["Федя"]!)
        {
            Console.WriteLine($"{ShowResult.Type} {ShowResult.Cash}");
        }
    }
}