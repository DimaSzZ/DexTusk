namespace Task_17Dispose;
class Program
{
    private static void Main()
    {
        var dispose = new TestDisposeClass(456);
        dispose.Dispose(); 
        using var newNum = new TestDisposeClass(322);
        Console.WriteLine($"Новый тестовый объект {newNum.RandomNum}");
    }

}