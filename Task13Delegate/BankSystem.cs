
namespace Task13Delegate
{
    internal class  BankSystem
    {
        public static Dictionary<string, List<InfoValuteAccount>>? DictionaryCleints = new()
        {
            { "Федя", new List<InfoValuteAccount>() { new InfoValuteAccount(typeof(Rub), 2700) 
                ,new InfoValuteAccount(typeof(Grivna), 2700),  new InfoValuteAccount(typeof(Lei), 2700)
            }
        }};
            
        public delegate void ConvertDelegate (double money, ref InfoValuteAccount donorAccaunt, ref InfoValuteAccount? recipientAccaunt);

        public static ConvertDelegate Convert = Convertation;
        public static void AddCashAccount(string? client, List<InfoValuteAccount>? listAccount)
        {
            if (client == null) return;
            bool keyExists = BankSystem.DictionaryCleints != null && BankSystem.DictionaryCleints.ContainsKey(client);
            if (!keyExists)
            {
                if (listAccount != null) BankSystem.DictionaryCleints?.Add(client, listAccount);
                Console.WriteLine("Такого клиента не было в базе данных, поэтому он был создан");
            }
            Console.WriteLine("Выберите валюту: 1-Рубли 2-Леи 3-Гривна");
            switch (Console.ReadLine())
            {
                case "1":
                    var rubAc = BankSystem.DictionaryCleints?[client];
                    rubAc?.Add(new InfoValuteAccount(typeof(Rub),1700));
                    if (BankSystem.DictionaryCleints != null)
                        if (rubAc != null)
                            BankSystem.DictionaryCleints[client] = rubAc;
                    break;
                case "2":
                    var leiAc = BankSystem.DictionaryCleints?[client];
                    leiAc?.Add(new InfoValuteAccount(typeof(Lei), 3700));
                    if (BankSystem.DictionaryCleints != null)
                        if (leiAc != null)
                            BankSystem.DictionaryCleints[client] = leiAc;
                    break;
                case "3":
                    var grivAc = BankSystem.DictionaryCleints?[client];
                    grivAc?.Add(new InfoValuteAccount(typeof(Grivna), 5600));
                    if (BankSystem.DictionaryCleints != null)
                        if (grivAc != null)
                            BankSystem.DictionaryCleints[client] = grivAc;
                    break;
            }
        }
        public static void Convertation(double money,ref InfoValuteAccount donorAccaunt,ref InfoValuteAccount? recipientAccaunt)
        {
            if (donorAccaunt?.Type == typeof(Rub))
            {
                donorAccaunt.Cash -= money;
                money /= new Rub().Curs;
            }
            else if (donorAccaunt?.Type == typeof(Lei))
            {
                donorAccaunt.Cash -= money;
                money /= new Lei().Curs;
            }
            else if (donorAccaunt?.Type == typeof(Grivna))
            {
                donorAccaunt.Cash -= money;
                money /= new Grivna().Curs;
            }
            if (recipientAccaunt?.Type == typeof(Rub))
            {
                recipientAccaunt.Cash+= money * new Rub().Curs;
            }
            else if(recipientAccaunt?.Type == typeof(Lei))
            {
                recipientAccaunt.Cash += money * new Lei().Curs;
            }
            else if (recipientAccaunt?.Type == typeof(Grivna))
            {
                recipientAccaunt.Cash += money * new Grivna().Curs;
            }
        }

        public static void TransferMet(ConvertDelegate convert)
        {
            string? fio;
            while (true)
            {
                Console.WriteLine("Введите имя пользователя");
                fio = Console.ReadLine();
                var checker = fio != null && BankSystem.DictionaryCleints != null && BankSystem.DictionaryCleints.ContainsKey(fio);
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

            Console.WriteLine("Введите валютный счет доннор, а потом валютный счет получатель где 1-Рубль 2-Лей 3-Гривна");
            Type typeDonnor;
            Type recipientrecipient;
            typeDonnor = Console.ReadLine() switch
            {
                "1" => typeof(Rub),
                "2" => typeof(Lei),
                "3" => typeof(Grivna),
                _ => throw new ArgumentOutOfRangeException()
            };
            recipientrecipient = Console.ReadLine() switch
            {
                "1" => typeof(Rub),
                "2" => typeof(Lei),
                "3" => typeof(Grivna),
                _ => throw new ArgumentOutOfRangeException()
            };
            Console.WriteLine("Введите количество денег");
            var cash = double.Parse(Console.ReadLine() ?? string.Empty);
            var donnorVariable = DictionaryCleints?[fio!].First(x => x.Type == typeDonnor);
            var recipientVariable = DictionaryCleints?[fio!].First(x => x.Type == recipientrecipient);
            if (donnorVariable != null) convert(cash, ref donnorVariable, ref recipientVariable);
            if (fio == null) return;
            foreach (var account in BankSystem.DictionaryCleints?[fio]!)
            {
                if (account.Type == donnorVariable?.Type)
                {
                    account.Cash = donnorVariable.Cash;
                }
                if (account.Type == recipientVariable?.Type)
                {
                    account.Cash = recipientVariable.Cash;
                }
            }
        }
    }

    
}
