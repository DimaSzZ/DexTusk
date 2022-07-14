using Task_3;
class Program
{
    static void Main()
    {
        Console.WriteLine("Выберете валюту из которой будете конвертировать ");
        Console.WriteLine("1-Рубль 2-Гривна 3-Леи");
        Currency? inConvertCurrency = null;
        Currency? outConvertCurrency = null;
        inConvertCurrency = Console.ReadLine() switch
        {
            "1" => new Rub(),
            "2" => new Griv(),
            "3" => new Lei(),
            _ => inConvertCurrency
        };
        Console.Write("Введите количество денег:");
        var cash = double.Parse(Console.ReadLine());
        Console.WriteLine("Выберете валюту в которую будете конвертировать ");
        Console.WriteLine("1-Рубль 2-Гривна 3-Леи");
        outConvertCurrency = Console.ReadLine() switch
        {
            "1" => new Rub(),
            "2" => new Griv(),
            "3" => new Lei(),
            _ => outConvertCurrency
        };
        Currency.Convertator(inConvertCurrency, cash, outConvertCurrency).GetMoney();
    }
}