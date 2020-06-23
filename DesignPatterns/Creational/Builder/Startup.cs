using System;

namespace DesignPatterns.Creational.Builder
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var classElement = new CodeBuilder("Person")
                .AddField("Name", "string")
                .AddField("Age", "int")
                .GetClassElement();

            Console.WriteLine(classElement);
        }
    }
}
