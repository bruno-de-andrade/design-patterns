using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Memento
{
    public class BankAccount
    {
        public int Balance { get; internal set; }

        private readonly List<Memento> _changes = new List<Memento>();

        private int _changeIndex;

        public BankAccount(int balance)
        {
            Balance = balance;

            _changes.Add(new Memento(balance));
        }

        public Memento Deposit(int amount)
        {
            Balance += amount;

            var memento = new Memento(Balance);
            _changes.Add(memento);

            _changeIndex++;

            return memento;
        }

        public void Restore(Memento memento)
        {
            if (memento != null)
            {
                Balance = memento.Balance;
                _changes.Add(memento);
                _changeIndex = _changes.Count - 1;
            }
        }

        public Memento Undo()
        {
            if (_changeIndex > 0)
            {
                _changeIndex--;
                var memento = _changes[_changeIndex];
                Balance = memento.Balance;

                return memento;
            }

            return null;
        }

        public Memento Redo()
        {
            if (_changes.Count > _changeIndex + 1)
            {
                _changeIndex++;
                var memento = _changes[_changeIndex];
                Balance = memento.Balance;

                return memento;
            }

            return null;
        }
    }
}
