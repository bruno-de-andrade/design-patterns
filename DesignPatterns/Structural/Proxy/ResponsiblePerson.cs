namespace DesignPatterns.Structural.Proxy
{
    public class ResponsiblePerson
    {
        private readonly Person _person;

        public int Age
        {
            get => _person.Age;
            set => _person.Age = value;
        }

        public ResponsiblePerson(Person person)
        {
            _person = person;
        }

        public string Drink()
        {
            if (_person.Age >= 18)
            {
                return _person.Drink();
            }
            else
            {
                return "too young";
            }
        }

        public string Drive()
        {
            if (_person.Age >= 16)
            {
                return _person.Drive();
            }
            else
            {
                return "too young";
            }
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}
