namespace Task_17Dispose;
class Program
{
    private static void Main()
    {
        var dispose = new TestDistuctorClass(456);
        dispose.Dispose(); // Либо так
        using var newNum = new TestDistuctorClass(322); // Либо через using. ОН все автоматически делает за нас.
        Console.WriteLine($"Новый тестовый объект {newNum.RandomNum}");
        // как вариант можно было еще использовать диструктор( финализатор) который через ~ непосредственно в самом TestDistuctorClass объявляется.
    }

}