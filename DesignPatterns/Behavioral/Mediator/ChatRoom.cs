using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ChatRoom
    {
        private List<Person> _people = new List<Person>();

        public void Broadcast(string source, string message)
        {
            foreach (var person in _people)
            {
                if (person.Name != source)
                {
                    person.Receive(source, message);
                }
            }
        }

        public void Join(Person person)
        {
            person.Room = this;
            _people.Add(person);

            Broadcast("room", $"{person.Name} joins the chat");
        }

        public void Message(string source, string destination, string message)
        {
            _people.FirstOrDefault(p => p.Name == destination)?.Receive(source, message);
        }
    }
}
