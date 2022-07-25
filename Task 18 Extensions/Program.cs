namespace Task_18_Extensions;
class Program
{
    static void Main()
    {
        var subtractTheHours = 5;
        var getInlyTime = subtractTheHours.HourNow(DateTime.Now);
        Console.WriteLine($"{getInlyTime.Hours}:{getInlyTime.Minutes}:{getInlyTime.Seconds}");
    }
}