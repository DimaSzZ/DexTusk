using Bogus;

namespace Task14Events
{
    internal class FakePersonRepository
    {
        private readonly IEnumerable<Persona> _persons;

        public FakePersonRepository()
        {
            var personFaker = new Faker<Persona>()
                .RuleFor(x => x.Name, g => g.Person.FirstName)
                .RuleFor(x => x.LastName, g => g.Person.LastName)
                .RuleFor(x => x.Birth, g => g.Person.DateOfBirth);
            _persons = personFaker.Generate(10);
        }
        public IEnumerable<Persona> GetAll()
        {
            return _persons;
        }
    }
}
