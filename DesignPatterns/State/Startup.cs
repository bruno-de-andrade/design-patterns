using System;

namespace DesignPatterns.State
{
    class Startup
    {
        static void Main(string[] args)
        {
            var combLock = new CombinationLock(new[] { 1, 2, 3, 4, 5 });

            Console.WriteLine(combLock.Status); //LOCKED

            combLock.EnterDigit(1);
            Console.WriteLine(combLock.Status); //1

            combLock.EnterDigit(2);
            Console.WriteLine(combLock.Status); //2

            combLock.EnterDigit(3);
            Console.WriteLine(combLock.Status); //3

            combLock.EnterDigit(4);
            Console.WriteLine(combLock.Status); //4

            combLock.EnterDigit(5);
            Console.WriteLine(combLock.Status); //OPEN
        }
    }
}
