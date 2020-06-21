﻿namespace DesignPatterns.Template_Method
{
    public class Creature
    {
        public int Attack { get; set; }

        public int Health { get; set; }

        public Creature(int attack, int health)
        {
            Attack = attack;
            Health = health;
        }
    }
}
