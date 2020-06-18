using System;

namespace DesignPatterns.Observer
{
    class Startup
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var rat = new Rat(game);
            Console.WriteLine(rat.Attack); //1

            var rat2 = new Rat(game);
            Console.WriteLine(rat.Attack); //2
            Console.WriteLine(rat2.Attack); //2

            using (var rat3 = new Rat(game))
            {
                Console.WriteLine(rat.Attack); //3
                Console.WriteLine(rat2.Attack); //3
                Console.WriteLine(rat3.Attack); //3
            }

            Console.WriteLine(rat.Attack); //2
            Console.WriteLine(rat2.Attack); //2
        }
    }
}
