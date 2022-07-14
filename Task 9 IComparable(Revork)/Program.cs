using Task_6_IComparable;
class Program
{
    static void Main()
    {
        Figure[] figures = new Figure[10];
        for (int i = 0; i < figures.Length; i++)
        {
            figures[i] = new Figure(new Random().Next(1, 50));
        }
        Array.Sort(figures);

        foreach (Figure figure in figures)
        {
            Console.WriteLine($"Сторона:{figure.Side} - Площадь:{figure.Square}");
        }
    }
}