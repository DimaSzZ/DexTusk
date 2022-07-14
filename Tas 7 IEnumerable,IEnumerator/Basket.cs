namespace Tas_4_IEnumerable_IEnumerator
{
    internal class Basket
    {
        public string[] ItemsBasket;
        public IEnumerator<string> GetEnumerator() => new BasketEnumerator(ItemsBasket);
        public Basket(string[] b)
        {
            ItemsBasket = b;
        }
    }
}
