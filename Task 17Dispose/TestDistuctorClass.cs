using System.Threading.Channels;

namespace Task_17Dispose
{
    internal class TestDistuctorClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Очистили память");
        }
        public int RandomNum { get; set; }
        public TestDistuctorClass(int random) =>RandomNum = random;
    }
}
