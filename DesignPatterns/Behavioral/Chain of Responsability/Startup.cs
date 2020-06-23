using System;

namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var goblin = new Creature("Goblin", attack: 2, defense: 2);

            var rootModifier = new CreatureModifier(goblin);
            rootModifier.Add(new DoubleAttackModifier(goblin));
            rootModifier.Add(new IncreaseDefenseModifier(goblin));
            rootModifier.Handle();

            Console.WriteLine($"Name: {goblin.Name}, Attack: {goblin.Attack}, Defense: {goblin.Defense}");

            var goblin2 = new Creature("Goblin 2", attack: 2, defense: 2);

            rootModifier = new CreatureModifier(goblin2);
            rootModifier.Add(new NoBonusesModifier(goblin2));
            rootModifier.Add(new DoubleAttackModifier(goblin));
            rootModifier.Handle();

            Console.WriteLine($"Name: {goblin2.Name}, Attack: {goblin2.Attack}, Defense: {goblin2.Defense}");

        }
    }
}
