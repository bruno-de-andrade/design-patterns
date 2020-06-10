using System;

namespace DesignPatterns.Chain_of_Responsability
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
