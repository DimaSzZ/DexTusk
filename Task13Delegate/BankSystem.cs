namespace Task13Delegate
{
    internal class  BankSystem
    {
        delegate double ConvertDelegate<in T, in B>(double money, T valueIn, B valueOut);

        private ConvertDelegate<> convertDelegate = Convertation;

        public void AddCashAccount(Client client, Dictionary<Type, double>? listAccount)
        {
            if (client.Fio != null)
            {
                Console.WriteLine("Выберите валюту: 1-Рубли 2-Леи 3-Гривна");
                switch (Console.ReadLine())
                {
                    case "1":
                        var a = Client.DictionaryCleints?[client.Fio];
                        a?.Add(typeof(Rub),2500);
                        break;
                    case "2":
                        var b = Client.DictionaryCleints?[client.Fio];
                        b?.Add(typeof(Lei), 3000);
                        break;
                    case "3":
                        var c = Client.DictionaryCleints?[client.Fio];
                        c?.Add(typeof(Grivna), 4500);
                        break;
                }
            }
        }
        public double Convertation<T, B>(double money, T valueIn, B valueOut)
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
