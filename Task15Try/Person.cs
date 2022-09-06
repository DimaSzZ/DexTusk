namespace Task15Try
{
    internal class Person
    {
        private string? _name;
        private int _age; 
        public string? Name { get; set; }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 18)
                    throw new LessAgePersonException("Лицам до 18 регистрация запрещена", value);
                else if (value > 140)
                {
                    throw new MoreAgePersonException("Вы первый, кто столько прожил",value);
                }
                else
                    _age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
