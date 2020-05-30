namespace DesignPatterns.Factory
{
    public class PersonFactory
    {
        private int _lastId;

        public Person CreatePerson(string name)
        {
            return new Person
            {
                Id = _lastId++,
                Name = name
            };
        }
    }
}
