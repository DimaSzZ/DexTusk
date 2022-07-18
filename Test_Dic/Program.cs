class Program
{
    static void Main()
    {
        List<int> zxc = new() { 1, 2, 3, 4, 5, 6 };
        zxc.Where(x => x % 2 == 0);
        foreach (var VARIABLE in zxc)
        {
            Console.WriteLine(VARIABLE);
        }
    }
}