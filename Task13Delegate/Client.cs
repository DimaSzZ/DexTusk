namespace Task13Delegate
{
    internal class Client
    {
        public static Dictionary<string, Dictionary<Type, double>>? DictionaryCleints { get; set; }
        public string? Fio { get; set; }
        public Client(string fio)
        {
            Fio = fio;
        }
    }
}
