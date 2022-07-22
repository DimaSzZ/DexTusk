namespace Task15Try
{
    internal class PersonExceptionLessAge : Exception
    {
        public int Value;
        public PersonExceptionLessAge(string message, int value):base(message)
        {
            Value = value;
        }
    }
}
