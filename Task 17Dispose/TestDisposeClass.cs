namespace Task_17Dispose
{
    internal class TestDisposeClass : IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
            }
            disposed = true;
        }
        public int RandomNum { get; set; }
        public TestDisposeClass(int random) =>RandomNum = random;
    }
}
