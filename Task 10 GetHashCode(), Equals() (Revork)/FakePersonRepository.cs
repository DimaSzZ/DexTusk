using Bogus;

namespace Task_7_GetHashCode____Equals__
{
    public class FakePersonRepository
    {
        private readonly IEnumerable<Person> _persons;

        public FakePersonRepository()
        {
            var personFaker = new Faker<Person>()
                .RuleFor(x => x.Name, g => g.Person.FirstName)
                .RuleFor(x => x.LastName, g => g.Person.LastName)
                .RuleFor(x => x.Birth, g => g.Person.DateOfBirth);
            _persons = personFaker.Generate(10);
        }
        public IEnumerable<Person> GetAll()
        {
            return _persons;
        }
    }
}
