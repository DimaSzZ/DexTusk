namespace Task13Delegate;
internal class Program
{
    private static void Main()
    {
        //BankSystem.AddCashAccount(new Client("Чорт"),new Dictionary<Type, double>());
        var fio = new Client("Чорт").Fio;
        if (fio != null)
            Client.DictionaryCleints?.Add(fio, new Dictionary<Type, double>() {[typeof(Program)] = 2000});
        var dictionaryCleint = Client.DictionaryCleints?["Чорт"];
        if (dictionaryCleint == null) return;
        foreach (var d in dictionaryCleint)
        {
            Console.WriteLine("Пиймал за сраку");
        }
    }
}