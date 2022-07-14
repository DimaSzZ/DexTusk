using System.Collections;

namespace Tas_4_IEnumerable_IEnumerator
{
    internal class AutoEnumerator : IEnumerator<string>
    {
        private string[] ItemsBasket;
        public AutoEnumerator(string[] basket) => this.ItemsBasket = basket;
        int position = -1;
        public string Current
        {
            get
            {
                if (position == -1 || position >= ItemsBasket.Length)
                    throw new ArgumentException();
                return ItemsBasket[position];
            }
        }
        object IEnumerator.Current => throw new NotImplementedException();
        public bool MoveNext()
        {
            if (position < ItemsBasket.Length - 1)
            {
                if (ItemsBasket[position + 1] == "Автобус") { Console.WriteLine("Эта машина Автобус"); }

                else if (ItemsBasket[position + 1] == "Легковая") { Console.WriteLine("Легковая машина"); }
                else if (ItemsBasket[position + 1] == "Грузовая") Console.WriteLine("Грузовая машина");
                else
                {
                    Console.WriteLine("Класс машины не распознан");
                }
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset() => position = -1;
        public void Dispose() { }
    }
}
