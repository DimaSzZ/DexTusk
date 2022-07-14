namespace Tas_4_IEnumerable_IEnumerator
{
    internal class Auto
    {
        public string[] Cars;
        public IEnumerator<string> GetEnumerator() => new AutoEnumerator(Cars);

        public Auto(string[] b)
        {
            Cars = b;
        }
    }
}
