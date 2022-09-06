namespace Task15Try
{
    internal class LessAgePersonException : Exception
    {
        public int Value;
        public LessAgePersonException(string message, int value):base(message)
        {
            Value = value;
        }
    }
}
