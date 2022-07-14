namespace Task_8_List__Dictionary
{
    internal static class SelectorList
    {
        public static Client Selector_IdPassport(this List<Client> clients, string id)
        {
            return clients.First(x => x.IdPassport == id);
        }
        public static List<Client> Selector_This_Cash(this List<Client> clients, double cash)
        {
            return (List<Client>)clients.Where(x => x.DictionaryValute[typeof(Rub)] < cash);
        }
        public static Client? Selector_Min_Cash(this List<Client?> clients)
        {
            return clients.Min();
        }
        public static double Selector_All_Cash(this List<Client> clients) => clients.Select(x => x.DictionaryValute[typeof(Rub)]).Sum();
    }
}
