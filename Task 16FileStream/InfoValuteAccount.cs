using System.ComponentModel;
using Task_16FileStream.Extention;

namespace Task_16FileStream
{
    [Serializable]
    internal class InfoValuteAccount
    {
        public InfoValuteAccount(string strinType, double cash)
        {
            Type = strinType;
            Cash = cash;
        }

        public string Type { get; set; }
        
        private double _cash { get; set; }
        public double Cash
        {
            get => _cash;
            set
            {
                var oldCash = _cash;
                _cash = value;
                if (!(_cash < 0)) return;
                _cash = oldCash;
                throw new ExeptionNegativeBalance("Вы ввели сумму, которой нет на вашем аккаунте. Введите сумму сново", value);
            }
        }
    }
}
