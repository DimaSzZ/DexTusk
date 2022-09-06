namespace Task_18_Extensions;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество часов, которые вы хотите отнять от настоящего времени");
        int hours = 5;
        var totalHours = hours.HourNow(DateTime.Now);
        Console.WriteLine($"{totalHours.Hour}:{totalHours.Minute}:{totalHours.Second}");
    }
}