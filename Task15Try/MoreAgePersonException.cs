namespace Task15Try
{
    internal class MoreAgePersonException : Exception
    {
        public int Value { get; }
        public MoreAgePersonException(string name, int value):base(name)
        {
            Value = value;
        }
    }
}
