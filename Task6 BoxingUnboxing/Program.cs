using System.Diagnostics;

class MyProgrman
{
    static void Main()
    {
        var sw = new Stopwatch();
        sw.Start();
        int firsNum = 123;
        object boxing = firsNum;
        sw.Stop();
        Console.WriteLine(sw.Elapsed.TotalMilliseconds);
        sw.Restart();
        sw.Start();
        int secondNum = (int)boxing;
        sw.Stop();
        sw.Restart();
        Console.WriteLine(sw.Elapsed.TotalMilliseconds);
    }
}