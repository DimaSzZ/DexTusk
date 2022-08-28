using System.Diagnostics;

namespace Task24_25_26_1_
{
    internal class Task1Efficiency
    {
        public static int[] _masTen = new int[10000000];
        public static int[] _masThundred = new int[100000000];
        public static void CalcTen()
        {
            var r = new Random();
            for (var i = 0; i < _masTen.Length; i++)
            {
                _masTen[i] = r.Next(1,10);
            }
            int sum = 0;
            for (int i = 0; i < _masTen.Length; i++)
            {
                sum += _masTen[i];
            }
            Console.WriteLine(sum/_masTen.Length);
        }
        public static void CalcThousand()
        {
            var r = new Random();
            for (var i = 0; i < _masThundred.Length; i++)
            {
                _masThundred[i] = r.Next(1, 10);
            }
            int sum = 0;
            for (int i = 0; i < _masThundred.Length; i++)
            {
                sum += _masThundred[i];
            }
            Console.WriteLine(sum/_masThundred.Length);
        }
        public static void Taks1Met()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            CalcTen();
            CalcThousand();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
            stopWatch.Restart();
            stopWatch.Start();
            new Thread(CalcTen).Start();
            new Thread(CalcThousand).Start();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
        }
    }
}
