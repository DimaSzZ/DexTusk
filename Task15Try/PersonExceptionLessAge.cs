namespace Task15Try
{
    internal class PersonExceptionLessAge : Exception
    {
        public int Value;
        public PersonExceptionLessAge(string name, int value):base(name)
        {
            Value = value;
        }
    }
}
