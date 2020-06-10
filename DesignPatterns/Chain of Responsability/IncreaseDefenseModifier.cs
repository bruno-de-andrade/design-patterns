using System;

namespace DesignPatterns.Chain_of_Responsability
{

    public class IncreaseDefenseModifier : CreatureModifier
    {
        public IncreaseDefenseModifier(Creature creature) : base(creature) { }

        public override void Handle()
        {
            Console.WriteLine($"Increasing {creature.Name}'s defense");
            creature.Defense += 3;

            base.Handle();
        }
    }
}
