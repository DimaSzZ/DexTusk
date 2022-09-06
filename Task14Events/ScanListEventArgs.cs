namespace Task14Events
{
    public class ScanListEventArgs
    {
        public ScanListEventArgs(string message)
        {
            Message = message;
        }
        public string Message { get; private set; }
    }
}
