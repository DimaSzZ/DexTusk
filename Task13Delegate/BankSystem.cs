namespace Task13Delegate
{
    internal class  BankSystem
    {
        public delegate double ConvertDelegate<in T,in B>(double money, T valueIn, B valueOut);

        public ConvertDelegate<object,object>? convertDelegateObject = Convertation;


        public static void AddCashAccount(Client client, Dictionary<Type, double>? listAccount)
        {
            if (client.Fio == null) return;
            if (Client.DictionaryCleints?[client.Fio] == null)
            {
                if (listAccount != null)
                {
                    Client.DictionaryCleints?.Add(client.Fio, listAccount);
                    Console.WriteLine("Такого клиента не было в базе данных, поэтому он был создан");
                }
            }
            Console.WriteLine("Выберите валюту: 1-Рубли 2-Леи 3-Гривна");
            switch (Console.ReadLine())
            {
                case "1":
                    var rubAc = Client.DictionaryCleints?[client.Fio];
                    rubAc?.Add(typeof(Rub),2500);
                    if (Client.DictionaryCleints != null)
                        if (rubAc != null)
                            Client.DictionaryCleints[client.Fio] = rubAc;
                    break;
                case "2":
                    var leiAc = Client.DictionaryCleints?[client.Fio];
                    leiAc?.Add(typeof(Rub), 2500);
                    if (Client.DictionaryCleints != null)
                        if (leiAc != null)
                            Client.DictionaryCleints[client.Fio] = leiAc;
                    break;
                case "3":
                    var grivAc = Client.DictionaryCleints?[client.Fio];
                    grivAc?.Add(typeof(Rub), 2500);
                    if (Client.DictionaryCleints != null)
                        if (grivAc != null)
                            Client.DictionaryCleints[client.Fio] = grivAc;
                    break;
            }
        }
        public static double Convertation< T, B>(double money, T valueIn, B valueOut)
        {
            switch (valueIn)
            {
                case Rub rub:
                    money /= rub.Curs;
                    break;
                case Lei lei:
                    money /= lei.Curs;
                    break;
                case Grivna grivna:
                    money /= grivna.Curs;
                    break;
            }
            switch (valueOut)
            {
                case Rub rub:
                    return money * rub.Curs;
                case Lei lei:
                    return money * lei.Curs;
                case Grivna grivna:
                    return money * grivna.Curs;
            }
            Console.WriteLine("Что то пошло не так");
            return 0;
        }
    }
}
