using System;

namespace DesignPatterns.Command
{
    public class Account
    {
        public int Balance { get; set; }

        public void Process(Command command)
        {
            switch (command.Action)
            {
                case Action.Deposit:
                    command.Success = Deposit(command.Amount);
                    break;
                case Action.Withdraw:
                    command.Success = Withdraw(command.Amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private bool Withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }

            return false;
        }

        private bool Deposit(int amount)
        {
            Balance += amount;

            return true;
        }
    }
}
