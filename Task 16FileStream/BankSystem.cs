﻿using Task_16FileStream.Extention;

namespace Task_16FileStream
{
    public class BankSystem
    {
        public static Dictionary<string, List<InfoValuteAccount>>? DictionaryCleints = new();
            [Obsolete("Obsolete")]
        public static void AddCashAccount(string? client, List<InfoValuteAccount>? listAccount)
        {
            if (client == null) return;
            var keyExists = DictionaryCleints != null && DictionaryCleints.ContainsKey(client);
            if (!keyExists)
            {
                if (listAccount != null) DictionaryCleints?.Add(client, listAccount);
                
                Console.WriteLine("Такого клиента не было в базе данных, поэтому он был создан");
            }
            Console.WriteLine("Выберите валюту: 1-Рубли 2-Леи 3-Гривна");
            switch (Console.ReadLine())
            {
                case "1":
                    DictionaryCleints?[client]?.Add(new InfoValuteAccount("Rub", 1700));
                    FileStreamClass.SaveDictionaryClients(DictionaryCleints!);
                    break;
                case "2":
                    var leiAc = DictionaryCleints?[client];
                    leiAc?.Add(new InfoValuteAccount("Lei", 3700));
                    if (DictionaryCleints != null)
                        DictionaryCleints[client] = leiAc!;
                    FileStreamClass.SaveDictionaryClients(DictionaryCleints!);
                    break;
                case "3":
                    var grivAc = DictionaryCleints?[client];
                    grivAc?.Add(new InfoValuteAccount("Grivna", 5600));
                    if (DictionaryCleints != null)
                        DictionaryCleints[client] = grivAc!;
                    FileStreamClass.SaveDictionaryClients(DictionaryCleints!);
                    break;
            }
        }

        static List<InfoValuteAccount> MetFunc(double money, string donorAccauntType, string recipientAccauntType,
            string fio, Func<double, string, string, string, List<InfoValuteAccount>> deFunc) => deFunc(money, donorAccauntType, recipientAccauntType, fio);

        private static double SelectorType(string t)
        {
            if (t == "Rub") return new Rub().Curs;
            else if (t == "Lei") return new Lei().Curs;
            else if (t == "Grivna") return new Grivna().Curs;
            else
                Console.WriteLine("Ошибка");
            return 0;

        }
        public static List<InfoValuteAccount> Convertation(double money, string donorAccauntType, string recipientAccauntType, string fio)
        {
            var donnorAccaunt = DictionaryCleints![fio].First(x => x.Type == donorAccauntType);
            donnorAccaunt.Cash -= money;
            var recipientAccaunt = DictionaryCleints[fio].First(x => x.Type == recipientAccauntType);
            recipientAccaunt.Cash += money / SelectorType(donorAccauntType) *
                                         SelectorType(recipientAccauntType);
            foreach (var accounts in DictionaryCleints[fio])
            {
                if (accounts.Type == donnorAccaunt.Type) { accounts.Cash = donnorAccaunt.Cash; };
                if (accounts.Type == recipientAccaunt.Type) { accounts.Cash = recipientAccaunt.Cash; };
            }
            return DictionaryCleints[fio];
        }

        [Obsolete("Obsolete")]
        public static void TransferMet()
        {
            string? fio;
            while (true)
            {
                Console.WriteLine("Введите имя пользователя");
                fio = Console.ReadLine();
                var checker = fio != null && DictionaryCleints != null &&
                              DictionaryCleints.ContainsKey(fio);
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
            string typeDonnor;
            string typerecipient;
            typeDonnor = Console.ReadLine() switch
            {
                "1" => "Rub",
                "2" => "Lei",
                "3" => "Grivna",
                _ => throw new ArgumentOutOfRangeException()
            };
            typerecipient = Console.ReadLine() switch
            {
                "1" => "Rub",
                "2" => "Lei",
                "3" => "Grivna",
                _ => throw new ArgumentOutOfRangeException()
            };
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите количество денег");
                    var cash = double.Parse(Console.ReadLine() ?? string.Empty);
                    if (DictionaryCleints != null)
                        if (fio != null)
                            DictionaryCleints[fio] =
                                MetFunc(cash, typeDonnor, typerecipient, fio, Convertation);
                    FileStreamClass.SaveDictionaryClients(DictionaryCleints);
                    break;
                }
                catch (ExeptionNegativeBalance ex)
                {
                    Console.WriteLine($"{ex.Message} {ex.Cash}");
                }
            }
        }
    }
}
