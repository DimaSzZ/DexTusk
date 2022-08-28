namespace Task24_25_26_1_
{
    internal class Executor
    {
        static Semaphore sem = new Semaphore(3, 3);
        Thread myThread;
        int count = 3;

        public Executor(int i)
        {
            myThread = new Thread(Read);
            myThread.Name = $"Читатель {i}";
            myThread.Start();
        }
        public void Read()
        {
            while (count > 0)
            {
                sem.WaitOne();  

                Console.WriteLine($"{Thread.CurrentThread.Name} входит в библиотеку");

                Console.WriteLine($"{Thread.CurrentThread.Name} читает");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} покидает библиотеку");

                sem.Release();  

                count--;
                Thread.Sleep(1000);
            }
        }
    }
}
