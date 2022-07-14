using Tas_4_IEnumerable_IEnumerator;

class Program
{
    static void Main()
    {
        string[] Basket = { "Гриб", "Ягода", "Гриб", "Ягода", "Гриб", "Монета", "Ягода" };
        var basket = new Basket(Basket);
        foreach (var item in basket) ;
        Console.WriteLine();
        string[] Cars = { "Автобус", "Легковая", "Грузовая", "Легковая", "Автобус", "Грузоподъемная", "Грузовая" };
        var cars = new Auto(Cars);
        foreach (var item in cars) ;
    }
}