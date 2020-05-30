using System;

namespace DesignPatterns.Builder
{
    class Startup
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");

            Console.WriteLine(cb);
        }
    }
}
