using System.Diagnostics;
using Task_2;

class Program
{
    static void Main()
    {
        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("");
                var sw = new Stopwatch();
                sw.Start();
                Console.WriteLine("Введите количество сторон и их длины");
                var figure = SpecialTestClass.Inserter(new SpecialTestClass { NumSide = 5, LengthSide = 5 });
                SpecialTestClass.Overrider(ref figure);
                Console.WriteLine(figure.Square);
                sw.Stop();
                Console.WriteLine($"Время {sw.Elapsed.TotalMilliseconds}");
                break;
            case "2":
                Console.WriteLine("");
                var Sw = new Stopwatch();
                Sw.Start();
                Console.WriteLine("Введите количество сторон и их длины");
                var Figure = SpecialTestStruct.Inserter(new SpecialTestStruct { NumSide = 5, LengthSide = 5 });
                SpecialTestStruct.Overrider(ref Figure);
                Console.WriteLine(Figure.Square);
                Sw.Stop();
                Console.WriteLine($"Время {Sw.Elapsed.TotalMilliseconds}");
                break;
        }
    }
}