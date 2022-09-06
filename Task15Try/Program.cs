using Task15Try;

class Program
{
    static void Main()
    {
        try
        {
            var persona = new Client(Console.ReadLine()!, int.Parse(Console.ReadLine()!));
        }
        catch (MoreAgePersonException exMore)
        {
            Console.WriteLine($"{exMore.Message} {exMore.Value}");
        }
        catch (LessAgePersonException exLess)
        {
            Console.WriteLine($"{exLess.Message}. Возраст: {exLess.Value} не допустим");
        }
    }
}
