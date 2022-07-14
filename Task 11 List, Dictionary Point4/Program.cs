namespace Task_8_List__Dictionary;
using  System.Collections.Generic;
class Program
{
    static void Main()
    {
        var Client = new Client("Усенков Дмитрий Валерьевич");

        Client.DictionaryValute?.Add(typeof(Rub),new Rub().SetMoney(2550));
        Client.DictionaryValute?.Add(typeof(Griv), new Griv().SetMoney(500000));
        Client.DictionaryValute?.Add(typeof(Dol), new Dol().SetMoney(2900));
        if (Client.DictionaryValute != null) Console.WriteLine(Client.DictionaryValute[typeof(Rub)]);
    }
}