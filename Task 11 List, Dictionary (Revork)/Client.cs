namespace Task_8_List__Dictionary
{
    internal class Client
    {
        private string? _fio;
        public string? Fio
        {
            get => _fio;
            set
            {
                _fio = value switch
                {
                    "1" => "Саша",
                    "2" => "Женя",
                    "3" => "Кирил",
                    "4" => "Максим",
                    _ => "Алекс"
                };
            }
        }
        public string IdPassport { get; set; }
        public double Cash { get; set; }
        public Client(string fio,double cash)
        {
            Fio = fio;
            Cash = cash;
            IdPassport = Convert.ToString(HashCode.Combine(Fio,Cash));
        }
        
    }
}
