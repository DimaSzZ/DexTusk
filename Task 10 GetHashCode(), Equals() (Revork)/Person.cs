namespace Task_7_GetHashCode____Equals__
{
    public class Person
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DateTime Birth { get; set; }
        public int IdPassport { get; set; }

        public override string ToString()
        {
            return $"Имя:{Name} День рождения: {Birth.Day}:{Birth.Month}:{Birth.Year} Фамилия: {LastName} Id паспарта:{IdPassport}";
        }
        public override bool Equals(object? obj)
        {
            return Equals(obj as Person);
        }

        protected bool Equals(Person? other)
        {
            return Name == other?.Name && LastName == other?.LastName && Birth.Equals(other?.Birth);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, LastName, Birth);
        }
    }
}
