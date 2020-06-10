using System;

namespace DesignPatterns.Chain_of_Responsability
{
    public class CreatureModifier
    {
        protected Creature creature;
        protected CreatureModifier nextModifier;

        public CreatureModifier(Creature creature)
        {
            this.creature = creature ?? throw new ArgumentNullException(paramName: nameof(creature));
        }

        public void Add(CreatureModifier creatureModifier)
        {
            if (nextModifier != null)
            {
                nextModifier.Add(creatureModifier);
            }
            else
            {
                nextModifier = creatureModifier;
            };
        }

        public virtual void Handle() => nextModifier?.Handle();
    }
}
