
namespace Task14Events
{
    public class ClassTest : List<Person>
    {
        public event EventHandler<ScanListEventArgs> Event;

        public new void Add(Person person)
        {
            base.Add(person);
            OnEvent("Add");
        }

        public new void Clear()
        {
            base.Clear();
            OnEvent("Clear");
        }

        private void OnEvent(string message)
        {
            Event(this, new ScanListEventArgs(message));
        }
    }
}
