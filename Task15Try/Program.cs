using Task15Try;

class Program
{
    static void Main()
    {
        try
        {
            var persona = new Client(Console.ReadLine()!, int.Parse(Console.ReadLine()!));
        }
        catch (PersonExceptionMoreAge exMore)
        {
            Console.WriteLine($"{exMore.Message} {exMore.Value}");
        }
        catch (PersonExceptionLessAge exLess)
        {
            Console.WriteLine($"{exLess.Message}. Возраст: {exLess.Value} не допустим");
        }
    }
}
