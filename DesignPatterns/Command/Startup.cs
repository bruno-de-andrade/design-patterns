using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    class Startup
    {
        static void Main(string[] args)
        {
            var account = new Account();
            var deposit100Command = new Command()
            {
                Action = Action.Deposit,
                Amount = 100
            };
            var withdraw50Command = new Command()
            {
                Action = Action.Withdraw,
                Amount = 50
            };
            account.Process(withdraw50Command);

            Console.WriteLine($"Account balance: {account.Balance}");
        }
    }
}
