namespace Task24_1_
{
    internal class ClientClass
    {
        public static List<ClientClass> clients = new List<ClientClass> {

            new ClientClass("Dima", 3222) };
        public ClientClass(string? fio,int cash)
        {
            Fio = fio;
            Cash = cash;
        }
        public string ?Fio { get; set; }
        public int Cash { get; set; }

    }
}
