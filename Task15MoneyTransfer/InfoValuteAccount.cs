namespace Task15MoneyTransfer
{
    internal class InfoValuteAccount
    {
        public InfoValuteAccount(Type type, double cash)
        {
            Type = type;
            Cash = cash;
        }
        public Type Type { get; set; }
        
        private double _cash { get; set; }
        public double Cash
        {
            get => _cash;
            set
            {
                var oldCash = _cash;
                _cash = value;
                if (_cash < 0)
                {
                    _cash = oldCash;
                    throw new ExeptionNegativeBalance("Вы ввели сумму, которой нет на вашем аккаунте. Введите сумму сново", value);
                }
            }
        }
    }
}
