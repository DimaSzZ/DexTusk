namespace Task_8_List__Dictionary
{
    internal class Client
    {
        public Dictionary<Type, double> DictionaryValute = new Dictionary<Type, double>();
        public string? Fio { get; set; }
        public string IdPassport { get; set; }
        
        public Client(string fio)
        {
            Fio = fio;
            IdPassport = Convert.ToString(HashCode.Combine(Fio));
        }
        
    }
}
