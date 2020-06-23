using System;

namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public class NoBonusesModifier : CreatureModifier
    {
        public NoBonusesModifier(Creature creature) : base(creature)
        {
        }

        public override void Handle()
        {
            Console.WriteLine("No bonuses");
        }
    }
}
