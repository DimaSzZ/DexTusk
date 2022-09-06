using System.Diagnostics;

namespace Task24_25_26_1_
{
    class JobExecutor
    {
        public JobExecutor()
        {
            Tasks = new Queue<Task>();
        }

        private Queue<Task> Tasks { get; set; }

        private int Amount { get { return Tasks.Count; } }

        private readonly object locker = new object();

        public void Start(int countThread)
        {
            Semaphore semaphore = new Semaphore(countThread, countThread);

            while (true)
            {
                semaphore.WaitOne();

                lock (locker)
                {
                    if (Amount > 0)
                        Tasks.Dequeue().Start();
                    else
                        return;
                }

                semaphore.Release();
            }

        }
        public void Stop(CancellationTokenSource ct)
        {
            Thread.Sleep(1000);
            ct.Cancel();
            Thread.Sleep(1000);
            ct.Dispose();
            Console.WriteLine("Поток остановлен, но проект не схлопнулся");
        }

        public void Add(Action action)
        {
            lock (locker)
            {
                Tasks.Enqueue(new Task(action));
            }
        }
        public void Clear()
        {
            Tasks.Clear();
        }
    }
}

