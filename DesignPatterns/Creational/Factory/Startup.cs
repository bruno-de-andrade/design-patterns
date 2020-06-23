using System;

namespace DesignPatterns.Creational.Factory
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var factory = new PersonFactory();
            var person1 = factory.CreatePerson("Rick");
            var person2 = factory.CreatePerson("Morty");

            Console.WriteLine($"Person 1 Id: {person1.Id}, Name: {person1.Name}");
            Console.WriteLine($"Person 2 Id: {person2.Id}, Name: {person2.Name}");
        }
    }
}
