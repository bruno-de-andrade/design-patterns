namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class CardGame
    {
        private readonly Creature[] _creatures;

        protected CardGame(Creature[] creatures)
        {
            _creatures = creatures;
        }

        /// <summary>
        /// Returns -1 if no clear winner (both alive or both dead). Otherwise, returns winner id
        /// </summary>
        public int Combat(int creature1Id, int creature2Id)
        {
            Creature first = _creatures[creature1Id];
            Creature second = _creatures[creature2Id];

            Hit(first, second);
            Hit(second, first);

            bool firstAlive = first.Health > 0;
            bool secondAlive = second.Health > 0;

            if (firstAlive == secondAlive)
            {
                return -1;
            }

            return firstAlive ? creature1Id : creature2Id;
        }

        /// <summary>
        /// Attacker hits other creature
        /// </summary>
        protected abstract void Hit(Creature attacker, Creature attacked);
    }
}
