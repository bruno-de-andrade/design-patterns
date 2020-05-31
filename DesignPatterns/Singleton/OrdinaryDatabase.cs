﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns.Singleton
{
    public class OrdinaryDatabase : IDatabase
    {
        private Dictionary<string, int> _capitals;

        public OrdinaryDatabase()
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
