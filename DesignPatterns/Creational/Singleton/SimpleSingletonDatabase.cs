using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns.Creational.Singleton
{
    public class SimpleSingletonDatabase : IDatabase
    {
        private static readonly Lazy<SimpleSingletonDatabase> _instance = new Lazy<SimpleSingletonDatabase>(() => new SimpleSingletonDatabase());

        private Dictionary<string, int> _capitals;

        public static IDatabase Instance => _instance.Value;

        private SimpleSingletonDatabase()
        {
            _capitals = File.ReadAllLines(Path.Combine(new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "Singleton/capitals.txt"))
                            .ToDictionary(
                                list => list.Split('|')[0],
                                list => int.Parse(list.Split('|')[1]));
        }

        public int GetPopulation(string name)
        {
            return _capitals[name];
        }
    }
}
