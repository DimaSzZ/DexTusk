namespace Task_5_Linq
{
    internal class Persona
    {
        string name;
        public string? Name
        {
            get => name;
            set
            {
                if (value == "1") { name = "Саша"; }
                else if (value == "2") { name = "Женя"; }
                else { name = "Алекс"; }
            }
        }
        public int Age { get; set; }
        public string? Gender
        {
            get => gender;
            set
            {
                if (value == "1") { gender = "Мужской"; }
                else { gender = "Женский"; }
            }
        }
        string? gender;
        public Persona(string? Name, int Age, string? Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }
        public override string ToString()
        {
            return $"Имя:{Name} Возраст: {Age} Пол: {Gender}";
        }
    }
}
