using System;

namespace DesignPatterns.Structural.Proxy
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var responsiblePerson = new ResponsiblePerson(new Person())
            {
                Age = 15
            };

            Console.WriteLine($"Drink: {responsiblePerson.Drink()}");
            Console.WriteLine($"Drive: {responsiblePerson.Drive()}");
            Console.WriteLine($"Drive and Drive: {responsiblePerson.DrinkAndDrive()}");
        }
    }
}
