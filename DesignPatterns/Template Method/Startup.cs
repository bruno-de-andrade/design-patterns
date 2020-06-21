using System;

namespace DesignPatterns.Template_Method
{
    class Startup
    {
        static void Main(string[] args)
        {
            var creature1 = new Creature(1, 2);
            var creature2 = new Creature(1, 3);

            var tempGame = new TemporaryCardDamageGame(new Creature[] { creature1, creature2 });
            tempGame.Combat(0, 1);
            var winner = tempGame.Combat(0, 1);

            Console.WriteLine($"Temporary Card game winner: {winner}");

            var permanentGame = new PermanentCardDamage(new Creature[] { creature1, creature2 });
            permanentGame.Combat(0, 1);
            winner = permanentGame.Combat(0, 1);

            Console.WriteLine($"Permanent Card game winner: {winner}");
        }
    }
}
