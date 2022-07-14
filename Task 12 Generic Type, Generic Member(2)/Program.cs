namespace Task_12_Generic_Type__Generic_Member_2_;

internal class Program
{
    private static void Main()
    {
        var resultConvertation = new Exchange().Convertation(2500, new Rub(), new Grivna());
        Console.WriteLine(resultConvertation);
    }
}