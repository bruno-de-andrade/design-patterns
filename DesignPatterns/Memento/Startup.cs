using System;

namespace DesignPatterns.Memento
{
    class Startup
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(0);

            var memento100 = bankAccount.Deposit(100);
            bankAccount.Deposit(50);

            Console.WriteLine($"{bankAccount.Balance}");

            bankAccount.Restore(memento100);

            Console.WriteLine($"{bankAccount.Balance}");

            bankAccount.Undo();

            Console.WriteLine($"{bankAccount.Balance}");
        }
    }
}
