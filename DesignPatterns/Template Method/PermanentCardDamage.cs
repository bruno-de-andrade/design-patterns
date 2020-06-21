namespace DesignPatterns.Template_Method
{
    public class PermanentCardDamage : CardGame
    {
        public PermanentCardDamage(Creature[] creatures) : base(creatures) { }

        protected override void Hit(Creature attacker, Creature attacked)
        {
            attacked.Health -= attacker.Attack;
        }
    }
}
