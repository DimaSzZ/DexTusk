namespace Task15MoneyTransfer
{
    internal class BankSystem
    {
        public static Dictionary<string, List<InfoValuteAccount>>? DictionaryCleints = new()
        {
            {
                "Федя",
                new List<InfoValuteAccount>() { new InfoValuteAccount(typeof(Rub), 2700)
                ,new InfoValuteAccount(typeof(Grivna), 2700),  new InfoValuteAccount(typeof(Lei), 2700)
            }
            }
        };

        static List<InfoValuteAccount> MetFunc(double money, Type donorAccauntType, Type recipientAccauntType,
            string fio, Func<double, Type, Type, string, List<InfoValuteAccount>> deFunc) => deFunc(money, donorAccauntType, recipientAccauntType, fio);

        private static double SelectorType(Type t)
        {
            if (t == typeof(Rub)) return new Rub().Curs;
            else if (t == typeof(Lei)) return new Lei().Curs;
            else if (t == typeof(Grivna)) return new Grivna().Curs;
            else
                Console.WriteLine("Ошибка");
            return 0;

        }
        public static List<InfoValuteAccount> Convertation(double money, Type donorAccauntType, Type recipientAccauntType, string fio)
        {
            var donnorAccaunt = DictionaryCleints![fio].First(x => x.Type == donorAccauntType);
            donnorAccaunt.Cash -= money;
            var recipientAccaunt = DictionaryCleints[fio].First(x => x.Type == recipientAccauntType);
            recipientAccaunt.Cash += money / BankSystem.SelectorType(donorAccauntType) *
                                         BankSystem.SelectorType(recipientAccauntType);
            foreach (var accounts in BankSystem.DictionaryCleints[fio])
            {
                if (accounts.Type == donnorAccaunt.Type) { accounts.Cash = donnorAccaunt.Cash; };
                if (accounts.Type == recipientAccaunt.Type) { accounts.Cash = recipientAccaunt.Cash; };
            }
            return BankSystem.DictionaryCleints[fio];
        }

        public static void TransferMet()
        {
            string? fio;
            while (true)
            {
                Console.WriteLine("Введите имя пользователя");
                fio = Console.ReadLine();
                var checker = fio != null && BankSystem.DictionaryCleints != null &&
                              BankSystem.DictionaryCleints.ContainsKey(fio);
                if (checker)
                {
                    Console.WriteLine("Авторизация прошла успешно.Внизу предоставлены ваши счета");
                    break;
                }
                else
                {
                    Console.WriteLine("Такого клиента нет в списке");
                }
            }

            if (fio != null)
                foreach (var accounts in DictionaryCleints?[fio]!)
                {
                    Console.WriteLine($"{accounts.Type} {accounts.Cash}");
                }

            Console.WriteLine(
                "Введите валютный счет доннор, а потом валютный счет получатель где 1-Рубль 2-Лей 3-Гривна");
            Type typeDonnor;
            Type typerecipient;
            typeDonnor = Console.ReadLine() switch
            {
                "1" => typeof(Rub),
                "2" => typeof(Lei),
                "3" => typeof(Grivna),
                _ => throw new ArgumentOutOfRangeException()
            };
            typerecipient = Console.ReadLine() switch
            {
                "1" => typeof(Rub),
                "2" => typeof(Lei),
                "3" => typeof(Grivna),
                _ => throw new ArgumentOutOfRangeException()
            };
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите количество денег");
                    var cash = double.Parse(Console.ReadLine() ?? string.Empty);
                    if (BankSystem.DictionaryCleints != null)
                        if (fio != null)
                            BankSystem.DictionaryCleints[fio] =
                                MetFunc(cash, typeDonnor, typerecipient, fio, Convertation);
                    break;
                }
                catch (NegativeBalanceException ex)
                {
                    Console.WriteLine($"{ex.Message} {ex.Cash}");
                }
            }
        }
    }
}
