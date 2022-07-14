using System.Collections;

namespace Tas_4_IEnumerable_IEnumerator
{
    internal class BasketEnumerator : IEnumerator<string>
    {
        private string[] ItemsBasket;
        public BasketEnumerator(string[] basket) => this.ItemsBasket = basket;
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
                if (ItemsBasket[position+1] == "Гриб") {Console.WriteLine("Это наш  гриб");}

                else if (ItemsBasket[position+1] == "Ягода") { Console.WriteLine("Это наша ягода"); }
                else Console.WriteLine("Непонятный предмет");
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

