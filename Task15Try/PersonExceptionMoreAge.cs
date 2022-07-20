namespace Task15Try
{
    internal class PersonExceptionMoreAge : Exception
    {
        public int Value { get; }
        public PersonExceptionMoreAge(string name, int value):base(name)
        {
            Value = value;
        }
    }
}
