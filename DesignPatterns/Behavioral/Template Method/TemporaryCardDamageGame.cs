namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class TemporaryCardDamageGame : CardGame
    {
        public TemporaryCardDamageGame(Creature[] creatures) : base(creatures) { }

        protected override void Hit(Creature attacker, Creature attacked)
        {
            if (attacker.Attack >= attacked.Health)
            {
                attacked.Health = 0;
            }
        }
    }
}
